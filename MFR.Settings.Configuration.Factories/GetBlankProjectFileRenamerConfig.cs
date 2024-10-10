using MFR.Settings.Configuration.Interfaces;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Gets the sole reference to an instance of an object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface that represents the blank config initialized with the default
    /// invokable operations and other settings.
    /// </summary>
    public static class GetBlankProjectFileRenamerConfig
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the blank config initialized with the default
        /// invokable operations and other settings.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the blank config initialized with the default
        /// invokable operations and other settings.
        /// </returns>
        public static IProjectFileRenamerConfig SoleInstance()
            => ProjectFileRenamerConfig.Blank;
    }
}