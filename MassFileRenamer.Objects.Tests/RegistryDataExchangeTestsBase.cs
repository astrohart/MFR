namespace MassFileRenamer.Objects.Tests
{
    public class RegistryDataExchangeTestsBase
    {
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

        protected const string CONFIG_FILE_DIR =
            @"C:\ProgramData\xyLOGIX, LLC\MassFileRenamer\Config";

        protected const string CONFIG_FILE_NAME = "config.json";
    }
}