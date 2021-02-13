using System;
using System.IO;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.GUI
{
    public static class ConfigurationProvider
    {
        /// <summary>
        /// Gets or sets the pathname of the configuration file.
        /// </summary>
        public static string ConfigurationFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the path to the Registry subkey that stores configuration information.
        /// </summary>
        public static string ConfigurationKeyName
            => $@"{Application.CompanyName}\Configuration";

        /// <summary>
        /// Gets the name of the Registry value that holds the path to the
        /// configuration file.
        /// </summary>
        public static string ConfigurationPathValueName
            => "Path";

        /// <summary>
        /// Gets the default folder for the configuration file.
        /// </summary>
        /// <remarks>
        /// We store the config file, by default, in a folder under C:\ProgramData.
        /// </remarks>
        /// efs
        public static string DefaultConfigDir
        {
            get;
        } = Path.Combine(
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                ), Application.CompanyName
            ), "Config"
        );

        /// <summary>
        /// Gets the default filename for the config file.
        /// </summary>
        public static string DefaultConfigFileName
        {
            get;
        } = "config.json";

        /// <summary>
        /// Loads the path to the application's configuration file from the
        /// system Registry.
        /// </summary>
        /// <returns>
        /// String containing the path value loaded, if any.
        /// </returns>
        public static string LoadConfigurationPath()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In ConfigurationProvider.LoadConfigurationPath"
            );

            var configPathname = SystemPreparer.GetProfileString(
                ConfigurationKeyName, ConfigurationPathValueName,
                Path.Combine(DefaultConfigDir, DefaultConfigFileName)
            );

            if (string.IsNullOrWhiteSpace(configPathname))
                throw new InvalidOperationException(
                    "Unable to load the path to the configuration file."
                );

            // Dump the variable configPathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ConfigurationProvider.LoadConfigurationPath: configPathname = '{configPathname}'"
            );

            ConfigurationFilePath = configPathname;

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "ConfigurationProvider.LoadConfigurationPath: Done."
            );

            return configPathname;
        }

        public static void SaveConfigurationPath()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In ConfigurationProvider.SaveConfigurationPath"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Saving the path to the configuration file in the system Registry..."
            );

            if (string.IsNullOrWhiteSpace(ConfigurationFilePath))
                return; // do not save a blank value

            SystemPreparer.SetProfileString(
                ConfigurationKeyName, ConfigurationPathValueName,
                ConfigurationFilePath
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "ConfigurationProvider.SaveConfigurationPath: Done."
            );
        }
    }
}