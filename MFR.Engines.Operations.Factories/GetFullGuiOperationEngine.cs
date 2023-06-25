using MFR.Engines.Operations.Interfaces;

namespace MFR.Engines.Operations.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine" />
    /// interface.
    /// </summary>
    public static class GetFullGuiOperationEngine
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine" />
        /// interface.
        /// </returns>
        public static IFullGuiOperationEngine SoleInstance()
            => FullGuiOperationEngine.Instance;
    }
}