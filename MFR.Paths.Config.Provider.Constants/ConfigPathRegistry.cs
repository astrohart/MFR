namespace MFR.Paths.Config.Provider.Constants
{
    /// <summary>
    /// Values used to read the configuration file path from the system Registry.
    /// </summary>
    /// <remarks>
    /// The configuration file contains user settings that control how the
    /// application runs.
    /// <para />
    /// The configuration file is in JSON format.
    /// <para />
    /// Configuration files are intended to be stored on a per user basis.
    /// </remarks>
    public static class ConfigPathRegistry
    {
        /// <summary>
        /// Gets the name of the Registry value that holds the path to the
        /// configuration file.
        /// </summary>
        public const string ValueName = "ConfigFile";
    }
}