using System.Diagnostics;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines methods and properties to aid in controlling the flow of the program.
    /// </summary>
    public static class ProgramFlowHelper
    {
        /// <summary>
        /// Launches the Visual Studio Debugger.
        /// </summary>
        public static void StartDebugger()
        {
            Debugger.Launch();
            Debugger.Break();
        }
    }
}