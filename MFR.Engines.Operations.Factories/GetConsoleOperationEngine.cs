using MFR.Engines.Operations.Interfaces;

namespace MFR.Engines.Operations.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Engines.Operations.Interfaces.IConsoleOperationEngine" />
    /// interface.
    /// </summary>
    public static class GetConsoleOperationEngine
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IConsoleOperationEngine" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IConsoleOperationEngine" />
        /// interface.
        /// </returns>
        public static IConsoleOperationEngine SoleInstance()
            => ConsoleOperationEngine.Instance;
    }
}