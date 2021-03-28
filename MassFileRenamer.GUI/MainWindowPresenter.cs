using MassFileRenamer.GUI.Properties;
using MassFileRenamer.Objects;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Presenter for the main application window.
    /// </summary>
    public class MainWindowPresenter : ConfigurationComposedObjectBase,
        IMainWindowPresenter
    {
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
        ///     cref="T:MassFileRenamer.Objects.IFileRenamer" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// THis object provides the core services that this application offers.
        /// </remarks>
        private IFileRenamer _fileRenamer;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IHistoryManager" />
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
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IMainWindow" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides the functionality of the main window of the application.
        /// </remarks>
        private IMainWindow _mainWindow;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IProgressDialog" />
        /// interface.
        /// </summary>
        private IProgressDialog _progressDialog;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.GUI.MainWindowPresenter" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="configurationPathname">
        /// (Required.) String containing the pathname of the configuration file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
        /// </exception>
        public MainWindowPresenter()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.MainWindowPresenter"
            );

            InitializeComponents();

            ReinitializeProgressDialog();
        }

        /// <summary>
        /// Gets the text to be searched for during the operations.
        /// </summary>
        private string FindWhat
        {
            get {
                var result = string.Empty;
                if (_mainWindow.FindWhatComboBox.InvokeRequired)
                    _mainWindow.FindWhatComboBox.Invoke(
                        (Action)(() =>
                        {
                            result = _mainWindow.FindWhatComboBox.EnteredText;
                        })
                    );
                else
                    result = _mainWindow.FindWhatComboBox.EnteredText;

                return result;
            }
        }

        /// <summary>
        /// Gets the replacement text to be used during the operations.
        /// </summary>
        private string ReplaceWith
        {
            get {
                var result = string.Empty;
                if (_mainWindow.ReplaceWithComboBox.InvokeRequired)
                    _mainWindow.ReplaceWithComboBox.Invoke(
                        (Action)(() =>
                        {
                            result = _mainWindow.ReplaceWithComboBox.EnteredText;
                        })
                    );
                else
                    result = _mainWindow.ReplaceWithComboBox.EnteredText;
                return result;
            }
        }

        /// <summary>
        /// Gets the path to the starting folder of the search.
        /// </summary>
        private string StartingFolder
        {
            get {
                var result = string.Empty;
                if (_mainWindow.StartingFolderComboBox.InvokeRequired)
                    _mainWindow.StartingFolderComboBox.Invoke(
                        (Action)(() =>
                        {
                            result = _mainWindow.StartingFolderComboBox.EnteredText;
                        })
                    );
                else
                    result = _mainWindow.StartingFolderComboBox.EnteredText;

                return result;
            }
        }

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
        /// Fluent-builder method for initializing the history manager
        /// dependency of this Presenter class. History Manager objects control
        /// the flow of values into and out of the list of previously-specified
        /// values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IHistoryManager" />
        /// on which this
        /// Presenter should depend.
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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.ClearAllHistory"
            );

            UpdateData();   // save data from the screen prior to doing the operation

            if (!_historyManager.ClearAll())
                return;         // clear operation canceled or not carried out

            UpdateData(false);

            OnAllHistoryCleared();

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindowPresenter.ClearAllHistory: Done."
            );
        }

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        public void CloseProgressDialog()
            => _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());

        /// <summary>
        /// Exports the current configuration data to a file on the user's hard drive.
        /// </summary>
        public void ExportConfiguration()
        {
            _exportConfigDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (_exportConfigDialog.ShowDialog(_mainWindow) != DialogResult.OK)
                return;

            ConfigurationProvider.Export(_exportConfigDialog.FileName);

            OnConfigurationExported(
                new ConfigurationExportedEventArgs(_exportConfigDialog.FileName)
            );
        }

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that is of the
        /// <typeparamref name="TView" /> type and which represents the form that
        /// is to be associated with this presenter.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="mainWindow" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IMainWindowPresenter HavingWindowReference(IMainWindow view)
        {
            _mainWindow = view ?? throw new ArgumentNullException(nameof(view));

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

            if (_importConfigDialog.ShowDialog(_mainWindow) != DialogResult.OK)
                return;

            ConfigurationProvider.Import(_importConfigDialog.FileName);

            UpdateConfiguration(ConfigurationProvider.Configuration);

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
            _mainWindow.OperationsCheckedListBox.CheckByName(
                "Rename Files", Configuration.RenameFiles
            );
            _mainWindow.OperationsCheckedListBox.CheckByName(
                "Rename Subfolders", Configuration.RenameSubfolders
            );
            _mainWindow.OperationsCheckedListBox.CheckByName(
                "Replace in Files", Configuration.ReplaceInFiles
            );
        }

        /// <summary>
        /// Begins the rename operation.
        /// </summary>
        public void Process()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.Process"
            );

            if (_mainWindow == null || _fileRenamer == null)
                return;

            // just in case, have the file renamer object update its
            // configuration to match that which we have access to
            _fileRenamer.UpdateConfiguration(Configuration);

            ReinitializeProgressDialog();

            ValidateInputs();

            CommenceRenameOperation();

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindowPresenter.Process: Done."
            );
        }

        /// <summary>
        /// Runs code that should execute when either the OK or Apply buttons
        /// are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialog">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MassFileRenamer.GUI.OptionsDialog" />.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dialog" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public void SaveConfigurationDataFrom(OptionsDialog dialog)
        {
            if (dialog == null) throw new ArgumentNullException(nameof(dialog));

            if (ConfigurationProvider.ConfigurationFilePath !=
                dialog.ConfigPathname)
                GetNewFileInfo.ForPath(
                                  ConfigurationProvider.ConfigurationFilePath
                              )
                              .RenameTo(dialog.ConfigPathname);

            ConfigurationProvider.ConfigurationFilePath = dialog.ConfigPathname;
            ConfigurationProvider.Configuration.ReOpenSolution =
                dialog.ShouldReOpenVisualStudioSolution;
            UpdateConfiguration(ConfigurationProvider.Configuration);
        }

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        public void ShowProgressDialog()
            => _progressDialog.DoIfNotDisposed(() => _progressDialog.Show());

        /// <summary>
        /// Updates the configuration currently being used with a new value.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface
        /// which has the new settings.
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
        /// equals <see langword="true" />) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating" /> equals <see langword="false" />).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <see langword="true" /> to move data from the screen to the model;
        /// <see langword="false" /> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        public void UpdateData(bool bSavingAndValidating = true)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.UpdateData"
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
                    "*** ERROR: The 'Configuration' property has a null reference. "
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: This property is required to be set to a valid object reference before we can proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "MainWindowPresenter.UpdateData: Done."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'Configuration' property has a valid object reference for its value."
            );

            // Dump the parameter bSavingAndValidating to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"MainWindowPresenter.UpdateData: bSavingAndValidating = {bSavingAndValidating}"
            );

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
                    _mainWindow.StartingFolderComboBox
                );

                Configuration.SaveCurrentFindWhatAndHistory(
                    _mainWindow.FindWhatComboBox
                );

                Configuration.SaveCurrentReplaceWithAndHistory(
                    _mainWindow.ReplaceWithComboBox
                );

                Configuration.IsFolded = _mainWindow.IsFolded;

                Configuration.MatchCase = _mainWindow.MatchCase;

                Configuration.MatchExactWord = _mainWindow.MatchExactWord;

                Configuration.SelectedOptionTab = _mainWindow.SelectedOptionTab;

                SaveOperationSelections();
            }
            else
            {
                InitializeOperationSelections();

                _mainWindow.SelectedOptionTab = ConfigurationProvider
                                                .Configuration
                                                .SelectedOptionTab;

                _mainWindow.MatchExactWord = Configuration.MatchExactWord;

                _mainWindow.MatchCase = Configuration.MatchCase;

                _mainWindow.IsFolded = Configuration.IsFolded;

                ComboBoxInitializer.InitializeComboBox(
                    _mainWindow.StartingFolderComboBox,
                    Configuration.StartingFolderHistory,
                    Configuration.StartingFolder
                );

                ComboBoxInitializer.InitializeComboBox(
                    _mainWindow.FindWhatComboBox, Configuration.FindWhatHistory,
                    Configuration.FindWhat
                );

                ComboBoxInitializer.InitializeComboBox(
                    _mainWindow.ReplaceWithComboBox,
                    Configuration.ReplaceWithHistory, Configuration.ReplaceWith
                );
            }

            OnDataOperationFinished();

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindowPresenter.UpdateData: Done."
            );
        }

        /// <summary>
        /// Fluent-builder method for composing a file-renamer object with this presenter.
        /// </summary>
        /// <param name="fileRenamer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileRenamer" /> interface.
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
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.WithFileRenamer"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Attempting to associate the File Renamer object with this Presenter..."
            );

            _fileRenamer = fileRenamer ??
                           throw new ArgumentNullException(nameof(fileRenamer));

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The File Renamer object has been attached."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Initializing the File Renamer object supplied..."
            );

            InitializeFileRenamer();

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The File Renamer object has been initialized."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindowPresenter.WithFileRenamer: Done."
            );

            return this;
        }

        /// <summary>
        /// Saves the selections made in the Operations to Perform checked list
        /// box into the <see cref="T:MassFileRenamer.Objects.Configuration" /> object.
        /// </summary>
        public void SaveOperationSelections()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In MainWindowPresenter.SaveOperationSelections"
            );

            Configuration.RenameFiles =
                _mainWindow.OperationsCheckedListBox.GetCheckedByName(
                    "Rename Files"
                );
            Configuration.RenameSubfolders =
                _mainWindow.OperationsCheckedListBox.GetCheckedByName(
                    "Rename Subfolders"
                );
            Configuration.ReplaceInFiles =
                _mainWindow.OperationsCheckedListBox.GetCheckedByName(
                    "Replace in Files"
                );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.SaveOperationSelections: Done."
            );
        }

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.GUI.IMainWindow" /> interface and
        /// which represents the main window of the application.
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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.MainWindowReference"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Attempting to associate the Main Window to its Presenter..."
            );

            _mainWindow = mainWindow ??
                          throw new ArgumentNullException(nameof(mainWindow));

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The Main Window has been attached to the Presenter."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.MainWindowReference: Done."
            );

            return this;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.AllHistoryCleared" />
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.ConfigurationExported" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ConfigurationExportedEventArgs" />
        /// that contains the event data.
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.ConfigurationImported" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ConfigurationImportedEventArgs" />
        /// that contains the event data.
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.DataOperationError" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.DataOperationErrorEventArgs" />
        /// that
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.DataOperationFinished" />
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.DataOperationStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.DataOperationEventArgs" />
        /// that
        /// contains the event data.
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
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.Started" />
        /// event raised
        /// by the File Renamer object. This event is raised when the rename
        /// operations are all completed.
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
        ///     cref="E:MassFileRenamer.GUI.IMainWindowPresenter.Started" />
        /// event,
        /// in turn.
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.Finished" />
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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.OperationError" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.ExceptionRaisedEventArgs" />
        /// that contains the event data.
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
                )
            );

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

            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarMaximum = count
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
                    "Value cannot be null or whitespace.",
                    nameof(statusLabelText)
                );
            if (string.IsNullOrWhiteSpace(currentFileLabelText))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(currentFileLabelText)
                );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.Status = statusLabelText
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.CurrentFile = currentFileLabelText
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarValue++
            );
        }

        /// <summary>
        /// Initializes the values of those dependencies which are not
        /// configurable by use of fluent-builder methods.
        /// </summary>
        private void InitializeComponents()

        {
            // exportConfigDialog
            _exportConfigDialog = new SaveFileDialog {
                DefaultExt = "json",
                FileName = "config.json",
                Filter =
                    "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*",
                RestoreDirectory = true,
                Title = "Export Configuration"
            };

            // importConfigDialog
            _importConfigDialog = new OpenFileDialog {
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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.InitializeFileRenamer"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _fileRenamer field has a null reference for a value..."
            );

            // Check to see if the required field, _fileRenamer, is null. If it
            // is, send an error to the log file and quit.
            if (_fileRenamer == null)
            {
                // the field _fileRenamer is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _fileRenamer field has a null reference.  This field is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MainWindowPresenter.InitializeFileRenamer: Done."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _fileRenamer field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Attempting to hook up events to the File Renamer..."
            );

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
                                                            StatusUpdateEventArgs
                                                        >(
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

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** File Renamer event handlers hooked up."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.InitializeFileRenamer: Done."
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.ExceptionRaised" />
        /// event.
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
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.FilesToBeRenamedCounted" />
        /// event raised by the file renamer object when it's finished
        /// determining the set of file system entries upon which the current
        /// operation should act.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
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
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.FilesToHaveTextReplacedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
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
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.Finished" />
        /// event
        /// raised by the File Renamer object. This event is raised when the
        /// rename operations are all completed.
        /// </summary>
        /// <remarks>
        /// This method responds merely by raising the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.IMainWindowPresenter.Finished" />
        /// event
        /// in turn.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFinished()
            => OnFinished();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.OperationFinished" />
        /// event raised by the file renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.OperationFinishedEventArgs" />
        /// that contains the event data.
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
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.OperationStarted" />
        /// event raised by the file-renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.OperationStartedEventArgs" />
        /// that contains the event data.
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
                                              .Text
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.ProcessingOperation" />
        /// event raised by the File Renamer object when it moves on to
        /// processing the next file system entry in its list.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by first checking the values passed in the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
        /// for
        /// valid values.
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
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.SubfoldersToBeRenamedCounted" />
        /// event raised by the File Renamer object when it has finished
        /// calculating how many subfolders are to be renamed.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
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
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.IProgressDialog.CancelRequested" />
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
        private void OnProgressDialogRequestedCancel(object sender, EventArgs e)
            => _fileRenamer.RequestAbort();

        /// <summary>
        /// Sets the progress dialog and/or reinitializes it from prior use.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ReinitializeProgressDialog()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In MainWindowPresenter.ReinitializeProgressDialog"
            );

            _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());
            _progressDialog.DoIfDisposed(
                () => _progressDialog = new ProgressDialog()
            );
            _progressDialog.CancelRequested += OnProgressDialogRequestedCancel;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The progress dialog has been reinitialized."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.ReinitializeProgressDialog: Done."
            );
        }

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ResetProgressBar()
            => _progressDialog.DoIfNotDisposed(_progressDialog.Reset);

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        [Log(AttributeExclude = true)]
        private void ShowCalculatingProgressBar(string text)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In MainWindowPresenter.ShowCalculatingProgressBar"
            );

            // Dump the parameter text to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"MainWindowPresenter.ShowCalculatingProgressBar: text = '{text}'"
            );

            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(text)
                );
            ResetProgressBar();

            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarStyle =
                    ProgressBarStyle.Marquee
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.Status = text
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.ShowCalculatingProgressBar: Done."
            );
        }

        /// <summary>
        /// Runs rules to ensure that the entries on the main window's form are
        /// valid. Throws a <see cref="T:System.Exception" /> if a validation
        /// rule fails.
        /// </summary>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the directory whose pathname is referenced by
        /// <see
        ///     cref="P:MassFileRenamer.GUI.MainWindowPresenter.StartingFolder" />
        /// is
        /// not found on the disk.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if either of the
        /// <see
        ///     cref="P:MassFileRenamer.GUI.MainWindowPresenter.FindWhat" />
        /// or
        /// <see
        ///     cref="P:MassFileRenamer.GUI.MainWindowPresenter.ReplaceWith" />
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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.ValidateInputs"
            );

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
            if (string.IsNullOrWhiteSpace(ReplaceWith))
                throw new InvalidOperationException(
                    Resources.Error_ReplaceWithBlank
                );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** All inputs have been successfully validated."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindowPresenter.ValidateInputs: Done."
            );
        }
    }
}