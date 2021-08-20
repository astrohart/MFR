using System.Windows.Forms;

namespace MFR.Settings.Configuration.Constants
{
    /// <summary>
    /// Values used to read the configuration file path from the system Registry.
    /// </summary>
    /// <remarks>
    /// The configuration file contains user settings that control how the
    /// application runs.
    /// <para />
    /// TRhe configuration file is in JSON format.
    /// <para />
    /// Configuration files are intended to be stored on a per user basis.
    /// </remarks>
    public static class ConfigurationPathRegistry
    {
        /// <summary>
        /// Gets the name of the Registry value that holds the path to the
        /// configuration file.
        /// </summary>
        public const string ValueName = "ConfigFile";

        /// <summary>
        /// Gets the path to the Registry subkey that stores information about
        /// the paths of files.
        /// </summary>
        public static readonly string KeyName =
            $@"HKEY_CURRENT_USER\SOFTWARE\{Application.CompanyName}\{Application.ProductName}\Paths";
    }
}