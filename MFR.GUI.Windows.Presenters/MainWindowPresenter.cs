using MFR.Common;
using MFR.Constants;
using MFR.Events;
using MFR.Events.Common;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.GUI.Controls.Extensions;
using MFR.GUI.Controls.Interfaces;
using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Initializers;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Constants;
using MFR.GUI.Windows.Presenters.Events;
using MFR.GUI.Windows.Presenters.Interfaces;
using MFR.GUI.Windows.Presenters.Properties;
using MFR.Managers.History.Interfaces;
using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Factories;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
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
        ///     cref="T:MFR.GUI.ICancellableProgressDialog" />
        /// interface.
        /// </summary>
        private ICancellableProgressDialog _cancellableProgressDialog;

        /// <summary>
        /// Reference to an instance of a
        /// <see
        ///     cref="T:System.Windows.Forms.SaveFileDialog" />
        /// that allows the user
        /// to choose where they want to export the configuration data.
        /// </summary>
        private SaveFileDialog _exportConfigDialog;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IFileRenamer" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// THis object provides the core services that this application offers.
        /// </remarks>
        private IFileRenamer _fileRenamer;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object's sole purpose in life is to provide the service of
        /// maintaining the history lists in the configuration data source.
        /// </remarks>
        private IHistoryManager _historyManager;

        /// <summary>
        /// Reference to an instance of
        /// <see
        ///     cref="T:System.Windows.Forms.OpenFileDialog" />
        /// that allows the user
        /// to choose a filename on the disk.
        /// </summary>
        /// <remarks>
        /// The file chosen by this dialog is to be used for importing
        /// configuration data.
        /// </remarks>
        private OpenFileDialog _importConfigDialog;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.MainWindowPresenter" />
        /// and returns a reference to it.
        /// </summary>
        public MainWindowPresenter()
        {
            // write the name of the current class and method we are now
            InitializeComponents();

            ReinitializeProgressDialog();
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
        /// Occurs when the configuration has been updated, say, by an import process.
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
        /// Gets a reference to this object instance.
        /// </summary>
        /// <remarks>
        /// This property is here to maintain method call semantics.
        /// </remarks>
        public IMainWindowPresenter Does
            => this;

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
            => !ConfigurationProvider.Configuration.IsTransientProfile();

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
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the actions
        /// associated with it.
        /// </remarks>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
            => GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets the name of the currently-selected profile.
        /// </summary>
        private string CurrentProfileName
            => Configuration is IProfile profile
                ? profile.Name
                : string.Empty;

        /// <summary>
        /// Creates a 'profile' (really a way of saving a group of configuration
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
            IHistoryManager historyManager)
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
        /// Dismisses the progress dialog.
        /// </summary>
        public void CloseProgressDialog()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Close()
            );

        /// <summary>
        /// Begins the rename operation.
        /// </summary>
        public void DoSelectedOperations()
        {
            // write the name of the current class and method we are now
            if (View == null || _fileRenamer == null)
                return;

            // just in case, have the file renamer object update its
            // configuration to match that which we have access to
            _fileRenamer.UpdateConfiguration(Configuration);

            ReinitializeProgressDialog();

            ValidateInputs();

            CommenceRenameOperation();
        }

        /// <summary>
        /// Exports the current configuration data to a file on the user's hard drive.
        /// </summary>
        public void ExportConfiguration()
        {
            // Bring data from the screen down into the Configuration
            // object
            UpdateData();

            _exportConfigDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (_exportConfigDialog.ShowDialog(View) != DialogResult.OK)
                return;

            ConfigurationProvider.Export(_exportConfigDialog.FileName);

            OnConfigurationExported(
                new ConfigurationExportedEventArgs(_exportConfigDialog.FileName)
            );
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
                p => !p.Name.StartsWith("tmp_")
            ) == 0)
                return;

            /*
             * Load the Profiles into the combo box,
             * except ones whose name begin with tmp_.
             */

            View.ProfileCollectionComboBox.Items.AddRange(
                ProfileProvider.Profiles.Where(p => !p.Name.StartsWith("tmp_"))
                               .ToArray<object>()
            );

            if (string.IsNullOrWhiteSpace(CurrentProfileName) ||
                CurrentProfileName.StartsWith("tmp_"))
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
        public void ImportConfiguration()
        {
            _importConfigDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (_importConfigDialog.ShowDialog(View) != DialogResult.OK)
                return;

            ConfigurationProvider.Import(_importConfigDialog.FileName);

            UpdateConfiguration(ConfigurationProvider.Configuration);

            UpdateData(false);

            OnConfigurationImported(
                new ConfigurationImportedEventArgs(_importConfigDialog.FileName)
            );
        }

        /// <summary>
        /// Sets the state of the Operations to Perform checked list box items
        /// based on configuration settings.
        /// </summary>
        public void InitializeOperationSelections()
        {
            View.OperationsCheckedListBox.CheckByName(
                "Rename Files", Configuration.RenameFiles
            );
            View.OperationsCheckedListBox.CheckByName(
                "Rename Subfolders", Configuration.RenameSubFolders
            );
            View.OperationsCheckedListBox.CheckByName(
                "Replace in Files", Configuration.ReplaceTextInFiles
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
        /// Saves data from the screen control and then saves the configuration to the
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

            if (ConfigurationProvider.ConfigurationFilePath !=
                dialog.ConfigPathname)
                MakeNewFileInfo.ForPath(
                                   ConfigurationProvider.ConfigurationFilePath
                               )
                               .RenameTo(dialog.ConfigPathname);

            ConfigurationProvider.ConfigurationFilePath = dialog.ConfigPathname;
            ConfigurationProvider.Configuration.ReOpenSolution =
                dialog.ShouldReOpenVisualStudioSolution;
            UpdateConfiguration(ConfigurationProvider.Configuration);
        }

        /// <summary>
        /// Transforms the current value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Configuration" />
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

            var newProfile = ConfigurationProvider.Configuration.ToProfile(profileName);
            ProfileProvider.Profiles.Add(
                newProfile
            );
            ProfileProvider.Save();

            /*
             * Make the new Profile the same as the currently-
             * loaded configuration.
             */

            ConfigurationProvider.Configuration = newProfile;
            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Saves the selections made in the Operations to Perform checked list
        /// box into the <see cref="T:MFR.Settings.Configuration.Configuration" /> object.
        /// </summary>
        public void SaveOperationSelections()
        {
            // write the name of the current class and method we are now
            Configuration.RenameFiles =
                View.OperationsCheckedListBox.GetCheckedByName("Rename Files");
            Configuration.RenameSubFolders =
                View.OperationsCheckedListBox.GetCheckedByName(
                    "Rename Subfolders"
                );
            Configuration.ReplaceTextInFiles =
                View.OperationsCheckedListBox.GetCheckedByName(
                    "Replace in Files"
                );
        }

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public void ShowCalculatingProgressBar(string text,
            bool canCancel = true)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );
            ResetProgressBar();

            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarStyle =
                    ProgressBarStyle.Marquee
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = text
            );
        }

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        public void ShowProgressDialog(bool canCancel)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    _cancellableProgressDialog.CanCancel = canCancel;
                    _cancellableProgressDialog.Show();
                }
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        public void ShowProgressDialog(IWin32Window owner)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Show(owner)
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        public void ShowProgressDialog(IWin32Window owner, bool canCancel)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    _cancellableProgressDialog.CanCancel = canCancel;
                    _cancellableProgressDialog.Show(owner);
                }
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        public void ShowProgressDialog()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Show()
            );

        /// <summary>
        /// Updates the configuration currently being used with a new value.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public override void UpdateConfiguration(IConfiguration configuration)
        {
            base.UpdateConfiguration(configuration);

            _fileRenamer.UpdateConfiguration(configuration);
            _historyManager.UpdateConfiguration(configuration);

            InitializeFileRenamer();
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
            // Check to see if the required property, Configuration, is null. If
            if (Configuration == null)
            {
                // the property Configuration is required.
                // stop.
                return;
            }
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
                Configuration.SaveCurrentStartingFolderAndHistory(
                    View.StartingFolderComboBox
                );

                Configuration.SaveCurrentFindWhatAndHistory(
                    View.FindWhatComboBox
                );

                Configuration.SaveCurrentReplaceWithAndHistory(
                    View.ReplaceWithComboBox
                );

                Configuration.IsFolded = View.IsFolded;

                Configuration.MatchCase = View.MatchCase;

                Configuration.MatchExactWord = View.MatchExactWord;

                Configuration.SelectedOptionTab = View.SelectedOptionTab;

                SaveOperationSelections();
            }
            else
            {
                InitializeOperationSelections();

                View.SelectedOptionTab = ConfigurationProvider.Configuration
                    .SelectedOptionTab;

                View.MatchExactWord = Configuration.MatchExactWord;

                View.MatchCase = Configuration.MatchCase;

                View.IsFolded = Configuration.IsFolded;

                ComboBoxInitializer.InitializeComboBox(
                    View.StartingFolderComboBox,
                    Configuration.StartingFolderHistory,
                    Configuration.StartingFolder
                );

                ComboBoxInitializer.InitializeComboBox(
                    View.FindWhatComboBox, Configuration.FindWhatHistory,
                    Configuration.FindWhat
                );

                ComboBoxInitializer.InitializeComboBox(
                    View.ReplaceWithComboBox, Configuration.ReplaceWithHistory,
                    Configuration.ReplaceWith
                );
            }

            OnDataOperationFinished();
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
        /// Fluent-builder method for composing a file-renamer object with this presenter.
        /// </summary>
        /// <param name="fileRenamer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.IFileRenamer" /> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="fileRenamer" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IMainWindowPresenter WithFileRenamer(IFileRenamer fileRenamer)
        {
            _fileRenamer = fileRenamer ??
                           throw new ArgumentNullException(nameof(fileRenamer));

            InitializeFileRenamer();

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
            ConfigurationExportedEventArgs e)
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
            ConfigurationImportedEventArgs e)
        {
            ConfigurationImported?.Invoke(this, e);
            SendMessage<ConfigurationImportedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    MainWindowPresenterMessages.MWP_CONFIGURATION_IMPORTED
                );
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
            CreateNewBlankProfileRequestedEventArgs e)
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
            DataOperationErrorEventArgs e)
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
        /// configuration data source, while a mildly lengthy operation, is
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
        /// configuration data source, while a mildly lengthy operation, is
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
        /// Handles the <see cref="E:MFR.IFileRenamer.Started" /> event
        /// raised by the File Renamer object. This event is raised when the
        /// rename operations are all completed.
        /// </summary>
        /// <param name="sender">
        /// Reference to the instance of the object that raised this event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds merely by raising the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.Started" />
        /// event, in turn.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected virtual void OnFileRenamerStarted(object sender, EventArgs e)
        {
            Started?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(MainWindowPresenterMessages.MWP_STARTED);
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
        [Log(AttributeExclude = true)]
        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(MainWindowPresenterMessages.MWP_FINISHED);
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.MainWindowPresenter.OperationError" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.ExceptionRaisedEventArgs" /> that contains
        /// the event data.
        /// </param>
        [Log(AttributeExclude = true)]
        protected virtual void OnOperationError(ExceptionRaisedEventArgs e)
        {
            OperationError?.Invoke(this, e);
            SendMessage<ExceptionRaisedEventArgs>.Having.Args(this, e)
                                                 .ForMessageId(
                                                     MainWindowPresenterMessages
                                                         .MWP_OPERATION_ERROR
                                                 );
        }

        /// <summary>
        /// Actually begins the rename process.
        /// </summary>
        private void CommenceRenameOperation()
            => Task.Run(
                () => _fileRenamer.ProcessAll(
                    StartingFolder, FindWhat, ReplaceWith
                ));

        /// <summary>
        /// Called when the count of files to be processed in a given operation
        /// is computed.
        /// </summary>
        /// <param name="count">
        /// (Required.) Integer value specifying the count of files that are to
        /// be processed in the current operation.
        /// </param>
        /// <remarks>
        /// Takes the message of resetting the progress dialog and reconfiguring
        /// the progress bar such that the <paramref name="count" /> parameter
        /// specifies the new maximum value of the progress bar.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <paramref name="count" /> parameter is zero or
        /// negative. This parameter describes a count of files; therefore, it
        /// is expected that it should be 1 or greater.
        /// </exception>
        private void HandleFilesCountedEvent(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            ResetProgressBar();

            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarMaximum = count
            );
        }

        /// <summary>
        /// Increments the value of the progress bar. Also updates the status
        /// text and the label that is displaying the pathname to the file that
        /// is currently being processed.
        /// </summary>
        /// <param name="statusLabelText">
        /// (Required.) String containing the text that is to be displayed on
        /// the top line of the progress dialog. This text serves to inform the
        /// user as to which operation is currently being performed.
        /// </param>
        /// efs
        /// <param name="currentFileLabelText">
        /// (Required.) String containing the pathname to the file that is
        /// currently being processed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="statusLabelText" />
        /// or <paramref name="currentFileLabelText" />,
        /// are passed blank or <see langword="null" /> string for values.
        /// </exception>
        private void IncrementProgressBar(string statusLabelText,
            string currentFileLabelText)
        {
            if (string.IsNullOrWhiteSpace(statusLabelText))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(statusLabelText)
                );
            if (string.IsNullOrWhiteSpace(currentFileLabelText))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(currentFileLabelText)
                );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = statusLabelText
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.CurrentFile =
                    currentFileLabelText
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarValue++
            );
        }

        /// <summary>
        /// Initializes the values of those dependencies which are not
        /// configurable by use of fluent-builder methods.
        /// </summary>
        private void InitializeComponents()

        {
            _exportConfigDialog = new SaveFileDialog
            {
                DefaultExt = "json",
                FileName = "config.json",
                Filter =
                    "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*",
                RestoreDirectory = true,
                Title = "Export Configuration"
            };
            _importConfigDialog = new OpenFileDialog
            {
                DefaultExt = "json",
                FileName = "config.json",
                Filter =
                    "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*",
                RestoreDirectory = true,
                Title = "Import Configuration"
            };
        }

        /// <summary>
        /// Sets the properties of the FileRenamer object that we are working
        /// with and subscribes to the events that it emits.
        /// </summary>
        private void InitializeFileRenamer()
        {
            // write the name of the current class and method we are now
            // Check to see if the required field, _fileRenamer, is null. If it
            if (_fileRenamer == null)
            {
                // the field _fileRenamer is required.
                // stop.
                return;
            }
            NewMessageMapping<ExceptionRaisedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_EXCEPTION_RAISED)
                .AndHandler(
                    new Action<object, ExceptionRaisedEventArgs>(
                        OnFileRenamerExceptionRaised
                    )
                );
            NewMessageMapping<OperationFinishedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_OPERATION_FINISHED)
                .AndHandler(
                    new Action<object, OperationFinishedEventArgs>(
                        OnFileRenamerOperationFinished
                    )
                );
            NewMessageMapping<OperationStartedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_OPERATION_STARTED)
                .AndHandler(
                    new Action<object, OperationStartedEventArgs>(
                        OnFileRenamerOperationStarted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_FILES_TO_BE_RENAMED_COUNTED
                )
                .AndHandler(
                    new Action<object, FilesOrFoldersCountedEventArgs>(
                        OnFileRenamerFilesToBeRenamedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED
                )
                .AndHandler(
                    new Action<object, FilesOrFoldersCountedEventArgs>(
                        OnFileRenamerFilesToHaveTextReplacedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED
                )
                .AndHandler(
                    new Action<object, FilesOrFoldersCountedEventArgs>(
                        OnFileRenamerSubfoldersToBeRenamedCounted
                    )
                );
            NewMessageMapping.Associate
                             .WithMessageId(FileRenamerMessages.FRM_STARTED)
                             .AndEventHandler(OnFileRenamerStarted);
            NewMessageMapping<StatusUpdateEventArgs>.Associate
                                                    .WithMessageId(
                                                        FileRenamerMessages
                                                            .FRM_STATUS_UPDATE
                                                    )
                                                    .AndHandler(
                                                        new Action<object,
                                                            StatusUpdateEventArgs>(
                                                            OnFileRenamerStatusUpdate
                                                        )
                                                    );
            NewMessageMapping<ProcessingOperationEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_PROCESSING_OPERATION)
                .AndHandler(
                    new Action<object, ProcessingOperationEventArgs>(
                        OnFileRenamerProcessingOperation
                    )
                );

            NewMessageMapping.Associate.WithMessageId(
                                 FileRenamerMessages.FRM_FINISHED
                             )
                             .AndHandler(new Action(OnFileRenamerFinished));
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
        private void OnCancellableProgressDialogRequestedCancel(object sender,
            EventArgs e)
            => _fileRenamer.RequestAbort();

        /// <summary>
        /// Handles the <see cref="E:MFR.IFileRenamer.ExceptionRaised" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to such an event by showing the user a message
        /// box, logging the error, and then aborting the operation.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerExceptionRaised(object sender,
            ExceptionRaisedEventArgs e)
        {
            _fileRenamer.RequestAbort();

            OnOperationError(new ExceptionRaisedEventArgs(e.Exception));
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.FilesToBeRenamedCounted" />
        /// event
        /// raised by the file renamer object when it's finished determining the
        /// set of file system entries upon which the current operation should act.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFilesToBeRenamedCounted(object sender,
            FilesOrFoldersCountedEventArgs e)
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.FilesToHaveTextReplacedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFilesToHaveTextReplacedCounted(object sender,
            FilesOrFoldersCountedEventArgs e)
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the <see cref="E:MFR.IFileRenamer.Finished" /> event
        /// raised by the File Renamer object. This event is raised when the
        /// rename operations are all completed.
        /// </summary>
        /// <remarks>
        /// This method responds merely by raising the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.Finished" />
        /// event in turn.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFinished()
            => OnFinished();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.OperationFinished" />
        /// event raised
        /// by the file renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.OperationFinishedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by telling the progress dialog to
        /// reset the progress bar back to the starting point.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerOperationFinished(object sender,
            OperationFinishedEventArgs e)
            => ResetProgressBar();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.OperationStarted" />
        /// event raised by
        /// the file-renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.OperationStartedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by telling the progress dialog to
        /// show the marquee progress bar for the operation type whose
        /// processing is now being started.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerOperationStarted(object sender,
            OperationStartedEventArgs e)
        {
            if (e.OperationType == OperationType.Unknown) return;

            ShowCalculatingProgressBar(
                GetOperationStartedDescription.For(e.OperationType)
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.ProcessingOperation" />
        /// event raised
        /// by the File Renamer object when it moves on to processing the next
        /// file system entry in its list.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.ProcessingOperationEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by first checking the values passed in the
        /// <see
        ///     cref="T:MFR.ProcessingOperationEventArgs" />
        /// for valid values.
        /// <para />
        /// If the checks fail, then this method does nothing.
        /// <para />
        /// Otherwise, the method responds by incrementing the progress dialog's
        /// progress bar to the next notch, and updating the text of the lower
        /// status label in the progress dialog to contain the path to the file
        /// currently being worked on.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerProcessingOperation(object sender,
            ProcessingOperationEventArgs e)
        {
            if (e.OperationType == OperationType.Unknown) return;
            if (e.Entry == null) return;
            if (string.IsNullOrWhiteSpace(e.Entry.Path)) return;

            IncrementProgressBar(
                GetOperationDescription.For(e.OperationType)
                                       .Text, e.Entry.Path
            );
        }

        private void OnFileRenamerStatusUpdate(object sender,
            StatusUpdateEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Text)) return;

            Console.WriteLine(e.Text);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.SubfoldersToBeRenamedCounted" />
        /// event raised by the File Renamer object when it has finished
        /// calculating how many subfolders are to be renamed.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerSubfoldersToBeRenamedCounted(object sender,
            FilesOrFoldersCountedEventArgs e)
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Sets the progress dialog and/or reinitializes it from prior use.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ReinitializeProgressDialog()
        {
            _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    if (_cancellableProgressDialog != null)
                    {
                        _cancellableProgressDialog.Close();
                        _cancellableProgressDialog.Dispose();
                    }

                    _cancellableProgressDialog = null;
                }
            );
            _cancellableProgressDialog.DoIfDisposed(
                () => _cancellableProgressDialog =
                    MakeNewProgressDialog.FromScratch()
            );
            _cancellableProgressDialog.CancelRequested +=
                OnCancellableProgressDialogRequestedCancel;
        }

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ResetProgressBar()
            => _cancellableProgressDialog.DoIfNotDisposed(
                _cancellableProgressDialog.Reset
            );

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
            // write the name of the current class and method we are now
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
