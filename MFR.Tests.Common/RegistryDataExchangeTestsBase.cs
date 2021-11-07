namespace MFR.Tests.Common
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all unit test fixtures that test methods and objects that perform data exchange to and from the system Registry.
    /// </summary>
    public class RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// String containing the fully-qualified pathname of the master
        /// configuration file.
        /// </summary>
        /// <remarks>
        /// The master configuration file is defined to be that file, containing
        /// a JSON representation of an object that implements the <see
        /// cref="T:MFR.Settings.Profiles.Interfaces.IProfile"/> interface, exists
        /// in the centralized location that is used by the application.
        /// <para/>
        /// (Other such files may exist, but these are exports/imports.)
        /// </remarks>
        public const string CONFIG_FILE_PATH =
            @"""C:\ProgramData\xyLOGIX, LLC\MassFileRenamer\Config\config.json""";

        /// <summary>
        /// String containing the fully-qualified pathname of a folder that stores the configuration file.
        /// </summary>
        protected const string CONFIG_FILE_DIR =
                    @"C:\ProgramData\xyLOGIX, LLC\MassFileRenamer\Config";

        /// <summary>
        /// String containing the name of a configuration file.
        /// </summary>
        protected const string CONFIG_FILE_NAME = "config.json";

        /// <summary>
        /// Fully-qualified pathname to where we expect that the path to the
        /// configuration file has been written to.
        /// </summary>
        protected const string KEY_PATH =
            @"HKEY_CURRENT_USER\Software\xyLOGIX, LLC\Project File Renamer\Paths";

        /// <summary>
        /// Name of the Registry value under which the path to the application's
        /// configuration file is to be stored.
        /// </summary>
        protected const string VALUE_NAME = "ConfigFile";
    }
}
