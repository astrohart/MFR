using MFR.Engines.Constants;
using MFR.Engines.Interfaces;

namespace MFR.Engines
{
    /// <summary>
    /// Coordinates the operation of the <c>File Renamer</c> component when the
    /// application is invoked for automated execution from the command line (i.e., the
    /// <c>--autoStart</c> command-line flag is applied).
    /// </summary>
    public class AutomatedGuiOperationEngine : OperationEngineBase,
        IAutomatedGuiOperationEngine
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static AutomatedGuiOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected AutomatedGuiOperationEngine() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface.
        /// </summary>
        public static IAutomatedGuiOperationEngine Instance
        {
            get;
        } = new AutomatedGuiOperationEngine();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public override OperationEngineType Type
            => OperationEngineType.AutomatedGUI;
    }
}