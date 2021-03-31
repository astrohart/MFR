using System;
using System.Runtime.InteropServices;

// ReSharper disable NotAccessedVariable

namespace MFR.Objects.Win32
{
    /// <summary>
    /// Filter for COM and Windows messages sent by the operating system on the
    /// behalf of a running COM object.
    /// </summary>
    /// <remarks>
    /// This class implements the
    /// <see
    ///     cref="T:MFR.Objects.Win32.IOleMessageFilter" />
    /// interface.
    /// </remarks>
    internal class WindowsMessageFilter : IOleMessageFilter
    {
        // Class containing the IOleMessageFilter thread error-handling functions.

        // IOleMessageFilter functions. Handle incoming thread requests.
        int IOleMessageFilter.HandleInComingCall(int dwCallType,
                IntPtr hTaskCaller, int dwTickCount, IntPtr lpInterfaceInfo)

            //Return the flag SERVERCALL_ISHANDLED.
            => 0;

        int IOleMessageFilter.MessagePending(IntPtr hTaskCallee,
                int dwTickCount, int dwPendingType)

            // Return the flag PENDINGMSG_WAITDEFPROCESS.
            => 2;

        // Thread call was rejected, so try again.
        int IOleMessageFilter.RetryRejectedCall(IntPtr hTaskCallee,
            int dwTickCount, int dwRejectType)
        {
            if (dwRejectType == 2)

                // flag = SERVERCALL_RETRYLATER. Retry the thread call
                // immediately if return >=0 & <100.
                return 99;

            // Too busy; cancel call.
            return -1;
        }

        // Start the filter.
        internal static void Register()
        {
            IOleMessageFilter newFilter = new WindowsMessageFilter();
            IOleMessageFilter oldFilter = null;
            CoRegisterMessageFilter(newFilter, out oldFilter);
        }

        // Done with the filter, close it.
        internal static void Revoke()
        {
            IOleMessageFilter oldFilter = null;
            CoRegisterMessageFilter(null, out oldFilter);
        }

        // Implement the IOleMessageFilter interface.
        [DllImport("Ole32.dll")]
        private static extern int CoRegisterMessageFilter(
            IOleMessageFilter newFilter, out IOleMessageFilter oldFilter);
    }
}