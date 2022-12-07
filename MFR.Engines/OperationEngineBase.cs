using MFR.Engines.Constants;
using MFR.Engines.Interfaces;
using MFR.Settings.Configuration;

namespace MFR.Engines
{
    /// <summary>
    /// Coordinates the operation of the 
    /// </summary>
    public class FulLGUIOperationEngine : OperationEngineBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FulLGUIOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FulLGUIOperationEngine() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Engines.FulLGUIOperationEngine" />.
        /// </summary>
        public static IOperationEngine Instance
        {
            get;
        } = new FulLGUIOperationEngine();

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

    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all operation
    /// engines.
    /// </summary>
    public abstract class OperationEngineBase : ConfigurationComposedObjectBase, IOperationEngine
    {
        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public abstract OperationEngineType Type
        {
            get;
        }
    }
}