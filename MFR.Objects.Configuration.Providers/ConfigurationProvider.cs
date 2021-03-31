using MFR.Objects.Configuration.Interfaces;
using System;
using System.IO;

namespace MFR.Objects.Configuration.Providers
{
    /// <summary>
    /// Provides shared functionality for obtaining and storing the path to the
    /// user's configuration file.
    /// </summary>
    public static class ConfigurationProvider
    {
        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:MFR.Objects.IConfiguration" /> interface and
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
                => LoadConfigPathAction.Execute()
                                       .Path;
            set {
                GetSaveConfigPathCommand
                    .ForPath(value)
                  .Execute();

                /* Clear out the cache of previously-loaded path
                 for this same operation. */
                LoadConfigPathAction
                    .AsCachedResultAction()
                    .ClearResultCache();
            }
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

        private static IAction<IRegQueryExpression<string>, IFileSystemEntry>
            LoadConfigPathAction
            => GetAction
               .For<IRegQueryExpression<string>, IFileSystemEntry>(
                   MessageType.LoadStringFromRegistry
               )
               .WithInput(
                   MakeNewRegQueryExpression.FromScatch<string>()
                                            .ForKeyPath(ConfigurationKeyName)
                                            .AndValueName(
                                                ConfigurationPathValueName
                                            )
                                            .WithDefaultValue(
                                                Path.Combine(
                                                    DefaultConfigDir,
                                                    DefaultConfigFileName
                                                )
                                            )
               );

        /// <summary>
        /// Exports configuration data to a file other than the master
        /// configuration file.
        /// </summary>
        /// <param name="exportFileName">
        /// </param>
        /// <remarks>
        /// Before performing the export, the method first saves the latest
        /// settings out to the master configuration file.
        /// <para />
        /// It goes without saying that an alternative to calling this method in
        /// the first place is to simply call the
        /// <see
        ///     cref="M:MFR.Objects.ConfigurationProvider.Save" />
        /// method
        /// with a value for its pathname parameter.
        /// <para />
        /// However, doing this will not save the user's settings to the master
        /// file, which is important enough that we write a special method to
        /// handle this.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="exportFileName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static void Export(string exportFileName)
        {
            if (string.IsNullOrWhiteSpace(exportFileName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(exportFileName)
                );

            Save(); /* save the user's latest settings to the master config file */
            Save(
                exportFileName
            ); /* save the latest settings out to the export file */
        }

        /// <summary>
        /// Imports configuration data from a file whose path is
        /// <paramref name="sourceFilePath" />.
        /// </summary>
        /// <param name="sourceFilePath">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file from which to import the configuration data.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="sourceFilePath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="sourceFilePath" />
        /// parameter, cannot be located on the disk.
        /// </exception>
        /// <remarks>
        /// First, this method loads the data from the file specified into the
        /// application's configuration object.
        /// <para />
        /// Then, the method saves the new data out to the master configuration file.
        /// </remarks>
        public static void Import(string sourceFilePath)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(sourceFilePath)
                );
            if (!File.Exists(sourceFilePath))
                throw new FileNotFoundException(
                    "Can't import the configuration because the source file does not exist.",
                    sourceFilePath
                );

            Load(sourceFilePath);
            Save(); /* save configuration data out to the master file */
        }

        /// <summary>
        /// Loads the configuration from the disk.
        /// <para />
        /// The
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Providers.ConfigurationProvider.Configuration" />
        /// property is then initialized to point to the data that has been loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname to a file to be loaded
        /// from disk, that contains the configuration data in JSON format.
        /// <para />
        /// If this value is blank, then the file whose path is stored in the
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Providers.ConfigurationProvider.Configuration" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        public static void Load(string pathname = "")
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In ConfigurationProvider.Load"
            );

            var path = ConfigurationFilePath;

            if (!File.Exists(path)) // oops!
                throw new FileNotFoundException(
                    $"The system could not locate the configuration file having the path '{path}'.",
                    path
                );

            try
            {
                Configuration = GetAction
                                .For<IFileSystemEntry, IConfiguration>(
                                    MessageType.LoadConfigurationFromFile
                                )
                                .WithInput(
                                    MakeNewFileSystemEntry.ForPath(
                                        string.IsNullOrWhiteSpace(pathname)
                                            ? ConfigurationFilePath
                                            : pathname
                                    )
                                )
                                .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Configuration = null;
            }

            if (Configuration != null)
                DebugUtils.WriteLine(
                    DebugLevel.Info, "*** SUCCESS *** Configuration loaded."
                );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "ConfigurationProvider.Load: Done."
            );
        }

        /// <summary>
        /// Saves configuration data to a file on the disk having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public static void Save(string pathname = "")
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In ConfigurationProvider.Save"
            );

            // do not proceed if either the ConfigurationFilePath property is
            // blank, or if the Configuration property has a null reference.

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ConfigurationProvider.Save: Checking whether the value of the 'ConfigurationFilePath' property is blank..."
            );

            if (string.IsNullOrWhiteSpace(ConfigurationFilePath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ConfigurationProvider.Save: Blank value passed for the 'ConfigurationFilePath' property. This property is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "ConfigurationProvider.Save: Done."
                );

                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ConfigurationProvider.Save: *** SUCCESS *** The property 'ConfigurationFilePath' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the 'Configuration' property has a null reference for a value..."
            );

            // Check to see if the required property, Configuration, is null. If
            // it is, send an error to the log file and quit, returning from the method.
            if (Configuration == null)
            {
                // the property Configuration is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The 'Configuration' property has a null reference."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: This property is required to be set to a valid object reference before we can proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "ConfigurationProvider.Save: Done."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ConfigurationProvider.Save: The 'Configuration' property is not blank."
            );

            try
            {
                GetCommand
                    .For<IFileSystemEntry>(MessageType.SaveConfigurationToFile)
                    .WithInput(
                        MakeNewFileSystemEntry.ForPath(ConfigurationFilePath)
                                              .AndHavingUserState(Configuration)
                    )
                    .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}