namespace MFR.Objects.Messages.Constants
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
        /// Unloads all Visual Studio Solutions (*.sln) that are currently open
        /// in instances of Visual Studio, that are found in the specified folder.
        /// </summary>
        UnloadAllLoadedSolutionsInFolder,

        /// <summary>
        /// Loads all the Visual Studio Solutions (*.sln) in the specified folder, each in its own instance of code
        /// </summary>
        LoadAllSolutionsInFolder,

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        Unknown
    }
}