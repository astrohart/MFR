using EnvDTE;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
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
        [Log(AttributeExclude = true)]
        static VisualStudioManager()
        {
            _processIdProvider = MakeNewProcessIdProvider.FromScratch();
        }

        /*
        /// <summary>
        /// Attempts to either launch the Visual Studio IDE or find the COM
        /// object that implements the <see cref="T:EnvDTE.DTE"/> OLE automation
        /// interface that is associated with the running instance referenced by
        /// the instance of <see cref="T:System.Diagnostics.Process"/>, a
        /// reference to which is specified by the <paramref name="processId"/> parameter.
        /// </summary>
        /// <param name="processId">
        /// (Required.) Integer whose value is set to the process ID (PID) of a
        /// running Visual Studio instance.
        /// </param>
        /// <returns>
        /// Reference to the COM object that implements the <see
        /// cref="T:EnvDTE.DTE"/> OLE automation interface that refers to the
        /// running Visual Studio instance referred to by the <paramref
        /// name="processId"/> parameter.
        /// </returns>
        public static DTE ConnectToRunningVisualStudio(int processId)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In VisualStudioManager.ConnectToRunningVisualStudio"
            );

            DTE result = default;

            // Dump the parameter processId to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.ConnectToRunningVisualStudio: processId = {processId}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.ConnectToRunningVisualStudio: Checking whether the value of the 'processId' argument is less than or equal to zero.  If so, then it's invalid, and we should stop."
            );

            if (processId <= 0)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "VisualStudioManager.ConnectToRunningVisualStudio: The value of the 'processId' argument is less than or equal to zero.  This is not a valid value. Stopping."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.ConnectToRunningVisualStudio: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.ConnectToRunningVisualStudio: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The value of the processId argument is a positive number."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.ConnectToRunningVisualStudio: Formulating the name of the Visual Studio DTE object CLSID in the Running Object Table (ROT)..."
            );

            var runningObjectDisplayName = $"VisualStudio.DTE.16.0:{processId}";

            // Dump the variable runningObjectDisplayName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.ConnectToRunningVisualStudio: runningObjectDisplayName = '{runningObjectDisplayName}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.ConnectToRunningVisualStudio: Trying to obtain the display names of the elements of the ROT..."
            );

            var runningObjectDisplayNames = new List<string>();

            /*
             * OKAY, getting the contents of the Running Object Table (ROT) does not always work.
             * So, we loop a maximum of 60 seconds, trying to
             * fetch the ROT table entry corresponding to the display name
             * formulated above.  If we go longer than 60 seconds, then we throw
             * TimeoutException to let the application know that we give up.

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
        */

        /// <summary>
        /// Attempts to find the Visual Studio instance that has the solution
        /// with pathname <paramref name="path" /> currently loaded. Returns
        /// <see
        ///     langword="null" />
        /// if such an instance cannot be found.
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
        /// instance that has the solution opened; <see langword="null" /> if
        /// such an instance cannot be located.
        /// </returns>
        public static DTE GetVsProcessHavingSolutionOpened(string path)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In VisualStudioManager.GetVsProcessHavingSolutionOpened"
            );

            DTE result = default;

            // Dump the parameter path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: path = '{path}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Checking whether the 'path' parameter references a valid Visual Studio solution..."
            );

            if (string.IsNullOrWhiteSpace(path) || !path.EndsWith(".sln"))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: The 'path' parameter is either blank, or it does not contain the path to a file ending with the '.sln' extension.  Quitting."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'path' parameter appears to contain the filename of a Visual Studio Solution file."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Checking whether the 'path' parameter contains a string that is an absolute pathname..."
            );

            if (!path.IsAbsolutePath())
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: The 'path' parameter does not contain an absolute path."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'path' parameter contains an absolute pathname."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{path}' exists on the disk..."
            );

            if (!File.Exists(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the file having the path '{path}' on the disk.  This file is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{path}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Attempting to find the Visual Studio process that has the solution with path '{path}' open..."
            );

            try
            {
                result = _processIdProvider.GetAllProcessIDsOf("devenv.exe")
                                           .Select(ConnectToRunningVisualStudio)
                                           .Where(dte => dte != null)
                                           .Select(
                                               dte => new {
                                                   dte,
                                                   sln = (SolutionClass)dte
                                                       .Solution
                                               }
                                           )
                                           .Where(
                                               x => path.Equals(x.sln.FullName)
                                           )
                                           .Select(x => x.dte)
                                           .FirstOrDefault();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                // if an exception occurs, just give up.
                result = default;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
            );

            return result;
        }

        /// <summary>
        /// Attempts to connect to the instance of Visual Studio that is running
        /// on the local machine, having the specified Process ID, <paramref name="pid" />.
        /// </summary>
        /// <param name="pid">
        /// (Required.) A positive integer that is the Process ID of a running
        /// instance of <c>devenv.exe</c>.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// interface, or <see langword="null" /> if no
        /// such running Visual Studio instance can be found.
        /// </returns>
        private static DTE ConnectToRunningVisualStudio(int pid)
        {
            DTE result = default;

            if (-1 == pid)
                return result; // Visual Studio is not running

            var retries = 60; /* retry for 60 seconds or until found */

            while (retries >= 0 && result == default)
            {
                try
                {
                    result =
                        (DTE)GetRunningObject.ByDisplayName(
                            $"VisualStudio.DTE.16.0:{pid}"
                        );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = default;
                }

                Thread.Sleep(1000);
                retries--;
            }

            return result;
        }
    }
}