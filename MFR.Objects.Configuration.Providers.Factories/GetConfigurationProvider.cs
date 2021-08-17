using MFR.Objects.Configuration.Providers.Interfaces;

namespace MFR.Objects.Configuration.Providers.Factories
{
    /// <summary>
    /// Obtains references to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Objects.Configuration.Providers.Interfaces.IConfigurationProvider" />
    /// interface.
    /// </summary>
    public static class GetConfigurationProvider
    {
        /// <summary>
        /// Obtains a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </returns>
        public static IConfigurationProvider SoleInstance()
            => ConfigurationProvider.Instance;
    }
}