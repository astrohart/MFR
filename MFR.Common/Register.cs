using System;
using xyLOGIX.Core.Debug;

namespace MFR.Common
{
    /// <summary>
    /// Provides methods to register with the Windows operating system.
    /// </summary>
    public static class Register
    {
        /// <summary>
        /// Registers an OLE Message Filter with the Windows operating system.
        /// </summary>
        public static void WindowsMessageFilter()
        {
            try
            {
                xyLOGIX.Win32.Messages.Filters.WindowsMessageFilter.Register();
            } 
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
