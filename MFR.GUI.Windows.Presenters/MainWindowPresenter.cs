using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.Engines.Constants;
using MFR.Engines.Interfaces;
using MFR.Events.Common;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.GUI.Controls.Extensions;
using MFR.GUI.Controls.Interfaces;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Initializers;
using MFR.GUI.Models.Constants;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Constants;
using MFR.GUI.Windows.Presenters.Events;
using MFR.GUI.Windows.Presenters.Interfaces;
using MFR.GUI.Windows.Presenters.Properties;
using MFR.Managers.History.Interfaces;
using MFR.Operations.Events;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Events;
using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Directories.Monitors.Events;
using xyLOGIX.Queues.Messages;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.GUI.Windows.Presenters
{
    /// <summary>
    /// Presenter for the main application window.
    /// </summary>
    public class MainWindowPresenter : ConfigurationComposedObjectBase,
        IMainWindowPresenter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object's sole purpose in life is to provide the service of
        /// maintaining the history lists in the configuration data
        /// source.
        /// </remarks>
        private IHistoryManager _historyManager;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.MainWindowPresenter" />
        /// and returns a reference to it.
        /// </summary>
        public MainWindowPresenter()
        {
            InitializeConfiguration();
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigurationProvider
            ConfigurationProvider
            => GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get;
            set;
        } = ConfigurationProvider.CurrentConfiguration;

        /// <summary>
        /// Gets the name of the currently-selected profile.
        /// </summary>
        private string CurrentProfileName
            => CurrentConfiguration is IProfile profile
                ? profile.Name
                : string.Empty;

        /// <summary>
        /// Gets a reference to this object instance.
        /// </summary>
        /// <remarks>
        /// This property is here to maintain method call semantics.
        /// </remarks>
        public IMainWindowPresenter Does
            => this;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IFileRenamer" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// THis object provides the core services that this application offers.
        /// </remarks>
        private IFileRenamer FileRenamer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the text to be searched for during the operations.
        /// </summary>
        private string FindWhat
            => FindWhatComboBox.EnteredText;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that plays the role of the Find What combo box.
        /// </summary>
        private IEntryRespectingComboBox FindWhatComboBox
            => View.FindWhatComboBox;

        /// <summary>
        /// Gets a value that indicates whether a Profile is currently loaded.
        /// </summary>
        public bool IsProfileLoaded
            => !ConfigurationProvider.CurrentConfiguration.IsTemporaryProfile();

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface and
        /// which actually performs the behavior of this Presenter.
        /// </summary>
        public IFullGuiOperationEngine OperationEngine
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
            => GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets the replacement text to be used during the operations.
        /// </summary>
        private string ReplaceWith
            => ReplaceWithComboBox.EnteredText;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that plays the role of the Replace With combo box on the main user interface.
        /// </summary>
        private IEntryRespectingComboBox ReplaceWithComboBox
            => View.ReplaceWithComboBox;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryPathValidator RootDirectoryPathValidator
            => GetRootDirectoryPathValidator.SoleInstance();

        /// <summary>
        /// Gets the path to the starting folder of the search.
        /// </summary>
        private string StartingFolder
            => StartingFolderComboBox.EnteredText;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that plays the role of the Starting Folder combo box on the main user
        /// interface.
        /// </summary>
        private IEntryRespectingComboBox StartingFolderComboBox
            => View.StartingFolderComboBox;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.IMainWindow" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides the functionality of the main window of the application.
        /// </remarks>
        public IMainWindow View
        {
            get;
            private set;
        }

        /// <summary>
        /// Failed to add the requested profile. Parameter is a string containing the
        /// error message to display.
        /// </summary>
        public event AddProfileFailedEventHandler AddProfileFailed;

        /// <summary>
        /// Occurs when all the history has been cleared.
        /// </summary>
        public event EventHandler AllHistoryCleared;

        /// <summary>
        /// Occurs when the configuration has been exported to a file.
        /// </summary>
        public event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        /// Occurs when the configuration has been updated, say, by an
        /// import process.
        /// </summary>
        public event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the user issues a request to create a new, blank Profile.
        /// </summary>
        public event CreateNewBlankProfileRequestedEventHandler
            CreateNewBlankProfileRequested;

        /// <summary>
        /// Occurs when an error happens during a data operation.
        /// </summary>
        public event DataOperationErrorEventHandler DataOperationError;

        /// <summary>
        /// Occurs when data is finished being moved to and fro between the
        /// screen and the configuration data source.
        /// </summary>
        public event EventHandler DataOperationFinished;

        /// <summary>
        /// Occurs when data is about to be moved to and fro between the screen
        /// and the configuration data source.
        /// </summary>
        public event DataOperationEventHandler DataOperationStarted;

        /// <summary>
        /// Occurs when the processing is done.
        /// </summary>
        public event EventHandler Finished;

        /// <summary>
        /// Occurs when an exception is thrown during a file operation.
        /// </summary>
        public event ExceptionRaisedEventHandler OperationError;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        public event EventHandler Started;

        /// <summary>
        /// Creates a 'profile' (really a way of saving a group of
        /// configuration
        /// settings) and then adds it to the collection of profiles that the user has.
        /// </summary>
        /// <param name="name">
        /// (Required.) A descriptive name for the profile.
        /// <para />
        /// The name of the profile can't be reused.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="name" /> parameter has a
        /// <see langref="null" /> reference, or is the blank or whitespace string.
        /// <para />
        /// The <paramref name="name" /> parameter is required.
        /// </exception>
        public void AddProfile(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            // Check whether there is an existing profile with the name we are wanting to use.
            // If so, then the user must be shown an error message to inform the user that the
            // name cannot be reused.
            if (GetProfileProvider.SoleInstance()
                                  .Profiles.HasProfileNamed(name))
            {
                OnAddProfileFailed(
                    new AddProfileFailedEventArgs(
                        string.Format(
                            Resources.Error_ProfileWithNameAlreadyExists, name
                        )
                    )
                );
                return;
            }

            ProfileProvider.Profiles.Add(
                OnCreateNewBlankProfileRequested(
                    new CreateNewBlankProfileRequestedEventArgs(name)
                )
            );
        }

        /// <summary>
        /// Fluent-builder method for initializing the history manager
        /// dependency of this Presenter class. History Manager objects control
        /// the flow of values into and out of the list of previously-specified
        /// values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// on which this Presenter
        /// should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IMainWindowPresenter AndHistoryManager(
            IHistoryManager historyManager
        )
        {
            _historyManager = historyManager ??
                              throw new ArgumentNullException(
                                  nameof(historyManager)
                              );

            return this;
        }

        /// <summary>
        /// Clears all the history lists in the configuration.
        /// </summary>
        [Log(AttributeExclude = true)]
        public void ClearAllHistory()
        {
            // write the name of the current class and method we are now
            UpdateData(); // save data from the screen prior to doing the operation

            if (!_historyManager.ClearAll())
                return; // clear operation canceled or not carried out

            UpdateData(false);

            OnAllHistoryCleared();
        }

        /// <summary>
        /// Begins the rename operation.
        /// </summary>
        public void DoSelectedOperations()
        {
            // write the name of the current class and method we are now
            if (View == null || OperationEngine == null)
                return;

            ValidateInputs();

            // just in case, have the file renamer object update its
            // configuration to match that which we have access to
            OperationEngine.UpdateConfiguration(CurrentConfiguration);

            OperationEngine.ProcessAll(
                StartingFolder, FindWhat, ReplaceWith,
                path => CurrentConfiguration.MatchCase
                    ? path.Contains(FindWhat)
                    : path.ContainsNoCase(FindWhat)
            );
        }

        /// <summary>
        /// Exports the current configuration data to a file on the
        /// user's hard drive.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to which the configuration should be exported.
        /// </param>
        /// <remarks>
        /// If a file having the specified <paramref name="pathname" /> already
        /// exists on the disk at the time the export operation is performed, it will be
        /// overwritten.
        /// </remarks>
        public void ExportConfiguration(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;

            try
            {
                /*
                 * If a configuration file already exists at the specified pathname,
                 * then
                 */

                if (File.Exists(pathname)) File.Delete(pathname);

                // Bring data from the screen down into the configuration
                // object
                UpdateData();

                ConfigurationProvider.Export(pathname);

                OnConfigurationExported(
                    new ConfigurationExportedEventArgs(pathname)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// This method is called to populate the Profiles combo box.
        /// </summary>
        public void FillProfileDropDownList()
        {
            View.ResetProfileCollectionComboBox();

            if (ProfileProvider.Profiles == null)
                return;

            if (ProfileProvider.Profiles.Count(
                    p => !p.Name.StartsWith("tmp")
                ) == 0)
                return;

            /*
             * Load the Profiles into the combo box,
             * except ones whose name begin with tmp.
             */

            View.ProfileCollectionComboBox.Items.AddRange(
                ProfileProvider.Profiles.Where(p => !p.Name.StartsWith("tmp"))
                               .ToArray<object>()
            );

            if (string.IsNullOrWhiteSpace(CurrentProfileName) ||
                CurrentProfileName.StartsWith("tmp"))
                View.ProfileCollectionComboBox.SelectFirstItem();
            else
                View.ProfileCollectionComboBox.SelectFirstItemNamed(
                    CurrentProfileName
                );
        }

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" />
        /// interface, and which represents the form that is to be associated
        /// with this presenter.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="view" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        public IMainWindowPresenter HavingWindowReference(IMainWindow view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));

            UpdateData(
                false
            ); // at this step, move data from the configuration to the screen

            return this;
        }

        /// <summary>
        /// Imports the configuration data for this application.
        /// </summary>
        /// <remarks>
        /// The data is presumed to be located inside of a JSON-formatted file
        /// that exists on the user's hard drive and has the <c>.json</c> extension.
        /// </remarks>
        public void ImportConfiguration(
            string pathname /* path of the file to be imported */
        )
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;
            if (!File.Exists(pathname)) return;

            try
            {
                ConfigurationProvider.Import(pathname);

                OnConfigurationImported(
                    new ConfigurationImportedEventArgs(pathname)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sets the state of the Operations to Perform checked list box items
        /// based on configuration settings.
        /// </summary>
        public void InitializeOperationSelections()
        {
            View.OperationsCheckedListBox.CheckByName(
                OperationNames.RenameFilesInFolder,
                CurrentConfiguration.RenameFiles
            );
            View.OperationsCheckedListBox.CheckByName(
                OperationNames.RenameSubFolders,
                CurrentConfiguration.RenameSubFolders
            );
            View.OperationsCheckedListBox.CheckByName(
                OperationNames.ReplaceTextInFiles,
                CurrentConfiguration.ReplaceTextInFiles
            );

            View.OperationsCheckedListBox.CheckByName(
                OperationNames.RenameSolutionFolders,
                CurrentConfiguration.RenameSolutionFolders
            );
        }

        /// <summary>
        /// Determines whether a Profile having the specified
        /// <paramref name="profileName" /> is already defined.
        /// <para />
        /// The match that is done is case-insensitive.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name of the Profile
        /// to search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a Profile having the specified
        /// <paramref name="profileName" /> is defined; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="profileName" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public bool ProfileAlreadyExist(string profileName)
            => !string.IsNullOrWhiteSpace(profileName) &&
               ProfileProvider.Profiles.HasProfileNamed(profileName);

        /// <summary>
        /// Saves data from the screen control and then saves the
        /// configuration to the
        /// persistence location.
        /// </summary>
        public void SaveConfiguration()
        {
            UpdateData();
            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Runs code that should execute when either the OK or Apply buttons
        /// are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialog">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Dialogs.Interfaces.IOptionsDialog" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dialog" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public void SaveConfigurationDataFrom(IOptionsDialog dialog)
        {
            if (dialog == null) throw new ArgumentNullException(nameof(dialog));

            if (ConfigurationProvider.ConfigFilePath != dialog.ConfigPathname)
                MakeNewFileInfo.ForPath(ConfigurationProvider.ConfigFilePath)
                               .RenameTo(dialog.ConfigPathname);

            ConfigurationProvider.CurrentConfiguration.AutoQuitOnCompletion =
                dialog.AutoQuitOnCompletion;
            ConfigurationProvider.ConfigFilePath = dialog.ConfigPathname;
            ConfigurationProvider.CurrentConfiguration.ReOpenSolution =
                dialog.ReOpenSolution;
            UpdateConfiguration(ConfigurationProvider.CurrentConfiguration);
        }

        /// <summary>
        /// Transforms the current value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.ProjectFileRenamerConfiguration" />
        /// property into a Profile with the <paramref name="profileName" /> specified.
        /// <para />
        /// If a Profile with the same name is already defined, then this method does
        /// nothing.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name to give the
        /// new Profile.
        /// </param>
        public void SaveCurrentConfigurationAsProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName)) return;

            if (Does.ProfileAlreadyExist(profileName)) return;

            var newProfile =
                ConfigurationProvider.CurrentConfiguration.ToProfile(
                    profileName
                );
            ProfileProvider.Profiles.Add(newProfile);
            ProfileProvider.Save();

            /*
             * Make the new Profile the same as the currently-
             * loaded configuration.
             */

            ConfigurationProvider.CurrentConfiguration = newProfile;
            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Updates the configuration currently being used with a new
        /// value.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface which has
        /// the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// <para />
        /// NOTE:This member may be overriden by a child class. If this is the
        /// case, the overrider must call the base class method before doing any
        /// of its own processing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public override void UpdateConfiguration(
            IProjectFileRenamerConfiguration configuration
        )
        {
            base.UpdateConfiguration(configuration);

            OperationEngine.UpdateConfiguration(configuration);
            _historyManager.UpdateConfiguration(configuration);

            InitializeOperationEngine();
        }

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <see langword="true" />) or from
        /// the model to the screen ( <paramref name="bSavingAndValidating" />
        /// equals <see langword="false" />).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <see langword="true" /> to move data from the screen to the
        /// model; <see langword="false" /> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        public void UpdateData(bool bSavingAndValidating = true)
        {
            // write the name of the current class and method we are now
            // Check to see if the required property, ProjectFileRenamerConfiguration, is null. If
            if (CurrentConfiguration == null)

                // the property ProjectFileRenamerConfiguration is required.
                // stop.
                return;

            // Since moving data to/from the screen may potentially take some
            // time, show the marquee-style progress bar on the status bar in
            // the interim
            OnDataOperationStarted(
                new DataOperationEventArgs(
                    "Updating configuration...  Please wait."
                )
            );

            if (bSavingAndValidating)
            {
                CurrentConfiguration.SaveCurrentStartingFolderAndHistory(
                    View.StartingFolderComboBox
                );

                CurrentConfiguration.SaveCurrentFindWhatAndHistory(
                    View.FindWhatComboBox
                );

                CurrentConfiguration.SaveCurrentReplaceWithAndHistory(
                    View.ReplaceWithComboBox
                );

                CurrentConfiguration.IsFolded = View.IsFolded;

                CurrentConfiguration.MatchCase = View.MatchCase;

                CurrentConfiguration.MatchExactWord = View.MatchExactWord;

                CurrentConfiguration.SelectedOptionTab = View.SelectedOptionTab;

                SaveOperationSelections();
            }
            else
            {
                InitializeOperationSelections();

                View.SelectedOptionTab = ConfigurationProvider
                                         .CurrentConfiguration
                                         .SelectedOptionTab;

                View.MatchExactWord = CurrentConfiguration.MatchExactWord;

                View.MatchCase = CurrentConfiguration.MatchCase;

                View.IsFolded = CurrentConfiguration.IsFolded;

                ComboBoxInitializer.InitializeComboBox(
                    View.StartingFolderComboBox,
                    CurrentConfiguration.StartingFolderHistory,
                    CurrentConfiguration.StartingFolder
                );

                ComboBoxInitializer.InitializeComboBox(
                    View.FindWhatComboBox, 
                    CurrentConfiguration.FindWhatHistory,
                    CurrentConfiguration.FindWhat
                );

                ComboBoxInitializer.InitializeComboBox(
                    View.ReplaceWithComboBox,
                    CurrentConfiguration.ReplaceWithHistory,
                    CurrentConfiguration.ReplaceWith
                );
            }

            OnDataOperationFinished();
        }

        /// <summary>
        /// Fluent-builder method for initializing the operation engine object.  This is
        /// the object that actually schedules and runs the file-renaming tasks and
        /// provides user feedback.
        /// </summary>
        /// <param name="operationEngine">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface on
        /// which this Presenter should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="operationEngine" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public IMainWindowPresenter WithOperationEngine(
            IFullGuiOperationEngine operationEngine
        )
        {
            OperationEngine = operationEngine ??
                              throw new ArgumentNullException(
                                  nameof(operationEngine)
                              );

            return this;
        }

        /// <summary>
        /// Saves the selections made in the Operations to Perform checked list
        /// box into the
        /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfiguration" />
        /// object.
        /// </summary>
        public void SaveOperationSelections()
        {
            // write the name of the current class and method we are now
            CurrentConfiguration.RenameFiles =
                View.OperationsCheckedListBox.GetCheckedByName(
                    OperationNames.RenameFilesInFolder
                );
            CurrentConfiguration.RenameSubFolders =
                View.OperationsCheckedListBox.GetCheckedByName(
                    OperationNames.RenameSubFolders
                );
            CurrentConfiguration.ReplaceTextInFiles =
                View.OperationsCheckedListBox.GetCheckedByName(
                    OperationNames.ReplaceTextInFiles
                );
            CurrentConfiguration.RenameSolutionFolders =
                View.OperationsCheckedListBox.GetCheckedByName(
                    OperationNames.RenameSolutionFolders
                );
        }

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.IMainWindow" /> interface and which
        /// represents the main window of the application.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="mainWindow" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IMainWindowPresenter WindowReference(IMainWindow mainWindow)
        {
            // write the name of the current class and method we are now
            View = mainWindow ??
                   throw new ArgumentNullException(nameof(mainWindow));
            return this;
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.AddProfileFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnAddProfileFailed(AddProfileFailedEventArgs e)
        {
            AddProfileFailed?.Invoke(this, e);
            SendMessage<AddProfileFailedEventArgs>.Having.Args(this, e)
                                                  .ForMessageId(
                                                      MainWindowPresenterMessages
                                                          .MWP_ADD_NEW_PROFILE_FAILED
                                                  );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.AllHistoryCleared" />
        /// event.
        /// </summary>
        /// <remarks>
        /// The objective of calling this method is to inform interested parties
        /// that the operation of clearing all the history is complete.
        /// </remarks>
        protected virtual void OnAllHistoryCleared()
        {
            AllHistoryCleared?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(
                           MainWindowPresenterMessages.MWP_ALL_HISTORY_CLEARED
                       );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.MainWindowPresenter.ConfigurationExported" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Settings.ConfigurationExportedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnConfigurationExported(
            ConfigurationExportedEventArgs e
        )
        {
            ConfigurationExported?.Invoke(this, e);
            SendMessage<ConfigurationExportedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    MainWindowPresenterMessages.MWP_CONFIGURATION_EXPORTED
                );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.MainWindowPresenter.ConfigurationImported" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Settings.ConfigurationImportedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnConfigurationImported(
            ConfigurationImportedEventArgs e
        )
        {
            ConfigurationImported?.Invoke(this, e);
            SendMessage<ConfigurationImportedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    MainWindowPresenterMessages.MWP_CONFIGURATION_IMPORTED
                );

            UpdateConfiguration(ConfigurationProvider.CurrentConfiguration);

            UpdateData(false);

            InitializeConfiguration();
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.CreateNewBlankProfileRequested" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual IProfile OnCreateNewBlankProfileRequested(
            CreateNewBlankProfileRequestedEventArgs e
        )
        {
            var result = CreateNewBlankProfileRequested?.Invoke(this, e);
            SendMessage<CreateNewBlankProfileRequestedEventArgs>.Having
                .Args(this, e)
                .ForMessageId(
                    MainWindowPresenterMessages
                        .MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED
                );
            return result;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.MainWindowPresenter.DataOperationError" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.DataOperationErrorEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnDataOperationError(
            DataOperationErrorEventArgs e
        )
        {
            DataOperationError?.Invoke(this, e);
            SendMessage<DataOperationErrorEventArgs>.Having.Args(this, e)
                                                    .ForMessageId(
                                                        MainWindowPresenterMessages
                                                            .MWP_DATA_OPERAITON_ERROR
                                                    );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.DataOperationFinished" />
        /// event.
        /// </summary>
        /// <remarks>
        /// Ideally, it should be the main application window that handles this
        /// event by simply displaying a marquee progress bar on the status bar
        /// of the application window but otherwise maintaining the ability of
        /// the user to use the GUI. This is because moving data to and from the
        /// configuration data source, while a mildly lengthy operation,
        /// is
        /// nowhere near as involved as the file operations we would normally undertake.
        /// </remarks>
        protected virtual void OnDataOperationFinished()
        {
            DataOperationFinished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(
                           MainWindowPresenterMessages
                               .MWP_DATA_OPERATION_FINISHED
                       );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.MainWindowPresenter.DataOperationStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A <see cref="T:MFR.DataOperationEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// Ideally, it should be the main application window that handles this
        /// event by simply displaying a marquee progress bar on the status bar
        /// of the application window but otherwise maintaining the ability of
        /// the user to use the GUI. This is because moving data to and from the
        /// configuration data source, while a mildly lengthy operation,
        /// is
        /// nowhere near as involved as the file operations we would normally undertake.
        /// </remarks>
        protected virtual void OnDataOperationStarted(DataOperationEventArgs e)
        {
            DataOperationStarted?.Invoke(this, e);
            SendMessage<DataOperationErrorEventArgs>.Having.Args(this, e)
                                                    .ForMessageId(
                                                        MainWindowPresenterMessages
                                                            .MWP_DATA_OPERATION_STARTED
                                                    );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.Finished" />
        /// event.
        /// </summary>
        /// <remarks>
        /// This event lets client objects know that the presenter is about to
        /// finish an operation. Typically, the client object is the main
        /// application window, which should respond by dismissing any progress
        /// dialog that may have been previously shown during the operation and
        /// re-enabling user input.
        /// </remarks>
        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(MainWindowPresenterMessages.MWP_FINISHED);
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Windows.Presenters.MainWindowPresenter.OperationError" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnOperationError(ExceptionRaisedEventArgs e)
            => OperationError?.Invoke(this, e);

        protected virtual void OnOperationStarted(object sender, EventArgs e)
        {
            Started?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(MainWindowPresenterMessages.MWP_STARTED);
        }

        /// <summary>
        /// Initializes the currently-loaded configuration object.
        /// </summary>
        private void InitializeConfiguration()
        {
            try
            {
                if (CurrentConfiguration == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The CurrentConfiguration property has a null reference for a value."
                    );

                    return;
                }

                CurrentConfiguration.StartingFolderChanged -=
                    OnConfigurationStartingFolderChanged;
                CurrentConfiguration.StartingFolderChanged +=
                    OnConfigurationStartingFolderChanged;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private void InitializeOperationEngine()
        {
            if (FileRenamer == null) return;
            if (OperationEngine == null) return;

            NewMessageMapping<EventArgs>.Associate.WithMessageId(
                                            OperationEngineMessages
                                                .OE_PROCESSING_STARTED
                                        )
                                        .AndHandler(
                                            new EventHandler(OnOperationStarted)
                                        );
            NewMessageMapping<DirectoryBeingMonitoredChangedEventArgs>.Associate
                .WithMessageId(
                    OperationEngineMessages.OE_ROOT_DIRECTORY_PATH_UPDATED
                )
                .AndHandler(
                    new DirectoryBeingMonitoredChangedEventHandler(
                        OnRootDirectoryPathBeingChanged
                    )
                );
            NewMessageMapping<EventArgs>.Associate.WithMessageId(
                                            OperationEngineMessages
                                                .OE_PROCESSING_FINISHED
                                        )
                                        .AndHandler(
                                            new EventHandler(
                                                OnProcessingFinished
                                            )
                                        );
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.GUI.ICancellableProgressDialog.CancelRequested" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method handles the situation in which the user has clicked the
        /// Cancel button on the progress dialog. The message taken by this
        /// method is to tell the File Renamer Object to attempt to abort.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnCancellableProgressDialogRequestedCancel(
            object sender,
            EventArgs e
        )
            => FileRenamer.RequestAbort();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolderChanged" />
        /// event raised by the configuration object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by checking whether the entry is a valid folder
        /// pathname; if so, then the folder pathname is added to the history of
        /// starting-folder entries in the history.
        /// <para />
        /// Starting-folder pathname entries aren't added to the configuration's history
        /// list if an entry having the same content already exists in the history.
        /// </remarks>
        private void OnConfigurationStartingFolderChanged(
            object sender,
            EventArgs e
        )
        {
            // Make sure we're getting a valid folder
            if (!RootDirectoryPathValidator.Validate(
                    CurrentConfiguration.StartingFolder
                )) return;

            StartingFolderComboBox.Items.AddDistinct(
                CurrentConfiguration.StartingFolder
            );
        }

        /// <summary>
        /// This method is called when the Operation Engine sends the
        /// <c>OE_PROCESSING_FINISHED</c> message.
        /// </summary>
        private void OnProcessingFinished(object sender, EventArgs e)
            => OnFinished();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="F:MFR.Engines.Constants.OperationEngineMessages.OE_ROOT_DIRECTORY_PATH_UPDATED" />
        /// message.
        /// </summary>
        /// <param name="sender">
        /// (Required.) Reference to an instance of the object that
        /// originally sent the message.
        /// </param>
        /// <param name="e">
        /// (Required.) A
        /// <see
        ///     cref="T:xyLOGIX.Directories.Monitors.Events.DirectoryBeingMonitoredChangedEventArgs" />
        /// that carries the message data.
        /// </param>
        private void OnRootDirectoryPathBeingChanged(
            object sender,
            DirectoryBeingMonitoredChangedEventArgs e
        )
        {
            /*
             * If we are here, then the root directory path (that is, that the user
             * initially started the operation from in the first place, and which may potentially have
             * several Visual Studio Solution (*.sln) files contained within it) got
             * modified during the operations, perhaps because Rename Solution Folders was one of the
             * indicated operations.
             *
             * Therefore, check if the OldPath property of the EventArgs object is equal to the
             * entered text in the View's combo box, and, if so, then update it to reflect
             * the new path.
             */
            if (View.StartingFolderComboBox.EnteredText.TrimEnd('\\')
                    .Equals(e.OldPath.TrimEnd('\\')))
                View.StartingFolderComboBox.EnteredText =
                    e.NewPath.TrimEnd('\\');
        }

        // raise the Finished event
        /// <summary>
        /// Runs rules to ensure that the entries on the main window's form are
        /// valid. Throws a <see cref="T:System.Exception" /> if a validation
        /// rule fails.
        /// </summary>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the directory whose pathname is referenced by
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolder" />
        /// is not found on the disk.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if either of the
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhat" />
        /// or
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWith" />
        /// properties are blank.
        /// </exception>
        /// <remarks>
        /// This method should be called in a try/catch handler. Upon catching
        /// an exception, instead of logging the error, the application should
        /// also respond by displaying a Stop message box to the user with the
        /// value of the <see cref="P:System.Exception.Message" /> property of
        /// the caught exception as its text, and then set the focus to the
        /// offending field (if feasible).
        /// </remarks>
        private void ValidateInputs()
        {
            if (!Directory.Exists(StartingFolder))
                throw new DirectoryNotFoundException(
                    string.Format(
                        Resources.Error_RootDirectoryNotFound, StartingFolder
                    )
                );
            if (string.IsNullOrWhiteSpace(FindWhat))
                throw new InvalidOperationException(
                    Resources.Error_FindWhatRequired
                );
            /*
             * NOTE: It is okay for the ReplaceWith
             * value to be blank in certain circumstances,
             * such as when replacing text in a file.  So,
             * do not do this blanket rule check here.
             */

            /*
            if (string.IsNullOrWhiteSpace(ReplaceWith))
                throw new InvalidOperationException(
                    Resources.Error_ReplaceWithBlank
                );
            */

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** All inputs have been successfully validated."
            );
        }
    }
}