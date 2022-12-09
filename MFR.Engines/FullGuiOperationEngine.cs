using MFR.Engines.Constants;
using MFR.Engines.Interfaces;

namespace MFR.Engines
{
    /// <summary>
    /// Coordinates the operation of the <c>File Renamer</c> component inadmidst the
    /// full graphical user interface of the application.
    /// </summary>
    public class FullGuiOperationEngine : OperationEngineBase,
        IFullGuiOperationEngine
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FullGuiOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FullGuiOperationEngine() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface.
        /// </summary>
        public static IFullGuiOperationEngine Instance
        {
            get;
        } = new FullGuiOperationEngine();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public override OperationEngineType Type
            => OperationEngineType.FullGUI;
    }
}