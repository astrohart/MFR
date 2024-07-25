using System.ComponentModel;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs
{
    partial class OptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.applyButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.cancelButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.okayButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.optionsTabControl = new xyLOGIX.UI.Dark.Controls.DarkTabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.removeAllErrantProcessesButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.removeErrantProcessButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.errantProcessListBox = new xyLOGIX.UI.Dark.Controls.DarkListBox();
            this.editErrantProcessButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.addErrantProcessButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.killErrantProcessesCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.autoQuitOnCompletionCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.configurationTabPage = new System.Windows.Forms.TabPage();
            this.configPathnamePromptLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.configPathnameTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.configPathnameBrowseButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.configPathnameLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.visualStudioTabPage = new System.Windows.Forms.TabPage();
            this.darkLabel2 = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.dontPromptUserToReloadOpenSolutionCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.settingIgnoredNoteLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.reOpenSolutionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.reOpenSolutionCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.gitTabPage = new System.Windows.Forms.TabPage();
            this.updateGitOnAutoStartCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.committerInfoGroupBox = new xyLOGIX.UI.Dark.Controls.DarkGroupBox();
            this.commitAuthorEmailTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.commitAuthorNameTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.commitAuthorEmailLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.commitAuthorNameLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.pushChangesWhenDoneCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.customizePostOperationChangesCommitMessageButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.customizePendingChangeCommitMessageButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.commitPostOperationChangesCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.commitPendingChangesBeforeOperationsCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.configPathBrowseBox = new System.Windows.Forms.OpenFileDialog();
            this.errantProcessSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionsTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.configurationTabPage.SuspendLayout();
            this.visualStudioTabPage.SuspendLayout();
            this.gitTabPage.SuspendLayout();
            this.committerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.IsDarkTheme = true;
            this.applyButton.Location = new System.Drawing.Point(366, 392);
            this.applyButton.Name = "applyButton";
            this.applyButton.Padding = new System.Windows.Forms.Padding(5);
            this.applyButton.Size = new System.Drawing.Size(87, 27);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "&Apply";
            this.applyButton.Click += new System.EventHandler(this.OnClickApply);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.IsDarkTheme = true;
            this.cancelButton.Location = new System.Drawing.Point(273, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.IsDarkTheme = true;
            this.okayButton.Location = new System.Drawing.Point(180, 392);
            this.okayButton.Name = "okayButton";
            this.okayButton.Padding = new System.Windows.Forms.Padding(5);
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.ActiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.optionsTabControl.ActiveTabTextColor = System.Drawing.SystemColors.Highlight;
            this.optionsTabControl.Controls.Add(this.generalTabPage);
            this.optionsTabControl.Controls.Add(this.configurationTabPage);
            this.optionsTabControl.Controls.Add(this.visualStudioTabPage);
            this.optionsTabControl.Controls.Add(this.gitTabPage);
            this.optionsTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.optionsTabControl.InactiveTabBackColor = System.Drawing.Color.Empty;
            this.optionsTabControl.InactiveTabTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.optionsTabControl.IsDarkTheme = true;
            this.optionsTabControl.ItemSize = new System.Drawing.Size(0, 18);
            this.optionsTabControl.Location = new System.Drawing.Point(13, 13);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(444, 373);
            this.optionsTabControl.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.optionsTabControl.TabIndex = 0;
            this.optionsTabControl.TabWellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.generalTabPage.Controls.Add(this.removeAllErrantProcessesButton);
            this.generalTabPage.Controls.Add(this.removeErrantProcessButton);
            this.generalTabPage.Controls.Add(this.errantProcessListBox);
            this.generalTabPage.Controls.Add(this.editErrantProcessButton);
            this.generalTabPage.Controls.Add(this.addErrantProcessButton);
            this.generalTabPage.Controls.Add(this.killErrantProcessesCheckBox);
            this.generalTabPage.Controls.Add(this.autoQuitOnCompletionCheckBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(436, 347);
            this.generalTabPage.TabIndex = 2;
            this.generalTabPage.Text = "Ge&neral";
            // 
            // removeAllErrantProcessesButton
            // 
            this.removeAllErrantProcessesButton.IsDarkTheme = true;
            this.removeAllErrantProcessesButton.Location = new System.Drawing.Point(326, 303);
            this.removeAllErrantProcessesButton.Name = "removeAllErrantProcessesButton";
            this.removeAllErrantProcessesButton.Padding = new System.Windows.Forms.Padding(5);
            this.removeAllErrantProcessesButton.Size = new System.Drawing.Size(87, 27);
            this.removeAllErrantProcessesButton.TabIndex = 6;
            this.removeAllErrantProcessesButton.Text = "Re&move All";
            this.removeAllErrantProcessesButton.Click += new System.EventHandler(this.OnRemoveAllErrantProcessesButtonClicked);
            // 
            // removeErrantProcessButton
            // 
            this.removeErrantProcessButton.IsDarkTheme = true;
            this.removeErrantProcessButton.Location = new System.Drawing.Point(326, 270);
            this.removeErrantProcessButton.Name = "removeErrantProcessButton";
            this.removeErrantProcessButton.Padding = new System.Windows.Forms.Padding(5);
            this.removeErrantProcessButton.Size = new System.Drawing.Size(87, 27);
            this.removeErrantProcessButton.TabIndex = 5;
            this.removeErrantProcessButton.Text = "&Remove";
            this.removeErrantProcessButton.Click += new System.EventHandler(this.OnRemoveErrantProcessButtonClicked);
            // 
            // errantProcessListBox
            // 
            this.errantProcessListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.errantProcessListBox.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.errantProcessListBox.BorderThickness = 1;
            this.errantProcessListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.errantProcessListBox.FormattingEnabled = true;
            this.errantProcessListBox.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.errantProcessListBox.IsDarkTheme = true;
            this.errantProcessListBox.Location = new System.Drawing.Point(16, 131);
            this.errantProcessListBox.Name = "errantProcessListBox";
            this.errantProcessListBox.ScrollAlwaysVisible = true;
            this.errantProcessListBox.Size = new System.Drawing.Size(304, 199);
            this.errantProcessListBox.TabIndex = 2;
            // 
            // editErrantProcessButton
            // 
            this.editErrantProcessButton.IsDarkTheme = true;
            this.editErrantProcessButton.Location = new System.Drawing.Point(326, 164);
            this.editErrantProcessButton.Name = "editErrantProcessButton";
            this.editErrantProcessButton.Padding = new System.Windows.Forms.Padding(5);
            this.editErrantProcessButton.Size = new System.Drawing.Size(87, 27);
            this.editErrantProcessButton.TabIndex = 4;
            this.editErrantProcessButton.Text = "&Edit...";
            this.editErrantProcessButton.Click += new System.EventHandler(this.OnEditErrantProcessButtonClicked);
            // 
            // addErrantProcessButton
            // 
            this.addErrantProcessButton.IsDarkTheme = true;
            this.addErrantProcessButton.Location = new System.Drawing.Point(326, 131);
            this.addErrantProcessButton.Name = "addErrantProcessButton";
            this.addErrantProcessButton.Padding = new System.Windows.Forms.Padding(5);
            this.addErrantProcessButton.Size = new System.Drawing.Size(87, 27);
            this.addErrantProcessButton.TabIndex = 3;
            this.addErrantProcessButton.Text = "&Add...";
            this.addErrantProcessButton.Click += new System.EventHandler(this.OnAddErrantProcessButtonClicked);
            // 
            // killErrantProcessesCheckBox
            // 
            this.killErrantProcessesCheckBox.Checked = true;
            this.killErrantProcessesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.killErrantProcessesCheckBox.IsDarkTheme = false;
            this.killErrantProcessesCheckBox.Location = new System.Drawing.Point(16, 96);
            this.killErrantProcessesCheckBox.Name = "killErrantProcessesCheckBox";
            this.killErrantProcessesCheckBox.Size = new System.Drawing.Size(339, 17);
            this.killErrantProcessesCheckBox.TabIndex = 1;
            this.killErrantProcessesCheckBox.Text = "&Kill the following processes, if active, prior to operations:";
            // 
            // autoQuitOnCompletionCheckBox
            // 
            this.autoQuitOnCompletionCheckBox.Checked = true;
            this.autoQuitOnCompletionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoQuitOnCompletionCheckBox.IsDarkTheme = false;
            this.autoQuitOnCompletionCheckBox.Location = new System.Drawing.Point(16, 21);
            this.autoQuitOnCompletionCheckBox.Name = "autoQuitOnCompletionCheckBox";
            this.autoQuitOnCompletionCheckBox.Size = new System.Drawing.Size(304, 17);
            this.autoQuitOnCompletionCheckBox.TabIndex = 0;
            this.autoQuitOnCompletionCheckBox.Text = "E&xit the application when operations are completed";
            this.autoQuitOnCompletionCheckBox.CheckedChanged += new System.EventHandler(this.OnAnyCheckBoxCheckedChanged);
            // 
            // configurationTabPage
            // 
            this.configurationTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.configurationTabPage.Controls.Add(this.configPathnamePromptLabel);
            this.configurationTabPage.Controls.Add(this.configPathnameTextBox);
            this.configurationTabPage.Controls.Add(this.configPathnameBrowseButton);
            this.configurationTabPage.Controls.Add(this.configPathnameLabel);
            this.configurationTabPage.Location = new System.Drawing.Point(4, 22);
            this.configurationTabPage.Name = "configurationTabPage";
            this.configurationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.configurationTabPage.Size = new System.Drawing.Size(436, 347);
            this.configurationTabPage.TabIndex = 0;
            this.configurationTabPage.Text = "&Configuration";
            // 
            // configPathnamePromptLabel
            // 
            this.configPathnamePromptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.configPathnamePromptLabel.IsDarkTheme = false;
            this.configPathnamePromptLabel.Location = new System.Drawing.Point(17, 17);
            this.configPathnamePromptLabel.Name = "configPathnamePromptLabel";
            this.configPathnamePromptLabel.Size = new System.Drawing.Size(295, 37);
            this.configPathnamePromptLabel.TabIndex = 0;
            this.configPathnamePromptLabel.Text = "Where on your computer should we store the config file?";
            // 
            // configPathnameTextBox
            // 
            this.configPathnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.configPathnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configPathnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.configPathnameTextBox.IsDarkTheme = false;
            this.configPathnameTextBox.Location = new System.Drawing.Point(17, 85);
            this.configPathnameTextBox.Name = "configPathnameTextBox";
            this.configPathnameTextBox.Size = new System.Drawing.Size(382, 23);
            this.configPathnameTextBox.TabIndex = 2;
            this.configPathnameTextBox.TextChanged += new System.EventHandler(this.OnAnyTextBoxChanged);
            // 
            // configPathnameBrowseButton
            // 
            this.configPathnameBrowseButton.IsDarkTheme = false;
            this.configPathnameBrowseButton.Location = new System.Drawing.Point(405, 85);
            this.configPathnameBrowseButton.Name = "configPathnameBrowseButton";
            this.configPathnameBrowseButton.Padding = new System.Windows.Forms.Padding(5);
            this.configPathnameBrowseButton.Size = new System.Drawing.Size(25, 23);
            this.configPathnameBrowseButton.TabIndex = 3;
            this.configPathnameBrowseButton.Text = "...";
            this.configPathnameBrowseButton.Click += new System.EventHandler(this.OnClickConfigPathnameBrowseButton);
            // 
            // configPathnameLabel
            // 
            this.configPathnameLabel.AutoSize = true;
            this.configPathnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.configPathnameLabel.IsDarkTheme = false;
            this.configPathnameLabel.Location = new System.Drawing.Point(14, 67);
            this.configPathnameLabel.Name = "configPathnameLabel";
            this.configPathnameLabel.Size = new System.Drawing.Size(160, 15);
            this.configPathnameLabel.TabIndex = 1;
            this.configPathnameLabel.Text = "Con&figuration file pathname:";
            // 
            // visualStudioTabPage
            // 
            this.visualStudioTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.visualStudioTabPage.Controls.Add(this.darkLabel2);
            this.visualStudioTabPage.Controls.Add(this.dontPromptUserToReloadOpenSolutionCheckBox);
            this.visualStudioTabPage.Controls.Add(this.settingIgnoredNoteLabel);
            this.visualStudioTabPage.Controls.Add(this.reOpenSolutionLabel);
            this.visualStudioTabPage.Controls.Add(this.reOpenSolutionCheckBox);
            this.visualStudioTabPage.Location = new System.Drawing.Point(4, 22);
            this.visualStudioTabPage.Name = "visualStudioTabPage";
            this.visualStudioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visualStudioTabPage.Size = new System.Drawing.Size(436, 347);
            this.visualStudioTabPage.TabIndex = 1;
            this.visualStudioTabPage.Text = "&Visual Studio";
            // 
            // darkLabel2
            // 
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.darkLabel2.IsDarkTheme = false;
            this.darkLabel2.Location = new System.Drawing.Point(42, 112);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(331, 38);
            this.darkLabel2.TabIndex = 4;
            this.darkLabel2.Text = "Do not warn when Visual Studio is open but target Solution(s) aren\'t loaded";
            // 
            // dontPromptUserToReloadOpenSolutionCheckBox
            // 
            this.dontPromptUserToReloadOpenSolutionCheckBox.IsDarkTheme = false;
            this.dontPromptUserToReloadOpenSolutionCheckBox.Location = new System.Drawing.Point(18, 116);
            this.dontPromptUserToReloadOpenSolutionCheckBox.Name = "dontPromptUserToReloadOpenSolutionCheckBox";
            this.dontPromptUserToReloadOpenSolutionCheckBox.Size = new System.Drawing.Size(18, 14);
            this.dontPromptUserToReloadOpenSolutionCheckBox.TabIndex = 3;
            this.dontPromptUserToReloadOpenSolutionCheckBox.CheckedChanged += new System.EventHandler(this.OnAnyCheckBoxCheckedChanged);
            // 
            // settingIgnoredNoteLabel
            // 
            this.settingIgnoredNoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.settingIgnoredNoteLabel.IsDarkTheme = false;
            this.settingIgnoredNoteLabel.Location = new System.Drawing.Point(15, 63);
            this.settingIgnoredNoteLabel.Name = "settingIgnoredNoteLabel";
            this.settingIgnoredNoteLabel.Size = new System.Drawing.Size(405, 38);
            this.settingIgnoredNoteLabel.TabIndex = 2;
            this.settingIgnoredNoteLabel.Text = "NOTE: This setting is ignored if the Rename Folder(s) that Contain Solution(s) op" +
    "eration is enabled.";
            // 
            // reOpenSolutionLabel
            // 
            this.reOpenSolutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.reOpenSolutionLabel.IsDarkTheme = false;
            this.reOpenSolutionLabel.Location = new System.Drawing.Point(42, 14);
            this.reOpenSolutionLabel.Name = "reOpenSolutionLabel";
            this.reOpenSolutionLabel.Size = new System.Drawing.Size(331, 38);
            this.reOpenSolutionLabel.TabIndex = 1;
            this.reOpenSolutionLabel.Text = "Close and then re-open containing solution before\r\nand after operation(s)";
            // 
            // reOpenSolutionCheckBox
            // 
            this.reOpenSolutionCheckBox.Checked = true;
            this.reOpenSolutionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reOpenSolutionCheckBox.IsDarkTheme = false;
            this.reOpenSolutionCheckBox.Location = new System.Drawing.Point(18, 18);
            this.reOpenSolutionCheckBox.Name = "reOpenSolutionCheckBox";
            this.reOpenSolutionCheckBox.Size = new System.Drawing.Size(18, 14);
            this.reOpenSolutionCheckBox.TabIndex = 0;
            this.reOpenSolutionCheckBox.CheckedChanged += new System.EventHandler(this.OnAnyCheckBoxCheckedChanged);
            // 
            // gitTabPage
            // 
            this.gitTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.gitTabPage.Controls.Add(this.updateGitOnAutoStartCheckBox);
            this.gitTabPage.Controls.Add(this.committerInfoGroupBox);
            this.gitTabPage.Controls.Add(this.pushChangesWhenDoneCheckBox);
            this.gitTabPage.Controls.Add(this.customizePostOperationChangesCommitMessageButton);
            this.gitTabPage.Controls.Add(this.customizePendingChangeCommitMessageButton);
            this.gitTabPage.Controls.Add(this.commitPostOperationChangesCheckBox);
            this.gitTabPage.Controls.Add(this.commitPendingChangesBeforeOperationsCheckBox);
            this.gitTabPage.Location = new System.Drawing.Point(4, 22);
            this.gitTabPage.Name = "gitTabPage";
            this.gitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gitTabPage.Size = new System.Drawing.Size(436, 347);
            this.gitTabPage.TabIndex = 3;
            this.gitTabPage.Text = "&Git";
            // 
            // updateGitOnAutoStartCheckBox
            // 
            this.updateGitOnAutoStartCheckBox.IsDarkTheme = false;
            this.updateGitOnAutoStartCheckBox.Location = new System.Drawing.Point(21, 180);
            this.updateGitOnAutoStartCheckBox.Name = "updateGitOnAutoStartCheckBox";
            this.updateGitOnAutoStartCheckBox.Size = new System.Drawing.Size(345, 17);
            this.updateGitOnAutoStartCheckBox.TabIndex = 5;
            this.updateGitOnAutoStartCheckBox.Text = "&Update local Git repos even when automatically started";
            this.updateGitOnAutoStartCheckBox.CheckedChanged += new System.EventHandler(this.OnAnyCheckBoxCheckedChanged);
            // 
            // committerInfoGroupBox
            // 
            this.committerInfoGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.committerInfoGroupBox.Controls.Add(this.commitAuthorEmailTextBox);
            this.committerInfoGroupBox.Controls.Add(this.commitAuthorNameTextBox);
            this.committerInfoGroupBox.Controls.Add(this.commitAuthorEmailLabel);
            this.committerInfoGroupBox.Controls.Add(this.commitAuthorNameLabel);
            this.committerInfoGroupBox.IsDarkTheme = false;
            this.committerInfoGroupBox.Location = new System.Drawing.Point(21, 207);
            this.committerInfoGroupBox.Name = "committerInfoGroupBox";
            this.committerInfoGroupBox.Size = new System.Drawing.Size(396, 123);
            this.committerInfoGroupBox.TabIndex = 6;
            this.committerInfoGroupBox.TabStop = false;
            this.committerInfoGroupBox.Text = "&Commit author information";
            // 
            // commitAuthorEmailTextBox
            // 
            this.commitAuthorEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.commitAuthorEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commitAuthorEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitAuthorEmailTextBox.IsDarkTheme = false;
            this.commitAuthorEmailTextBox.Location = new System.Drawing.Point(73, 64);
            this.commitAuthorEmailTextBox.Name = "commitAuthorEmailTextBox";
            this.commitAuthorEmailTextBox.Size = new System.Drawing.Size(293, 23);
            this.commitAuthorEmailTextBox.TabIndex = 3;
            this.commitAuthorEmailTextBox.TextChanged += new System.EventHandler(this.OnAnyTextBoxChanged);
            // 
            // commitAuthorNameTextBox
            // 
            this.commitAuthorNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.commitAuthorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commitAuthorNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitAuthorNameTextBox.IsDarkTheme = false;
            this.commitAuthorNameTextBox.Location = new System.Drawing.Point(73, 32);
            this.commitAuthorNameTextBox.Name = "commitAuthorNameTextBox";
            this.commitAuthorNameTextBox.Size = new System.Drawing.Size(293, 23);
            this.commitAuthorNameTextBox.TabIndex = 1;
            this.commitAuthorNameTextBox.TextChanged += new System.EventHandler(this.OnAnyTextBoxChanged);
            // 
            // commitAuthorEmailLabel
            // 
            this.commitAuthorEmailLabel.AutoSize = true;
            this.commitAuthorEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitAuthorEmailLabel.IsDarkTheme = false;
            this.commitAuthorEmailLabel.Location = new System.Drawing.Point(25, 66);
            this.commitAuthorEmailLabel.Name = "commitAuthorEmailLabel";
            this.commitAuthorEmailLabel.Size = new System.Drawing.Size(39, 15);
            this.commitAuthorEmailLabel.TabIndex = 2;
            this.commitAuthorEmailLabel.Text = "&Email:";
            // 
            // commitAuthorNameLabel
            // 
            this.commitAuthorNameLabel.AutoSize = true;
            this.commitAuthorNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitAuthorNameLabel.IsDarkTheme = false;
            this.commitAuthorNameLabel.Location = new System.Drawing.Point(25, 34);
            this.commitAuthorNameLabel.Name = "commitAuthorNameLabel";
            this.commitAuthorNameLabel.Size = new System.Drawing.Size(42, 15);
            this.commitAuthorNameLabel.TabIndex = 0;
            this.commitAuthorNameLabel.Text = "&Name:";
            // 
            // pushChangesWhenDoneCheckBox
            // 
            this.pushChangesWhenDoneCheckBox.IsDarkTheme = false;
            this.pushChangesWhenDoneCheckBox.Location = new System.Drawing.Point(21, 155);
            this.pushChangesWhenDoneCheckBox.Name = "pushChangesWhenDoneCheckBox";
            this.pushChangesWhenDoneCheckBox.Size = new System.Drawing.Size(345, 17);
            this.pushChangesWhenDoneCheckBox.TabIndex = 4;
            this.pushChangesWhenDoneCheckBox.Text = "&Push changes to remote when done";
            this.pushChangesWhenDoneCheckBox.CheckedChanged += new System.EventHandler(this.OnAnyCheckBoxCheckedChanged);
            // 
            // customizePostOperationChangesCommitMessageButton
            // 
            this.customizePostOperationChangesCommitMessageButton.IsDarkTheme = true;
            this.customizePostOperationChangesCommitMessageButton.Location = new System.Drawing.Point(21, 115);
            this.customizePostOperationChangesCommitMessageButton.Name = "customizePostOperationChangesCommitMessageButton";
            this.customizePostOperationChangesCommitMessageButton.Padding = new System.Windows.Forms.Padding(5);
            this.customizePostOperationChangesCommitMessageButton.Size = new System.Drawing.Size(205, 27);
            this.customizePostOperationChangesCommitMessageButton.TabIndex = 3;
            this.customizePostOperationChangesCommitMessageButton.Text = "Customi&ze commit message....";
            this.customizePostOperationChangesCommitMessageButton.Click += new System.EventHandler(this.OnClickCustomizePostOperationChangesCommitMessageButton);
            // 
            // customizePendingChangeCommitMessageButton
            // 
            this.customizePendingChangeCommitMessageButton.IsDarkTheme = true;
            this.customizePendingChangeCommitMessageButton.Location = new System.Drawing.Point(21, 48);
            this.customizePendingChangeCommitMessageButton.Name = "customizePendingChangeCommitMessageButton";
            this.customizePendingChangeCommitMessageButton.Padding = new System.Windows.Forms.Padding(5);
            this.customizePendingChangeCommitMessageButton.Size = new System.Drawing.Size(205, 27);
            this.customizePendingChangeCommitMessageButton.TabIndex = 1;
            this.customizePendingChangeCommitMessageButton.Text = "C&ustomize commit message....";
            this.customizePendingChangeCommitMessageButton.Click += new System.EventHandler(this.OnClickCustomizePendingChangeCommitMessageButton);
            // 
            // commitPostOperationChangesCheckBox
            // 
            this.commitPostOperationChangesCheckBox.IsDarkTheme = false;
            this.commitPostOperationChangesCheckBox.Location = new System.Drawing.Point(21, 92);
            this.commitPostOperationChangesCheckBox.Name = "commitPostOperationChangesCheckBox";
            this.commitPostOperationChangesCheckBox.Size = new System.Drawing.Size(345, 17);
            this.commitPostOperationChangesCheckBox.TabIndex = 2;
            this.commitPostOperationChangesCheckBox.Text = "Commi&t change(s) that result from performing operation(s)";
            this.commitPostOperationChangesCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChangedCommitPostOperationChangesCheckBox);
            // 
            // commitPendingChangesBeforeOperationsCheckBox
            // 
            this.commitPendingChangesBeforeOperationsCheckBox.IsDarkTheme = false;
            this.commitPendingChangesBeforeOperationsCheckBox.Location = new System.Drawing.Point(21, 24);
            this.commitPendingChangesBeforeOperationsCheckBox.Name = "commitPendingChangesBeforeOperationsCheckBox";
            this.commitPendingChangesBeforeOperationsCheckBox.Size = new System.Drawing.Size(345, 17);
            this.commitPendingChangesBeforeOperationsCheckBox.TabIndex = 0;
            this.commitPendingChangesBeforeOperationsCheckBox.Text = "Co&mmit my pending changes before starting operation(s)";
            this.commitPendingChangesBeforeOperationsCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChangedCommitPendingChangesBeforeOperationsCheckBox);
            // 
            // configPathBrowseBox
            // 
            this.configPathBrowseBox.DefaultExt = "json";
            this.configPathBrowseBox.FileName = "config.json";
            this.configPathBrowseBox.Filter = "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*";
            this.configPathBrowseBox.RestoreDirectory = true;
            this.configPathBrowseBox.Title = "Browse";
            // 
            // errantProcessSelectionDialog
            // 
            this.errantProcessSelectionDialog.DefaultExt = "json";
            this.errantProcessSelectionDialog.FileName = "*.exe";
            this.errantProcessSelectionDialog.Filter = "Application (*.exe)|*.exe";
            this.errantProcessSelectionDialog.RestoreDirectory = true;
            this.errantProcessSelectionDialog.Title = "Add Errant Process Entry";
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(469, 431);
            this.Controls.Add(this.optionsTabControl);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.optionsTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.configurationTabPage.ResumeLayout(false);
            this.configurationTabPage.PerformLayout();
            this.visualStudioTabPage.ResumeLayout(false);
            this.gitTabPage.ResumeLayout(false);
            this.committerInfoGroupBox.ResumeLayout(false);
            this.committerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private xyLOGIX.UI.Dark.Controls.DarkButton applyButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton cancelButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton okayButton;
        private xyLOGIX.UI.Dark.Controls.DarkTabControl optionsTabControl;
        private System.Windows.Forms.TabPage configurationTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkLabel configPathnameLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox configPathnameTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkButton configPathnameBrowseButton;
        private xyLOGIX.UI.Dark.Controls.DarkLabel configPathnamePromptLabel;
        private System.Windows.Forms.OpenFileDialog configPathBrowseBox;
        private System.Windows.Forms.TabPage visualStudioTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox reOpenSolutionCheckBox;
        private TabPage generalTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox autoQuitOnCompletionCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel reOpenSolutionLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel settingIgnoredNoteLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel darkLabel2;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox dontPromptUserToReloadOpenSolutionCheckBox;
        private TabPage gitTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkButton customizePendingChangeCommitMessageButton;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox commitPostOperationChangesCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox commitPendingChangesBeforeOperationsCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkButton customizePostOperationChangesCommitMessageButton;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox pushChangesWhenDoneCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkGroupBox committerInfoGroupBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel commitAuthorEmailLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel commitAuthorNameLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox commitAuthorEmailTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox commitAuthorNameTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox updateGitOnAutoStartCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox killErrantProcessesCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkListBox errantProcessListBox;
        private xyLOGIX.UI.Dark.Controls.DarkButton editErrantProcessButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton addErrantProcessButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton removeErrantProcessButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton removeAllErrantProcessesButton;
        private OpenFileDialog errantProcessSelectionDialog;
    }
}