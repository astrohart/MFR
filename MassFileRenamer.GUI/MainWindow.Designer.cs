
using MassFileRenamer.Objects;
using System.ComponentModel;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
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
            this.startingFolderComboBox = new MassFileRenamer.Objects.EntryRespectingComboBox();
            this.findWhatcomboBox = new MassFileRenamer.Objects.EntryRespectingComboBox();
            this.replaceWithComboBox = new MassFileRenamer.Objects.EntryRespectingComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsPerform = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearStartingFolderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearFindWhatHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearReplaceWithHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsImportExportConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsImportConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExportConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.findReplaceOptionsTabPage = new System.Windows.Forms.TabPage();
            this.matchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.operationsTabPage = new System.Windows.Forms.TabPage();
            this.tabPageInstructionLabel = new System.Windows.Forms.Label();
            this.selectDeselectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.operationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.inclusionsTabPage = new System.Windows.Forms.TabPage();
            this.exclusionsTabPage = new System.Windows.Forms.TabPage();
            this.foldButton = new MassFileRenamer.Objects.FoldUnfoldButton();
            this.hiddenFocusLabel = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.optionsTabControl.SuspendLayout();
            this.findReplaceOptionsTabPage.SuspendLayout();
            this.operationsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingFolderLabel
            // 
            this.startingFolderLabel.AutoSize = true;
            this.startingFolderLabel.Location = new System.Drawing.Point(12, 35);
            this.startingFolderLabel.Name = "startingFolderLabel";
            this.startingFolderLabel.Size = new System.Drawing.Size(226, 15);
            this.startingFolderLabel.TabIndex = 0;
            this.startingFolderLabel.Text = "What &folder should the operation start in?";
            // 
            // startingFolderBrowseButton
            // 
            this.startingFolderBrowseButton.Location = new System.Drawing.Point(560, 51);
            this.startingFolderBrowseButton.Name = "startingFolderBrowseButton";
            this.startingFolderBrowseButton.Size = new System.Drawing.Size(24, 27);
            this.startingFolderBrowseButton.TabIndex = 2;
            this.startingFolderBrowseButton.Text = "...";
            this.startingFolderBrowseButton.UseVisualStyleBackColor = true;
            this.startingFolderBrowseButton.Click += new System.EventHandler(this.OnClickBrowse);
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.AutoSize = true;
            this.findWhatLabel.Location = new System.Drawing.Point(9, 90);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(109, 15);
            this.findWhatLabel.TabIndex = 3;
            this.findWhatLabel.Text = "&Text to be replaced:";
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.AutoSize = true;
            this.replaceWithLabel.Location = new System.Drawing.Point(9, 144);
            this.replaceWithLabel.Name = "replaceWithLabel";
            this.replaceWithLabel.Size = new System.Drawing.Size(64, 15);
            this.replaceWithLabel.TabIndex = 5;
            this.replaceWithLabel.Text = "&With what:";
            // 
            // performOperationButton
            // 
            this.performOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.performOperationButton.Location = new System.Drawing.Point(436, 192);
            this.performOperationButton.Name = "performOperationButton";
            this.performOperationButton.Size = new System.Drawing.Size(148, 27);
            this.performOperationButton.TabIndex = 8;
            this.performOperationButton.Text = "&Perform Operation";
            this.performOperationButton.UseVisualStyleBackColor = true;
            this.performOperationButton.Click += new System.EventHandler(this.OnClickPerformOperation);
            // 
            // startingFolderComboBox
            // 
            this.startingFolderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startingFolderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.startingFolderComboBox.EnteredText = "";
            this.startingFolderComboBox.FormattingEnabled = true;
            this.startingFolderComboBox.Location = new System.Drawing.Point(15, 54);
            this.startingFolderComboBox.Name = "startingFolderComboBox";
            this.startingFolderComboBox.Size = new System.Drawing.Size(539, 23);
            this.startingFolderComboBox.TabIndex = 1;
            this.startingFolderComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // findWhatcomboBox
            // 
            this.findWhatcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.findWhatcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.findWhatcomboBox.EnteredText = "";
            this.findWhatcomboBox.FormattingEnabled = true;
            this.findWhatcomboBox.Location = new System.Drawing.Point(15, 109);
            this.findWhatcomboBox.Name = "findWhatcomboBox";
            this.findWhatcomboBox.Size = new System.Drawing.Size(572, 23);
            this.findWhatcomboBox.TabIndex = 4;
            this.findWhatcomboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // replaceWithComboBox
            // 
            this.replaceWithComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.replaceWithComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.replaceWithComboBox.EnteredText = "";
            this.replaceWithComboBox.FormattingEnabled = true;
            this.replaceWithComboBox.Location = new System.Drawing.Point(15, 163);
            this.replaceWithComboBox.Name = "replaceWithComboBox";
            this.replaceWithComboBox.Size = new System.Drawing.Size(572, 23);
            this.replaceWithComboBox.TabIndex = 6;
            this.replaceWithComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboBox);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMessage,
            this.statusBarProgressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 456);
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
            this.viewStatusBar});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
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
            this.toolsHistoryMenu,
            this.toolStripSeparator2,
            this.toolsImportExportConfigMenu,
            this.toolStripSeparator1,
            this.toolsOptions});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsHistoryMenu
            // 
            this.toolsHistoryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsHistoryClearMenu,
            this.toolsHistoryClearAll});
            this.toolsHistoryMenu.Name = "toolsHistoryMenu";
            this.toolsHistoryMenu.Size = new System.Drawing.Size(247, 22);
            this.toolsHistoryMenu.Text = "&History";
            // 
            // toolsHistoryClearMenu
            // 
            this.toolsHistoryClearMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsHistoryClearStartingFolderHistory,
            this.toolsHistoryClearFindWhatHistory,
            this.toolsHistoryClearReplaceWithHistory});
            this.toolsHistoryClearMenu.Name = "toolsHistoryClearMenu";
            this.toolsHistoryClearMenu.Size = new System.Drawing.Size(118, 22);
            this.toolsHistoryClearMenu.Text = "&Clear";
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
            // toolsHistoryClearAll
            // 
            this.toolsHistoryClearAll.Name = "toolsHistoryClearAll";
            this.toolsHistoryClearAll.Size = new System.Drawing.Size(118, 22);
            this.toolsHistoryClearAll.Text = "Clear &All";
            this.toolsHistoryClearAll.Click += new System.EventHandler(this.OnToolsHistoryClearAll);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // toolsImportExportConfigMenu
            // 
            this.toolsImportExportConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsImportConfig,
            this.toolsExportConfig});
            this.toolsImportExportConfigMenu.Name = "toolsImportExportConfigMenu";
            this.toolsImportExportConfigMenu.Size = new System.Drawing.Size(247, 22);
            this.toolsImportExportConfigMenu.Text = "I&mport and Export Configuration";
            // 
            // toolsImportConfig
            // 
            this.toolsImportConfig.Name = "toolsImportConfig";
            this.toolsImportConfig.Size = new System.Drawing.Size(196, 22);
            this.toolsImportConfig.Text = "&Import Configuration...";
            this.toolsImportConfig.Click += new System.EventHandler(this.OnToolsImportConfig);
            // 
            // toolsExportConfig
            // 
            this.toolsExportConfig.Name = "toolsExportConfig";
            this.toolsExportConfig.Size = new System.Drawing.Size(196, 22);
            this.toolsExportConfig.Text = "E&xport Configuration...";
            this.toolsExportConfig.Click += new System.EventHandler(this.OnToolsExportConfig);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // toolsOptions
            // 
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(247, 22);
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
            this.optionsTabControl.Location = new System.Drawing.Point(15, 235);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(569, 210);
            this.optionsTabControl.TabIndex = 11;
            // 
            // findReplaceOptionsTabPage
            // 
            this.findReplaceOptionsTabPage.Controls.Add(this.matchWholeWordCheckBox);
            this.findReplaceOptionsTabPage.Controls.Add(this.matchCaseCheckBox);
            this.findReplaceOptionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.findReplaceOptionsTabPage.Name = "findReplaceOptionsTabPage";
            this.findReplaceOptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.findReplaceOptionsTabPage.Size = new System.Drawing.Size(561, 182);
            this.findReplaceOptionsTabPage.TabIndex = 0;
            this.findReplaceOptionsTabPage.Text = "Find/Replace Options";
            this.findReplaceOptionsTabPage.UseVisualStyleBackColor = true;
            // 
            // matchWholeWordCheckBox
            // 
            this.matchWholeWordCheckBox.AutoSize = true;
            this.matchWholeWordCheckBox.Location = new System.Drawing.Point(7, 33);
            this.matchWholeWordCheckBox.Name = "matchWholeWordCheckBox";
            this.matchWholeWordCheckBox.Size = new System.Drawing.Size(125, 19);
            this.matchWholeWordCheckBox.TabIndex = 1;
            this.matchWholeWordCheckBox.Text = "Matc&h whole word";
            this.matchWholeWordCheckBox.UseVisualStyleBackColor = true;
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
            this.foldButton.Location = new System.Drawing.Point(15, 192);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(87, 27);
            this.foldButton.TabIndex = 7;
            this.foldButton.Text = "&More >>";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.FormFolded += new MassFileRenamer.Objects.FormFoldedEventHandler(this.OnFormFolded);
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
            // MainWindow
            // 
            this.AcceptButton = this.performOperationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(596, 478);
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
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private Label startingFolderLabel;
      private Button startingFolderBrowseButton;
      private Label findWhatLabel;
      private Label replaceWithLabel;
      private Button performOperationButton;
      private FoldUnfoldButton foldButton;
      private EntryRespectingComboBox startingFolderComboBox;
      private EntryRespectingComboBox findWhatcomboBox;
      private EntryRespectingComboBox replaceWithComboBox;
        private StatusStrip statusBar;
        private MenuStrip menuBar;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem fileExit;
        private ToolStripMenuItem toolsMenu;
        private ToolStripMenuItem toolsOptions;
        private ToolStripStatusLabel statusBarMessage;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem viewStatusBar;
        private ToolStripMenuItem toolsImportExportConfigMenu;
        private ToolStripMenuItem toolsImportConfig;
        private ToolStripMenuItem toolsExportConfig;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem operationsMenu;
        private ToolStripMenuItem operationsPerform;
        private TabControl optionsTabControl;
        private TabPage findReplaceOptionsTabPage;
        private TabPage operationsTabPage;
        private TabPage inclusionsTabPage;
        private TabPage exclusionsTabPage;
        private CheckedListBox operationsCheckedListBox;
        private CheckBox selectDeselectAllCheckBox;
        private Label tabPageInstructionLabel;
        private CheckBox matchWholeWordCheckBox;
        private CheckBox matchCaseCheckBox;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem helpAbout;
        private ToolStripMenuItem toolsHistoryMenu;
        private ToolStripMenuItem toolsHistoryClearMenu;
        private ToolStripMenuItem toolsHistoryClearStartingFolderHistory;
        private ToolStripMenuItem toolsHistoryClearFindWhatHistory;
        private ToolStripMenuItem toolsHistoryClearReplaceWithHistory;
        private ToolStripMenuItem toolsHistoryClearAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripProgressBar statusBarProgressBar;
        private Label hiddenFocusLabel;
    }
}

