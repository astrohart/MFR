using PostSharp.Patterns.Diagnostics;
using System;
using System.Threading;
using xyLOGIX.Core.Debug;
using xyLOGIX.Interop.Processes.Actions;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to stop processes and services from the command line.
    /// </summary>
    public static class Stop
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Renamers.Files.Actions.Stop" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Stop() { }

        /// <summary>
        /// Stops a Windows Service by using the command line <c>sc stop</c> command.
        /// </summary>
        /// <param name="serviceName">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the service
        /// (must have no spaces).
        /// </param>
        /// <remarks>
        /// If a blank value is passed as the argument of the
        /// <paramref name="serviceName" /> parameter, then this method does nothing.
        /// </remarks>
        public static void Service(string serviceName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(serviceName)) return;
                if (serviceName.Contains(" "))
                    return; // service name can't have spaces

                Run.SystemCommand($"sc stop {serviceName}", "", true);

                Thread.Sleep(
                    10000
                ); // sleep for 10 seconds to allow the action to be processed.
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}