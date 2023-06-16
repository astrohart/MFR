using MFR.Settings.Configuration.Interfaces;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Gets the sole reference to an instance of an object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface that represents the blank configuration initialized with the default
    /// invokable operations and other settings.
    /// </summary>
    public static class GetBlankProjectFileRenamerConfiguration
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that represents the blank configuration initialized with the default
        /// invokable operations and other settings.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that represents the blank configuration initialized with the default
        /// invokable operations and other settings.
        /// </returns>
        public static IProjectFileRenamerConfiguration SoleInstance()
            => ProjectFileRenamerConfiguration.Blank;
    }
}