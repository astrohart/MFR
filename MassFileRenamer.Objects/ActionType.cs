namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Values specifying what message to execute.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        LoadStringFromRegistry,

        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        SaveStringToRegistry,

        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        LoadConfigurationFromFile,

        /// <summary>
        /// Saves the configuration to a file.
        /// </summary>
        SaveConfigurationToFile,

        /// <summary>
        /// Imports the configuration from a file on the disk.
        /// </summary>
        ImportConfigurationFromFile,

        /// <summary>
        /// Exports the configuration to a file on the disk.
        /// </summary>
        ExportConfigurationToFile,

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        Unknown
    }
}