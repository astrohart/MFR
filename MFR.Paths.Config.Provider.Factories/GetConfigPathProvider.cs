using MFR.Paths.Config.Provider.Interfaces;

namespace MFR.Paths.Config.Provider.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider" />
    /// interface that manages the loading and storing of the application configuration
    /// file's pathname to/from the system Registry.
    /// </summary>
    public static class GetConfigPathProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider" />
        /// interface that manages the loading and storing of the application configuration
        /// file's pathname to/from the system Registry.
        /// </returns>
        public static IConfigPathProvider SoleInstance()
            => ConfigPathProvider.Instance;
    }
}