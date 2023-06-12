using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Settings.Configuration.Providers.Factories
{
    /// <summary>
    /// Obtains references to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetProjectFileRenamerConfigurationProvider
    {
        /// <summary>
        /// Obtains a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </returns>
        public static IProjectFileRenamerConfigurationProvider SoleInstance()
            => ProjectFileRenmerConfigurationProvider.Instance;
    }
}