using System.ComponentModel;

namespace MFR.GUI.Windows
{
   partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.startingFolderLabel = new System.Windows.Forms.Label();
            this.startingFolderBrowseButton = new System.Windows.Forms.Button();
            this.findWhatLabel = new System.Windows.Forms.Label();
            this.replaceWithLabel = new System.Windows.Forms.Label();
            this.performOperationButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsPerform = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsSaveProfileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigApplyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsConfigNewProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearStartingFolderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearFindWhatHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearReplaceWithHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.findReplaceOptionsTabPage = new System.Windows.Forms.TabPage();
            this.matchExactWordCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.operationsTabPage = new System.Windows.Forms.TabPage();
            this.tabPageInstructionLabel = new System.Windows.Forms.Label();
            this.selectDeselectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.operationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.inclusionsTabPage = new System.Windows.Forms.TabPage();
            this.exclusionsTabPage = new System.Windows.Forms.TabPage();
            this.foldButton = new MFR.GUI.Controls.FoldUnfoldButton();
            this.hiddenFocusLabel = new System.Windows.Forms.Label();
            this.standardToolBar = new System.Windows.Forms.ToolStrip();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newProfileButton = new System.Windows.Forms.ToolStripButton();
            this.saveProfileButton = new System.Windows.Forms.ToolStripButton();
            this.manageProfilesButton = new System.Windows.Forms.ToolStripButton();
            this.profileListComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportConfigButton = new System.Windows.Forms.ToolStripButton();
            this.importConfigButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.switchButton = new System.Windows.Forms.Button();
            this.replaceWithComboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.findWhatcomboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.startingFolderComboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.optionsTabControl.SuspendLayout();
            this.findReplaceOptionsTabPage.SuspendLayout();
            this.operationsTabPage.SuspendLayout();
            this.standardToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingFolderLabel
            // 
            this.startingFolderLabel.AutoSize = true;
            this.startingFolderLabel.Location = new System.Drawing.Point(12, 62);
            this.startingFolderLabel.Name = "startingFolderLabel";
            this.startingFolderLabel.Size = new System.Drawing.Size(226, 15);
            this.startingFolderLabel.TabIndex = 0;
            this.startingFolderLabel.Text = "What &folder should the operation start in?";
            // 
            // startingFolderBrowseButton
            // 
            this.startingFolderBrowseButton.Location = new System.Drawing.Point(560, 78);
            this.startingFolderBrowseButton.Name = "startingFolderBrowseButton";
            this.startingFolderBrowseButton.Size = new System.Drawing.Size(24, 27);
            this.startingFolderBrowseButton.TabIndex = 2;
            this.startingFolderBrowseButton.Text = "...";
            this.startingFolderBrowseButton.UseVisualStyleBackColor = true;
            this.startingFolderBrowseButton.Click += new System.EventHandler(this.OnClickBrowseForStartingFolder);
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.AutoSize = true;
            this.findWhatLabel.Location = new System.Drawing.Point(9, 117);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(109, 15);
            this.findWhatLabel.TabIndex = 3;
            this.findWhatLabel.Text = "&Text to be replaced:";
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.AutoSize = true;
            this.replaceWithLabel.Location = new System.Drawing.Point(9, 171);
            this.replaceWithLabel.Name = "replaceWithLabel";
            this.replaceWithLabel.Size = new System.Drawing.Size(64, 15);
            this.replaceWithLabel.TabIndex = 5;
            this.replaceWithLabel.Text = "&With what:";
            // 
            // performOperationButton
            // 
            this.performOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.performOperationButton.Image = ((System.Drawing.Image)(resources.GetObject("performOperationButton.Image")));
            this.performOperationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.performOperationButton.Location = new System.Drawing.Point(459, 219);
            this.performOperationButton.Name = "performOperationButton";
            this.performOperationButton.Size = new System.Drawing.Size(128, 27);
            this.performOperationButton.TabIndex = 8;
            this.performOperationButton.Text = "&Perform Operation";
            this.performOperationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.performOperationButton.UseVisualStyleBackColor = true;
            this.performOperationButton.Click += new System.EventHandler(this.OnClickPerformOperation);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMessage,
            this.statusBarProgressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 482);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(596, 22);
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarMessage
            // 
            this.statusBarMessage.Name = "statusBarMessage";
            this.statusBarMessage.Size = new System.Drawing.Size(581, 17);
            this.statusBarMessage.Spring = true;
            this.statusBarMessage.Text = "Ready";
            this.statusBarMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBarProgressBar
            // 
            this.statusBarProgressBar.MarqueeAnimationSpeed = 300;
            this.statusBarProgressBar.Name = "statusBarProgressBar";
            this.statusBarProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusBarProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusBarProgressBar.Visible = false;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.operationsMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(596, 24);
            this.menuBar.TabIndex = 10;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(93, 22);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolBar,
            this.viewStatusBar});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // viewToolBar
            // 
            this.viewToolBar.Checked = true;
            this.viewToolBar.CheckOnClick = true;
            this.viewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolBar.Name = "viewToolBar";
            this.viewToolBar.Size = new System.Drawing.Size(126, 22);
            this.viewToolBar.Text = "&Toolbar";
            this.viewToolBar.Click += new System.EventHandler(this.OnViewToolBar);
            // 
            // viewStatusBar
            // 
            this.viewStatusBar.Checked = true;
            this.viewStatusBar.CheckOnClick = true;
            this.viewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewStatusBar.Name = "viewStatusBar";
            this.viewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.viewStatusBar.Text = "&Status Bar";
            this.viewStatusBar.Click += new System.EventHandler(this.OnViewStatusBar);
            // 
            // operationsMenu
            // 
            this.operationsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsPerform});
            this.operationsMenu.Name = "operationsMenu";
            this.operationsMenu.Size = new System.Drawing.Size(77, 20);
            this.operationsMenu.Text = "&Operations";
            // 
            // operationsPerform
            // 
            this.operationsPerform.Name = "operationsPerform";
            this.operationsPerform.Size = new System.Drawing.Size(117, 22);
            this.operationsPerform.Text = "&Perform";
            this.operationsPerform.Click += new System.EventHandler(this.OnOperationsPerform);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsConfigMenu,
            this.toolStripSeparator1,
            this.toolsOptions});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsConfigMenu
            // 
            this.toolsConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsConfigImport,
            this.toolsConfigExport,
            this.toolStripSeparator2,
            this.toolsSaveProfileAs,
            this.toolsConfigApplyProfile,
            this.toolsConfigProfiles,
            this.toolsConfigNewProfile,
            this.toolStripSeparator5,
            this.toolsHistoryMenu});
            this.toolsConfigMenu.Name = "toolsConfigMenu";
            this.toolsConfigMenu.Size = new System.Drawing.Size(148, 22);
            this.toolsConfigMenu.Text = "&Configuration";
            // 
            // toolsConfigImport
            // 
            this.toolsConfigImport.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigImport.Image")));
            this.toolsConfigImport.Name = "toolsConfigImport";
            this.toolsConfigImport.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigImport.Text = "&Import...";
            this.toolsConfigImport.Click += new System.EventHandler(this.OnToolsConfigImport);
            // 
            // toolsConfigExport
            // 
            this.toolsConfigExport.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigExport.Image")));
            this.toolsConfigExport.Name = "toolsConfigExport";
            this.toolsConfigExport.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigExport.Text = "&Export...";
            this.toolsConfigExport.Click += new System.EventHandler(this.OnToolsExportConfig);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // toolsSaveProfileAs
            // 
            this.toolsSaveProfileAs.Image = ((System.Drawing.Image)(resources.GetObject("toolsSaveProfileAs.Image")));
            this.toolsSaveProfileAs.Name = "toolsSaveProfileAs";
            this.toolsSaveProfileAs.Size = new System.Drawing.Size(159, 22);
            this.toolsSaveProfileAs.Text = "&Save Profile As";
            // 
            // toolsConfigApplyProfile
            // 
            this.toolsConfigApplyProfile.Name = "toolsConfigApplyProfile";
            this.toolsConfigApplyProfile.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigApplyProfile.Text = "&Apply Profile";
            // 
            // toolsConfigProfiles
            // 
            this.toolsConfigProfiles.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigProfiles.Image")));
            this.toolsConfigProfiles.ImageTransparentColor = System.Drawing.Color.White;
            this.toolsConfigProfiles.Name = "toolsConfigProfiles";
            this.toolsConfigProfiles.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigProfiles.Text = "&Manage Profiles";
            // 
            // toolsConfigNewProfile
            // 
            this.toolsConfigNewProfile.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigNewProfile.Image")));
            this.toolsConfigNewProfile.Name = "toolsConfigNewProfile";
            this.toolsConfigNewProfile.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigNewProfile.Text = "&New Profile";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // toolsHistoryMenu
            // 
            this.toolsHistoryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsHistoryClearAll,
            this.toolsHistoryClearMenu});
            this.toolsHistoryMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsHistoryMenu.Image")));
            this.toolsHistoryMenu.Name = "toolsHistoryMenu";
            this.toolsHistoryMenu.Size = new System.Drawing.Size(159, 22);
            this.toolsHistoryMenu.Text = "&History";
            // 
            // toolsHistoryClearAll
            // 
            this.toolsHistoryClearAll.Image = ((System.Drawing.Image)(resources.GetObject("toolsHistoryClearAll.Image")));
            this.toolsHistoryClearAll.Name = "toolsHistoryClearAll";
            this.toolsHistoryClearAll.Size = new System.Drawing.Size(163, 22);
            this.toolsHistoryClearAll.Text = "&Clear";
            // 
            // toolsHistoryClearMenu
            // 
            this.toolsHistoryClearMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsHistoryClearStartingFolderHistory,
            this.toolsHistoryClearFindWhatHistory,
            this.toolsHistoryClearReplaceWithHistory});
            this.toolsHistoryClearMenu.Name = "toolsHistoryClearMenu";
            this.toolsHistoryClearMenu.Size = new System.Drawing.Size(163, 22);
            this.toolsHistoryClearMenu.Text = "Clear &Specifically";
            // 
            // toolsHistoryClearStartingFolderHistory
            // 
            this.toolsHistoryClearStartingFolderHistory.Name = "toolsHistoryClearStartingFolderHistory";
            this.toolsHistoryClearStartingFolderHistory.Size = new System.Drawing.Size(192, 22);
            this.toolsHistoryClearStartingFolderHistory.Text = "&Starting Folder History";
            // 
            // toolsHistoryClearFindWhatHistory
            // 
            this.toolsHistoryClearFindWhatHistory.Name = "toolsHistoryClearFindWhatHistory";
            this.toolsHistoryClearFindWhatHistory.Size = new System.Drawing.Size(192, 22);
            this.toolsHistoryClearFindWhatHistory.Text = "&Find What History";
            // 
            // toolsHistoryClearReplaceWithHistory
            // 
            this.toolsHistoryClearReplaceWithHistory.Name = "toolsHistoryClearReplaceWithHistory";
            this.toolsHistoryClearReplaceWithHistory.Size = new System.Drawing.Size(192, 22);
            this.toolsHistoryClearReplaceWithHistory.Text = "&ReplaceWIthHistory";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolsOptions
            // 
            this.toolsOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolsOptions.Image")));
            this.toolsOptions.ImageTransparentColor = System.Drawing.Color.White;
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(148, 22);
            this.toolsOptions.Text = "&Options";
            this.toolsOptions.Click += new System.EventHandler(this.OnToolsOptions);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            this.helpMenu.DropDownOpening += new System.EventHandler(this.OnHelpMenuDropDownOpening);
            // 
            // helpAbout
            // 
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(165, 22);
            this.helpAbout.Text = "&About [App Title]";
            this.helpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.findReplaceOptionsTabPage);
            this.optionsTabControl.Controls.Add(this.operationsTabPage);
            this.optionsTabControl.Controls.Add(this.inclusionsTabPage);
            this.optionsTabControl.Controls.Add(this.exclusionsTabPage);
            this.optionsTabControl.Location = new System.Drawing.Point(15, 262);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(569, 210);
            this.optionsTabControl.TabIndex = 11;
            // 
            // findReplaceOptionsTabPage
            // 
            this.findReplaceOptionsTabPage.Controls.Add(this.matchExactWordCheckBox);
            this.findReplaceOptionsTabPage.Controls.Add(this.matchCaseCheckBox);
            this.findReplaceOptionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.findReplaceOptionsTabPage.Name = "findReplaceOptionsTabPage";
            this.findReplaceOptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.findReplaceOptionsTabPage.Size = new System.Drawing.Size(561, 182);
            this.findReplaceOptionsTabPage.TabIndex = 0;
            this.findReplaceOptionsTabPage.Text = "Find/Replace Options";
            this.findReplaceOptionsTabPage.UseVisualStyleBackColor = true;
            // 
            // matchExactWordCheckBox
            // 
            this.matchExactWordCheckBox.AutoSize = true;
            this.matchExactWordCheckBox.Location = new System.Drawing.Point(7, 33);
            this.matchExactWordCheckBox.Name = "matchExactWordCheckBox";
            this.matchExactWordCheckBox.Size = new System.Drawing.Size(121, 19);
            this.matchExactWordCheckBox.TabIndex = 1;
            this.matchExactWordCheckBox.Text = "Match e&xact word";
            this.matchExactWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(7, 7);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(86, 19);
            this.matchCaseCheckBox.TabIndex = 0;
            this.matchCaseCheckBox.Text = "Match &case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // operationsTabPage
            // 
            this.operationsTabPage.Controls.Add(this.tabPageInstructionLabel);
            this.operationsTabPage.Controls.Add(this.selectDeselectAllCheckBox);
            this.operationsTabPage.Controls.Add(this.operationsCheckedListBox);
            this.operationsTabPage.Location = new System.Drawing.Point(4, 24);
            this.operationsTabPage.Name = "operationsTabPage";
            this.operationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.operationsTabPage.Size = new System.Drawing.Size(561, 182);
            this.operationsTabPage.TabIndex = 1;
            this.operationsTabPage.Text = "Operations";
            this.operationsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPageInstructionLabel
            // 
            this.tabPageInstructionLabel.AutoSize = true;
            this.tabPageInstructionLabel.Location = new System.Drawing.Point(8, 12);
            this.tabPageInstructionLabel.Name = "tabPageInstructionLabel";
            this.tabPageInstructionLabel.Size = new System.Drawing.Size(128, 15);
            this.tabPageInstructionLabel.TabIndex = 2;
            this.tabPageInstructionLabel.Text = "&Operations to perform:";
            // 
            // selectDeselectAllCheckBox
            // 
            this.selectDeselectAllCheckBox.AutoSize = true;
            this.selectDeselectAllCheckBox.Location = new System.Drawing.Point(11, 34);
            this.selectDeselectAllCheckBox.Name = "selectDeselectAllCheckBox";
            this.selectDeselectAllCheckBox.Size = new System.Drawing.Size(120, 19);
            this.selectDeselectAllCheckBox.TabIndex = 1;
            this.selectDeselectAllCheckBox.Text = "Select/deselect all";
            this.selectDeselectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectDeselectAllCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChangedSelectDeselectAllCheckBox);
            // 
            // operationsCheckedListBox
            // 
            this.operationsCheckedListBox.FormattingEnabled = true;
            this.operationsCheckedListBox.Items.AddRange(new object[] {
            "Rename Files",
            "Rename Subfolders",
            "Replace in Files"});
            this.operationsCheckedListBox.Location = new System.Drawing.Point(11, 57);
            this.operationsCheckedListBox.Name = "operationsCheckedListBox";
            this.operationsCheckedListBox.ScrollAlwaysVisible = true;
            this.operationsCheckedListBox.Size = new System.Drawing.Size(539, 112);
            this.operationsCheckedListBox.Sorted = true;
            this.operationsCheckedListBox.TabIndex = 0;
            // 
            // inclusionsTabPage
            // 
            this.inclusionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.inclusionsTabPage.Name = "inclusionsTabPage";
            this.inclusionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inclusionsTabPage.Size = new System.Drawing.Size(561, 182);
            this.inclusionsTabPage.TabIndex = 2;
            this.inclusionsTabPage.Text = "Inclusions";
            this.inclusionsTabPage.UseVisualStyleBackColor = true;
            // 
            // exclusionsTabPage
            // 
            this.exclusionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.exclusionsTabPage.Name = "exclusionsTabPage";
            this.exclusionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exclusionsTabPage.Size = new System.Drawing.Size(561, 182);
            this.exclusionsTabPage.TabIndex = 3;
            this.exclusionsTabPage.Text = "Exclusions";
            this.exclusionsTabPage.UseVisualStyleBackColor = true;
            // 
            // foldButton
            // 
            this.foldButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.foldButton.FormFoldedSize = new System.Drawing.Size(612, 294);
            this.foldButton.FormUnfoldedSize = new System.Drawing.Size(612, 515);
            this.foldButton.Location = new System.Drawing.Point(15, 219);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(87, 27);
            this.foldButton.TabIndex = 7;
            this.foldButton.Text = "&More >>";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.FormFolded += new MFR.GUI.Controls.Events.FormFoldedEventHandler(this.OnFormFolded);
            // 
            // hiddenFocusLabel
            // 
            this.hiddenFocusLabel.AutoSize = true;
            this.hiddenFocusLabel.Location = new System.Drawing.Point(648, 245);
            this.hiddenFocusLabel.Name = "hiddenFocusLabel";
            this.hiddenFocusLabel.Size = new System.Drawing.Size(0, 15);
            this.hiddenFocusLabel.TabIndex = 12;
            this.hiddenFocusLabel.Visible = false;
            // 
            // standardToolBar
            // 
            this.standardToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.standardToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goButton,
            this.toolStripSeparator3,
            this.newProfileButton,
            this.saveProfileButton,
            this.manageProfilesButton,
            this.profileListComboBox,
            this.toolStripSeparator4,
            this.exportConfigButton,
            this.importConfigButton,
            this.toolStripSeparator6,
            this.clearAllHistoryButton});
            this.standardToolBar.Location = new System.Drawing.Point(0, 24);
            this.standardToolBar.Name = "standardToolBar";
            this.standardToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.standardToolBar.Size = new System.Drawing.Size(596, 25);
            this.standardToolBar.TabIndex = 13;
            this.standardToolBar.Text = "Standard";
            // 
            // goButton
            // 
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.White;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(42, 22);
            this.goButton.Text = "&Go";
            this.goButton.ToolTipText = "Perform Operation";
            this.goButton.Click += new System.EventHandler(this.OnOperationsPerform);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // newProfileButton
            // 
            this.newProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("newProfileButton.Image")));
            this.newProfileButton.ImageTransparentColor = System.Drawing.Color.White;
            this.newProfileButton.Name = "newProfileButton";
            this.newProfileButton.Size = new System.Drawing.Size(23, 22);
            this.newProfileButton.Text = "New Profile";
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveProfileButton.Image")));
            this.saveProfileButton.ImageTransparentColor = System.Drawing.Color.White;
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(23, 22);
            this.saveProfileButton.Text = "Save Profile As";
            // 
            // manageProfilesButton
            // 
            this.manageProfilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageProfilesButton.Image = ((System.Drawing.Image)(resources.GetObject("manageProfilesButton.Image")));
            this.manageProfilesButton.ImageTransparentColor = System.Drawing.Color.White;
            this.manageProfilesButton.Name = "manageProfilesButton";
            this.manageProfilesButton.Size = new System.Drawing.Size(23, 22);
            this.manageProfilesButton.Text = "Manage Profiles";
            // 
            // profileListComboBox
            // 
            this.profileListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileListComboBox.Name = "profileListComboBox";
            this.profileListComboBox.Size = new System.Drawing.Size(200, 25);
            this.profileListComboBox.ToolTipText = "Profiles";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // exportConfigButton
            // 
            this.exportConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("exportConfigButton.Image")));
            this.exportConfigButton.ImageTransparentColor = System.Drawing.Color.White;
            this.exportConfigButton.Name = "exportConfigButton";
            this.exportConfigButton.Size = new System.Drawing.Size(23, 22);
            this.exportConfigButton.Text = "Export Configuration";
            this.exportConfigButton.Click += new System.EventHandler(this.OnToolsExportConfig);
            // 
            // importConfigButton
            // 
            this.importConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("importConfigButton.Image")));
            this.importConfigButton.ImageTransparentColor = System.Drawing.Color.White;
            this.importConfigButton.Name = "importConfigButton";
            this.importConfigButton.Size = new System.Drawing.Size(23, 22);
            this.importConfigButton.Text = "Import Configuration";
            this.importConfigButton.Click += new System.EventHandler(this.OnToolsConfigImport);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // clearAllHistoryButton
            // 
            this.clearAllHistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearAllHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("clearAllHistoryButton.Image")));
            this.clearAllHistoryButton.ImageTransparentColor = System.Drawing.Color.White;
            this.clearAllHistoryButton.Name = "clearAllHistoryButton";
            this.clearAllHistoryButton.Size = new System.Drawing.Size(23, 22);
            this.clearAllHistoryButton.Text = "Clear All History";
            this.clearAllHistoryButton.Click += new System.EventHandler(this.OnToolsHistoryClearAll);
            // 
            // switchButton
            // 
            this.switchButton.BackColor = System.Drawing.SystemColors.Control;
            this.switchButton.Image = global::MFR.GUI.Windows.Properties.Resources.SwitchUpDown_16x;
            this.switchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.switchButton.Location = new System.Drawing.Point(261, 164);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 14;
            this.switchButton.Text = "&Switch";
            this.switchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchButton.UseVisualStyleBackColor = false;
            this.switchButton.Click += new System.EventHandler(this.OnClickSwitchButton);
            // 
            // replaceWithComboBox
            // 
            this.replaceWithComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.replaceWithComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.replaceWithComboBox.EnteredText = "";
            this.replaceWithComboBox.FormattingEnabled = true;
            this.replaceWithComboBox.Location = new System.Drawing.Point(15, 190);
            this.replaceWithComboBox.Name = "replaceWithComboBox";
            this.replaceWithComboBox.Size = new System.Drawing.Size(572, 23);
            this.replaceWithComboBox.TabIndex = 6;
            this.replaceWithComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // findWhatcomboBox
            // 
            this.findWhatcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.findWhatcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.findWhatcomboBox.EnteredText = "";
            this.findWhatcomboBox.FormattingEnabled = true;
            this.findWhatcomboBox.Location = new System.Drawing.Point(15, 136);
            this.findWhatcomboBox.Name = "findWhatcomboBox";
            this.findWhatcomboBox.Size = new System.Drawing.Size(572, 23);
            this.findWhatcomboBox.TabIndex = 4;
            this.findWhatcomboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // startingFolderComboBox
            // 
            this.startingFolderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startingFolderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.startingFolderComboBox.EnteredText = "";
            this.startingFolderComboBox.FormattingEnabled = true;
            this.startingFolderComboBox.Items.AddRange(new object[] {
            ""});
            this.startingFolderComboBox.Location = new System.Drawing.Point(15, 81);
            this.startingFolderComboBox.Name = "startingFolderComboBox";
            this.startingFolderComboBox.Size = new System.Drawing.Size(539, 23);
            this.startingFolderComboBox.TabIndex = 1;
            this.startingFolderComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.performOperationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(596, 504);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.standardToolBar);
            this.Controls.Add(this.hiddenFocusLabel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.replaceWithComboBox);
            this.Controls.Add(this.findWhatcomboBox);
            this.Controls.Add(this.startingFolderComboBox);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.performOperationButton);
            this.Controls.Add(this.replaceWithLabel);
            this.Controls.Add(this.findWhatLabel);
            this.Controls.Add(this.startingFolderBrowseButton);
            this.Controls.Add(this.startingFolderLabel);
            this.Controls.Add(this.optionsTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AppTitle]";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.optionsTabControl.ResumeLayout(false);
            this.findReplaceOptionsTabPage.ResumeLayout(false);
            this.findReplaceOptionsTabPage.PerformLayout();
            this.operationsTabPage.ResumeLayout(false);
            this.operationsTabPage.PerformLayout();
            this.standardToolBar.ResumeLayout(false);
            this.standardToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label startingFolderLabel;
      private System.Windows.Forms.Button startingFolderBrowseButton;
      private System.Windows.Forms.Label findWhatLabel;
      private System.Windows.Forms.Label replaceWithLabel;
      private System.Windows.Forms.Button performOperationButton;
      private MFR.GUI.Controls.FoldUnfoldButton foldButton;
      private MFR.GUI.Controls.EntryRespectingComboBox startingFolderComboBox;
      private MFR.GUI.Controls.EntryRespectingComboBox findWhatcomboBox;
      private MFR.GUI.Controls.EntryRespectingComboBox replaceWithComboBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsOptions;
        private System.Windows.Forms.ToolStripStatusLabel statusBarMessage;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigImport;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem operationsMenu;
        private System.Windows.Forms.ToolStripMenuItem operationsPerform;
        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage findReplaceOptionsTabPage;
        private System.Windows.Forms.TabPage operationsTabPage;
        private System.Windows.Forms.TabPage inclusionsTabPage;
        private System.Windows.Forms.TabPage exclusionsTabPage;
        private System.Windows.Forms.CheckedListBox operationsCheckedListBox;
        private System.Windows.Forms.CheckBox selectDeselectAllCheckBox;
        private System.Windows.Forms.Label tabPageInstructionLabel;
        private System.Windows.Forms.CheckBox matchExactWordCheckBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.ToolStripProgressBar statusBarProgressBar;
        private System.Windows.Forms.Label hiddenFocusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigApplyProfile;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigProfiles;
        private System.Windows.Forms.ToolStripMenuItem toolsSaveProfileAs;
        private System.Windows.Forms.ToolStripMenuItem toolsConfigNewProfile;
        private System.Windows.Forms.ToolStrip standardToolBar;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton newProfileButton;
        private System.Windows.Forms.ToolStripButton manageProfilesButton;
        private System.Windows.Forms.ToolStripComboBox profileListComboBox;
        private System.Windows.Forms.ToolStripMenuItem viewToolBar;
        private System.Windows.Forms.ToolStripMenuItem viewStatusBar;
        private System.Windows.Forms.ToolStripButton saveProfileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryClearMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryClearStartingFolderHistory;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryClearFindWhatHistory;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryClearReplaceWithHistory;
        private System.Windows.Forms.ToolStripMenuItem toolsHistoryClearAll;
        private System.Windows.Forms.ToolStripButton exportConfigButton;
        private System.Windows.Forms.ToolStripButton importConfigButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton clearAllHistoryButton;
        private System.Windows.Forms.Button switchButton;
    }
}

