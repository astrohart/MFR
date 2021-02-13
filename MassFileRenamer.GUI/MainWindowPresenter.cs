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
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if a file with pathname specified by the
        /// <paramref
        ///     name="configurationPathname" />
        /// parameter cannot be found.
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
            if (!File.Exists(configurationPathname))
                throw new FileNotFoundException(
                    $"Could not locate the configuration file at '{configurationPathname}'."
                );

            _mainWindow = mainWindow ??
                          throw new ArgumentNullException(nameof(mainWindow));
            _renamer = renamer ??
                       throw new ArgumentNullException(nameof(renamer));

            InitializeFileRenamer();

            ReinitializeProgressDialog();

            LoadConfiguration(configurationPathname);
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
        /// Occurs when the configuration has been exported to a file.
        /// </summary>
        public event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        /// Occurs when the configuration has been updated, say, by an import process.
        /// </summary>
        public event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the processing is done.
        /// </summary>
        public event EventHandler Finished;

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
                "*** INFO: Checking whether the 'pathname' parameter is blank..."
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
                    "*** INFO: Saving the current configuration to the default location..."
                );

                SaveConfiguration();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The configuration has been saved."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Exporting the configuration to the path '{pathname}'..."
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
                    $"*** ERROR *** Failed to export the configuration."
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
                "*** INFO: Checking whether the 'pathname' parameter is blank..."
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
                "*** INFO: Checking whether the file referenced by the 'pathname' parameter exists..."
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
                $"*** INFO: Checking whether the file with path '{pathname}' is in JSON format..."
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
                    "*** INFO: Removing the existing configuration file..."
                );

                if (File.Exists(ConfigurationPathname))
                    File.Delete(ConfigurationPathname);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Copying the file with path '{pathname}' to the path '{ConfigurationPathname}'..."
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
                        "*** INFO: Saving the current configuration to disk..."
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
            => ConfigurationSerializer.Save(
                ConfigurationPathname, Configuration
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        public void ShowProgressDialog()
            => _progressDialog.DoIfNotDisposed(() => _progressDialog.Show());

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
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.Finished" />
        /// event.
        /// </summary>
        protected virtual void OnFinished()
            => Finished?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.MainWindowPresenter.Started" />
        /// event.
        /// </summary>
        protected virtual void OnStarted()
            => Started?.Invoke(this, EventArgs.Empty);

        private static string GetOperationDescriptionFor(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
            case OperationType.RenameFilesInFolder:
                result = "Renaming files...";
                break;

            case OperationType.ReplaceTextInFiles:
                result = "Replacing text in files...";
                break;

            case OperationType.RenameSubFolders:
                result = "Renaming subfolders...";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return result;
        }

        private void CommenceRenameOperation()
            => Task.Run(
                () => _renamer.ProcessAll(StartingFolder, FindWhat, ReplaceWith)
            );

        private string GetOperationStartedText(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
            case OperationType.RenameFilesInFolder:
                result = "Calculating files to be renamed...";
                break;

            case OperationType.ReplaceTextInFiles:
                result = "Calculating files in which to replace text...";
                break;

            case OperationType.RenameSubFolders:
                result = "Calculating folders to be renamed...";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return result;
        }

        private void HandleFilesCountedEvent(int count)
        {
            ResetProgressBar();

            if (count <= 0)
                return;

            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarMaximum = count
            );
        }

        private void IncrementProgressBar(string operationDescription,
            string pathname)
        {
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.Status = operationDescription
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.DetailedStatus = pathname
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarValue++
            );
        }

        /// <summary>
        /// Sets the properties of the FileRenamer object that we are working
        /// with and subscribes to the events that it emits.
        /// </summary>
        private void InitializeFileRenamer()
        {
            if (_renamer == null) return;

            _renamer.OperationFinished += (sender, eventArgs)
                => ResetProgressBar();
            _renamer.OperationStarted += (sender, eventArgs)
                => ShowCalculatingProgressBar(eventArgs.OperationType);
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
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if a file with pathname specified by the
        /// <paramref
        ///     name="configurationPathname" />
        /// parameter cannot be found.
        /// </exception>
        private void LoadConfiguration(string configurationPathname)
        {
            if (string.IsNullOrWhiteSpace(configurationPathname))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(configurationPathname)
                );
            if (!File.Exists(configurationPathname))
                throw new FileNotFoundException(
                    $"Could not locate the configuration file at '{configurationPathname}'."
                );

            ConfigurationPathname = configurationPathname;

            ConfigurationPathname = SystemPreparer.CreateConfigFile(
                Path.GetDirectoryName(ConfigurationPathname),
                Path.GetFileName(ConfigurationPathname)
            );

            Configuration = ConfigurationSerializer.Load(ConfigurationPathname);
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
        }

        private void ResetProgressBar()
        {
            _progressDialog.DoIfNotDisposed(() => _progressDialog.Reset());
        }

        private void ShowCalculatingProgressBar(OperationType type)
        {
            ResetProgressBar();

            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.ProgressBarStyle =
                    ProgressBarStyle.Marquee
            );
            _progressDialog.DoIfNotDisposed(
                () => _progressDialog.Status = GetOperationStartedText(type)
            );
        }

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