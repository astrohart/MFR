using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Paths.Config.Provider.Factories;
using MFR.Paths.Config.Provider.Interfaces;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Actions;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using Determine = MFR.Settings.Configuration.Providers.Actions.Determine;

namespace MFR.Settings.Configuration.Providers
{
    /// <summary>
    /// Provides shared functionality for obtaining and storing the path to the
    /// user's config file.
    /// </summary>
    public class
        ProjectFileRenamerConfigProvider :
            IProjectFileRenamerConfigProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProjectFileRenamerConfigProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProjectFileRenamerConfigProvider()
        {
            InitializeConfigPathProvider();

            ConfigPathProvider
                .Load(); // load the pathname of the profile file from the system Registry.
        }

        /// <summary>
        /// Gets or sets the pathname of the config file.
        /// </summary>
        /// <remarks>
        /// This property raises the
        /// <see
        ///     cref="E:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePathChanged" />
        /// event when its value is updated.
        /// </remarks>
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
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// and which
        /// exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        public IProjectFileRenamerConfig CurrentConfiguration
        {
            get;
            set;
        } = GetBlankProjectFileRenamerConfig.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        public static IProjectFileRenamerConfigProvider Instance
        {
            get;
        } = new ProjectFileRenamerConfigProvider();

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property is updated.
        /// </summary>
        public event EventHandler ConfigFilePathChanged;

        /// <summary>
        /// Resets the config to default values.
        /// </summary>
        public void Clear()
            => CurrentConfiguration =
                GetBlankProjectFileRenamerConfig.SoleInstance();

        /// <summary>
        /// Exports config data to a file other than the master
        /// config file.
        /// </summary>
        /// <param name="exportFileName">
        /// </param>
        /// <remarks>
        /// Before performing the export, the method first saves the latest
        /// settings out to the master config file.
        /// <para />
        /// It goes without saying that an alternative to calling this method in
        /// the first place is to simply call the
        /// <see
        ///     cref="M:MFR.Settings.ProjectFileRenamerConfigProvider.Save" />
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
        /// Imports config data from a file whose path is
        /// <paramref name="sourceFilePath" />.
        /// </summary>
        /// <param name="sourceFilePath">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file from which to import the config data.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="sourceFilePath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="sourceFilePath" />
        /// parameter, cannot be located on the file system.
        /// </exception>
        /// <remarks>
        /// First, this method loads the data from the file specified into the
        /// application's config object.
        /// <para />
        /// Then, the method saves the new data out to the master
        /// config file.
        /// </remarks>
        public void Import(string sourceFilePath)
        {
            try
            {
                if (!Determine.IsConfigPathValid(sourceFilePath)) return;

                Load(sourceFilePath);
                Save(); // saves to the master location, thus doing an import
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Loads the config from the file system.
        /// <para />
        /// The
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.CurrentConfiguration" />
        /// property is then initialized to point to the data that has been loaded.
        /// <para />
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property is used as the pathname of the file that is to be loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of an application config file that is to be loaded.
        /// <para />
        /// If this parameter has a blank argument, or the application config file
        /// having the specified <paramref name="pathname" /> cannot be located on the
        /// disk, then the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.CurrentConfiguration" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        public IProjectFileRenamerConfig Load([NotLogged] string pathname = "")
        {
            var result = GetBlankProjectFileRenamerConfig.SoleInstance();

            try
            {
                /*
                 * If we aren't passed anything for the pathname parameter
                 * of this method, and if the CurrentConfiguration is already
                 * loaded, then just return a reference to the CurrentConfiguration
                 * property, to save cycles -- but only if the CurrentConfiguration
                 * property isn't set to the blank value.
                 */

                if (string.IsNullOrWhiteSpace(pathname) &&
                    !ProjectFileRenamerConfig.IsBlankOrNull(
                        CurrentConfiguration
                    ))
                {
                    result = CurrentConfiguration;
                    return result;
                }

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
                    result = CurrentConfiguration =
                        MakeNewProjectFileRenamerConfig.FromScratch();
                    return result;
                }

                result = CurrentConfiguration =
                    Obtain.ConfigurationFrom(pathnameToLoadFrom);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                CurrentConfiguration = GetBlankProjectFileRenamerConfig
                    .SoleInstance();
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** ProjectFileRenamerConfig loaded."
            );

            return result;
        }

        /// <summary>
        /// Saves config data to a file on the file system having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
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
        /// Saves config data to a file on the file system having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void SaveCopyAs(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;

            // Check to see if the required property, ProjectFileRenamerConfig, is null. If
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
        ///     cref="E:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePathChanged" />
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
        /// the loading and storing of the pathname of the application config file
        /// to/from the system Registry.
        /// </summary>
        private void InitializeConfigPathProvider()
            => ConfigPathProvider.ConfigFilePathChanged +=
                OnConfigFilePathChanged;
    }
}
