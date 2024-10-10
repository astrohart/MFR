using MFR.Settings.Configuration.Mappers.Interfaces;

namespace MFR.Settings.Configuration.Mappers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
    /// interface that represents a configuration string mapper object that is meant to
    /// act on replacement parameters that are found in commit messages.
    /// </summary>
    public static class GetCommitMessageMapper
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface that represents a configuration string mapper object that is meant to
        /// act on replacement parameters that are found in commit messages.
        /// </returns>
        public static IConfigurationStringMapper SoleInstance()
            => CommitMessageMapper.Instance;
    }
}