using MassFileRenamer.GUI.Properties;
using MassFileRenamer.Objects;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Presenter for the main application window.
    /// </summary>
    public class MainWindowPresenter : IMainWindowPresenter
    {
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
        private readonly IHistoryManager _historyManager;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IMainWindow" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides the functionality of the main window of the application.
        /// </remarks>
        private readonly IMainWindow _mainWindow;

        private readonly IFileRenamer _renamer;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ITextExpressionMatcher" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object's sole purpose in life is to define whether a source
        /// string matches a pattern based on settings specified by the
        /// configuration object.
        /// </remarks>
        private ITextExpressionMatcher _fileNameMatcher;

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
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.GUI.IMainWindow" /> interface.
        /// </param>
        /// <param name="renamer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileRenamer" /> interface.
        /// </param>
        /// <param name="configurationPathname">
        /// (Required.) String containing the pathname of the configuration file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required <paramref name="mainWindow" /> or
        /// <paramref name="renamer" /> parameters have a <c>null</c> value.
        /// </exception>
        public MainWindowPresenter(IMainWindow mainWindow, IFileRenamer renamer,
            string configurationPathname)
        {
            if (string.IsNullOrWhiteSpace(configurationPathname))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(configurationPathname)
                );

            _mainWindow = mainWindow ??
                          throw new ArgumentNullException(nameof(mainWindow));
            _renamer = renamer ??
                       throw new ArgumentNullException(nameof(renamer));

            ReinitializeProgressDialog();

            LoadConfiguration(configurationPathname);

            _historyManager = new HistoryManager(_mainWindow, Configuration);
        }

        /// <summary>
        /// String containing the pathname to the configuration file.
        /// </summary>
        private string ConfigurationPathname
        {
            get => ConfigurationProvider.ConfigurationFilePath;
            set => ConfigurationProvider.ConfigurationFilePath = value;
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
                            result = _mainWindow.FindWhatComboBox.Text;
                        })
                    );
                else
                    result = _mainWindow.FindWhatComboBox.Text;

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
                            result = _mainWindow.ReplaceWithComboBox.Text;
                        })
                    );
                else
                    result = _mainWindow.ReplaceWithComboBox.Text;
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
                            result = _mainWindow.StartingFolderComboBox.Text;
                        })
                    );
                else
                    result = _mainWindow.StartingFolderComboBox.Text;

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
        /// Gets or sets a reference to an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IConfiguration" />
        /// interface that
        /// contains the configuration details.
        /// </summary>
        public IConfiguration Configuration
        {
            get;
            private set;
        }

        /// <summary>
        /// Clears all the history lists in the configuration.
        /// </summary>
        public void ClearAllHistory()
        {
            _historyManager.ClearAll();

            UpdateData(false);

            OnAllHistoryCleared();
        }

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        public void CloseProgressDialog()
            => _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());

        /// <summary>
        /// Exports the configuration to a file on the disk.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file to be written.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="pathname" />, is
        /// passed a blank or <c>null</c> value.
        /// </exception>
        public void ExportConfiguration(string pathname)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.ExportConfiguration"
            );

            // Dump the variable pathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"MainWindowPresenter.ExportConfiguration: pathname = '{pathname}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the 'pathname' parameter is blank.."
            );

            if (string.IsNullOrWhiteSpace(pathname))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pathname)
                );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'pathname' parameter is not blank."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Saving the current configuration to the default location.."
                );

                SaveConfiguration();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The configuration has been saved."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Exporting the configuration to the path '{pathname}'.."
                );

                if (File.Exists(pathname))
                    File.Delete(pathname);

                new FileInfo(ConfigurationPathname).CopyTo(pathname);

                if (File.Exists(pathname))
                    OnConfigurationExported(
                        new ConfigurationExportedEventArgs(pathname)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** Configuration has been exported successfully."
                );
            }
            catch (Exception ex)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR *** Failed to export the configuration."
                );

                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.ExportConfiguration: Done."
            );
        }

        /// <summary>
        /// Imports configuration from a JSON file located on the disk.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the path to the file.
        /// </param>
        /// <remarks>
        /// This method does nothing if the <paramref name="pathname" />
        /// parameter is blank or the file does not exist.
        /// </remarks>
        public void ImportConfiguration(string pathname)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MainWindowPresenter.ImportConfiguration"
            );

            // Dump the variable pathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"MainWindowPresenter.ImportConfiguration: pathname = '{pathname}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the 'pathname' parameter is blank.."
            );

            if (string.IsNullOrWhiteSpace(pathname))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "MainWindowPresenter.ImportConfiguration: Blank value passed for pathname parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MainWindowPresenter.ImportConfiguration: Done."
                );

                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'pathname' parameter is not blank."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the file referenced by the 'pathname' parameter exists.."
            );

            if (!File.Exists(pathname))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"MainWindowPresenter.ImportConfiguration: The file with path '{pathname}' does not exist.  We have nothing to do."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MainWindowPresenter.ImportConfiguration: Done."
                );

                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{pathname}' has been found."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{pathname}' is in JSON format.."
            );

            if (!".json".Equals(Path.GetExtension(pathname)))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"MainWindowPresenter.ImportConfiguration: The file with path '{pathname}' must be in the JavaScript Over Network (JSON) format."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MainWindowPresenter.ImportConfiguration: Done."
                );

                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{pathname}' appears to be in the correct format."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Removing the existing configuration file.."
                );

                if (File.Exists(ConfigurationPathname))
                    File.Delete(ConfigurationPathname);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Copying the file with path '{pathname}' to the path '{ConfigurationPathname}'.."
                );

                new FileInfo(pathname).CopyTo(ConfigurationPathname);

                if (File.Exists(ConfigurationPathname))
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** SUCCESS *** The file with path '{pathname}' has been copied to the destination successfully."
                    );
                else
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"MainWindowPresenter.ImportConfiguration: Failed to copy the file with path '{pathname}' to the path '{ConfigurationPathname}'."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** INFO: Saving the current configuration to disk.."
                    );

                    SaveConfiguration(); // restore the configuration file on the disk.

                    DebugUtils.WriteLine(
                        DebugLevel.Info, "*** SUCCESS *** Configuration saved."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "MainWindowPresenter.ImportConfiguration: Done."
                    );

                    return;
                }

                LoadConfiguration(ConfigurationPathname);

                OnConfigurationImported(
                    new ConfigurationImportedEventArgs(pathname)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "MainWindowPresenter.ImportConfiguration: Done."
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
            if (_mainWindow == null || _renamer == null)
                return;

            ReinitializeProgressDialog();

            ValidateInputs();

            CommenceRenameOperation();
        }

        /// <summary>
        /// Saves the configuration to disk.
        /// </summary>
        public void SaveConfiguration()
        {
            OnDataOperationStarted(
                new DataOperationEventArgs("Saving configuration...")
            );

            ConfigurationSerializer.Save(ConfigurationPathname, Configuration);

            OnDataOperationFinished();
        }

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        public void ShowProgressDialog()
            => _progressDialog.DoIfNotDisposed(() => _progressDialog.Show());

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <c>true</c>) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating" /> equals <c>false</c>).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <c>true</c> to move data from the screen to the model;
        /// <c>false</c> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        public void UpdateData(bool bSavingAndValidating = true)
        {
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

                Configuration.MatchWholeWord = _mainWindow.MatchWholeWord;

                Configuration.SelectedOptionTab = _mainWindow.SelectedOptionTab;

                SaveOperationSelections();
            }
            else
            {
                InitializeOperationSelections();

                _mainWindow.SelectedOptionTab = Configuration.SelectedOptionTab;

                _mainWindow.MatchWholeWord = Configuration.MatchWholeWord;

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
        }

        /// <summary>
        /// Saves the selections made in the Operations to Perform checked list
        /// box into the <see cref="T:MassFileRenamer.Objects.Configuration" /> object.
        /// </summary>
        public void SaveOperationSelections()
        {
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
            => AllHistoryCleared?.Invoke(this, EventArgs.Empty);

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
            => ConfigurationExported?.Invoke(this, e);

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
            => ConfigurationImported?.Invoke(this, e);

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
            => DataOperationFinished?.Invoke(this, EventArgs.Empty);

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
            => DataOperationStarted?.Invoke(this, e);

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
        protected virtual void OnFinished()
            => Finished?.Invoke(this, EventArgs.Empty);

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
        protected virtual void OnOperationError(ExceptionRaisedEventArgs e)
            => OperationError?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.Started" />
        /// event.
        /// </summary>
        /// <remarks>
        /// This event lets client objects know that the presenter is about to
        /// start an operation. Ideally, the client of this presenter object is
        /// the main application window. The main application window is supposed
        /// to respond to this event by disabling user input to itself and then
        /// displaying the progress dialog to inform the user of the status of
        /// the operation.
        /// </remarks>
        protected virtual void OnStarted()
            => Started?.Invoke(this, EventArgs.Empty);

        private static string GetOperationDescriptionFor(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
            case OperationType.RenameFilesInFolder:
                result = "Renaming files..";
                break;

            case OperationType.ReplaceTextInFiles:
                result = "Replacing text in files..";
                break;

            case OperationType.RenameSubFolders:
                result = "Renaming subfolders..";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return result;
        }

        private static string GetOperationStartedText(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
            case OperationType.CloseActiveSolution:
                result =
                    "Closing solution containing the item(s) to be processed...";
                break;

            case OperationType.FindVisualStudio:
                result = "Determining whether Visual Studio is open...";
                break;

            case OperationType.GettingListOfFilesToBeRenamed:
                result = "Getting list of files to be renamed...";
                break;

            case OperationType.OpenActiveSolution:
                result =
                    "Reloading the solution containing the item(s) that were processed...";
                break;

            case OperationType.RenameFilesInFolder:
                result = "Calculating files to be renamed..";
                break;

            case OperationType.ReplaceTextInFiles:
                result = "Calculating files in which to replace text..";
                break;

            case OperationType.RenameSubFolders:
                result = "Calculating folders to be renamed..";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return result;
        }

        /// <summary>
        /// Actually begins the rename process.
        /// </summary>
        private void CommenceRenameOperation()
            => Task.Run(
                () => _renamer.ProcessAll(StartingFolder, FindWhat, ReplaceWith)
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
        /// Takes the action of resetting the progress dialog and reconfiguring
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
        /// are passed blank or <c>null</c> string for values.
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
        /// Sets the
        /// <see
        ///     cref="F:MassFileRenamer.GUI.MainWindowPresenter._fileNameMatcher" />
        /// field to have a reference to a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcher" />
        /// that has the
        /// <see
        ///     cref="P:MassFileRenamer.GUI.MainWindowPresenter.Configuration" />
        /// property's value composed with it.
        /// </summary>
        private void InitializeTextExpressionMatcher()
            => _fileNameMatcher = new TextExpressionMatcher(Configuration);

        /// <summary>
        /// Sets the properties of the FileRenamer object that we are working
        /// with and subscribes to the events that it emits.
        /// </summary>
        private void InitializeFileRenamer()
        {
            if (_renamer == null) return;

            _renamer.ExceptionRaised += OnExceptionRaised;
            _renamer.OperationFinished += (sender, eventArgs)
                => ResetProgressBar();
            _renamer.OperationStarted += (sender, eventArgs)
                => ShowCalculatingProgressBar(
                    GetOperationStartedText(eventArgs.OperationType)
                );
            _renamer.FilesToBeRenamedCounted += (sender, eventArgs)
                => HandleFilesCountedEvent(eventArgs.Count);
            _renamer.FilesToHaveTextReplacedCounted += (sender, eventArgs)
                => HandleFilesCountedEvent(eventArgs.Count);
            _renamer.SubfoldersToBeRenamedCounted += (sender, eventArgs)
                => HandleFilesCountedEvent(eventArgs.Count);
            _renamer.Started += (x, y) => OnStarted();
            _renamer.StatusUpdate += (sender, eventArgs)
                => Console.WriteLine(eventArgs.Text);
            _renamer.ProcessingOperation += (sender, eventArgs)
                => IncrementProgressBar(
                    GetOperationDescriptionFor(eventArgs.OperationType),
                    eventArgs.Pathname
                );
            _renamer.Finished += (x, y) => OnFinished();
            _renamer.TestExpressionMatchRequested += OnRenamerTestExpressionMatchRequested;
        }

        /// <summary>
        /// Loads the configuration.
        /// </summary>
        /// <param name="configurationPathname">
        /// (Required.) String containing the pathname of the configuration file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
        /// </exception>
        private void LoadConfiguration(string configurationPathname)
        {
            if (string.IsNullOrWhiteSpace(configurationPathname))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(configurationPathname)
                );

            OnDataOperationStarted(
                new DataOperationEventArgs("Loading configuration...")
            );

            // Since loading the configuration may take awhile, given that it
            // potentially may come from either a large JSON file or slow
            // database connection show the progress dialog in a marquee mode.

            ConfigurationPathname = configurationPathname;

            ConfigurationPathname = SystemPreparer.CreateConfigFile(
                Path.GetDirectoryName(ConfigurationPathname),
                Path.GetFileName(ConfigurationPathname)
            );

            Configuration = ConfigurationSerializer.Load(ConfigurationPathname);

            InitializeTextExpressionMatcher();

            InitializeFileRenamer();

            OnDataOperationFinished();
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
        private void OnExceptionRaised(object sender,
            ExceptionRaisedEventArgs e)
        {
            MessageBox.Show(
                _mainWindow, $"A problem has occurred.\n{e.Exception.Message}",
                Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
            );
            OnOperationError(new ExceptionRaisedEventArgs(e.Exception));
            _renamer.RequestAbort();
        }

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
        /// Cancel button on the progress dialog. The action taken by this
        /// method is to tell the File Renamer Object to attempt to abort.
        /// </remarks>
        private void OnProgressDialogRequestedCancel(object sender, EventArgs e)
            => _renamer.RequestAbort();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.IFileRenamer.TestExpressionMatchRequested" />
        /// event raised by the file renamer object to request that we find a
        /// match to a file name according to settings specified by the user in
        /// the configuration.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by calling on the object, a reference to which
        /// is stored in the
        /// <see
        ///     cref="F:MassFileRenamer.GUI.MainWindowPresenter._fileNameMatcher" />
        /// field, to determine if a match(es) exist between the text pattern in
        /// the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs.FindWhat" />
        /// property and the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs.Path" />
        /// property, according to settings specified by the user in the
        /// configuration. The result of the matching operation is stored in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs.DoesMatch" />
        /// property, which is then read by the object that raised this event.
        /// </remarks>
        private void OnRenamerTestExpressionMatchRequested(object sender,
            TestExpressionMatchRequestedEventArgs e)
        {
            if (_fileNameMatcher == null)
                return;

            if (Configuration == null)
                return;

            e.DoesMatch = _fileNameMatcher.IsMatch(
                Configuration.MatchWholeWord
                    ? Path.GetFileNameWithoutExtension(e.Path)
                    : Path.GetFileName(e.Path), e.FindWhat
            );
        }

        /// <summary>
        /// Sets the progress dialog and/or reinitializes it from prior use.
        /// </summary>
        private void ReinitializeProgressDialog()
        {
            _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());
            _progressDialog.DoIfDisposed(
                () => _progressDialog = new ProgressDialog()
            );
            _progressDialog.CancelRequested += OnProgressDialogRequestedCancel;
        }

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
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
        /// a blank or <c>null</c> string for a value.
        /// </exception>
        private void ShowCalculatingProgressBar(string text)
        {
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
        }
    }
}