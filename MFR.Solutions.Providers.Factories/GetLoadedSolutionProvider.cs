using MFR.Solutions.Providers.Interfaces;

namespace MFR.Solutions.Providers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider" />
    /// interface.
    /// </summary>
    public static class GetLoadedSolutionProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider" />
        /// interface.
        /// </returns>
        public static ILoadedSolutionProvider SoleInstance()
            => LoadedSolutionProvider.Instance;
    }
}