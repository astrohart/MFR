using MFR.Renamers.Files.Actions.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MFR.Renamers.Files.Actions
{
    public static class List
    {
        private const int CCH_RM_MAX_APP_NAME = 255;
        private const int CCH_RM_MAX_SVC_NAME = 63;
        private const int RmRebootReasonNone = 0;

        /// <summary>
        /// Find out what process(es) have a lock on the specified file.
        /// </summary>
        /// <param name="pathname">Path of the file.</param>
        /// <returns>Processes locking the file</returns>
        /// <remarks>
        /// See also:
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/aa373661(v=vs.85).aspx
        /// http://wyupdate.googlecode.com/svn-history/r401/trunk/frmFilesInUse.cs (no
        /// copyright in code at time of viewing)
        /// </remarks>
        public static IList<Process> ProcessesLockingFileSystemEntry(string pathname)
        {
            var result = Enumerable.Empty<Process>()
                                   .ToList();

            var key = Guid.NewGuid()
                          .ToString();
            var retval = NativeMethods.RmStartSession(out var hSession, 0, key);

            if (retval != 0) return result;

            try
            {
                const int MORE_DATA = 234;
                uint pnProcInfo = 0, lpdwRebootReasons = RmRebootReasonNone;

                string[]
                    resources = { pathname }; // Just checking on one resource.

                retval = NativeMethods.RmRegisterResources(
                    hSession, (uint)resources.Length, resources, 0, null, 0,
                    null
                );

                if (retval != 0) return result;

                //Note: there's a race condition here -- the first call to RmGetList() returns
                //      the total number of process. However, when we call RmGetList() again to get
                //      the actual processes this number may have increased.
                retval = NativeMethods.RmGetList(
                    hSession, out var pnProcInfoNeeded, ref pnProcInfo, null,
                    ref lpdwRebootReasons
                );

                if (retval == MORE_DATA)
                    result = EnumerateProcesses(
                        pnProcInfoNeeded, hSession, lpdwRebootReasons
                    );
                else if (retval != 0) return result;
            }
            finally
            {
                NativeMethods.RmEndSession(hSession);
            }

            return new List<Process>();
        }

        private static List<Process> EnumerateProcesses(
            uint pnProcInfoNeeded,
            uint handle,
            uint lpdwRebootReasons
        )
        {
            var processes = new List<Process>(10);

            // Create an array to store the process results
            var processInfo = new RM_PROCESS_INFO[pnProcInfoNeeded];
            var pnProcInfo = pnProcInfoNeeded;

            // Get the list
            var res = NativeMethods.RmGetList(
                handle, out pnProcInfoNeeded, ref pnProcInfo, processInfo,
                ref lpdwRebootReasons
            );

            if (res != 0)
                throw new Exception(
                    "Could not list processes locking resource."
                );
            for (var i = 0; i < pnProcInfo; i++)
                try
                {
                    processes.Add(
                        Process.GetProcessById(
                            processInfo[i]
                                .Process.dwProcessId
                        )
                    );
                }
                catch
                    (ArgumentException) { } // catch the error -- in case the process is no longer running

            return processes;
        }
    }
}