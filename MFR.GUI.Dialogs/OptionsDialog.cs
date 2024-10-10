using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Dialogs.Properties;
using MFR.GUI.Models.Factories;
using MFR.GUI.Models.Interfaces;
using MFR.GUI.Windows.Presenters.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.UI.Dark.Forms;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Provides options to the user that allow the user to modify the
    /// application's behavior.
    /// </summary>
    public partial class OptionsDialog : DarkForm, IOptionsDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.OptionsDialog" />
        /// and returns a reference to it.
        /// </summary>
        public OptionsDialog()
        {
            InitializeComponent();

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Exit the Application When Operations Are Complete</b> checkbox.
        /// </summary>
        public bool AutoQuitOnCompletion
        {
            [DebuggerStepThrough] get => autoQuitOnCompletionCheckBox.Checked;
            [DebuggerStepThrough]
            set => autoQuitOnCompletionCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Email</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        public string CommitAuthorEmail
        {
            [DebuggerStepThrough] get => commitAuthorEmailTextBox.Text;
            [DebuggerStepThrough] set => commitAuthorEmailTextBox.Text = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Name</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        public string CommitAuthorName
        {
            [DebuggerStepThrough] get => commitAuthorNameTextBox.Text;
            [DebuggerStepThrough] set => commitAuthorNameTextBox.Text = value;
        }

        /// <summary>
        /// Gets or sets the text of the config File Pathname text box.
        /// </summary>
        public string ConfigPathname
        {
            [DebuggerStepThrough] get => configPathnameTextBox.Text;
            [DebuggerStepThrough] set => configPathnameTextBox.Text = value;
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
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfig CurrentConfiguration
            => ConfigProvider.CurrentConfiguration;

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Do not warn when Visual Studio is open but target Solution(s) aren't loaded</b>
        /// checkbox
        /// </summary>
        public bool DontPromptUserToReloadOpenSolution
        {
            [DebuggerStepThrough]
            get => dontPromptUserToReloadOpenSolutionCheckBox.Checked;
            [DebuggerStepThrough]
            set => dontPromptUserToReloadOpenSolutionCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface,
        /// representing the process(es), if running, that should be forcibly terminated
        /// prior to the execution of the <c>Rename Files in Folder</c> and
        /// <c>Rename Sub Folders</c> operations.
        /// </summary>
        public IList<IErrantProcessInfo> ErrantProcesses
        {
            [DebuggerStepThrough]
            get {
                var result = new AdvisableCollection<IErrantProcessInfo>();

                try
                {
                    if (errantProcessListBox == null) return result;
                    if (errantProcessListBox.IsDisposed) return result;
                    if (errantProcessListBox.Items.Count == 0) return result;

                    result.AddRange(
                        errantProcessListBox.Items.Cast<IErrantProcessInfo>()
                    );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = new AdvisableCollection<IErrantProcessInfo>();
                }

                return result;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the user has configured more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool HasErrantProcesses
        {
            get {
                var result = false;

                try
                {
                    if (errantProcessListBox == null) return result;
                    if (errantProcessListBox.IsDisposed) return result;

                    result = errantProcessListBox.Items.Count > 0;
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
        /// Gets a value indicating whether an entry is currently selected in the
        /// <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if an entry is currently selected in the
        /// <b>Errant Processes</b> list box; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsErrantProcessSelected
        {
            [DebuggerStepThrough]
            get {
                var result = false;

                try
                {
                    if (errantProcessListBox == null) return result;
                    if (errantProcessListBox.Items.Count > 0) return result;

                    result = errantProcessListBox.SelectedIndex >= 0;
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
        /// Gets a value that indicates whether the data in this dialog box has
        /// been modified.
        /// </summary>
        public bool IsModified
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] private set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Push Changes To Remote When Done</b> checkbox.
        /// </summary>
        public bool PushChangesToRemoteWhenDone
        {
            [DebuggerStepThrough] get => pushChangesWhenDoneCheckBox.Checked;
            [DebuggerStepThrough]
            set => pushChangesWhenDoneCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Reopen Visual Studio Solution</b> checkbox.
        /// </summary>
        public bool ReOpenSolution
        {
            [DebuggerStepThrough] get => reOpenSolutionCheckBox.Checked;
            [DebuggerStepThrough] set => reOpenSolutionCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface that
        /// represents the item that is currently selected, if any, in the
        /// <b>Errant Processes</b> list box on the <b>General</b> tab.
        /// </summary>
        /// <remarks>
        /// If there are no items currently in the list box, or none are currently
        /// selected, then this property returns a <see langword="null" /> reference.
        /// </remarks>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface;
        /// otherwise, a <see langword="null" /> reference is returned.
        /// </returns>
        public IErrantProcessInfo SelectedErrantProcess
        {
            get {
                IErrantProcessInfo result = default;

                try
                {
                    if (errantProcessListBox == null) return result;
                    if (errantProcessListBox.IsDisposed) return result;
                    if (errantProcessListBox.SelectedIndex < 0) return result;

                    result =
                        errantProcessListBox.SelectedItem as IErrantProcessInfo;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = default;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Pending Changes</b> checkbox.
        /// </summary>
        public bool ShouldCommitPendingChanges
        {
            [DebuggerStepThrough]
            get => commitPendingChangesBeforeOperationsCheckBox.Checked;
            [DebuggerStepThrough]
            set => commitPendingChangesBeforeOperationsCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Post-Operation Changes</b>
        /// checkbox.
        /// </summary>
        public bool ShouldCommitPostOperationChanges
        {
            [DebuggerStepThrough]
            get => commitPostOperationChangesCheckBox.Checked;
            [DebuggerStepThrough]
            set => commitPostOperationChangesCheckBox.Checked = value;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Update Local Git Repos When Automatically Started</b> checkbox.
        /// </summary>
        public bool UpdateGitOnAutoStart
        {
            get => updateGitOnAutoStartCheckBox.Checked;
            set => updateGitOnAutoStartCheckBox.Checked = value;
        }

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        public event ModifiedEventHandler Modified;

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

            if (DialogResult.OK == DialogResult) UpdateData();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            UpdateData(false); // move data from the config to the screen

            customizePendingChangeCommitMessageButton.Enabled =
                commitPendingChangesBeforeOperationsCheckBox.Checked;
            customizePostOperationChangesCommitMessageButton.Enabled =
                commitPostOperationChangesCheckBox.Checked;
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.OptionsDialog.Modified" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.ModifiedEventArgs" /> that contains the
        /// event data.
        /// </param>
        /// <remarks>
        /// If the <see cref="P:MFR.ModifiedEventArgs.Handled" />
        /// property is set <see langword="true" /> by the event's handler, then
        /// the <see cref="P:MFR.GUI.OptionsDialog.IsModified" /> will be set to
        /// <see langword="false" />.
        /// </remarks>
        protected virtual void OnModified(ModifiedEventArgs e)
        {
            if (Modified == null) return;

            UpdateData(); // save data from the screen

            Modified.Invoke(this, e);
            SetModifiedFlag(!e.Handled);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            SetModifiedFlag(false); // start us off as having no modified values
        }

        private void ClearErrantProcesses()
        {
            try
            {
                if (errantProcessListBox == null) return;
                if (errantProcessListBox.IsDisposed) return;
                if (errantProcessListBox.Items.Count == 0)
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessesToRemove
                    );
                    return;
                }

                errantProcessListBox.Items.Clear();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    this,
                    string.Format(
                        Resources.Error_FailedRemoveAllErrantProcesses,
                        ex.Message
                    )
                );
            }
        }

        private bool FileAlreadyIsInErrantProcessList(string pathname)
        {
            var result = false;

            try
            {
                if (!Does.FileExist(pathname)) return result;

                foreach (var errantProcess in ErrantProcesses.ToArray())
                {
                    if (errantProcess == null) continue;
                    if (!pathname.Equals(errantProcess.Pathname)) continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        private void OnAddErrantProcessButtonClicked(object sender, EventArgs e)
        {
            try
            {
                errantProcessSelectionDialog.InitialDirectory =
                    SpecialWindowsFolders.QuickAccess;
                if (DialogResult.Cancel ==
                    errantProcessSelectionDialog.ShowDialog(this))
                    return;

                if (FileAlreadyIsInErrantProcessList(
                        errantProcessSelectionDialog.FileName
                    ))
                {
                    Messages.ShowStopError(
                        this,
                        string.Format(
                            Resources.Error_ErrantProcessEntryAlreadyPresent,
                            errantProcessSelectionDialog.FileName
                        )
                    );
                    return;
                }

                errantProcessListBox.Items.Add(
                    MakeNewErrantProcessInfo.ForFile(
                        errantProcessSelectionDialog.FileName
                    )
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    this,
                    string.Format(
                        Resources.Error_FailedAddErrantProcessEntry, ex.Message
                    )
                );
            }
        }

        /// <summary>
        /// This method handles the
        /// <see cref="E:System.Windows.Forms.CheckBox.CheckedChanged" /> event for all the
        /// checkboxes on the tabs of this property sheet.
        /// </summary>
        /// <param name="sender">
        /// (Required.) Reference to the object that raised this
        /// event.
        /// </param>
        /// <param name="e">
        /// (Required.) A <see cref="T:System.EventArgs" /> that contains
        /// the event data.
        /// </param>
        /// <remarks>
        /// This method responds by calling the
        /// <see cref="M:MFR.GUI.Dialogs.OptionsDialog.SetModifiedFlag" /> method to
        /// mark this property sheet as dirty, so that the <b>Apply</b> button becomes
        /// available.
        /// <para />
        /// <b>NOTE:</b> When developers add a new checkbox to any of the tabs of this
        /// property sheet, they should bind this handler to the
        /// <see cref="E:System.Windows.Forms.CheckBox.CheckedChanged" /> event of that
        /// checkbox.
        /// </remarks>
        private void OnAnyCheckBoxCheckedChanged(object sender, EventArgs e)
            => SetModifiedFlag();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to respond to the value of the text inside the
        /// CurrentConfiguration File Pathname text box being changed. This method
        /// responds to such a happenstance by updating the value of the
        /// <see
        ///     cref="P:MFR.GUI.OptionsDialog.IsModified" />
        /// property to be
        /// <see
        ///     langword="true" />
        /// by calling the
        /// <see
        ///     cref="M:MFR.GUI.OptionsDialog.SetModifiedFlag" />
        /// method.
        /// </remarks>
        private void OnAnyTextBoxChanged(object sender, EventArgs e)
            => SetModifiedFlag();

        private void
            OnCheckedChangedCommitPendingChangesBeforeOperationsCheckBox(
                object sender,
                EventArgs e
            )
        {
            customizePendingChangeCommitMessageButton.Enabled =
                commitPendingChangesBeforeOperationsCheckBox.Checked;
            OnAnyCheckBoxCheckedChanged(sender, e);
        }

        private void OnCheckedChangedCommitPostOperationChangesCheckBox(
            object sender,
            EventArgs e
        )
        {
            customizePostOperationChangesCommitMessageButton.Enabled =
                commitPostOperationChangesCheckBox.Checked;
            OnAnyCheckBoxCheckedChanged(sender, e);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called in response to the user clicking the Apply
        /// button. We merely raise the
        /// <see
        ///     cref="E:MFR.GUI.OptionsDialog.Modified" />
        /// event in order to prompt
        /// the client of this dialog box to update data.
        /// </remarks>
        private void OnClickApply(object sender, EventArgs e)
        {
            cancelButton.Enabled =
                false; // now that we've "applied" options, the Cancel button doesn't mean anything
            OnModified(new ModifiedEventArgs());
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// for the Browse button on the config File Pathname text box..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to a click of the '...' button that lies next
        /// to the text box that accepts the pathname of the application's
        /// config file.
        /// </remarks>
        private void OnClickConfigPathnameBrowseButton(
            object sender,
            EventArgs e
        )
        {
            configPathBrowseBox.InitialDirectory =
                string.IsNullOrWhiteSpace(ConfigPathname)
                    ? Path.GetDirectoryName(ConfigProvider.ConfigFilePath)
                    : Path.GetDirectoryName(ConfigPathname);
            configPathBrowseBox.FileName =
                string.IsNullOrWhiteSpace(ConfigPathname)
                    ? ConfigProvider.ConfigFilePath
                    : ConfigPathname;

            if (configPathBrowseBox.ShowDialog(this) != DialogResult.OK)
                return;

            ConfigPathname = configPathBrowseBox.FileName;
        }

        private void OnClickCustomizePendingChangeCommitMessageButton(
            object sender,
            EventArgs e
        )
        {
            using (var dialog = new CustomizeCommitMessageDialog())
            {
                dialog.CommitMessageFormat = CurrentConfiguration
                    .PendingChangesCommitMessageFormat;
                dialog.DetailedCommitMessageFormat = CurrentConfiguration
                    .PendingChangesDetailedCommitMessageFormat;

                if (DialogResult.OK != dialog.ShowDialog(this)) return;

                CurrentConfiguration.PendingChangesCommitMessageFormat =
                    dialog.CommitMessageFormat;
                CurrentConfiguration.PendingChangesDetailedCommitMessageFormat =
                    dialog.DetailedCommitMessageFormat;
            }
        }

        private void OnClickCustomizePostOperationChangesCommitMessageButton(
            object sender,
            EventArgs e
        )
        {
            using (var dialog = new CustomizeCommitMessageDialog())
            {
                dialog.CommitMessageFormat = CurrentConfiguration
                    .PostOperationCommitMessageFormat;
                dialog.DetailedCommitMessageFormat = CurrentConfiguration
                    .PostOperationDetailedCommitMessageFormat;

                if (DialogResult.OK != dialog.ShowDialog(this)) return;

                CurrentConfiguration.PostOperationCommitMessageFormat =
                    dialog.CommitMessageFormat;
                CurrentConfiguration.PostOperationDetailedCommitMessageFormat =
                    dialog.DetailedCommitMessageFormat;
            }
        }

        private void OnEditErrantProcessButtonClicked(
            object sender,
            EventArgs e
        )
        {
            try
            {
                if (!IsErrantProcessSelected)
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessSelectedForEditing
                    );
                    return;
                }

                if (!HasErrantProcesses)
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessesToEdit
                    );
                    return;
                }

                var currentErrantProcessFolder =
                    Path.GetDirectoryName(SelectedErrantProcess.Pathname);
                if (string.IsNullOrWhiteSpace(currentErrantProcessFolder))
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessEntryPathname
                    );
                    return;
                }

                errantProcessSelectionDialog.InitialDirectory =
                    currentErrantProcessFolder;
                errantProcessSelectionDialog.FileName =
                    Path.GetFileName(SelectedErrantProcess.Pathname);

                if (DialogResult.Cancel ==
                    errantProcessSelectionDialog.ShowDialog(this))
                    return;

                SelectedErrantProcess.Pathname =
                    errantProcessSelectionDialog.FileName;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    this,
                    string.Format(
                        Resources.Error_FailedEditErrantProcessEntry, ex.Message
                    )
                );
            }
        }

        private void OnRemoveAllErrantProcessesButtonClicked(
            object sender,
            EventArgs e
        )
        {
            try
            {
                if (!HasErrantProcesses)
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessesToRemove
                    );
                    return;
                }

                if (DialogResult.No == Messages.ConfirmWithYesNo(
                        this, Resources.Question_ConfirmRemoveAllErrantProcesses
                    ))
                    return;

                ClearErrantProcesses();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    this,
                    string.Format(
                        Resources.Error_FailedRemoveAllErrantProcesses,
                        ex.Message
                    )
                );
            }
        }

        private void OnRemoveErrantProcessButtonClicked(
            object sender,
            EventArgs e
        )
        {
            try
            {
                if (!HasErrantProcesses)
                {
                    Messages.ShowStopError(
                        this, Resources.Error_NoErrantProcessesToRemove
                    );
                    return;
                }

                if (!IsErrantProcessSelected)
                {
                    Messages.ShowStopError(
                        this,
                        Resources.Error_NoErrantProcessToBeRemovedIsSelected
                    );
                    return;
                }

                if (DialogResult.No == Messages.ConfirmWithYesNo(
                        this,
                        $"Are you sure you want to remove the Errant Process entry having pathname, '{SelectedErrantProcess.Pathname}'?\n\nThis action cannot be undone."
                    ) && errantProcessListBox != null &&
                    !errantProcessListBox.IsDisposed)
                {
                    errantProcessListBox.Focus();
                    return;
                }

                errantProcessListBox.Items.RemoveAt(errantProcessListBox.SelectedIndex);
                errantProcessListBox.Focus();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    this,
                    string.Format(
                        Resources.Error_FailedRemoveErrantProcessEntry,
                        ex.Message
                    )
                );
            }
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Application.Idle" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to update the enabled or disabled state of controls.
        /// </remarks>
        [Log(AttributeExclude = true)] // do not log this method
        private void OnUpdateCmdUI(object sender, EventArgs e)
        {
            applyButton.Enabled = IsModified;
            addErrantProcessButton.Enabled = true;
            editErrantProcessButton.Enabled =
                removeErrantProcessButton.Enabled =
                    HasErrantProcesses && IsErrantProcessSelected;
            removeAllErrantProcessesButton.Enabled = HasErrantProcesses;
        }

        /// <summary>
        /// Sets the dirty state of the data of this dialog box.
        /// </summary>
        /// <param name="dirty">
        /// Set to <see langword="true" /> to indicate data has changed;
        /// <see
        ///     langword="false" />
        /// otherwise. Default is <see langword="true" />.
        /// </param>
        private void SetModifiedFlag(bool dirty = true)
            => IsModified = dirty;

        /// <summary>
        /// Moves data from this dialog's controls to the config object.
        /// </summary>
        /// <param name="bSaveAndValidate">
        /// (Required.) A <see cref="T:System.Boolean" />
        /// that specifies whether to save information from the screen into data variables.
        /// <see langword="false" /> to load data to the screen.
        /// </param>
        private void UpdateData(bool bSaveAndValidate = true)
        {
            if (bSaveAndValidate)
            {
                CurrentConfiguration.PushChangesToRemoteWhenDone =
                    PushChangesToRemoteWhenDone;
                CurrentConfiguration.AutoQuitOnCompletion =
                    AutoQuitOnCompletion;
                CurrentConfiguration.CommitAuthorName = CommitAuthorName;
                CurrentConfiguration.CommitAuthorEmail = CommitAuthorEmail;
                CurrentConfiguration.ReOpenSolution = ReOpenSolution;
                ConfigProvider.ConfigFilePath = ConfigPathname;
                CurrentConfiguration.PromptUserToReloadOpenSolution =
                    !DontPromptUserToReloadOpenSolution;
                CurrentConfiguration.ShouldCommitPostOperationChanges =
                    ShouldCommitPostOperationChanges;
                CurrentConfiguration.ShouldCommitPendingChanges =
                    ShouldCommitPendingChanges;
                CurrentConfiguration.UpdateGitOnAutoStart =
                    UpdateGitOnAutoStart;
            }
            else
            {
                UpdateGitOnAutoStart =
                    CurrentConfiguration.UpdateGitOnAutoStart;
                ShouldCommitPendingChanges =
                    CurrentConfiguration.ShouldCommitPendingChanges;
                ShouldCommitPostOperationChanges = CurrentConfiguration
                    .ShouldCommitPostOperationChanges;
                DontPromptUserToReloadOpenSolution = !CurrentConfiguration
                    .PromptUserToReloadOpenSolution;
                ReOpenSolution = CurrentConfiguration.ReOpenSolution;
                ConfigPathname = ConfigProvider.ConfigFilePath;
                CommitAuthorEmail = CurrentConfiguration.CommitAuthorEmail;
                CommitAuthorName = CurrentConfiguration.CommitAuthorName;
                AutoQuitOnCompletion =
                    CurrentConfiguration.AutoQuitOnCompletion;
                PushChangesToRemoteWhenDone =
                    CurrentConfiguration.PushChangesToRemoteWhenDone;
            }
        }
    }
}