namespace MFR.Settings.Configuration.Mappers.Constants
{
    /// <summary>
    /// Values that define the types of configuration string mappers that are supported.
    /// </summary>
    public enum ConfigurationStringMapperType
    {
        /// <summary>
        /// Configuration string mapper that handles commit messages.
        /// </summary>
        CommitMessage,

        /// <summary>
        /// Unknown configuration string mapper type.
        /// </summary>
        Unknown = -1
    }
}