using System.Runtime.InteropServices;

namespace MFR.Renamers.Files.Actions.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct RM_PROCESS_INFO
    {
        private const int CCH_RM_MAX_APP_NAME = 255;
        private const int CCH_RM_MAX_SVC_NAME = 63;

        public RM_UNIQUE_PROCESS Process;

        [MarshalAs(
            UnmanagedType.ByValTStr, SizeConst = CCH_RM_MAX_APP_NAME + 1
        )]
        public string strAppName;

        [MarshalAs(
            UnmanagedType.ByValTStr, SizeConst = CCH_RM_MAX_SVC_NAME + 1
        )]
        public string strServiceShortName;

        public RM_APP_TYPE ApplicationType;
        public uint AppStatus;
        public uint TSSessionId;

        [MarshalAs(UnmanagedType.Bool)] public bool bRestartable;
    }
}