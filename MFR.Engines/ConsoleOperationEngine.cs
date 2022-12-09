using MFR.Engines.Constants;
using MFR.Engines.Interfaces;

namespace MFR.Engines
{
    /// <summary>
    /// Coordinates the operation of the <c>File Renamer</c> component when the
    /// application is invoked as a console app.
    /// </summary>
    public class ConsoleOperationEngine : OperationEngineBase,
        IConsoleOperationEngine
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ConsoleOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ConsoleOperationEngine() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface.
        /// </summary>
        public static IConsoleOperationEngine Instance
        {
            get;
        } = new ConsoleOperationEngine();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public override OperationEngineType Type
            => OperationEngineType.Console;
    }
}