using MFR.GUI.Constants;
using MFR.GUI.Controls;
using MFR.GUI.Controls.Helpers;
using MFR.GUI.Controls.Interfaces;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Interfaces;
using MFR.GUI.Windows.Properties;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MFR.GUI.Windows
{
    /// <summary>
    /// Displays the main window of the application.
    /// </summary>
    public partial class MainWindow : Form, IMainWindow
    {
        /// <summary>
        /// Reference to the presenter for this form.
        /// </summary>
        private IMainWindowPresenter _presenter;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MainWindow() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Windows.MainWindow" />
        /// and returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MainWindow()
        {
            InitializeComponent();

            InitializePresenter();

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Windows.MainWindow" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MainWindow Instance
        {
            get;
        } = new MainWindow();

        /// <summary>
        /// Gets a value indicating whether the data entered on this form is valid.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool IsDataValid
            => !string.IsNullOrWhiteSpace(StartingFolderComboBox.EnteredText) &&
               Directory.Exists(StartingFolderComboBox.EnteredText) &&
               !string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText) &&
               !string.IsNullOrWhiteSpace(ReplaceWithComboBox.EnteredText);

        /// <summary>
        /// Gets a value that indicates whether the history is free of all
        /// previous entries.
        /// </summary>
        private bool IsHistoryClear
            => StartingFolderComboBox.IsClear() && FindWhatComboBox.IsClear() &&
               ReplaceWithComboBox.IsClear();

        [Log(AttributeExclude = true)] // do not log this method
        private bool OnlyReplaceInFilesOperationIsEnabled
            => OperationsCheckedListBox.CheckedItems.Count == 1 &&
               OperationsCheckedListBox.GetItemChecked(2);

        /// <summary>
        /// Gets a reference to the text box control that allows the user to
        /// specify the text to be found.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public IEntryRespectingComboBox FindWhatComboBox
        {
            [DebuggerStepThrough] get => findWhatcomboBox;
        }

        /// <summary>
        /// Gets a reference to the
        /// <see
        ///     cref="T:MFR.Objects.FoldUnfoldButton" />
        /// that controls
        /// whether the form is the folded (smaller) size or unfolded (larger,
        /// with more options visible) size.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public FoldUnfoldButton FoldButton
        {
            [DebuggerStepThrough] get => foldButton;
        }

        /// <summary>
        /// Gets the full name of this application, including the current version.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public string FullApplicationName
            => $"{ProgramText.MainWindowTitle} {Version}";

        /// <summary>
        /// Gets or sets a value specifying whether the form is in the Folded state.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool IsFolded
        {
            get => FoldButton.IsFolded;
            set => FoldButton.IsFolded = value;
        }

        /// <summary>
        /// Gets or sets the value of the Match Case checkbox.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool MatchCase
        {
            get => matchCaseCheckBox.Checked;
            set => matchCaseCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the value of the Match Exact Word checkbox.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool MatchExactWord
        {
            get => matchExactWordCheckBox.Checked;
            set => matchExactWordCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets a reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.CheckedListBox" />
        /// that has the list of operations.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public CheckedListBox OperationsCheckedListBox
        {
            [DebuggerStepThrough] get => operationsCheckedListBox;
        }

        /// <summary>
        /// Gets a reference to the text box control that allows the user to
        /// specify the text to replace found text with.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public IEntryRespectingComboBox ReplaceWithComboBox
        {
            [DebuggerStepThrough] get => replaceWithComboBox;
        }

        /// <summary>
        /// Gets or sets the value of the Select/Deselect All checkbox
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool SelectAll
        {
            get => selectDeselectAllCheckBox.Checked;
            set => selectDeselectAllCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the index of the tab that is selected in the Options
        /// tab control.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public int SelectedOptionTab
        {
            [DebuggerStepThrough] get => optionsTabControl.SelectedIndex;
            set => optionsTabControl.SelectedIndex = value;
        }

        /// <summary>
        /// Gets a reference to the control that allows the user to specify the
        /// path to the starting folder.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public IEntryRespectingComboBox StartingFolderComboBox
        {
            [DebuggerStepThrough] get => startingFolderComboBox;
        }

        /// <summary>
        /// Gets a string containing this application's version.
        /// </summary>
        /// <remarks>
        /// Thanks to
        /// <a
        ///     href="
        /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/d9a69018-4840-4aeb-b9f1-4d98ab35f782/applicationproductversion?forum=csharpgeneral
        /// ">
        /// Kiran
        /// Suthar
        /// </a>
        /// 's answer on the Microsoft forums.
        /// </remarks>
        [Log(AttributeExclude = true)] // do not log this method
        public string Version
        {
            get;
        } = Assembly.GetExecutingAssembly()
                    .GetName()
                    .Version.ToString();

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            _presenter.UpdateData();

            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = FullApplicationName;

            _presenter.UpdateData(false);

            UpdateSize(
                IsFolded
                    ? FoldButton.FormFoldedSize
                    : FoldButton.FormUnfoldedSize
            );

            FoldButton.SetFoldedStateText();

            MakeButtonTransparent(switchButton);
        }

        private static bool DoesDirectoryContainSolutionFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            if (!path.IsAbsolutePath()) return false;
            if (!Directory.Exists(path)) return false;

            return Directory.EnumerateFiles(
                                path, "*.sln", SearchOption.TopDirectoryOnly
                            )
                            .Any();
        }

        /// <summary>
        /// Sets up the presenter object and attaches handlers to events that it exposes.
        /// </summary>
        /// <param name="configurationPathname">
        /// (Required.) String containing the pathname of the configuration file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
        /// </exception>
        private void InitializePresenter()
        {
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Attempting to obtain new Presenter object..."
            );

            _presenter = AssociatePresenter<IMainWindowPresenter>.WithView()
                .HavingWindowReference(this)
                .WithFileRenamer(
                    MakeNewFileRenamer.FromScratch()
                                      .StartingFrom(
                                          ConfigurationProvider.Configuration
                                              .StartingFolder
                                      )
                                      .AndAttachConfiguration(
                                          ConfigurationProvider.Configuration
                                      )
                )
                .AndHistoryManager(
                    MakeHistoryManager.ForForm(this)
                                      .AndAttachConfiguration(
                                          ConfigurationProvider.Configuration
                                      )
                )
                .AndAttachConfiguration(ConfigurationProvider.Configuration);

            _presenter.UpdateData(false);

            if (_presenter == null)
                throw new InvalidOperationException(
                    "Failed to initialize the main application window."
                );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** Obtained a reference to the Presenter.  Attaching event handlers..."
            );

            NewMessageMapping.Associate.WithMessageId(
                                 MainWindowPresenterMessages
                                     .MWP_ALL_HISTORY_CLEARED
                             )
                             .AndEventHandler(OnPresenterAllHistoryCleared);
            NewMessageMapping<ConfigurationExportedEventArgs>.Associate
                .WithMessageId(
                    MainWindowPresenterMessages.MWP_CONFIGURATION_EXPORTED
                )
                .AndEventHandler(OnPresenterConfigurationExported);
            NewMessageMapping<ConfigurationImportedEventArgs>.Associate
                .WithMessageId(
                    MainWindowPresenterMessages.MWP_CONFIGURATION_IMPORTED
                )
                .AndEventHandler(OnPresenterConfigurationImported);
            NewMessageMapping.Associate.WithMessageId(
                                 MainWindowPresenterMessages
                                     .MWP_DATA_OPERATION_FINISHED
                             )
                             .AndEventHandler(OnPresenterDataOperationFinished);
            NewMessageMapping<DataOperationEventArgs>.Associate.WithMessageId(
                    MainWindowPresenterMessages.MWP_DATA_OPERATION_STARTED
                )
                .AndEventHandler(OnPresenterDataOperationStarted);
            NewMessageMapping<ExceptionRaisedEventArgs>.Associate.WithMessageId(
                    MainWindowPresenterMessages.MWP_OPERATION_ERROR
                )
                .AndEventHandler(OnPresenterOperationError);
            NewMessageMapping
                .Associate
                .WithMessageId(MainWindowPresenterMessages.MWP_FINISHED)
                .AndEventHandler(OnPresenterFinished);
            NewMessageMapping.Associate.WithMessageId(
                                 MainWindowPresenterMessages.MWP_STARTED
                             )
                             .AndEventHandler(OnPresenterStarted);

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MainWindow.InitializePresenter: Done."
            );
        }

        // Give the button a transparent background.
        private void MakeButtonTransparent(Button btn)
        {
            var bm = (Bitmap)btn.Image;
            bm.MakeTransparent(bm.GetPixel(0, 0));
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.CheckBox.CheckedChanged" />
        /// event for
        /// the Select/Deselect All check box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by toggling the Checked states of
        /// all the boxes in the Operations To Perform checked list box.
        /// </remarks>
        private void OnCheckedChangedSelectDeselectAllCheckBox(object sender,
            EventArgs e)
            => operationsCheckedListBox.CheckAll(SelectAll);

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// for the Browse ("...") button.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// <para>
        /// When the user clicks the "..." button, we want to show them a dialog
        /// box to select a folder.
        /// </para>
        /// <para>
        /// The contents of the Starting Folder text box will then be
        /// initialized to hold the pathname to the folder that the user selects.
        /// </para>
        /// </remarks>
        private void OnClickBrowseForStartingFolder(object sender, EventArgs e)
        {
            using (var fsd = new FolderSelectDialog())
            {
                fsd.InitialDirectory = StartingFolderComboBox.EnteredText;
                fsd.Title = "Browse";
                if (!fsd.ShowDialog(Handle))
                    return;

                /*
                 * OKAY, the folder selected by the user must be a folder that contains
                 * a Visual Studio Solution (*.sln) file.
                 */

                if (!DoesDirectoryContainSolutionFile(fsd.FileName))
                {
                    MessageBox.Show(
                        this,
                        "Please select a directory that contains a Visual Studio Solution (*.sln) file.",
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                    );
                    return;
                }

                StartingFolderComboBox.EnteredText = fsd.FileName;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// for the Perform Operation button.
        /// </summary>
        /// <param name="sender">
        /// The sender of this event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This handler starts the processing of renaming folders and files
        /// when the Perform Operation button is clicked.
        /// </remarks>
        private void OnClickPerformOperation(object sender, EventArgs e)
        {
            _presenter.UpdateData();

            if (!ValidateData()) return;

            //MessageBox.Show(
            //    this,
            //    "For debugging purposes, the operation(s) selected have been canceled.",
            //    Application.ProductName, MessageBoxButtons.OK,
            //    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
            //);
            //return;

            UseWaitCursor = true;
            Enabled = false;

            ConfigurationProvider.Save(); // save the configuration to disk

            try
            {
                _presenter.Process();
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;

                MessageBox.Show(
                    this, ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1
                );

                Enabled = true;
                UseWaitCursor = false;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// raised by the Switch button.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by switching the contents of the Find What and
        /// Replace With combo boxes.
        /// </remarks>
        private void OnClickSwitchButton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText) &&
                string.IsNullOrWhiteSpace(ReplaceWithComboBox.Text))
                return; // nothing to do

            var replaceWith = ReplaceWithComboBox.EnteredText;
            ReplaceWithComboBox.EnteredText = FindWhatComboBox.EnteredText;
            FindWhatComboBox.EnteredText = replaceWith;
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the File -&gt; Exit menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to handle the message of the user clicking the
        /// Exit command on the File menu. This method saves the configuration
        /// and then closes this window. Since this window is the main window of
        /// the application, closing this window ends the lifecycle of the application.
        /// </remarks>
        private void OnFileExit(object sender, EventArgs e)
        {
            // Save the configuration one last time
            ConfigurationProvider.Save();

            Close();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Objects.FoldUnfoldButton.FormFolded" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Objects.FormFoldedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// </remarks>
        private void OnFormFolded(object sender, FormFoldedEventArgs e)
        {
            UpdateSize(e.Size);

            FoldButton.SetFoldedStateText();

            ConfigurationProvider.Configuration.IsFolded = e.Folded;
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the user clicking on the About command on the Help menu.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by displaying the About dialog box.
        /// </remarks>
        private void OnHelpAbout(object sender, EventArgs e)
            => AboutDialog.Display(this);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpening" />
        /// event raised by the message of the user clicking on the Help menu to
        /// open it.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by ensuring that the text of the
        /// Help menu's About command contains the full name of this application.
        /// </remarks>
        private void OnHelpMenuDropDownOpening(object sender, EventArgs e)
        {
            if (!helpAbout.Text.Contains("[App Title]")) // already set
                return;

            helpAbout.Text = $"&About {FullApplicationName}";
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event on the Operations -&gt; Perform menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called in order to respond when the user clicks the
        /// Perform command on the Operations menu. The handling of this event
        /// is delegated to the Perform Operation button.
        /// </remarks>
        private void OnOperationsPerform(object sender, EventArgs e)
            => performOperationButton.PerformClick();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.OptionsDialog.Modified" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the Apply button being clicked in the
        /// property sheet displayed by the Tools -&gt; Options menu command.
        /// </remarks>
        private void OnOptionsModified(object sender, ModifiedEventArgs e)
        {
            // Get a reference to the dialog box by casting the sender parameter
            var dialog = (OptionsDialog)sender;
            if (dialog == null) return;

            _presenter.SaveConfigurationDataFrom(dialog);

            e.Handled =
                true; // instruct the Options dialog box to re-gray out the Apply button
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.AllHistoryCleared" />
        /// event raised by the presenter object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by clearing out all the text in
        /// the combo boxes on this form.
        /// </remarks>
        private void OnPresenterAllHistoryCleared(object sender, EventArgs e)
        {
            StartingFolderComboBox.Clear();
            FindWhatComboBox.Clear();
            ReplaceWithComboBox.Clear();

            StartingFolderComboBox.Focus();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.ConfigurationExported" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An
        /// <see
        ///     cref="T:MFR.Objects.ConfigurationExportedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when an export of the configuration has been
        /// successfully completed. This method responds to the event by
        /// informing the user that the operation has completed successfully.
        /// </remarks>
        private void OnPresenterConfigurationExported(object sender,
            ConfigurationExportedEventArgs e)
            => MessageBox.Show(
                this,
                $"Successfully exported the configuration to the file with path '{e.Path}'.",
                Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.ConfigurationImported" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by triggering an update of the
        /// screen from values stored in the configuration object in the
        /// <see
        ///     cref="P:MFR.GUI.MainWindowPresenter.Configuration" />
        /// property. This happens most often as a the result of the Import
        /// Configuration command on the Tools menu.
        /// </remarks>
        private void OnPresenterConfigurationImported(object sender,
            ConfigurationImportedEventArgs e)
        {
            _presenter.UpdateData(false);

            MessageBox.Show(
                this,
                $"Successfully imported the configuration from the file with path '{e.Path}'.",
                Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.DataOperationFinished" />
        /// event raised by the presenter object when a data operation is
        /// finished.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance
        /// of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by removing the
        /// progress bar from the status bar and setting the text of its message
        /// label back to the idle text. We use the Invoke If Required
        /// methodology just in case it's not the GUI thread that raised the
        /// event.
        /// <para />
        /// If the status bar is not presently visible, then
        /// this method does nothing.
        /// </remarks
        private void OnPresenterDataOperationFinished(object sender,
            EventArgs e)
            => statusBar.InvokeIfRequired(
                () =>
                {
                    if (!statusBar.Visible) return;

                    statusBarProgressBar.Visible = false;
                    statusBarMessage.Text = Resources.AppIdle;
                }
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.DataOperationStarted" />
        /// event raised by the presenter object when it's about to start an
        /// operation that involves interaction with a data source.
        /// <para />
        /// Depending on the data source, this operation can be fast or it can
        /// be slow, so the presenter object informs us in case we want to
        /// update the user interface in order to tell the user what is going on.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Objects.DataOperationEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by displaying the marquee progress
        /// control in the status bar and updating the status bar's Message
        /// indicator to display the text that is passed in the
        /// <see
        ///     cref="P:MFR.Objects.DataOperationEventArgs.Message" />
        /// property.
        /// <para />
        /// If the status bar is not presently visible, then this method does nothing.
        /// </remarks>
        private void OnPresenterDataOperationStarted(object sender,
            DataOperationEventArgs e)
            => statusBar.InvokeIfRequired(
                () =>
                {
                    if (!statusBar.Visible) return;

                    statusBarMessage.Text = e.Message;
                    statusBarProgressBar.Visible = true;
                }
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.Finished" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method toggles UI state and dismisses the progress dialog.
        /// </remarks>
        private void OnPresenterFinished(object sender, EventArgs e)
            => startingFolderBrowseButton.InvokeIfRequired(
                () =>
                {
                    UseWaitCursor = false;
                    Enabled = true;

                    _presenter.CloseProgressDialog();
                }
            );

        [Log(AttributeExclude = true)]
        private void OnPresenterOperationError(object sender,
            ExceptionRaisedEventArgs e)
        {
            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);

            ErrorDialogLauncher.Display(this, e.Exception);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.Started" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This handler is called when the
        /// <see
        ///     cref="M:MFR.Objects.FileRenamer.ProcessAll" />
        /// begins its
        /// execution. This method responds by showing the progress dialog.
        /// </remarks>
        private void OnPresenterStarted(object sender, EventArgs e)
            => startingFolderBrowseButton.InvokeIfRequired(
                () =>
                {
                    Enabled = false;
                    UseWaitCursor = true;

                    _presenter.ShowProgressDialog();
                }
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.ComboBox.SelectedIndexChanged" />
        /// event
        /// raised by the Starting Folder, Find What, and Replace With combo boxes.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by moving the input focus to a hidden label.
        /// This is to get rid of that annoying highlight that remains in a
        /// combo box when it loses the input focus.
        /// </remarks>
        private void OnSelChangeComboBox(object sender, EventArgs e)
            => hiddenFocusLabel.Focus();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Import and Export Configuration -&gt;
        /// Import Configuration menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Import Configuration
        /// menu command from the Import and Export Configuration submenu of the
        /// Tools menu. This method responds to the event by showing the user a
        /// dialog that the user can utilize to select the file they want to
        /// import, and then calls the presenter to perform the import operation.
        /// </remarks>
        private void OnToolsConfigImport(object sender, EventArgs e)
            => _presenter.ImportConfiguration();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Import and Export Configuration -&gt;
        /// Export Configuration menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Export Configuration
        /// menu command from the Import and Export Configuration submenu of the
        /// Tools menu. This method responds to the event by showing the user a
        /// dialog that the user can utilize to select the pathname of the file
        /// that the user wants the configuration data to be exported to.
        /// </remarks>
        private void OnToolsExportConfig(object sender, EventArgs e)
            => _presenter.ExportConfiguration();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the user clicking the Tools menu, pointing to
        /// History, and then choosing the Clear All command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by clearing the contents of all
        /// history lists in the configuration, saving it to the configuration
        /// data source, and then reloading the screen from the configuration.
        /// </remarks>
        private void OnToolsHistoryClearAll(object sender, EventArgs e)
            => _presenter.ClearAllHistory();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Options menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Options command on
        /// the Tools menu. This method responds by showing the user an Options
        /// dialog that the user can then utilize in order to configure this
        /// application's behavior.
        /// </remarks>
        private void OnToolsOptions(object sender, EventArgs e)
        {
            using (var dialog = new OptionsDialog())
            {
                dialog.ConfigPathname =
                    ConfigurationProvider.ConfigurationFilePath;
                dialog.Modified += OnOptionsModified;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                _presenter.SaveConfigurationDataFrom(dialog);
            }
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Application.Idle" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by updating the enabled/disabled
        /// state of controls and menu items, unless the
        /// <see
        ///     cref="P:System.Windows.Forms.Control.Enabled" />
        /// property is
        /// <see
        ///     langword="false" />
        /// , which means an operation is in progress.
        /// </remarks>
        [Log(AttributeExclude = true)] // do not log this method
        private void OnUpdateCmdUI(object sender, EventArgs e)
        {
            if (!Enabled) return;

            goButton.Enabled = performOperationButton.Enabled =
                operationsPerform.Enabled = IsDataValid;
            SelectAll = OperationsCheckedListBox.AreAllItemsSelected();
            clearAllHistoryButton.Enabled = toolsHistoryClearAll.Enabled =
                toolsHistoryClearStartingFolderHistory.Enabled =
                    toolsHistoryClearFindWhatHistory.Enabled =
                        toolsHistoryClearReplaceWithHistory.Enabled =
                            !IsHistoryClear;
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user clicks the Status Bar command on
        /// the View menu. This method responds by toggling the value of the
        /// Visible property of the status bar.
        /// </remarks>
        private void OnViewStatusBar(object sender, EventArgs e)
            => statusBar.Visible = !statusBar.Visible;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the View -&gt; Toolbar command..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user clicks the Toolbar command on
        /// the View menu. This method responds by toggling the value of the
        /// Visible property of the Standard toolbar.
        /// </remarks>
        private void OnViewToolBar(object sender, EventArgs e)
            => standardToolBar.Visible = !standardToolBar.Visible;

        /// <summary>
        /// Resizes the form to that specified in the <paramref name="newSize" />
        /// parameter.
        /// </summary>
        /// <param name="newSize">
        /// A <see cref="T:System.Drawing.Size" /> that specifies the new size to use.
        /// </param>
        private void UpdateSize(Size newSize)
        {
            Size = newSize;

            Application.DoEvents();
            Update();
            Refresh(); // repaint

            CenterToScreen();
        }

        /// <summary>
        /// Ensures the fields on the form have valid values, and prompts the
        /// user if otherwise is the case.
        /// </summary>
        /// <returns>
        /// Returns <see langword="true" /> if all the fields have valid data;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// Use the return value of this method from the calling method to
        /// decide whether to proceed with the operation. A return value of
        /// <see
        ///     langword="false" />
        /// means an operation should not proceed. If a value
        /// is invalid, a message box is displayed to the user telling the user
        /// what the user needs to fix. Then, the input focus is set to the
        /// offending field.
        /// </remarks>
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(StartingFolderComboBox.EnteredText) ||
                !Directory.Exists(StartingFolderComboBox.EnteredText))
            {
                MessageBox.Show(
                    this,
                    "Please choose a pathname to a folder that exists on your computer for the starting location of the search.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                hiddenFocusLabel.Focus();
                StartingFolderComboBox.Focus();
                return false;
            }

            if (!DoesDirectoryContainSolutionFile(
                StartingFolderComboBox.EnteredText
            ))
            {
                MessageBox.Show(
                    this,
                    "Please select a directory that contains a Visual Studio Solution (*.sln) file for the What Folder Should the Operation Start In field.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                return false;
            }

            if (string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText))
            {
                MessageBox.Show(
                    this,
                    "Please provide a value for the text to be located during the search.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                hiddenFocusLabel.Focus();
                FindWhatComboBox.Focus();
                return false;
            }

            if (OperationsCheckedListBox.NoItemsAreSelected())
            {
                MessageBox.Show(
                    this,
                    "Please select at least one operation on the Operations tab.\n\nNOTE: To show the Operations tab (if it isn't already visible), click the More button.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                hiddenFocusLabel.Focus();
                StartingFolderComboBox.Focus();
                return false;
            }

            // If the Replace in Files operation is the only operation that is
            // enabled, then we allow a blank value for the Replace With value.
            // Otherwise, mandate that the value be filled in
            if (!OnlyReplaceInFilesOperationIsEnabled &&
                string.IsNullOrWhiteSpace(ReplaceWithComboBox.EnteredText))
            {
                MessageBox.Show(
                    this,
                    "Please provide a value for the replacement value to be used during the search.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                hiddenFocusLabel.Focus();
                ReplaceWithComboBox.Focus();
                return false;
            }

            /*
             * OKAY, Sometimes we also run into circumstances where the Text to Be Replaced
             * field's value and the With What field's value are identically equal.  This
             * means no replacement is to be done.  So, we prompt the user to try again, and
             * fail validation.
             */

            if (!string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText) &&
                !string.IsNullOrWhiteSpace(ReplaceWithComboBox.EnteredText) &&
                FindWhatComboBox.EnteredText.Equals(
                    ReplaceWithComboBox.EnteredText
                ))
            {
                MessageBox.Show(
                    this,
                    "Please type different values in the Text to Be Replaced and With What fields.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                );
                hiddenFocusLabel.Focus();
                ReplaceWithComboBox.Focus();
                return false;
            }

            return true;
        }
    }
}