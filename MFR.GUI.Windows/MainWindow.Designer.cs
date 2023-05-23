using PostSharp.Patterns.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

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
      [Log(AttributeExclude = true)]
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.startingFolderLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.startingFolderBrowseButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.findWhatLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.replaceWithLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.performOperationButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.statusBar = new xyLOGIX.UI.Dark.Controls.DarkStatusStrip();
            this.statusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuBar = new xyLOGIX.UI.Dark.Controls.DarkMenuStrip();
            this.fileMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.fileExit = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewToolBar = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewStatusBar = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.sep2 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.viewDarkTheme = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.operationsMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.operationsPerform = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigImport = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigExport = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolStripSeparator2 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.toolsSaveProfileAs = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigApplyProfile = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigProfiles = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsConfigNewProfile = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolStripSeparator5 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.toolsHistoryMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsHistoryClearAll = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsHistoryClearMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsHistoryClearStartingFolderHistory = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsHistoryClearFindWhatHistory = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsHistoryClearReplaceWithHistory = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolStripSeparator1 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.toolsOptions = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.helpMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.helpAbout = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.optionsTabControl = new xyLOGIX.UI.Dark.Controls.DarkTabControl();
            this.findReplaceOptionsTabPage = new System.Windows.Forms.TabPage();
            this.renameSolutionFoldersCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.matchExactWordCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.matchCaseCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.operationsTabPage = new System.Windows.Forms.TabPage();
            this.tabPageInstructionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.selectDeselectAllCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.operationsCheckedListBox = new xyLOGIX.UI.Dark.Controls.DarkCheckedListBox();
            this.inclusionsTabPage = new System.Windows.Forms.TabPage();
            this.exclusionsTabPage = new System.Windows.Forms.TabPage();
            this.foldButton = new MFR.GUI.Controls.FoldUnfoldButton();
            this.hiddenFocusLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.replaceWithComboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.findWhatcomboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.startingFolderComboBox = new MFR.GUI.Controls.EntryRespectingComboBox();
            this.exportConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.importConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.newProfileButton = new System.Windows.Forms.ToolStripButton();
            this.saveProfileButton = new System.Windows.Forms.ToolStripButton();
            this.manageProfilesButton = new System.Windows.Forms.ToolStripButton();
            this.profileListComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.exportConfigButton = new System.Windows.Forms.ToolStripButton();
            this.importConfigButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.clearAllHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.standardToolStrip = new xyLOGIX.UI.Dark.Controls.DarkToolStrip();
            this.switchButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.optionsTabControl.SuspendLayout();
            this.findReplaceOptionsTabPage.SuspendLayout();
            this.operationsTabPage.SuspendLayout();
            this.standardToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingFolderLabel
            // 
            this.startingFolderLabel.AutoSize = true;
            this.startingFolderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.startingFolderLabel.IsDarkTheme = false;
            this.startingFolderLabel.Location = new System.Drawing.Point(12, 62);
            this.startingFolderLabel.Name = "startingFolderLabel";
            this.startingFolderLabel.Size = new System.Drawing.Size(226, 15);
            this.startingFolderLabel.TabIndex = 0;
            this.startingFolderLabel.Text = "What &folder should the operation start in?";
            // 
            // startingFolderBrowseButton
            // 
            this.startingFolderBrowseButton.IsDarkTheme = false;
            this.startingFolderBrowseButton.Location = new System.Drawing.Point(556, 77);
            this.startingFolderBrowseButton.Name = "startingFolderBrowseButton";
            this.startingFolderBrowseButton.Padding = new System.Windows.Forms.Padding(5);
            this.startingFolderBrowseButton.Size = new System.Drawing.Size(24, 27);
            this.startingFolderBrowseButton.TabIndex = 2;
            this.startingFolderBrowseButton.Text = "...";
            this.startingFolderBrowseButton.Click += new System.EventHandler(this.OnClickBrowseForStartingFolder);
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.AutoSize = true;
            this.findWhatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.findWhatLabel.IsDarkTheme = false;
            this.findWhatLabel.Location = new System.Drawing.Point(12, 118);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(109, 15);
            this.findWhatLabel.TabIndex = 3;
            this.findWhatLabel.Text = "&Text to be replaced:";
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.AutoSize = true;
            this.replaceWithLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.replaceWithLabel.IsDarkTheme = false;
            this.replaceWithLabel.Location = new System.Drawing.Point(12, 168);
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
            this.performOperationButton.ImagePadding = 0;
            this.performOperationButton.IsDarkTheme = false;
            this.performOperationButton.Location = new System.Drawing.Point(423, 219);
            this.performOperationButton.Name = "performOperationButton";
            this.performOperationButton.Padding = new System.Windows.Forms.Padding(5);
            this.performOperationButton.Size = new System.Drawing.Size(157, 27);
            this.performOperationButton.TabIndex = 8;
            this.performOperationButton.Text = "&Perform Operation";
            this.performOperationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.performOperationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.performOperationButton.Click += new System.EventHandler(this.OnClickPerformOperation);
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusBar.IsDarkTheme = false;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMessage,
            this.statusBarProgressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 483);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.statusBar.Size = new System.Drawing.Size(596, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarMessage
            // 
            this.statusBarMessage.Name = "statusBarMessage";
            this.statusBarMessage.Size = new System.Drawing.Size(596, 9);
            this.statusBarMessage.Spring = true;
            this.statusBarMessage.Text = "Ready";
            this.statusBarMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBarProgressBar
            // 
            this.statusBarProgressBar.MarqueeAnimationSpeed = 300;
            this.statusBarProgressBar.Name = "statusBarProgressBar";
            this.statusBarProgressBar.Size = new System.Drawing.Size(100, 8);
            this.statusBarProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusBarProgressBar.Visible = false;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.menuBar.IsDarkTheme = false;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.operationsMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(596, 24);
            this.menuBar.TabIndex = 10;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.Transparent;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.fileMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileExit
            // 
            this.fileExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(93, 22);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.Color.Transparent;
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolBar,
            this.viewStatusBar,
            this.sep2,
            this.viewDarkTheme});
            this.viewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // viewToolBar
            // 
            this.viewToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.viewToolBar.Checked = true;
            this.viewToolBar.CheckOnClick = true;
            this.viewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolBar.Name = "viewToolBar";
            this.viewToolBar.Size = new System.Drawing.Size(137, 22);
            this.viewToolBar.Text = "&Toolbar";
            this.viewToolBar.Click += new System.EventHandler(this.OnViewToolBar);
            // 
            // viewStatusBar
            // 
            this.viewStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.viewStatusBar.Checked = true;
            this.viewStatusBar.CheckOnClick = true;
            this.viewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewStatusBar.Name = "viewStatusBar";
            this.viewStatusBar.Size = new System.Drawing.Size(137, 22);
            this.viewStatusBar.Text = "&Status Bar";
            this.viewStatusBar.Click += new System.EventHandler(this.OnViewStatusBar);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(134, 6);
            // 
            // viewDarkTheme
            // 
            this.viewDarkTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.viewDarkTheme.CheckOnClick = true;
            this.viewDarkTheme.Image = ((System.Drawing.Image)(resources.GetObject("viewDarkTheme.Image")));
            this.viewDarkTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewDarkTheme.Name = "viewDarkTheme";
            this.viewDarkTheme.Size = new System.Drawing.Size(137, 22);
            this.viewDarkTheme.Text = "Dark Theme";
            this.viewDarkTheme.Click += new System.EventHandler(this.OnViewDarkTheme);
            // 
            // operationsMenu
            // 
            this.operationsMenu.BackColor = System.Drawing.Color.Transparent;
            this.operationsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsPerform});
            this.operationsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.operationsMenu.Name = "operationsMenu";
            this.operationsMenu.Size = new System.Drawing.Size(77, 20);
            this.operationsMenu.Text = "&Operations";
            // 
            // operationsPerform
            // 
            this.operationsPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.operationsPerform.Name = "operationsPerform";
            this.operationsPerform.Size = new System.Drawing.Size(117, 22);
            this.operationsPerform.Text = "&Perform";
            this.operationsPerform.Click += new System.EventHandler(this.OnOperationsPerform);
            // 
            // toolsMenu
            // 
            this.toolsMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsConfigMenu,
            this.toolStripSeparator1,
            this.toolsOptions});
            this.toolsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsConfigMenu
            // 
            this.toolsConfigMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsConfigImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsConfigImport.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigImport.Image")));
            this.toolsConfigImport.Name = "toolsConfigImport";
            this.toolsConfigImport.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigImport.Text = "&Import...";
            this.toolsConfigImport.Click += new System.EventHandler(this.OnToolsConfigImport);
            // 
            // toolsConfigExport
            // 
            this.toolsConfigExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsConfigExport.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigExport.Image")));
            this.toolsConfigExport.Name = "toolsConfigExport";
            this.toolsConfigExport.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigExport.Text = "&Export...";
            this.toolsConfigExport.Click += new System.EventHandler(this.OnToolsConfigExport);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // toolsSaveProfileAs
            // 
            this.toolsSaveProfileAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsSaveProfileAs.Image = ((System.Drawing.Image)(resources.GetObject("toolsSaveProfileAs.Image")));
            this.toolsSaveProfileAs.Name = "toolsSaveProfileAs";
            this.toolsSaveProfileAs.Size = new System.Drawing.Size(159, 22);
            this.toolsSaveProfileAs.Text = "&Save Profile As";
            // 
            // toolsConfigApplyProfile
            // 
            this.toolsConfigApplyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsConfigApplyProfile.Name = "toolsConfigApplyProfile";
            this.toolsConfigApplyProfile.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigApplyProfile.Text = "&Apply Profile";
            // 
            // toolsConfigProfiles
            // 
            this.toolsConfigProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsConfigProfiles.Image = ((System.Drawing.Image)(resources.GetObject("toolsConfigProfiles.Image")));
            this.toolsConfigProfiles.ImageTransparentColor = System.Drawing.Color.White;
            this.toolsConfigProfiles.Name = "toolsConfigProfiles";
            this.toolsConfigProfiles.Size = new System.Drawing.Size(159, 22);
            this.toolsConfigProfiles.Text = "&Manage Profiles";
            // 
            // toolsConfigNewProfile
            // 
            this.toolsConfigNewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsHistoryMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsHistoryClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsHistoryClearAll.Image = ((System.Drawing.Image)(resources.GetObject("toolsHistoryClearAll.Image")));
            this.toolsHistoryClearAll.Name = "toolsHistoryClearAll";
            this.toolsHistoryClearAll.Size = new System.Drawing.Size(163, 22);
            this.toolsHistoryClearAll.Text = "&Clear";
            // 
            // toolsHistoryClearMenu
            // 
            this.toolsHistoryClearMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsHistoryClearStartingFolderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsHistoryClearStartingFolderHistory.Name = "toolsHistoryClearStartingFolderHistory";
            this.toolsHistoryClearStartingFolderHistory.Size = new System.Drawing.Size(192, 22);
            this.toolsHistoryClearStartingFolderHistory.Text = "&Starting Folder History";
            // 
            // toolsHistoryClearFindWhatHistory
            // 
            this.toolsHistoryClearFindWhatHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsHistoryClearFindWhatHistory.Name = "toolsHistoryClearFindWhatHistory";
            this.toolsHistoryClearFindWhatHistory.Size = new System.Drawing.Size(192, 22);
            this.toolsHistoryClearFindWhatHistory.Text = "&Find What History";
            // 
            // toolsHistoryClearReplaceWithHistory
            // 
            this.toolsHistoryClearReplaceWithHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolsOptions.Image")));
            this.toolsOptions.ImageTransparentColor = System.Drawing.Color.White;
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(148, 22);
            this.toolsOptions.Text = "&Options";
            this.toolsOptions.Click += new System.EventHandler(this.OnToolsOptions);
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.Color.Transparent;
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.helpMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            this.helpMenu.DropDownOpening += new System.EventHandler(this.OnHelpMenuDropDownOpening);
            // 
            // helpAbout
            // 
            this.helpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(165, 22);
            this.helpAbout.Text = "&About [App Title]";
            this.helpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.ActiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.optionsTabControl.ActiveTabTextColor = System.Drawing.SystemColors.Highlight;
            this.optionsTabControl.Controls.Add(this.findReplaceOptionsTabPage);
            this.optionsTabControl.Controls.Add(this.operationsTabPage);
            this.optionsTabControl.Controls.Add(this.inclusionsTabPage);
            this.optionsTabControl.Controls.Add(this.exclusionsTabPage);
            this.optionsTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.optionsTabControl.InactiveTabBackColor = System.Drawing.Color.Empty;
            this.optionsTabControl.InactiveTabTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.optionsTabControl.IsDarkTheme = true;
            this.optionsTabControl.ItemSize = new System.Drawing.Size(0, 18);
            this.optionsTabControl.Location = new System.Drawing.Point(15, 262);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(569, 210);
            this.optionsTabControl.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.optionsTabControl.TabIndex = 11;
            this.optionsTabControl.TabWellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            // 
            // findReplaceOptionsTabPage
            // 
            this.findReplaceOptionsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.findReplaceOptionsTabPage.Controls.Add(this.renameSolutionFoldersCheckBox);
            this.findReplaceOptionsTabPage.Controls.Add(this.matchExactWordCheckBox);
            this.findReplaceOptionsTabPage.Controls.Add(this.matchCaseCheckBox);
            this.findReplaceOptionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.findReplaceOptionsTabPage.Name = "findReplaceOptionsTabPage";
            this.findReplaceOptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.findReplaceOptionsTabPage.Size = new System.Drawing.Size(561, 184);
            this.findReplaceOptionsTabPage.TabIndex = 0;
            this.findReplaceOptionsTabPage.Text = "Find/Replace Options";
            // 
            // renameSolutionFoldersCheckBox
            // 
            this.renameSolutionFoldersCheckBox.AutoSize = true;
            this.renameSolutionFoldersCheckBox.IsDarkTheme = false;
            this.renameSolutionFoldersCheckBox.Location = new System.Drawing.Point(7, 58);
            this.renameSolutionFoldersCheckBox.Name = "renameSolutionFoldersCheckBox";
            this.renameSolutionFoldersCheckBox.Size = new System.Drawing.Size(162, 19);
            this.renameSolutionFoldersCheckBox.TabIndex = 2;
            this.renameSolutionFoldersCheckBox.Text = "Rename solution folder(s)";
            // 
            // matchExactWordCheckBox
            // 
            this.matchExactWordCheckBox.AutoSize = true;
            this.matchExactWordCheckBox.IsDarkTheme = false;
            this.matchExactWordCheckBox.Location = new System.Drawing.Point(7, 33);
            this.matchExactWordCheckBox.Name = "matchExactWordCheckBox";
            this.matchExactWordCheckBox.Size = new System.Drawing.Size(121, 19);
            this.matchExactWordCheckBox.TabIndex = 1;
            this.matchExactWordCheckBox.Text = "Match e&xact word";
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.IsDarkTheme = false;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(7, 7);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(86, 19);
            this.matchCaseCheckBox.TabIndex = 0;
            this.matchCaseCheckBox.Text = "Match &case";
            // 
            // operationsTabPage
            // 
            this.operationsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.operationsTabPage.Controls.Add(this.tabPageInstructionLabel);
            this.operationsTabPage.Controls.Add(this.selectDeselectAllCheckBox);
            this.operationsTabPage.Controls.Add(this.operationsCheckedListBox);
            this.operationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.operationsTabPage.Name = "operationsTabPage";
            this.operationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.operationsTabPage.Size = new System.Drawing.Size(561, 184);
            this.operationsTabPage.TabIndex = 1;
            this.operationsTabPage.Text = "Operations";
            // 
            // tabPageInstructionLabel
            // 
            this.tabPageInstructionLabel.AutoSize = true;
            this.tabPageInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPageInstructionLabel.IsDarkTheme = false;
            this.tabPageInstructionLabel.Location = new System.Drawing.Point(8, 12);
            this.tabPageInstructionLabel.Name = "tabPageInstructionLabel";
            this.tabPageInstructionLabel.Size = new System.Drawing.Size(128, 15);
            this.tabPageInstructionLabel.TabIndex = 2;
            this.tabPageInstructionLabel.Text = "&Operations to perform:";
            // 
            // selectDeselectAllCheckBox
            // 
            this.selectDeselectAllCheckBox.AutoSize = true;
            this.selectDeselectAllCheckBox.IsDarkTheme = false;
            this.selectDeselectAllCheckBox.Location = new System.Drawing.Point(11, 34);
            this.selectDeselectAllCheckBox.Name = "selectDeselectAllCheckBox";
            this.selectDeselectAllCheckBox.Size = new System.Drawing.Size(120, 19);
            this.selectDeselectAllCheckBox.TabIndex = 1;
            this.selectDeselectAllCheckBox.Text = "Select/deselect all";
            this.selectDeselectAllCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChangedSelectDeselectAllCheckBox);
            // 
            // operationsCheckedListBox
            // 
            this.operationsCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.operationsCheckedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.operationsCheckedListBox.FormattingEnabled = true;
            this.operationsCheckedListBox.IsDarkTheme = true;
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
            this.inclusionsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.inclusionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.inclusionsTabPage.Name = "inclusionsTabPage";
            this.inclusionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inclusionsTabPage.Size = new System.Drawing.Size(561, 184);
            this.inclusionsTabPage.TabIndex = 2;
            this.inclusionsTabPage.Text = "Inclusions";
            // 
            // exclusionsTabPage
            // 
            this.exclusionsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exclusionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.exclusionsTabPage.Name = "exclusionsTabPage";
            this.exclusionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exclusionsTabPage.Size = new System.Drawing.Size(561, 184);
            this.exclusionsTabPage.TabIndex = 3;
            this.exclusionsTabPage.Text = "Exclusions";
            // 
            // foldButton
            // 
            this.foldButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.foldButton.FormFoldedSize = new System.Drawing.Size(612, 318);
            this.foldButton.FormUnfoldedSize = new System.Drawing.Size(612, 544);
            this.foldButton.IsDarkTheme = false;
            this.foldButton.Location = new System.Drawing.Point(15, 219);
            this.foldButton.Name = "foldButton";
            this.foldButton.Padding = new System.Windows.Forms.Padding(5);
            this.foldButton.Size = new System.Drawing.Size(87, 27);
            this.foldButton.TabIndex = 7;
            this.foldButton.Text = "&More >>";
            this.foldButton.FormFolded += new MFR.GUI.Controls.Events.FormFoldedEventHandler(this.OnFormFolded);
            // 
            // hiddenFocusLabel
            // 
            this.hiddenFocusLabel.AutoSize = true;
            this.hiddenFocusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.hiddenFocusLabel.IsDarkTheme = false;
            this.hiddenFocusLabel.Location = new System.Drawing.Point(648, 245);
            this.hiddenFocusLabel.Name = "hiddenFocusLabel";
            this.hiddenFocusLabel.Size = new System.Drawing.Size(0, 15);
            this.hiddenFocusLabel.TabIndex = 12;
            this.hiddenFocusLabel.Visible = false;
            // 
            // replaceWithComboBox
            // 
            this.replaceWithComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.replaceWithComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.replaceWithComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.replaceWithComboBox.EnteredText = "";
            this.replaceWithComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceWithComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.replaceWithComboBox.FormattingEnabled = true;
            this.replaceWithComboBox.IsDarkTheme = false;
            this.replaceWithComboBox.Items.AddRange(new object[] {
            ""});
            this.replaceWithComboBox.Location = new System.Drawing.Point(15, 190);
            this.replaceWithComboBox.Name = "replaceWithComboBox";
            this.replaceWithComboBox.Size = new System.Drawing.Size(565, 23);
            this.replaceWithComboBox.TabIndex = 6;
            this.replaceWithComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // findWhatcomboBox
            // 
            this.findWhatcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.findWhatcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.findWhatcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.findWhatcomboBox.EnteredText = "";
            this.findWhatcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findWhatcomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.findWhatcomboBox.FormattingEnabled = true;
            this.findWhatcomboBox.IsDarkTheme = false;
            this.findWhatcomboBox.Items.AddRange(new object[] {
            ""});
            this.findWhatcomboBox.Location = new System.Drawing.Point(15, 136);
            this.findWhatcomboBox.Name = "findWhatcomboBox";
            this.findWhatcomboBox.Size = new System.Drawing.Size(565, 23);
            this.findWhatcomboBox.TabIndex = 4;
            this.findWhatcomboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // startingFolderComboBox
            // 
            this.startingFolderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startingFolderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.startingFolderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startingFolderComboBox.EnteredText = "";
            this.startingFolderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startingFolderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.startingFolderComboBox.FormattingEnabled = true;
            this.startingFolderComboBox.IsDarkTheme = true;
            this.startingFolderComboBox.Items.AddRange(new object[] {
            ""});
            this.startingFolderComboBox.Location = new System.Drawing.Point(15, 81);
            this.startingFolderComboBox.Name = "startingFolderComboBox";
            this.startingFolderComboBox.Size = new System.Drawing.Size(535, 23);
            this.startingFolderComboBox.TabIndex = 1;
            this.startingFolderComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // exportConfigDialog
            // 
            this.exportConfigDialog.DefaultExt = "config.json";
            this.exportConfigDialog.Filter = "Configuration File (*.config.json)|*.config.json|All Files (*.*)|*.*";
            this.exportConfigDialog.InitialDirectory = "shell:::{679f85cb-0220-4080-b29b-5540cc05aab6}";
            this.exportConfigDialog.RestoreDirectory = true;
            this.exportConfigDialog.Title = "Export Configuration";
            // 
            // importConfigDialog
            // 
            this.importConfigDialog.DefaultExt = "config.json";
            this.importConfigDialog.Filter = "Configuration File (*.config.json)|*.config.json|All Files (*.*)|*.*";
            this.importConfigDialog.InitialDirectory = "shell:::{679f85cb-0220-4080-b29b-5540cc05aab6}";
            this.importConfigDialog.RestoreDirectory = true;
            this.importConfigDialog.Title = "Import Configuration";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.goButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.White;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(42, 22);
            this.goButton.Text = "&Go";
            this.goButton.ToolTipText = "Perform Operation";
            this.goButton.Click += new System.EventHandler(this.OnOperationsPerform);
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.sep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.sep1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // newProfileButton
            // 
            this.newProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.newProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.newProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("newProfileButton.Image")));
            this.newProfileButton.ImageTransparentColor = System.Drawing.Color.White;
            this.newProfileButton.Name = "newProfileButton";
            this.newProfileButton.Size = new System.Drawing.Size(23, 22);
            this.newProfileButton.Text = "New Profile";
            this.newProfileButton.Click += new System.EventHandler(this.OnToolsConfigurationNewProfile);
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.saveProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.saveProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveProfileButton.Image")));
            this.saveProfileButton.ImageTransparentColor = System.Drawing.Color.White;
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(23, 22);
            this.saveProfileButton.Text = "Save Profile As";
            this.saveProfileButton.Click += new System.EventHandler(this.OnToolsConfigurationSaveProfile);
            // 
            // manageProfilesButton
            // 
            this.manageProfilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.manageProfilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageProfilesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.manageProfilesButton.Image = ((System.Drawing.Image)(resources.GetObject("manageProfilesButton.Image")));
            this.manageProfilesButton.ImageTransparentColor = System.Drawing.Color.White;
            this.manageProfilesButton.Name = "manageProfilesButton";
            this.manageProfilesButton.Size = new System.Drawing.Size(23, 22);
            this.manageProfilesButton.Text = "Manage Profiles";
            // 
            // profileListComboBox
            // 
            this.profileListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.profileListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileListComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.profileListComboBox.Items.AddRange(new object[] {
            "<No profile selected>"});
            this.profileListComboBox.Name = "profileListComboBox";
            this.profileListComboBox.Size = new System.Drawing.Size(200, 25);
            this.profileListComboBox.ToolTipText = "Profiles";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // exportConfigButton
            // 
            this.exportConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.exportConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportConfigButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.exportConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("exportConfigButton.Image")));
            this.exportConfigButton.ImageTransparentColor = System.Drawing.Color.White;
            this.exportConfigButton.Name = "exportConfigButton";
            this.exportConfigButton.Size = new System.Drawing.Size(23, 22);
            this.exportConfigButton.Text = "Export Configuration";
            this.exportConfigButton.Click += new System.EventHandler(this.OnToolsConfigExport);
            // 
            // importConfigButton
            // 
            this.importConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.importConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importConfigButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.importConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("importConfigButton.Image")));
            this.importConfigButton.ImageTransparentColor = System.Drawing.Color.White;
            this.importConfigButton.Name = "importConfigButton";
            this.importConfigButton.Size = new System.Drawing.Size(23, 22);
            this.importConfigButton.Text = "Import Configuration";
            this.importConfigButton.Click += new System.EventHandler(this.OnToolsConfigImport);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // clearAllHistoryButton
            // 
            this.clearAllHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.clearAllHistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearAllHistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.clearAllHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("clearAllHistoryButton.Image")));
            this.clearAllHistoryButton.ImageTransparentColor = System.Drawing.Color.White;
            this.clearAllHistoryButton.Name = "clearAllHistoryButton";
            this.clearAllHistoryButton.Size = new System.Drawing.Size(23, 22);
            this.clearAllHistoryButton.Text = "Clear All History";
            this.clearAllHistoryButton.Click += new System.EventHandler(this.OnToolsHistoryClearAll);
            // 
            // standardToolStrip
            // 
            this.standardToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.standardToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.standardToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.standardToolStrip.IsDarkTheme = true;
            this.standardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goButton,
            this.sep1,
            this.newProfileButton,
            this.saveProfileButton,
            this.manageProfilesButton,
            this.profileListComboBox,
            this.toolStripSeparator4,
            this.exportConfigButton,
            this.importConfigButton,
            this.toolStripSeparator6,
            this.clearAllHistoryButton});
            this.standardToolStrip.Location = new System.Drawing.Point(0, 24);
            this.standardToolStrip.Name = "standardToolStrip";
            this.standardToolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.standardToolStrip.Size = new System.Drawing.Size(596, 25);
            this.standardToolStrip.TabIndex = 13;
            this.standardToolStrip.Text = "Standard";
            // 
            // switchButton
            // 
            this.switchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.switchButton.Image = global::MFR.GUI.Windows.Properties.Resources.SwitchUpDown_16x;
            this.switchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.switchButton.ImagePadding = 3;
            this.switchButton.IsDarkTheme = true;
            this.switchButton.Location = new System.Drawing.Point(257, 164);
            this.switchButton.Name = "switchButton";
            this.switchButton.Padding = new System.Windows.Forms.Padding(5);
            this.switchButton.Size = new System.Drawing.Size(82, 23);
            this.switchButton.TabIndex = 14;
            this.switchButton.Text = "&Switch";
            this.switchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.switchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchButton.Click += new System.EventHandler(this.OnClickSwitchButton);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.performOperationButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 505);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.standardToolStrip);
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
            this.standardToolStrip.ResumeLayout(false);
            this.standardToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        private xyLOGIX.UI.Dark.Controls.DarkLabel startingFolderLabel;
        private xyLOGIX.UI.Dark.Controls.DarkButton startingFolderBrowseButton;
        private xyLOGIX.UI.Dark.Controls.DarkLabel findWhatLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel replaceWithLabel;
        private xyLOGIX.UI.Dark.Controls.DarkButton performOperationButton;
        private MFR.GUI.Controls.FoldUnfoldButton foldButton;
        private MFR.GUI.Controls.EntryRespectingComboBox startingFolderComboBox;
        private MFR.GUI.Controls.EntryRespectingComboBox findWhatcomboBox;
        private MFR.GUI.Controls.EntryRespectingComboBox replaceWithComboBox;
        private xyLOGIX.UI.Dark.Controls.DarkStatusStrip statusBar;
        private xyLOGIX.UI.Dark.Controls.DarkMenuStrip menuBar;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem fileMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem fileExit;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsOptions;
        private System.Windows.Forms.ToolStripStatusLabel statusBarMessage;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigImport;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigExport;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator toolStripSeparator1;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem operationsMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem operationsPerform;
        private xyLOGIX.UI.Dark.Controls.DarkTabControl optionsTabControl;
        private System.Windows.Forms.TabPage findReplaceOptionsTabPage;
        private System.Windows.Forms.TabPage operationsTabPage;
        private System.Windows.Forms.TabPage inclusionsTabPage;
        private System.Windows.Forms.TabPage exclusionsTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkCheckedListBox operationsCheckedListBox;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox selectDeselectAllCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel tabPageInstructionLabel;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox matchExactWordCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox matchCaseCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem helpMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem helpAbout;
        private System.Windows.Forms.ToolStripProgressBar statusBarProgressBar;
        private xyLOGIX.UI.Dark.Controls.DarkLabel hiddenFocusLabel;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator toolStripSeparator2;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigApplyProfile;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigProfiles;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsSaveProfileAs;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsConfigNewProfile;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewToolBar;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewStatusBar;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator toolStripSeparator5;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryClearMenu;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryClearStartingFolderHistory;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryClearFindWhatHistory;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryClearReplaceWithHistory;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsHistoryClearAll;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep2;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewDarkTheme;
        private System.Windows.Forms.SaveFileDialog exportConfigDialog;
        private System.Windows.Forms.OpenFileDialog importConfigDialog;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox renameSolutionFoldersCheckBox;
        private System.Windows.Forms.ToolStripButton goButton;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton newProfileButton;
        private System.Windows.Forms.ToolStripButton saveProfileButton;
        private System.Windows.Forms.ToolStripButton manageProfilesButton;
        private System.Windows.Forms.ToolStripComboBox profileListComboBox;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton exportConfigButton;
        private System.Windows.Forms.ToolStripButton importConfigButton;
        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton clearAllHistoryButton;
        private xyLOGIX.UI.Dark.Controls.DarkToolStrip standardToolStrip;
        private xyLOGIX.UI.Dark.Controls.DarkButton switchButton;
    }
}

