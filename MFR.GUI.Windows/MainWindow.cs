using MFR.CommandLine.Models.Interfaces;
using MFR.Directories.Validators.Events;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.Engines.Constants;
using MFR.Engines.Operations.Factories;
using MFR.Engines.Operations.Interfaces;
using MFR.Events.Common;
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
using MFR.GUI.Presenters.Associators;
using MFR.GUI.Windows.Actions;
using MFR.GUI.Windows.Constants;
using MFR.GUI.Windows.Events;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Constants;
using MFR.GUI.Windows.Presenters.Events;
using MFR.GUI.Windows.Presenters.Interfaces;
using MFR.GUI.Windows.Properties;
using MFR.Managers.History.Factories;
using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Factories;
using MFR.Operations.Events;
using MFR.Settings.Configuration;
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
using xyLOGIX.Files.Actions;
using xyLOGIX.Pools.Tasks.Factories;
using xyLOGIX.Pools.Tasks.Interfaces;
using xyLOGIX.Queues.Messages.Mappings;
using xyLOGIX.UI.Dark.Controls;
using xyLOGIX.UI.Dark.Forms;
using xyLOGIX.Win32.Interact;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using Display = MFR.GUI.Displayers.Display;
using File = Alphaleonis.Win32.Filesystem.File;
using Path = Alphaleonis.Win32.Filesystem.Path;
using Wait = xyLOGIX.Application.Semaphores.Wait;

namespace MFR.GUI.Windows
{
    /// <summary>
    /// Displays the main window of the application.
    /// </summary>
    public partial class MainWindow : DarkForm, IMainWindow
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that contains the settings that were specified by the user on the command line
        /// when this application was launched.
        /// </summary>
        private ICommandLineInfo _cmdInfo;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Needed to make the
        /// <see cref="P:MFR.GUI.Windows.MainWindow.OperationEngine" /> property
        /// compute-once and store without having to use a static context.
        /// <para />
        /// This is due to the use of <see langword="dynamic" /> in the computation.
        /// </remarks>
        private IFullGuiOperationEngine _operationEngine;

        /// <summary>
        /// One of the <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" />
        /// enumeration values that describes the current state of processing.
        /// </summary>
        private MainWindowState _state;

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
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            SetState(MainWindowState.Unknown);

            InitializeComponent();

            InitializeConfiguration();

            InitializeOperationEngine();

            InitializePresenter();

            Application.Idle += OnUpdateCmdUI;
            RootDirectoryPathValidator.RootDirectoryInvalid +=
                OnRootDirectoryInvalid;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that contains the settings that were specified by the user on the command line
        /// when this application was launched.
        /// </summary>
        private ICommandLineInfo CommandLineInfo
        {
            get => _cmdInfo;
            set => _cmdInfo = value;
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets the required creation parameters when the control handle is
        /// created.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the
        /// required creation parameters when the handle to the control is created.
        /// </returns>
        protected override CreateParams CreateParams
        {
            get {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        private IProjectFileRenamerConfig CurrentConfiguration
            => ConfigProvider.CurrentConfiguration;

        /// <summary>
        /// Gets or sets the text displayed in the edit portion of the <b>Find What</b>
        /// combo box.
        /// </summary>
        public string FindWhat
        {
            get => findWhatComboBox.EnteredText;
            set => findWhatComboBox.Text = value;
        }

        /// <summary>
        /// Gets a reference to the text box control that allows the user to
        /// specify the text to be found.
        /// </summary>
        [Log(AttributeExclude = true)] // do not log this method
        public IEntryRespectingComboBox FindWhatComboBox
        {
            [DebuggerStepThrough] get => findWhatComboBox;
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
        {
            get {
                bool result;

                try
                {
                    result = StartingFolderComboBox.Items.Count == 0 &&
                             FindWhatComboBox.Items.Count == 0 &&
                             ReplaceWithComboBox.Items.Count == 0;
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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine" />
        /// interface that represents the engine that carries out the user's requested
        /// operations.
        /// </summary>
        private IFullGuiOperationEngine OperationEngine
        {
            get {
                var result = _operationEngine;

                try
                {
                    if (_operationEngine == null)
                        result = _operationEngine = GetOperationEngine
                            .OfType<
                                IFullGuiOperationEngine>(
                                OperationEngineType
                                    .FullGUI
                            )
                            .AndAttachConfiguration(
                                CurrentConfiguration
                            ) as
                            IFullGuiOperationEngine;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = _operationEngine;
                }

                return result;
            }
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
        public DarkToolStripComboBox ProfileCollectionComboBox
            => profileListComboBox;

        /// <summary>
        /// Gets or sets the text displayed in the edit portion of the <b>Replace With</b>
        /// combo box.
        /// </summary>
        public string ReplaceWith
        {
            get => replaceWithComboBox.EnteredText;
            set => replaceWithComboBox.Text = value;
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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryPathValidator RootDirectoryPathValidator
            => GetRootDirectoryPathValidator.SoleInstance();

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
        /// Gets or sets the text displayed in the edit portion of the
        /// <b>Starting Folder</b> combo box.
        /// </summary>
        public string StartingFolder
        {
            get => startingFolderComboBox.EnteredText;
            set => startingFolderComboBox.Text = value;
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
        /// Gets  the <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" />
        /// enumeration value that describes the current state.
        /// </summary>
        public MainWindowState State
        {
            get => _state;
            private set {
                var changed = _state != value;
                var oldState = _state;
                _state = value;
                if (changed)
                    OnStateChanged(
                        new MainWindowStateChangedEventArgs(oldState, value)
                    );
            }
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Pools.Tasks.Interfaces.ITaskPool" /> interface.
        /// </summary>
        private static ITaskPool TaskPool
        {
            get;
        } = GetTaskPool.SoleInstance();

        /// <summary>
        /// Gets a string containing this application's version.
        /// </summary>
        /// <remarks>
        /// Thanks to
        /// <a
        ///     href="
        /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/d9a69018-4840-4aeb-b9f1-4d98ab35f782/applicationproductversion?forum=csharpgeneral
        /// ">
        /// Kiran Suthar
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
        /// Occurs when the value of the <see cref="P:MFR.GUI.Windows.MainWindow.State" />
        /// property is updated.
        /// </summary>
        public event MainWindowStateChangedEventHandler StateChanged;

        /// <summary>
        /// Associates the specified <paramref name="cmdInfo" /> object with this window.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that contains the settings specified by the user on the command line when this
        /// application was launched.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed for the argument of
        /// the <paramref name="cmdInfo" /> parameter, then this method does nothing.
        /// </remarks>
        public void AttachCommandLineInfo(ICommandLineInfo cmdInfo)
        {
            try
            {
                if (cmdInfo == null) return;

                CommandLineInfo = cmdInfo;

                if (Presenter == null) return;

                Presenter.SetCommandLineInfo(cmdInfo);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Deselects all the available operations that are listed on the <b>Operations</b>
        /// tab.
        /// </summary>
        public void DeselectAllOperations()
            => SelectAll = false;

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
        /// Selects all the available operations that are listed on the <b>Operations</b>
        /// tab.
        /// </summary>
        public void SelectAllOperations()
            => SelectAll = true;

        /// <summary>
        /// Updates the value of the <see cref="P:MFR.GUI.Windows.MainWindow.State" />
        /// property.
        /// </summary>
        /// <param name="newState">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" /> values that
        /// identifies the new state to be set.
        /// </param>
        public void SetState(MainWindowState newState)
            => State = newState;

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" />
        /// that contains the event data.
        /// </param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            SaveUserSettingsOnExit();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            DoInitializeWindow();

            /*
             * Just carry out the normal behavior in the event that the config
             * is not specified on the command line.
             *
             * However, if the config did come from the command-line options chosen
             * by the user, then we should update the screen with the values from the
             * config, and then "click" the Perform Operation button.
             */
            if (!CurrentConfiguration.IsFromCommandLine ||
                !CurrentConfiguration.AutoStart)
            {
                SetState(MainWindowState.Idle);

                return;
            }

            performOperationButton.PerformClick();
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Windows.MainWindow.StateChanged" /> event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnStateChanged(MainWindowStateChangedEventArgs e)
            => StateChanged?.Invoke(this, e);

        // Give the button a transparent background.
        private static void MakeButtonBitmapTransparent(ButtonBase button)
        {
            var bm = (Bitmap)button.Image;
            bm.MakeTransparent(bm.GetPixel(0, 0));
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
        private static void OnPresenterAddNewProfileFailed(
            object sender,
            AddProfileFailedEventArgs e
        )
            => xyLOGIX.Win32.Interact.Messages.ShowStopError(e.Message);

        private static IProfile OnPresenterCreateNewBlankProfileRequested(
            object sender,
            CreateNewBlankProfileRequestedEventArgs e
        )
        {
            if (string.IsNullOrWhiteSpace(e.Name))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(e.Name)
                );

            IProfile result;

            try
            {
                result = GetProfileCollectionAction.For<string, IProfile>(
                                                       ProfileCollectionActionType
                                                           .CreateNewNamedProfile
                                                   )
                                                   .WithInput(e.Name)
                                                   .Execute();

                ConfigProvider.CurrentConfiguration =
                    result; // set the newly-created profile as the new config.
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
        /// Configures the <b>Find What</b> combo box.
        /// </summary>
        /// <remarks>
        /// One of the things method does is get a list of all the <c>*.csproj</c> files in
        /// the stating folder and builds an auto-completion suggestion list consisting of
        /// just their names (with no folder path or file extension).
        /// </remarks>
        private void ConfigureAutocompletionForFindWhatComboBox()
        {
            try
            {
                if (!Directory.Exists(StartingFolder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        Resources
                            .Error_CantSetUpFindWhatComboStartFolderNotExists
                            .PostfixFormat(StartingFolder)
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "MainWindow.ConfigureAutocompletionForFindWhatComboBox: Done."
                    );
                    return;
                }

                var findWhatAutocompleteCustomSource =
                    new AutoCompleteStringCollection();

                // Obtain a list of the names of the C# projects that are listed in the
                // root directory (i.e., starting folder designated by the user).
                findWhatAutocompleteCustomSource.AddRange(
                    Directory.EnumerateFiles(
                                 StartingFolder, "*.csproj",
                                 SearchOption.AllDirectories
                             )
                             .Select(Path.GetFileNameWithoutExtension)
                             .ToArray()
                );
                FindWhatComboBox.AutoCompleteCustomSource =
                    findWhatAutocompleteCustomSource;
                FindWhatComboBox.AutoCompleteMode =
                    AutoCompleteMode.SuggestAppend;
                FindWhatComboBox.AutoCompleteSource =
                    AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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
                                           GetOperationStartedDescriptionText
                                               .For(
                                                   OperationType
                                                       .CheckingWhetherChosenFolderContainsSolutions
                                               )
                                       ))
                {
                    dialogBox.ShowDialog(this);

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
        /// Carries out a series of actions to initialize the GUI.
        /// </summary>
        private void DoInitializeWindow()
            => this.InvokeIfRequired(
                () =>
                {
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

                    ConfigureAutocompletionForFindWhatComboBox();

                    // Automatically resize the main window for the monitor it is
                    // being displayed upon
                    PerformAutoScale();
                }
            );

        /// <summary>
        /// Responds to the <c>ConfiguredStartingFolderChanged</c> event by updating the
        /// value of the <b>Starting Folder</b> combo box and ensuring the new value for
        /// the starting folder is added to the history.
        /// </summary>
        private void DoUpdateConfiguredStartingFolder()
        {
            try
            {
                Presenter.UpdateData(false);

                // Make sure we're getting a valid folder
                if (!RootDirectoryPathValidator.Validate(
                        CurrentConfiguration.StartingFolder
                    )) return;

                StartingFolderComboBox.Items.AddDistinct(
                    CurrentConfiguration.StartingFolder
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Checks whether the value of the
        /// <see cref="P:MFR.GUI.Windows.MainWindow.CurrentConfiguration" /> property is
        /// <see langword="null" />.
        /// <para />
        /// If so, then calls the
        /// <see
        ///     cref="M:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Load" />
        /// method to load the application config.
        /// </summary>
        private void InitializeConfiguration()
        {
            try
            {
                if (!ProjectFileRenamerConfig.IsBlankOrNull(
                        CurrentConfiguration
                    ))
                    return;

                ConfigProvider.Load();

                if (ProjectFileRenamerConfig.IsBlankOrNull(
                        CurrentConfiguration
                    ))
                    return;

                CurrentConfiguration.StartingFolderChanged +=
                    OnConfiguredStartingFolderChanged;

                InitializeStartingFolder();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sets up the operation engine object.
        /// </summary>
        private void InitializeOperationEngine()
            => OperationEngine.SetDialogOwner(this);

        /// <summary>
        /// Sets up the presenter object and attaches handlers to events that it exposes.
        /// </summary>
        private void InitializePresenter()
        {
            Presenter = AssociatePresenter<IMainWindowPresenter>.WithView()
                .HavingWindowReference(this)
                .AndHistoryManager(
                    MakeHistoryManager.ForForm(this)
                                      .AndAttachConfiguration(
                                          CurrentConfiguration
                                      )
                )
                .WithOperationEngine(OperationEngine);

            Presenter.UpdateConfiguration(CurrentConfiguration);

            if (Presenter == null)
                throw new InvalidOperationException(
                    "Failed to initialize the main application window."
                );
            NewMessageMapping<EventArgs>.Associate.WithMessageId(
                                            MainWindowPresenterMessages
                                                .MWP_ALL_HISTORY_CLEARED
                                        )
                                        .AndEventHandler(
                                            OnPresenterAllHistoryCleared
                                        );
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
            NewMessageMapping<EventArgs>.Associate.WithMessageId(
                                            MainWindowPresenterMessages
                                                .MWP_DATA_OPERATION_FINISHED
                                        )
                                        .AndEventHandler(
                                            OnPresenterDataOperationFinished
                                        );
            NewMessageMapping<DataOperationEventArgs>.Associate.WithMessageId(
                    MainWindowPresenterMessages.MWP_DATA_OPERATION_STARTED
                )
                .AndEventHandler(OnPresenterDataOperationStarted);
            NewMessageMapping<ExceptionRaisedEventArgs>.Associate.WithMessageId(
                    OperationEngineMessages.OE_OPERATION_ERROR
                )
                .AndEventHandler(OnOperationError);
            NewMessageMapping
                .Associate
                .WithMessageId(MainWindowPresenterMessages.MWP_FINISHED)
                .AndEventHandler(OnPresenterFinished);
        }

        /// <summary>
        /// Called to check whether a Starting Folder has been configured (e.g., from
        /// command-line options) and, if so, and if that folder exists, then the text of
        /// the <b>Starting Folder</b> combo box is updated to match.
        /// </summary>
        private void InitializeStartingFolder()
        {
            if (!string.IsNullOrWhiteSpace(
                    CurrentConfiguration.StartingFolder
                ) &&
                !CurrentConfiguration.StartingFolder.Equals(StartingFolder) &&
                Does.DirectoryExist(CurrentConfiguration.StartingFolder))
                StartingFolder = CurrentConfiguration.StartingFolder;

            /*
             * Ensure that the File -> Save menu item is grayed out upon
             * launch.  This because the user has not made any changes to
             * the configured settings yet.
             *
             * This button loves to enable itself when the user first starts
             * the application. That does not make intuitive sense.
             */

            fileSave.PerformClick();
        }

        private void InitializeStyles()
        {
            SetStyle(
                ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ContainerControl |
                ControlStyles.SupportsTransparentBackColor, true
            );
            UpdateStyles();
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
        private void OnCheckedChangedSelectDeselectAllCheckBox(
            object sender,
            EventArgs e
        )
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

        private void OnClickCustomizeOperationsButton(
            object sender,
            EventArgs e
        )
        {
            using (var dialog = MakeNewCustomizeOperationsDialog.FromScratch())
                dialog.ShowDialog(this);
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
                /*
                 * Save the user's configuration, if it is marked as
                 * dirty.
                 */
                if (Presenter.IsDirty)
                    fileSave.PerformClick();

                SetState(MainWindowState.PerformingOperations);

                /* Validation of data takes awhile...show a marquee
                 progress dialog during the operation. */

                var validationOfDataSucceeded = false;

                using (var dialog = MakeNewOperationDrivenProgressDialog
                                    .FromScratch()
                                    .HavingProc(
                                        new Action(
                                            () => validationOfDataSucceeded =
                                                ValidateData()
                                        )
                                    )
                                    .AndStatusText(
                                        Resources.Info_PreparingStartOperations
                                    ))
                    dialog.ShowDialog(this);

                if (!validationOfDataSucceeded) return;

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

                SetState(MainWindowState.Idle);
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
        /// Handles the
        /// <see
        ///     cref="E:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolderChanged" />
        /// event raised by the object instance that represents the currently-loaded
        /// application config.
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
        /// This method responds by invoking the
        /// <see cref="M:MFR.GUI.Windows.MainWindow.DoUpdateConfiguredStartingFolder" />
        /// method, and, if required, marshaling the method call to the UI thread.
        /// </remarks>
        private void OnConfiguredStartingFolderChanged(
            object sender,
            StartingFolderChangedEventArgs e
        )
        {
            if (e.OldPath.EqualsNoCase(e.NewPath)) return;

            this.InvokeIfRequired(DoUpdateConfiguredStartingFolder);
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpening" />
        /// event raised by the <b>File</b> menu when the user clicks on it but before the
        /// items are shown to the user.
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
        /// This method responds by enabling and disabling menu items in a manner
        /// that corresponds to the current state of the application.
        /// </remarks>
        private void OnFileDropDownOpening(object sender, EventArgs e)
            => fileSave.Enabled = Presenter.IsDirty;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the <b>Exit</b> command on the <b>File</b> menu.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to handle the message of the user clicking the
        /// Exit command on the File menu. This method saves the config
        /// and then closes this window. Since this window is the main window of
        /// the application, closing this window ends the lifecycle of the application.
        /// </remarks>
        private void OnFileExit(object sender, EventArgs e)
            => Close();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event
        /// raised by the <b>Save</b> button on the <b>Standard</b> toolbar or the
        /// <b>Save</b> item on the <b>File</b> menu.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>This method responds by saving the configuration to the file system.</remarks>
        private void OnFileSave(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            Presenter.SaveConfiguration();

            UseWaitCursor = false;
        }

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

            GetProjectFileRenamerConfigProvider.SoleInstance()
                                               .CurrentConfiguration.IsFolded =
                e.Folded;
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

        private void OnOperationError(object sender, ExceptionRaisedEventArgs e)
        {
            this.InvokeIfRequired(
                () =>
                {
                    UseWaitCursor = false;
                    Enabled = true;

                    Update();
                    Refresh();
                    Application.DoEvents();
                }
            );

            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);

            // and which allows the user to choose to send an error report.
            Display.ErrorReportDialog(this, e.Exception);
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

            Presenter.RenameConfigFileToMatchNewName(dialog.ConfigPathname);

            UpdateData();

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
        /// This method is called when an export of the config has been
        /// successfully completed. This method responds to the event by
        /// informing the user that the operation has completed successfully.
        /// </remarks>
        private void OnPresenterConfigurationExported(
            object sender,
            ConfigurationExportedEventArgs e
        )
            => MessageBox.Show(
                this,
                $"Successfully exported the config to the file with path '{e.Path}'.",
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
        /// screen from values stored in the config object in the
        /// <see
        ///     cref="P:MFR.GUI.MainWindowPresenter.ProjectFileRenamerConfig" />
        /// property. This happens most often as a result of the
        /// <b>Import Configuration</b> command on the <b>Tools</b> menu.
        /// </remarks>
        private void OnPresenterConfigurationImported(
            object sender,
            ConfigurationImportedEventArgs e
        )
            => MessageBox.Show(
                this,
                $"Successfully imported the config from the file with path '{e.Path}'.",
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
        private void OnPresenterDataOperationFinished(
            object sender,
            EventArgs e
        )
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
        /// Depending on the data source, this operation can be fast, or it can
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
        private void OnPresenterDataOperationStarted(
            object sender,
            DataOperationEventArgs e
        )
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
            // Block this thread until there aren't any more pooled tasks running
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Awaiting the completion of all replace-in-file tasks..."
            );

            Wait.Until(() => !TaskPool.HasTasks, -1);

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: All replace-in-file tasks are reported as being completed."
            );

            // Asks the progress dialog to destroy itself
            MessageHelper.DoRequestProgressClose();

            SetState(MainWindowState.OperationsFinished);

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Running presenter-finished processing..."
            );

            this.InvokeIfRequired(
                () =>
                {
                    if (!CurrentConfiguration.AutoQuitOnCompletion) return;
                    UpdateData();
                    Close();
                }
            );

            /*
             * If this application was invoked using command-line
             * arguments to set the config settings, and
             * if the --autoStart flag is also passed on the command
             * line, then automatically exit the application once
             * processing is done.
             */

            if (CurrentConfiguration.IsFromCommandLine &&
                CurrentConfiguration.AutoStart)
                this.InvokeIfRequired(Close);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid" />
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
        private void OnRootDirectoryInvalid(
            object sender,
            RootDirectoryInvalidEventArgs e
        )
            => this.InvokeIfRequired(
                () =>
                {
                    MessageBox.Show(
                        this, e.Message, Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Stop,
                        MessageBoxDefaultButton.Button1
                    );
                    e.Cancel = true;
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
        /// This to get rid of that annoying highlight that remains in a
        /// combo box when it loses the input focus.
        /// </remarks>
        //private void OnSelChangeComboBox(object sender, EventArgs e)
        //    => hiddenFocusLabel.Focus();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Import and Export ProjectFileRenamerConfig -
        /// &gt;
        /// Export ProjectFileRenamerConfig menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Export
        /// ProjectFileRenamerConfig
        /// menu command from the Import and Export ProjectFileRenamerConfig submenu
        /// of the
        /// Tools menu. This method responds to the event by showing the user a
        /// dialog that the user can utilize to select the pathname of the file
        /// that the user wants the config data to be exported to.
        /// </remarks>
        private void OnToolsConfigExport(object sender, EventArgs e)
        {
            if (exportConfigDialog.ShowDialog(this) == DialogResult.Cancel)
                return;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Exporting the config to '{exportConfigDialog.FileName}'..."
            );

            Presenter.ExportConfiguration(exportConfigDialog.FileName);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event for the Tools -&gt; Import and Export ProjectFileRenamerConfig -
        /// &gt;
        /// Import ProjectFileRenamerConfig menu command.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Import
        /// ProjectFileRenamerConfig
        /// menu command from the Import and Export ProjectFileRenamerConfig submenu
        /// of the
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
                $"*** INFO: Exporting the config to '{importConfigDialog.FileName}'..."
            );

            Presenter.ImportConfiguration(importConfigDialog.FileName);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event
        /// raised by the New Profile toolbar button and/or Tools ->
        /// ProjectFileRenamerConfig -> New
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
            // Save the current config settings.
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
             * to the config.
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

            Presenter.SaveCurrentConfigurationurationAsProfile(
                results.ProfileName
            );

            /*
             * Update the contents of the Profiles dropdown on the toolbar.
             */
            Presenter.FillProfileDropDownList();

            /*
             * Move the selection of the dropdown to be the profile with
             * the name of the profile the user has saved; this now
             * the current profile.
             */
            ProfileCollectionComboBox.SelectFirstItemNamed(results.ProfileName);
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
        /// history lists in the config, saving it to the config
        /// data source, and then reloading the screen from the config.
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
                dialog.Modified += OnOptionsModified;
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                Presenter.RenameConfigFileToMatchNewName(dialog.ConfigPathname);

                UpdateData();
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
            saveButton.Enabled = Presenter.IsDirty;
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
        /// event for the View -&gt; Toolbar command.
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
            => standardToolStrip.Visible = !standardToolStrip.Visible;

        /// <summary>
        /// Saves the user's settings to the config object in memory, and shows a
        /// progress dialog to the user while doing so.
        /// </summary>
        private void SaveUserSettingsOnExit()
        {
            if (State == MainWindowState.ConfigurationSaved) return;

            using (var dialog =
                   MakeNewOperationDrivenProgressDialog.FromScratch())
            {
                dialog.Proc = new Action(() => UpdateData());
                dialog.Status = "Saving user config settings...";

                dialog.ShowDialog(this);
            }
        }

        /// <summary>
        /// Warns the user about a potentially destructive operation.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the selected operation(s) should NOT be
        /// processed; <see langword="false" /> otherwise.
        /// </returns>
        private bool ShouldNotProceedDueToPotentialOverwrites()
        {
            var result = false;

            try
            {
                this.InvokeIfRequired(
                    () => result =
                        DialogResult.No.Equals(xyLOGIX.Win32.Interact.Messages.ConfirmWithYesNo(
                            this,
                            Resources
                                .Confirm_ReplaceTextThatWouldOverwriteExistingFiles
                        ))
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Moves data from this dialog's controls to the config object.
        /// </summary>
        /// <param name="bSaveAndValidate">
        /// (Required.) A <see cref="T:System.Boolean" />
        /// that specifies whether to save information from the screen into data variables.
        /// <see langword="false" /> to load data to the screen.
        /// </param>
        private void UpdateData(bool bSaveAndValidate = true)
            => this.InvokeIfRequired(
                () =>
                {
                    if (bSaveAndValidate)
                        Presenter.UpdateConfiguration(CurrentConfiguration);

                    Presenter.UpdateData(bSaveAndValidate);

                    SetState(MainWindowState.ConfigurationSaved);
                }
            );

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
            if (!RootDirectoryPathValidator.Validate(
                    StartingFolderComboBox.EnteredText
                ))
            {
                hiddenFocusLabel.Focus();
                StartingFolderComboBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(FindWhatComboBox.EnteredText))
            {
                this.InvokeIfRequired(
                    () => xyLOGIX.Win32.Interact.Messages.ShowStopError(
                        this, Resources.Error_FindWhat_MissingValue
                    )
                );

                hiddenFocusLabel.Focus();
                FindWhatComboBox.Focus();
                return false;
            }

            if (OperationsCheckedListBox.NoItemsAreSelected())
            {
                var canProceed = false;
                this.InvokeIfRequired(
                    () => canProceed =
                        xyLOGIX.Win32.Interact.Messages.ConfirmWithYesNo(
                            this, Resources.Error_FindWhat_MissingValue
                        ) != DialogResult.No
                );

                if (canProceed)
                {
                    SelectAllOperations();
                    return true;
                }

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
                this.InvokeIfRequired(
                    () => xyLOGIX.Win32.Interact.Messages.ShowStopError(
                        this, Resources.Error_Specify_ReplaceWith
                    )
                );

                hiddenFocusLabel.Focus();
                ReplaceWithComboBox.Focus();
                return false;
            }

            /* OKAY, scan the all the folders within the directory tree of the
                starting folder.  If even one of the folders has a name and contained
                <c>.csproj</c> name matching the replaceWith text identically, stop,
                and throw a warning to the user.

                At 14:28 hours MDT on 08/06/2023, we just nuked a bunch of our work by
                (a) having not committed early and often for an entire 1-1/2 days of coding, and
                (b) then running this app by setting the 'replaceWith' to match identically,
                the name of one of the projects already in the Solution.

                Therefore, if we encounter this situation, then we need to warn the user "Hey,
                do you really want to do this?"  So they can wake up and cancel the operation
                if need be.
            */

            if (Would.UserOverwriteExistingDirectory(
                    StartingFolderComboBox.EnteredText,
                    ReplaceWithComboBox.EnteredText
                ) && ShouldNotProceedDueToPotentialOverwrites())
            {
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

            this.InvokeIfRequired(
                () => xyLOGIX.Win32.Interact.Messages.ShowStopError(
                    this, Resources.Error_FindWhat_ReplaceWith_Identical
                )
            );

            hiddenFocusLabel.Focus();
            ReplaceWithComboBox.Focus();
            return false;
        }

        /// <summary>
        /// Exposes static methods to make determinations about data and the state of the
        /// system.
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
            /// or refers to a file that does actually exist on the file system.
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