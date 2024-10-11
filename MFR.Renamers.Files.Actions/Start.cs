using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Interop.Processes.Actions;

namespace MFR.Renamers.Files.Actions
{
    public static class Start
    {
        public static void Service(string serviceName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(serviceName)) return;
                if (serviceName.Contains(" "))
                    return; // service name can't have spaces

                Run.SystemCommand($"sc start {serviceName}", "", true);
                
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}