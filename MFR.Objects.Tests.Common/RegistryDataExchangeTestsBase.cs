using MFR.Objects.Configuration.Interfaces;
namespace MFR.Objects.Tests
{
    public class RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// String containing the fully-qualified pathname of the master
        /// configuration file.
        /// </summary>
        /// <remarks>
        /// The master configuration file is defined to be that file, containing
        /// a JSON representation of an object that implements the <see
        /// cref="T:MFR.Objects.IConfiguration"/> interface, exists
        /// in the centralized location that is used by the application.
        /// <para/>
        /// (Other such files may exist, but these are exports/imports.)
        /// </remarks>
        public const string CONFIG_FILE_PATH =
            @"""C:\ProgramData\xyLOGIX, LLC\MassFileRenamer\Config\config.json""";

        protected const string CONFIG_FILE_DIR =
                    @"C:\ProgramData\xyLOGIX, LLC\MassFileRenamer\Config";

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
