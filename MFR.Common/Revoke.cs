﻿using System;
using xyLOGIX.Core.Debug;

namespace MFR.Common
{
    public static class Revoke
    {
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