using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Thread = System.Threading.Thread;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides helper methods for interacting with Visual Studio.
    /// </summary>
    public static class VisualStudioManager
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IProcessIdProvider" />
        /// interface and
        /// that provides the ability to obtain the Process IDs (PIDs) of
        /// running processes from the operating system.
        /// </summary>
        private static readonly IProcessIdProvider _processIdProvider;

        /// <summary>
        /// Initializes static data or performs messages that need to be
        /// performed once only for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.VisualStudioManager" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        static VisualStudioManager()
        {
            _processIdProvider = GetNewProcessIdProvider.FromScratch();
        }

        /// <summary>
        /// Attempts to find the Visual Studio instance that has the solution
        /// with pathname <paramref name="path" /> currently loaded. Returns
        /// <see langword="null" /> if such an instance cannot be found.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Visual Studio solution file.
        /// </param>
        /// <returns>
        /// Reference to an instance of the object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// automation interface for the Visual Studio
        /// instance that has the solution opened; <see langword="null" /> if such an
        /// instance cannot be located.
        /// </returns>
        public static DTE GetVsProcessHavingSolutionOpened(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !path.EndsWith(".sln"))
                return null;

            return _processIdProvider.GetAllProcessIDsOf("devenv.exe")
                                     .Select(LaunchVsIde)
                                     .Where(dte => dte != null)
                                     .Select(
                                         dte => new {
                                             dte,
                                             sln = (SolutionClass)dte.Solution
                                         }
                                     )
                                     .Where(x => path.Equals(x.sln.FullName))
                                     .Select(x => x.dte)
                                     .FirstOrDefault();
        }

        /// <summary>
        /// Attempts to either launch the Visual Studio IDE or find the COM
        /// object that implements the <see cref="T:EnvDTE.DTE" /> OLE automation
        /// interface that is associated with the running instance referenced by
        /// the instance of <see cref="T:System.Diagnostics.Process" />, a
        /// reference to which is specified by the <paramref name="processId" /> parameter.
        /// </summary>
        /// <param name="processId">
        /// (Required.) Integer whose value is set to the process ID (PID) of a
        /// running Visual Studio instance.
        /// </param>
        /// <returns>
        /// Reference to the COM object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// OLE automation interface that refers to the
        /// running Visual Studio instance referred to by the
        /// <paramref
        ///     name="processId" />
        /// parameter.
        /// </returns>
        public static DTE LaunchVsIde(int processId)
        {
            if (processId == -1)
                return null;

            var runningObjectDisplayName = $"VisualStudio.DTE.16.0:{processId}";

            IEnumerable<string> runningObjectDisplayNames = null;
            for (var i = 0; i < 60; i++)
            {
                object runningObject;
                try
                {
                    runningObject = GetRunningObject(
                        runningObjectDisplayName, out runningObjectDisplayNames
                    );
                }
                catch
                {
                    runningObject = null;
                }

                if (runningObject != null) return (DTE)runningObject;

                Thread.Sleep(1000);
            }

            throw new TimeoutException(
                $"Failed to retrieve DTE object. Current running objects: {string.Join(";", runningObjectDisplayNames ?? Array.Empty<string>())}"
            );
        }

        private static object GetRunningObject(string displayName,
            out IEnumerable<string> runningObjectDisplayNames)
        {
            NativeMethods.CreateBindCtx(0, out var bindContext);

            bindContext.GetRunningObjectTable(out var runningObjectTable);

            runningObjectTable.EnumRunning(out var monikerEnumerator);

            object runningObject = null;
            var runningObjectDisplayNameList = new List<string>();
            var monikers = new IMoniker[1];
            var numberFetched = IntPtr.Zero;
            while (monikerEnumerator.Next(1, monikers, numberFetched) == 0)
            {
                var moniker = monikers[0];

                string objectDisplayName = null;
                try
                {
                    moniker.GetDisplayName(
                        bindContext, null, out objectDisplayName
                    );
                }
                catch (UnauthorizedAccessException)
                {
                    // Some ROT objects require elevated permissions.
                }

                if (string.IsNullOrWhiteSpace(objectDisplayName)) continue;
                runningObjectDisplayNameList.Add(objectDisplayName);
                if (!objectDisplayName.EndsWith(
                    displayName, StringComparison.Ordinal
                )) continue;
                runningObjectTable.GetObject(moniker, out runningObject);
                if (runningObject == null)
                    throw new InvalidOperationException(
                        $"Failed to get running object with display name {displayName}"
                    );
            }

            runningObjectDisplayNames = runningObjectDisplayNameList;
            return runningObject;
        }

        private static class NativeMethods
        {
            [DllImport("ole32.dll")]
            public static extern int CreateBindCtx(uint reserved,
                out IBindCtx ppbc);

            [DllImport("ole32.dll")]
            public static extern void GetRunningObjectTable(int reserved,
                out IRunningObjectTable prot);
        }
    }
}