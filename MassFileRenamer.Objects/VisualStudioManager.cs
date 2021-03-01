using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Process = System.Diagnostics.Process;
using Thread = System.Threading.Thread;

namespace MassFileRenamer.Objects
{
    public static class VisualStudioManager
    {
        public static DTE GetVsProcessHavingSolutionOpened(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !path.EndsWith(".sln"))
                return null;

            return (from p in Process.GetProcessesByName("devenv")
                    select LaunchVsIde(p)
                into dte
                    where dte != null
                    let sln = (SolutionClass)dte.Solution
                    where path.Equals(sln.FullName)
                    select dte).FirstOrDefault();
        }

        public static DTE LaunchVsIde(Process p)
        {
            if (p == null)
                return null;
            var runningObjectDisplayName = $"VisualStudio.DTE.16.0:{p.Id}";

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