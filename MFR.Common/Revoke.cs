using System;
using xyLOGIX.Core.Debug;

namespace MFR.Common
{
    /// <summary>
    /// Methods to revoke things from being in a registered status with the operating system.
    /// </summary>
    public static class Revoke
    {
        /// <summary>
        /// Revokes the most-recently-registered OLE message filter.
        /// </summary>
        public static void WindowsMessageFilter()
        {
            try
            {
                xyLOGIX.Win32.Messages.Filters.WindowsMessageFilter.Revoke();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
