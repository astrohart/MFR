using System;
using xyLOGIX.Core.Debug;

namespace MFR.Common
{
    /// <summary>
    /// Methods to revoke things from being in a registered status with the operating
    /// system.
    /// </summary>
    public static class Revoke
    {
        /// <summary>
        /// Revokes the most-recently-registered OLE message filter.
        /// </summary>
        /// <returns><see langword="true" /> if the operation succeeds; <see langword="false" /> otherwise.</returns>
        public static bool WindowsMessageFilter()
        {
            var result = true;

            try
            {
                xyLOGIX.Win32.Messages.Filters.WindowsMessageFilter.Revoke();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}