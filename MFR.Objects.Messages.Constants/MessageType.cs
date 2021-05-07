namespace MFR.Objects.Messages.Constants
{
    /// <summary>
    /// Values specifying what message to execute.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Unloads all *.sln files in the specified folder, that are themselves
        /// also loaded in open instances of Visual Studio.
        /// </summary>
        UnloadAllSolutionsInFolder,

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
        /// Loads all the Visual Studio Solutions (*.sln) in the specified
        /// folder, each in its own instance of <c>devenv.exe</c>.
        /// </summary>
        LoadAllSolutionsInFolder,

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        Unknown
    }
}