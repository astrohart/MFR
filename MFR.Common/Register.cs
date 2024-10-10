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
        /// <returns>
        /// <see langword="true" /> if the registration attempt succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool WindowsMessageFilter()
        {
            bool result;

            try
            {
                result = xyLOGIX.Win32.Messages.Filters.WindowsMessageFilter
                                .Register();
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