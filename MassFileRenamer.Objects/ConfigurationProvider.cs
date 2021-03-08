using System;
using System.IO;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides shared functionality for obtaining and storing the path to the
    /// user's configuration file.
    /// </summary>
    public static class ConfigurationProvider
    {
        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface and
        /// which exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        public static IConfiguration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pathname of the configuration file.
        /// </summary>
        public static string ConfigurationFilePath
        {
            get
                => GetAction
                   .For<IRegQueryExpression<string>, IFileSystemEntry>(
                       MessageType.LoadStringFromRegistry
                   )
                   .WithInput(
                       MakeNewRegQueryExpression.FromScatch<string>()
                                                .ForKeyPath(
                                                    ConfigurationKeyName
                                                )
                                                .AndValueName(
                                                    ConfigurationPathValueName
                                                )
                                                .WithDefaultValue(
                                                    Path.Combine(
                                                        DefaultConfigDir,
                                                        DefaultConfigFileName
                                                    )
                                                )
                   )
                   .Execute()
                   .Path;
            set
                => GetCommand
                   .For<IRegOperationMetadata<string>>(
                       MessageType.SaveStringToRegistry
                   )
                   .WithInput(
                       MakeNewRegOperationMetadata.FromScatch<string>()
                                                  .ForKeyPath(
                                                      ConfigurationKeyName
                                                  )
                                                  .AndValueName(
                                                      ConfigurationPathValueName
                                                  )
                                                  .WithValue(value)
                   )
                   .Execute();
        }

        /// <summary>
        /// Gets the path to the Registry subkey that stores information about
        /// the paths of files.
        /// </summary>
        public static string ConfigurationKeyName
            => $@"HKEY_CURRENT_USER\SOFTWARE\{Application.CompanyName}\{Application.ProductName}\Paths";

        /// <summary>
        /// Gets the name of the Registry value that holds the path to the
        /// configuration file.
        /// </summary>
        public static string ConfigurationPathValueName
            => "ConfigFile";

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
            ), @"MassFileRenamer\Config"
        );

        /// <summary>
        /// Gets the default filename for the config file.
        /// </summary>
        public static string DefaultConfigFileName
        {
            get;
        } = "config.json";
    }
}