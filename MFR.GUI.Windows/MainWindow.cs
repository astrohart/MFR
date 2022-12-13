using MFR.Directories.Validators.Events;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.Events.Common;
using MFR.FileSystem.Enumerators.Actions;
using MFR.GUI.Constants;
using MFR.GUI.Controls;
using MFR.GUI.Controls.Events;
using MFR.GUI.Controls.Extensions;
using MFR.GUI.Controls.Helpers;
using MFR.GUI.Controls.Interfaces;
using MFR.GUI.Dialogs;
using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Displayers;
using MFR.GUI.Presenters.Associators;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Constants;
using MFR.GUI.Windows.Presenters.Events;
using MFR.GUI.Windows.Presenters.Interfaces;
using MFR.GUI.Windows.Properties;
using MFR.Managers.History.Factories;
using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Factories;
using MFR.Operations.Events;
using MFR.Renamers.Files.Factories;
using MFR.Settings.Configuration.Events;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using File = Alphaleonis.Win32.Filesystem.File;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.GUI.Windows
{
    /// <summary>
    /// Displays the main window of the application.
    /// </summary>
    public partial class MainWindow : Form, IMainWindow
    {
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
            RootDirectoryValidator.RootDirectoryInvalid +=
                OnRootDirectoryInvalid;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface
        /// that represents the currently-loaded projectFileRenamerConfiguration.
        /// </summary>
        private static IProjectFileRenamerConfiguration ProjectFileRenamerConfiguration
            => GetConfigurationProvider.SoleInstance()
                                       .CurrentConfiguration;

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user projectFileRenamerConfiguration and the actions
        /// associated with it.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfiguration CurrentConfiguration
            => ConfigurationProvider.CurrentConfiguration;

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
        ///     cref="T:MFR.GUI.Controls.FoldUnfoldButton" />
        /// that controls whether
        /// the form is the folded (smaller) size or unfolded (larger, with more
        /// options visible) size.
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
        /// Gets a reference to the one and only
        /// <see cref="T:MFR.GUI.Windows.MainWindow" /> object in this application.
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
        /// Gets or sets a value specifying whether the form is in the Folded state.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public bool IsFolded
        {
            get => FoldButton.IsFolded;
            set => FoldButton.IsFolded = value;
        }

        /// <summary>
        /// Gets a value that indicates whether the history is free of all
        /// previous entries.
        /// </summary>
        [Log(AttributeExclude = true)]
        private bool IsHistoryClear
            => StartingFolderComboBox.IsClear() && FindWhatComboBox.IsClear() &&
               ReplaceWithComboBox.IsClear();

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

        [Log(AttributeExclude = true)] // do not log this method
        private bool OnlyReplaceInFilesOperationIsEnabled
            => OperationsCheckedListBox.CheckedItems.Count == 1 &&
               OperationsCheckedListBox.GetItemChecked(2);

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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object plays the role of the Presenter for this form, which determines the
        /// behavior of this form.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public IMainWindowPresenter Presenter
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to a <see cref="T:System.Windows.Forms.ToolStripComboBox" />
        /// that has a drop-down list of the profiles that the user has created.
        /// </summary>
        [Log(AttributeExclude = true)]
        public ToolStripComboBox ProfileCollectionComboBox
            => profileListComboBox;

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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryValidator RootDirectoryValidator
            => GetRootDirectoryValidator.SoleInstance();

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
        } = Assembly.GetEntryAssembly()
                    .GetName()
                    .Version.ToString();

        /// <summary>
        /// Clears all the items from the Profile List combo box and then adds the
        /// <c>
        /// &lt;No profile selected&gt;
        /// </c>
        /// item and then selects the first element in the
        /// <see cref="P:System.Windows.Forms.ToolStripComboBox.Items" /> list.
        /// </summary>
        public void ResetProfileCollectionComboBox()
        {
            ProfileCollectionComboBox.Items.Clear();
            ProfileCollectionComboBox.Items.Add("<No profile selected>");
            ProfileCollectionComboBox.SelectedIndex = 0;
        }

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

            Presenter.UpdateData();
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

            Presenter.UpdateData(false);

            UpdateSize(
                IsFolded
                    ? FoldButton.FormFoldedSize
                    : FoldButton.FormUnfoldedSize
            );

            FoldButton.SetFoldedStateText();

            MakeButtonBitmapTransparent(switchButton);

            Presenter.FillProfileDropDownList();

            SetUpFindWhatComboBox();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Automatically resize the main window for the monitor it is 
            // being displayed upon
            PerformAutoScale();

            /*
             * Just carry out the normal behavior in the event that the configuration
             * is not specified on the command line.
             *
             * However, if the configuration did come from the command-line options chosen
             * by the user, then we should update the screen with the values from the
             * projectFileRenamerConfiguration, and then "click" the Perform Operation button.
             */
            if (!CurrentConfiguration.IsFromCommandLine ||
                !CurrentConfiguration.AutoStart)
                return;

            Presenter.UpdateData(false);

            performOperationButton.PerformClick();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AddProfileFailed" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This handler is called when the operation of creating a new profile fails.
        /// <para />
        /// This method responds by showing the user an error message box explaining what
        /// happened.
        /// </remarks>
        private static void OnPresenterAddNewProfileFailed(object sender,
            AddProfileFailedEventArgs e)
            => xyLOGIX.Win32.Interact.Messages.ShowStopError(e.Message);

        private static IProfile OnPresenterCreateNewBlankProfileRequested(
            object sender, CreateNewBlankProfileRequestedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Name))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(e.Name)
                );

            IProfile result;

            try
            {
                result = GetProfileCollectionActionType.For<string, IProfile>(
                        ProfileCollectionActionType.CreateNewNamedProfile
                    )
                    .WithInput(e.Name)
                    .Execute();

                ConfigurationProvider.CurrentConfiguration =
                    result; // set the newly-created profile as the new projectFileRenamerConfiguration.
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the folder having the specified <paramref name="path" />
        /// contains a Visual Studio Solution (*.sln) file.
        /// <para />
        /// NEW: Also searches subfolders.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the path of the folder to
        /// check.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the folder with the specified
        /// <paramref name="path" /> exists and contains at least one file with the
        /// <c>.sln</c> file.
        /// </returns>
        private bool DoesDirectoryContainSolutionFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            if (!path.IsAbsolutePath()) return false;
            if (!Directory.Exists(path)) return false;

            var result = false;

            try
            {
                /*
                 * We call Is.SolutionFile in the Any call below.  This may seem
                 * counter-intuitive, since, after all, we are explicitly telling
                 * our file system enumeration class to only search *.sln files --
                 * but, since we just need to know whether the folder with the path
                 * given by the 'path' parameter has AT LEAST ONE file ending in the
                 * .sln file, we need the functionality of the Any() method and it
                 * being passed a predicate such as Is.SolutionFile, so this way, the
                 * file-search operation (which can get expensive) stops as soon as
                 * a solution file -- ANY solution file -- is found in this folder, or
                 * its subdirectories.
                 */

                using (var dialogBox = MakeNewOperationDrivenProgressDialog
                                       .FromScratch()
                                       .HavingProc(
                                           arg => Does
                                               .FolderHaveAtLeastOneFileMatching(
                                                   arg, "*.sln"
                                               )
                                       )
                                       .AndArgument(path)
                                       .AndStatusText(
                                           GetOperationStartedDescription.For(
                                               OperationType
                                                   .CheckingWhetherChosenFolderContainsSolutions
                                           )
                                       ))
                {
                    Enabled = false;
                    UseWaitCursor = true;

                    dialogBox.ShowDialog(this);

                    Enabled = true;
                    UseWaitCursor = false;

                    result = (bool)dialogBox.Result;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                xyLOGIX.Win32.Interact.Messages.ShowStopError(this, ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Sets up the presenter object and attaches handlers to events that it exposes.
        /// </summary>
        private void InitializePresenter()
        {
            Presenter = AssociatePresenter<IMainWindowPresenter>.WithView()
                .HavingWindowReference(this)
                .WithFileRenamer(
                    GetFileRenamer.SoleInstance()
                                  .StartingFrom(ProjectFileRenamerConfiguration.StartingFolder)
                                  .AndAttachConfiguration(ProjectFileRenamerConfiguration)
                )
                .AndHistoryManager(
                    MakeHistoryManager.ForForm(this)
                                      .AndAttachConfiguration(ProjectFileRenamerConfiguration)
                )
                .AndAttachConfiguration(ProjectFileRenamerConfiguration);

            Presenter.UpdateData(false);

            if (Presenter == null)
                throw new InvalidOperationException(
                    "Failed to initialize the main application window."
                );
            NewMessageMapping.Associate.WithMessageId(
                                 MainWindowPresenterMessages
                                     .MWP_ALL_HISTORY_CLEARED
                             )
                             .AndEventHandler(OnPresenterAllHistoryCleared);
            NewMessageMapping<AddProfileFailedEventArgs>.Associate
                .WithMessageId(
                    MainWindowPresenterMessages.MWP_ADD_NEW_PROFILE_FAILED
                )
                .AndEventHandler(OnPresenterAddNewProfileFailed);
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
            NewMessageMapping<CreateNewBlankProfileRequestedEventArgs, IProfile>
                .Associate.WithMessageId(
                    MainWindowPresenterMessages
                        .MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED
                )
                .AndEventHandler(OnPresenterCreateNewBlankProfileRequested);
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
        }

        // Give the button a transparent background.
        private void MakeButtonBitmapTransparent(Button btn)
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
        ///     <para>
        ///     When the user clicks the "..." button, we want to show them a dialog
        ///     box to select a folder.
        ///     </para>
        ///     <para>
        ///     The contents of the Starting Folder text box will then be
        ///     initialized to hold the pathname to the folder that the user selects.
        ///     </para>
        /// </remarks>
        private void OnClickBrowseForStartingFolder(object sender, EventArgs e)
        {
            using (var fsd = MakeNewFolderSelectDialog.FromScratch()
                       .HavingTitle("Browse")
                       .AndInitialDirectory(StartingFolderComboBox.EnteredText))
            {
                if (DialogResult.Cancel == fsd.ShowDialog(this))
                    return;

                /*
                 * OKAY, the folder selected by the user must be a folder that contains
                 * at least one Visual Studio Solution (*.sln) file.
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
            try
            {
                Presenter.UpdateData();

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

                Presenter.DoSelectedOperations();
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

            (ReplaceWithComboBox.EnteredText, FindWhatComboBox.EnteredText) = (
                FindWhatComboBox.EnteredText, ReplaceWithComboBox.EnteredText);
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
            => Close();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Controls.FoldUnfoldButton.FormFolded" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.FormFoldedEventArgs" /> that contains the
        /// event data.
        /// </param>
        /// <remarks>
        /// </remarks>
        private void OnFormFolded(object sender, FormFoldedEventArgs e)
        {
            UpdateSize(e.Size);

            FoldButton.SetFoldedStateText();

            GetConfigurationProvider.SoleInstance()
                                    .CurrentConfiguration.IsFolded = e.Folded;
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the user clicking on the About command on the
        /// HelpProfileExplainerDialog menu.
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
        /// event raised by the message of the user clicking on the
        /// HelpProfileExplainerDialog menu to
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
        /// HelpProfileExplainerDialog menu's About command contains the full name of this
        /// application.
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
        /// Handles the <see cref="E:MFR.GUI.OptionsDialog.Modified" /> event.
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
            var dialog = (OptionsDialog)sender;
            if (dialog == null) return;

            Presenter.SaveConfigurationDataFrom(dialog);

            e.Handled =
                true; // instruct the Options dialog box to re-gray out the Apply button
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.AllHistoryCleared" />
        /// event
        /// raised by the presenter object.
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
        /// An <see cref="T:MFR.Settings.ConfigurationExportedEventArgs" /> that
        /// contains the event data.
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
        ///     cref="P:MFR.GUI.MainWindowPresenter.ProjectFileRenamerConfiguration" />
        /// property. This
        /// happens most often as a the result of the Import ProjectFileRenamerConfiguration
        /// command on the Tools menu.
        /// </remarks>
        private void OnPresenterConfigurationImported(object sender,
            ConfigurationImportedEventArgs e)
            => MessageBox.Show(
                this,
                $"Successfully imported the configuration from the file with path '{e.Path}'.",
                Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.DataOperationFinished" />
        /// event
        /// raised by the presenter object when a data operation is finished.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by removing the progress bar from
        /// the status bar and setting the text of its message label back to the
        /// idle text. We use the Invoke If Required methodology just in case
        /// it's not the GUI thread that raised the event.
        /// <para />
        /// If the status bar is not presently visible, then this method does nothing.
        /// </remarks>
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
        /// event
        /// raised by the presenter object when it's about to start an operation
        /// that involves interaction with a data source.
        /// <para />
        /// Depending on the data source, this operation can be fast or it can
        /// be slow, so the presenter object informs us in case we want to
        /// update the user interface in order to tell the user what is going on.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.DataOperationEventArgs" /> that contains
        /// the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by displaying the marquee progress
        /// control in the status bar and updating the status bar's Message
        /// indicator to display the text that is passed in the
        /// <see
        ///     cref="P:MFR.DataOperationEventArgs.Message" />
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
        /// Handles the <see cref="E:MFR.GUI.IMainWindowPresenter.Finished" /> event.
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
        {
            startingFolderBrowseButton.InvokeIfRequired(
                () =>
                {
                    UseWaitCursor = false;
                    Enabled = true;

                    Presenter.CloseProgressDialog();
                }
            );

            /*
             * If this application was invoked using command-line
             * arguments to set the configuration settings, and
             * if the --autoStart flag is also passed on the command
             * line, then automatically exit the application once
             * processing is done.
             */

            if (CurrentConfiguration.IsFromCommandLine &&
                CurrentConfiguration.AutoStart)
                this.InvokeIfRequired(Close);
        }

        [Log(AttributeExclude = true)]
        private void OnPresenterOperationError(object sender,
            ExceptionRaisedEventArgs e)
        {
            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);

            // and which allows the user to choose to send an error report.
            Display.ErrorReportDialog(this, e.Exception);
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.GUI.IMainWindowPresenter.Started" /> event.
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
        ///     cref="M:MFR.FileRenamer.ProcessAll" />
        /// begins its execution.
        /// This method responds by showing the progress dialog.
        /// </remarks>
        private void OnPresenterStarted(object sender, EventArgs e)
            => startingFolderBrowseButton.InvokeIfRequired(
                () =>
                {
                    Enabled = false;
                    UseWaitCursor = true;

                    Presenter.ShowProgressDialog();
                }
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid" />
        /// event raised by the <c>Root Directory Validator</c> component.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by displaying a message to the user about why the
        /// validation failed, and then instructing the validator to stop the validation
        /// process.
        /// </remarks>
        private void OnRootDirectoryInvalid(object sender,
            RootDirectoryInvalidEventArgs e)
        {
            MessageBox.Show(
                this, e.Message, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
            );
            e.Cancel = true;
        }

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
        /// event for the Tools -&gt; Import and Export ProjectFileRenamerConfiguration -&gt;
        /// Import ProjectFileRenamerConfiguration menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Import ProjectFileRenamerConfiguration
        /// menu command from the Import and Export ProjectFileRenamerConfiguration submenu of the
        /// Tools menu. This method responds to the event by showing the user a
        /// dialog that the user can utilize to select the file they want to
        /// import, and then calls the presenter to perform the import operation.
        /// </remarks>
        private void OnToolsConfigImport(object sender, EventArgs e)
        { 
            if (importConfigDialog.ShowDialog(this) == DialogResult.Cancel)
                return;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Exporting the configuration to '{importConfigDialog.FileName}'..."
            );

            Presenter.ImportConfiguration(importConfigDialog.FileName);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event
        /// raised by the New Profile toolbar button and/or Tools -> ProjectFileRenamerConfiguration -> New
        /// Profile menu command.
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
        /// This method is called when the user click the New Profile toolbar
        /// button or menu item.
        /// <para />
        /// The goal is to prompt the user for the name of their new profile, create it,
        /// then add it to the list of profiles and then set it as the current profile.
        /// </remarks>
        private void OnToolsConfigurationNewProfile(object sender, EventArgs e)
        {
            // Creating a new profile will blank out the application screen.
            // Save the current projectFileRenamerConfiguration settings.
            var results =
                Display.ProfileNameDialogBox(ProfileCreateOperationType.New);
            if (DialogResult.Cancel == results.DialogResult)
                return;

            if (string.IsNullOrWhiteSpace(results.ProfileName))
            {
                xyLOGIX.Win32.Interact.Messages.ShowStopError(
                    "You cannot specify a blank value for the profile name."
                );
                return;
            }

            Presenter.AddProfile(results.ProfileName);
        }

        private void OnToolsConfigurationSaveProfile(object sender, EventArgs e)
        {
            /*
             * First step, save whatever settings are on the screen
             * to the configuration.
             */

            // Prompt the user to create a new name for the new
            // Profile
            var results = Display.ProfileNameDialogBox(
                ProfileCreateOperationType.SaveAs, this
            );
            if (DialogResult.Cancel == results.DialogResult)
                return;

            if (string.IsNullOrWhiteSpace(results.ProfileName))
            {
                xyLOGIX.Win32.Interact.Messages.ShowStopError(
                    "You cannot specify a blank value for the profile name."
                );
                return;
            }

            // First, save data from the screen
            Presenter.UpdateData();

            Presenter.SaveCurrentConfigurationAsProfile(results.ProfileName);

            /*
             * Update the contents of the Profiles dropdown on the toolbar.
             */
            Presenter.FillProfileDropDownList();

            /*
             * Move the selection of the dropdown to be the profile with
             * the name of the profile the user has saved; this is now
             * the current profile.
             */
            ProfileCollectionComboBox.SelectFirstItemNamed(results.ProfileName);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Import and Export ProjectFileRenamerConfiguration -&gt;
        /// Export ProjectFileRenamerConfiguration menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Export ProjectFileRenamerConfiguration
        /// menu command from the Import and Export ProjectFileRenamerConfiguration submenu of the
        /// Tools menu. This method responds to the event by showing the user a
        /// dialog that the user can utilize to select the pathname of the file
        /// that the user wants the configuration data to be exported to.
        /// </remarks>
        private void OnToolsConfigExport(object sender, EventArgs e)
        {
            if (exportConfigDialog.ShowDialog(this) == DialogResult.Cancel)
                return;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Exporting the configuration to '{exportConfigDialog.FileName}'..."
            );

            Presenter.ExportConfiguration(exportConfigDialog.FileName);
        }

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
            => Presenter.ClearAllHistory();

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
                dialog.ConfigPathname = GetConfigurationProvider.SoleInstance()
                    .ConfigurationFilePath;
                dialog.Modified += OnOptionsModified;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                Presenter.SaveConfigurationDataFrom(dialog);
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
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event
        /// raised by the <b>Dark Theme</b> command on the <b>View</b> menu.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>This method responds by toggling the Dark Theme on and off.</remarks>
        private void OnViewDarkTheme(object sender, EventArgs e)
        {
            // TODO: Add code here to implement the switch to Dark Theme.
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
        /// Configures the <b>Find What</b> combo box.
        /// </summary>
        /// <remarks>
        /// One of the things method does is get a list of all the <c>*.csproj</c> files in
        /// the stating folder and builds an auto-completion suggestion list consisting of
        /// just their names (with no folder path or file extension).
        /// </remarks>
        private void SetUpFindWhatComboBox()
        {
            var findWhatAutocompleteCustomSource =
                new AutoCompleteStringCollection();
            findWhatAutocompleteCustomSource.AddRange(
                Directory.EnumerateFiles(
                             ProjectFileRenamerConfiguration.StartingFolder, "*.csproj",
                             SearchOption.AllDirectories
                         )
                         .Select(Path.GetFileNameWithoutExtension)
                         .ToArray()
            );
            FindWhatComboBox.AutoCompleteCustomSource =
                findWhatAutocompleteCustomSource;
            FindWhatComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FindWhatComboBox.AutoCompleteSource =
                AutoCompleteSource.CustomSource;
        }

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
            if (!RootDirectoryValidator.Validate(
                    StartingFolderComboBox.EnteredText
                ))
            {
                hiddenFocusLabel.Focus();
                StartingFolderComboBox.Focus();
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
             * fail validation.  Otherwise, we have a tautology.
             */

            if (string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText) ||
                string.IsNullOrWhiteSpace(ReplaceWithComboBox.EnteredText) ||
                !FindWhatComboBox.EnteredText.Equals(
                    ReplaceWithComboBox.EnteredText
                )) return true;

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

        /// <summary>
        /// Exposes static methods to make determinations about data and the state of the
        /// system..
        /// </summary>
        internal static class Is
        {
            /// <summary>
            /// Determines whether the file having the specified <paramref name="pathname" />
            /// is a Visual Studio Solution (*.sln) file.
            /// </summary>
            /// <param name="pathname">
            /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of a file that is to be examined in order to determine whether it is a
            /// Visual Studio Solution (*.sln) file.
            /// </param>
            /// <returns>
            /// <see langword="true" /> if the file having the specified
            /// <paramref name="pathname" /> is a Visual Studio Solution (*.sln) file;
            /// <see langword="false" /> otherwise.
            /// </returns>
            /// <remarks>
            /// This method also returns <see langword="false" /> if the
            /// <paramref name="pathname" /> that is passed is blank, <see langword="null" />,
            /// or refers to a file that does actually exist on the disk.
            /// </remarks>
            internal static bool SolutionFIle(string pathname)
            {
                var result = false;

                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!File.Exists(pathname)) return result;

                try
                {
                    result = ".sln".Equals(
                        Path.GetExtension(pathname.ToLowerInvariant())
                    );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
        }
    }
}