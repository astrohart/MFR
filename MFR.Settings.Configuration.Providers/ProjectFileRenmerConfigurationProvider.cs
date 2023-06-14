using MFR.FileSystem.Factories;
using MFR.FileSystem.Factories.Actions;
using MFR.FileSystem.Interfaces;
using MFR.Paths.Config.Provider.Factories;
using MFR.Paths.Config.Provider.Interfaces;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Actions;
using MFR.Settings.Configuration.Providers.Interfaces;
using System;
using xyLOGIX.Core.Debug;
using Initialize = MFR.GUI.Models.Actions.Initialize;

namespace MFR.Settings.Configuration.Providers
{
    /// <summary>
    /// Provides shared functionality for obtaining and storing the path to the
    /// user's configuration file.
    /// </summary>
    public class
        ProjectFileRenamerConfigurationProvider :
            IProjectFileRenamerConfigurationProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProjectFileRenamerConfigurationProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProjectFileRenamerConfigurationProvider()
        {
            InitializeConfigPathProvider();

            ConfigPathProvider
                .Load(); // load the pathname of the profile file from the system Registry.
        }

        /// <summary>
        /// Gets or sets the pathname of the configuration file.
        /// </summary>
        public string ConfigFilePath
        {
            get => ConfigPathProvider.ConfigFilePath;
            set => ConfigPathProvider.ConfigFilePath = value;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider" />
        /// interface.
        /// </summary>
        private static IConfigPathProvider ConfigPathProvider
        {
            get;
        } = GetConfigPathProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface
        /// and which
        /// exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        public IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get;
            set;
        } = Create.BlankConfiguration();

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        public static IProjectFileRenamerConfigurationProvider Instance
        {
            get;
        } = new ProjectFileRenamerConfigurationProvider();

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
        ///     cref="M:MFR.Settings.ProjectFileRenamerConfigurationProvider.Save" />
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
        /// Then, the method saves the new data out to the master
        /// configuration file.
        /// </remarks>
        public void Import(string sourceFilePath)
        {
            try
            {
                if (!Determine.IsConfigPathValid(sourceFilePath)) return;

                Load(sourceFilePath);
                Save();     // saves to the master location, thus doing an import
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Loads the configuration from the disk.
        /// <para />
        /// The
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration" />
        /// property is then initialized to point to the data that has been loaded.
        /// <para />
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property is used as the pathname of the file that is to be loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of an application configuration file that is to be loaded.
        /// <para />
        /// If this parameter has a blank argument, or the application configuration file
        /// having the specified <paramref name="pathname" /> cannot be located on the
        /// disk, then the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        public void Load(string pathname = "")
        {
            try
            {
                /*
                 * Should we load from the pathname passed to us, or from the
                 * ConfigFilePath?
                 */

                var pathnameToLoadFrom =
                    Determine.CorrectPathForLoadingConfiguration(
                        pathname, ConfigFilePath
                    );
                if (!Does.FileExist(pathnameToLoadFrom))
                {
                    CurrentConfiguration =
                        MakeNewProjectFileRenamerConfiguration.FromScratch();
                    CurrentConfiguration.InvokableOperations =
                        Initialize.OperationList();
                    return;
                }

                CurrentConfiguration =
                    Obtain.ConfigurationFrom(pathnameToLoadFrom);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                CurrentConfiguration = Create.BlankConfiguration();
            }

            if (CurrentConfiguration == null)
                return;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** ProjectFileRenamerConfiguration loaded."
            );

            // store the pathname in the pathname parameter into the ConfigFilePath property
            ConfigFilePath = pathname;
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
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property.
        /// </param>
        public void Save(string pathname = "")
        {
            if (string.IsNullOrWhiteSpace(pathname))
                pathname = ConfigFilePath;

            SaveCopyAs(pathname);

            ConfigFilePath = pathname;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property is updated.
        /// </summary>
        public event EventHandler ConfigFilePathChanged;

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
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void SaveCopyAs(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;

            // Check to see if the required property, ProjectFileRenamerConfiguration, is null. If
            if (CurrentConfiguration == null) return;

            if (CurrentConfiguration.IsFromCommandLine &&
                CurrentConfiguration.AutoStart)
                return;

            try
            {
                GetConfigurationCommand.For<IFileSystemEntry>(
                                           ConfigurationCommandType
                                               .SaveConfigurationToFile
                                       )
                                       .WithInput(
                                           MakeNewFileSystemEntry
                                               .ForPath(pathname)
                                               .SetUserState(
                                                   CurrentConfiguration
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
        /// Raises the
        /// <see
        ///     cref="E:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePathChanged" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// (Required.) Reference to the instance of the object that
        /// raised this event.
        /// </param>
        /// <param name="e">
        /// (Required.) A <see cref="T:System.EventArgs" /> that contains
        /// the event data.
        /// </param>
        protected virtual void OnConfigFilePathChanged(
            object sender,
            EventArgs e
        )
            => ConfigFilePathChanged?.Invoke(sender, e);

        /// <summary>
        /// Configures settings on the object, which we have as a dependency, that manages
        /// the loading and storing of the pathname of the application configuration file
        /// to/from the system Registry.
        /// </summary>
        private void InitializeConfigPathProvider()
            => ConfigPathProvider.ConfigFilePathChanged +=
                OnConfigFilePathChanged;
    }
}