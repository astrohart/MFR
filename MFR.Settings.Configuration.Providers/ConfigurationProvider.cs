using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Settings.Configuration.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.Settings.Configuration.Providers
{
    /// <summary>
    /// Provides shared functionality for obtaining and storing the path to the
    /// user's configuration file.
    /// </summary>
    public class ConfigurationProvider : IConfigurationProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ConfigurationProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ConfigurationProvider() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Configuration.Providers.ConfigurationProvider" />.
        /// </summary>
        public static ConfigurationProvider Instance
        {
            get;
        } = new ConfigurationProvider();

        /// <summary>
        /// Default action to be utilized for loading the path to the configuration file
        /// from the system Registry.
        /// </summary>
        private IAction<IRegQueryExpression<string>, IFileSystemEntry>
            LoadConfigPathAction
            => GetConfigurationAction
               .For<IRegQueryExpression<string>, IFileSystemEntry>(
                   ConfigurationActionType.LoadStringFromRegistry
               )
               .WithInput(
                   MakeNewRegQueryExpression.FromScatch<string>()
                                            .ForKeyPath(
                                                ConfigurationFilePathKeyName
                                            )
                                            .AndValueName(
                                                ConfigurationFilePathValueName
                                            )
                                            .WithDefaultValue(
                                                Path.Combine(
                                                    DefaultConfigDir,
                                                    DefaultConfigFileName
                                                )
                                            )
               );

        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface and which
        /// exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        public IConfiguration Configuration
        {
            get;
            set;
        } = MakeNewConfiguration.FromScratch();

        /// <summary>
        /// Gets or sets the pathname of the configuration file.
        /// </summary>
        public string ConfigurationFilePath
        {
            get
                => LoadConfigPathAction.Execute()
                                       .Path;
            set {
                GetSaveConfigPathCommand.ForPath(
                                            ConfigurationFilePathKeyName,
                                            ConfigurationFilePathValueName,
                                            value
                                        )
                                        .Execute();

                /* Clear out the cache of previously-loaded paths
                 for this same operation. */
                LoadConfigPathAction.AsCachedResultAction()
                                    .ClearResultCache();
            }
        }

        /// <summary>
        /// Gets the default folder for the configuration file.
        /// </summary>
        /// <remarks>
        /// We store the config file, by default, in a folder under
        /// %USERPROFILE%\AppData\Local.
        /// </remarks>
        public string DefaultConfigDir
        {
            get;
        } = Path.Combine(
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), Application.CompanyName
            ), $@"{Application.ProductName}\Config"
        );

        /// <summary>
        /// Gets the default filename for the config file.
        /// </summary>
        public string DefaultConfigFileName
            => "config.json";

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
        ///     cref="M:MFR.Settings.ConfigurationProvider.Save" />
        /// method with a
        /// value for its pathname parameter.
        /// <para />
        /// However, doing this will not save the user's settings to the master
        /// file, which is important enough that we write a special method to
        /// handle this.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="exportFileName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public void Export(string exportFileName)
        {
            if (string.IsNullOrWhiteSpace(exportFileName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(exportFileName)
                );

            Save(); /* save the user's latest settings to the master config file */
            SaveCopyAs(
                exportFileName
            ); /* save the latest settings out to the export file */
        }

        /// <summary>
        /// Gets a string whose value is the pathname of the system Registry key in which
        /// configuration settings are stored.
        /// </summary>
        public string ConfigurationFilePathKeyName
            => ConfigurationPathRegistry.KeyName;

        /// <summary>
        /// Gets a string whose value is the Registry value under which we store the path
        /// to the configuration file.
        /// </summary>
        public string ConfigurationFilePathValueName
            => ConfigurationPathRegistry.ValueName;

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
        public void Import(string sourceFilePath)
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
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.Configuration" />
        /// property is then initialized to point to the data that has been loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the pathname to a file to be loaded
        /// from disk, that contains the configuration data in JSON format.
        /// <para />
        /// If this value is blank, then the file whose path is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.Configuration" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file whose pathname is passed in the
        /// <paramref
        ///     name="pathname" />
        /// parameter cannot be located on the disk.
        /// </exception>
        public void Load(string pathname = "")
        {
            // write the name of the current class and method we are now
            /*
             * If the file whose path is specified in the pathname parameter does not exist,
             * or if the pathname parameter is blank (in which case, the File.Exists method will
             * still return false), then fall back to the default config file path.
             */

            if (!CanLoad(ref pathname))
                return;

            try
            {
                Configuration = GetConfigurationAction
                                .For<IFileSystemEntry, IConfiguration>(
                                    ConfigurationActionType
                                        .LoadConfigurationFromFile
                                )
                                .WithInput(
                                    MakeNewFileSystemEntry.ForPath(pathname)
                                )
                                .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
                Configuration =
                    MakeNewConfiguration.FromScratch(); // make a default config if can't be loaded
            }

            if (Configuration != null)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info, "*** SUCCESS *** Configuration loaded."
                );

                // store the pathname in the pathname parameter into the ConfigurationFilePath property
                ConfigurationFilePath = pathname;
            }
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
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property.
        /// </param>
        public void Save(string pathname = "")
        {
            if (string.IsNullOrWhiteSpace(pathname))
                pathname = ConfigurationFilePath;

            SaveCopyAs(pathname);

            ConfigurationFilePath = pathname;
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
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void SaveCopyAs(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;
            
            // Check to see if the required property, Configuration, is null. If
            if (Configuration == null) return;

            try
            {
                GetConfigurationCommand.For<IFileSystemEntry>(
                                           ConfigurationCommandType
                                               .SaveConfigurationToFile
                                       )
                                       .WithInput(
                                           MakeNewFileSystemEntry
                                               .ForPath(pathname)
                                               .AndHavingUserState(
                                                   Configuration
                                               )
                                       )
                                       .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Determines whether the configuration should be loaded from the file whose path
        /// is specified in the <paramref name="pathname" /> parameter, or whether no data
        /// actually exists at that location and we should, instead, just use
        /// the default value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.Configuration" />
        /// property.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) Address of the string containing the fully-qualified pathname of
        /// the configuration
        /// file.
        /// <para />
        /// If this parameter is blank, then the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is used.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file at the path specified by
        /// <paramref name="pathname" /> exists on the disk, or if the file whose path is
        /// given by the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property exists on the disk; <see langword="false" /> otherwise.
        /// <para />
        /// If the <paramref name="pathname" /> passed is blank, then this method updates
        /// it to have the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property.
        /// </returns>
        private bool CanLoad(ref string pathname)
        {
            var fallbackPath = ConfigurationFilePath;

            if (File.Exists(pathname))
                return true;

            if (!File.Exists(fallbackPath)) 
                return false;

            pathname = fallbackPath;
            return true;
        }
    }
}
