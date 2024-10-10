using System.Runtime.InteropServices;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace MFR.Renamers.Files.Actions.Win32
{
    /// <summary>
    /// Uniquely identifies a process by its <c>PID</c> and the time the process began.
    /// An array of <c>RM_UNIQUE_PROCESS</c> structures can be passed to the
    /// <c>RmRegisterResources</c>
    /// function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RM_UNIQUE_PROCESS
    {
        /// <summary>
        /// The process identifier (PID).
        /// </summary>
        public int dwProcessId;

        /// <summary>
        /// The creation time of the process. The time is provided as a <c>FILETIME</c>
        /// structure that is returned by the <c>lpCreationTime</c> parameter of the
        /// <c>GetProcessTimes</c> function.
        /// </summary>
        public FILETIME ProcessStartTime;
    }
}