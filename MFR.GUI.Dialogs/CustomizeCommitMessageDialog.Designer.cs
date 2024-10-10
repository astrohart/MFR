namespace MFR.GUI.Dialogs
{
    partial class CustomizeCommitMessageDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeCommitMessageDialog));
            this.okayButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.cancelButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.commitMessageLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.commitMessageTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.detailedCommitMessageTabControl = new xyLOGIX.UI.Dark.Controls.DarkTabControl();
            this.detailedCommitMessageTabPage = new System.Windows.Forms.TabPage();
            this.timezoneButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.rootDirButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.replaceWithButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.findWhatButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.shortDateButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.shortTimeButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.detailedCommitMessageTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.detailedCommitMessageLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.previewDetailedCommitMessageTabPage = new System.Windows.Forms.TabPage();
            this.previewTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.detailedCommitMessageTabControl.SuspendLayout();
            this.detailedCommitMessageTabPage.SuspendLayout();
            this.previewDetailedCommitMessageTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.IsDarkTheme = true;
            this.okayButton.Location = new System.Drawing.Point(492, 12);
            this.okayButton.Name = "okayButton";
            this.okayButton.Padding = new System.Windows.Forms.Padding(5);
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "OK";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.IsDarkTheme = true;
            this.cancelButton.Location = new System.Drawing.Point(492, 45);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            // 
            // commitMessageLabel
            // 
            this.commitMessageLabel.AutoSize = true;
            this.commitMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitMessageLabel.IsDarkTheme = false;
            this.commitMessageLabel.Location = new System.Drawing.Point(12, 9);
            this.commitMessageLabel.Name = "commitMessageLabel";
            this.commitMessageLabel.Size = new System.Drawing.Size(233, 15);
            this.commitMessageLabel.TabIndex = 0;
            this.commitMessageLabel.Text = "&Commit message (required, 50 chars max):";
            // 
            // commitMessageTextBox
            // 
            this.commitMessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.commitMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commitMessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.commitMessageTextBox.IsDarkTheme = false;
            this.commitMessageTextBox.Location = new System.Drawing.Point(13, 28);
            this.commitMessageTextBox.MaxLength = 50;
            this.commitMessageTextBox.Name = "commitMessageTextBox";
            this.commitMessageTextBox.Size = new System.Drawing.Size(459, 23);
            this.commitMessageTextBox.TabIndex = 1;
            // 
            // detailedCommitMessageTabControl
            // 
            this.detailedCommitMessageTabControl.ActiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.detailedCommitMessageTabControl.ActiveTabTextColor = System.Drawing.SystemColors.Highlight;
            this.detailedCommitMessageTabControl.Controls.Add(this.detailedCommitMessageTabPage);
            this.detailedCommitMessageTabControl.Controls.Add(this.previewDetailedCommitMessageTabPage);
            this.detailedCommitMessageTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.detailedCommitMessageTabControl.InactiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.detailedCommitMessageTabControl.InactiveTabTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.detailedCommitMessageTabControl.IsDarkTheme = true;
            this.detailedCommitMessageTabControl.ItemSize = new System.Drawing.Size(0, 18);
            this.detailedCommitMessageTabControl.Location = new System.Drawing.Point(12, 78);
            this.detailedCommitMessageTabControl.Name = "detailedCommitMessageTabControl";
            this.detailedCommitMessageTabControl.SelectedIndex = 0;
            this.detailedCommitMessageTabControl.Size = new System.Drawing.Size(567, 293);
            this.detailedCommitMessageTabControl.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.detailedCommitMessageTabControl.TabIndex = 2;
            this.detailedCommitMessageTabControl.TabWellBackColor = System.Drawing.Color.Empty;
            // 
            // detailedCommitMessageTabPage
            // 
            this.detailedCommitMessageTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.detailedCommitMessageTabPage.Controls.Add(this.timezoneButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.rootDirButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.replaceWithButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.findWhatButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.shortDateButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.shortTimeButton);
            this.detailedCommitMessageTabPage.Controls.Add(this.detailedCommitMessageTextBox);
            this.detailedCommitMessageTabPage.Controls.Add(this.detailedCommitMessageLabel);
            this.detailedCommitMessageTabPage.Location = new System.Drawing.Point(4, 22);
            this.detailedCommitMessageTabPage.Name = "detailedCommitMessageTabPage";
            this.detailedCommitMessageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailedCommitMessageTabPage.Size = new System.Drawing.Size(559, 267);
            this.detailedCommitMessageTabPage.TabIndex = 0;
            this.detailedCommitMessageTabPage.Text = "&Detailed Commit Message (Optional)";
            // 
            // timezoneButton
            // 
            this.timezoneButton.IsDarkTheme = true;
            this.timezoneButton.Location = new System.Drawing.Point(454, 224);
            this.timezoneButton.Name = "timezoneButton";
            this.timezoneButton.Padding = new System.Windows.Forms.Padding(5);
            this.timezoneButton.Size = new System.Drawing.Size(87, 27);
            this.timezoneButton.TabIndex = 7;
            this.timezoneButton.Text = "Time&zone";
            this.timezoneButton.Click += new System.EventHandler(this.OnClickTimezoneButton);
            // 
            // rootDirButton
            // 
            this.rootDirButton.IsDarkTheme = true;
            this.rootDirButton.Location = new System.Drawing.Point(454, 185);
            this.rootDirButton.Name = "rootDirButton";
            this.rootDirButton.Padding = new System.Windows.Forms.Padding(5);
            this.rootDirButton.Size = new System.Drawing.Size(87, 27);
            this.rootDirButton.TabIndex = 6;
            this.rootDirButton.Text = "R&oot Dir";
            this.rootDirButton.Click += new System.EventHandler(this.OnClickRootDir);
            // 
            // replaceWithButton
            // 
            this.replaceWithButton.IsDarkTheme = true;
            this.replaceWithButton.Location = new System.Drawing.Point(455, 146);
            this.replaceWithButton.Name = "replaceWithButton";
            this.replaceWithButton.Padding = new System.Windows.Forms.Padding(5);
            this.replaceWithButton.Size = new System.Drawing.Size(87, 27);
            this.replaceWithButton.TabIndex = 5;
            this.replaceWithButton.Text = "&Replace With";
            this.replaceWithButton.Click += new System.EventHandler(this.OnClickReplaceWithButton);
            // 
            // findWhatButton
            // 
            this.findWhatButton.IsDarkTheme = true;
            this.findWhatButton.Location = new System.Drawing.Point(454, 107);
            this.findWhatButton.Name = "findWhatButton";
            this.findWhatButton.Padding = new System.Windows.Forms.Padding(5);
            this.findWhatButton.Size = new System.Drawing.Size(87, 27);
            this.findWhatButton.TabIndex = 4;
            this.findWhatButton.Text = "Find &What";
            this.findWhatButton.Click += new System.EventHandler(this.OnClickFindWhatButton);
            // 
            // shortDateButton
            // 
            this.shortDateButton.IsDarkTheme = true;
            this.shortDateButton.Location = new System.Drawing.Point(454, 68);
            this.shortDateButton.Name = "shortDateButton";
            this.shortDateButton.Padding = new System.Windows.Forms.Padding(5);
            this.shortDateButton.Size = new System.Drawing.Size(87, 27);
            this.shortDateButton.TabIndex = 3;
            this.shortDateButton.Text = "Short &Date";
            this.shortDateButton.Click += new System.EventHandler(this.OnClickShortDateButton);
            // 
            // shortTimeButton
            // 
            this.shortTimeButton.IsDarkTheme = true;
            this.shortTimeButton.Location = new System.Drawing.Point(454, 29);
            this.shortTimeButton.Name = "shortTimeButton";
            this.shortTimeButton.Padding = new System.Windows.Forms.Padding(5);
            this.shortTimeButton.Size = new System.Drawing.Size(87, 27);
            this.shortTimeButton.TabIndex = 2;
            this.shortTimeButton.Text = "Short &Time";
            this.shortTimeButton.Click += new System.EventHandler(this.OnClickShortTimeButton);
            // 
            // detailedCommitMessageTextBox
            // 
            this.detailedCommitMessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.detailedCommitMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailedCommitMessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.detailedCommitMessageTextBox.IsDarkTheme = false;
            this.detailedCommitMessageTextBox.Location = new System.Drawing.Point(11, 29);
            this.detailedCommitMessageTextBox.Multiline = true;
            this.detailedCommitMessageTextBox.Name = "detailedCommitMessageTextBox";
            this.detailedCommitMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailedCommitMessageTextBox.Size = new System.Drawing.Size(428, 223);
            this.detailedCommitMessageTextBox.TabIndex = 1;
            this.detailedCommitMessageTextBox.TextChanged += new System.EventHandler(this.OnTextChangedDetailedCommitMessage);
            // 
            // detailedCommitMessageLabel
            // 
            this.detailedCommitMessageLabel.AutoSize = true;
            this.detailedCommitMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.detailedCommitMessageLabel.IsDarkTheme = false;
            this.detailedCommitMessageLabel.Location = new System.Drawing.Point(8, 10);
            this.detailedCommitMessageLabel.Name = "detailedCommitMessageLabel";
            this.detailedCommitMessageLabel.Size = new System.Drawing.Size(202, 15);
            this.detailedCommitMessageLabel.TabIndex = 0;
            this.detailedCommitMessageLabel.Text = "&Detailed commit message (optional):";
            // 
            // previewDetailedCommitMessageTabPage
            // 
            this.previewDetailedCommitMessageTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.previewDetailedCommitMessageTabPage.Controls.Add(this.previewTextBox);
            this.previewDetailedCommitMessageTabPage.Location = new System.Drawing.Point(4, 22);
            this.previewDetailedCommitMessageTabPage.Name = "previewDetailedCommitMessageTabPage";
            this.previewDetailedCommitMessageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.previewDetailedCommitMessageTabPage.Size = new System.Drawing.Size(559, 267);
            this.previewDetailedCommitMessageTabPage.TabIndex = 1;
            this.previewDetailedCommitMessageTabPage.Text = "&Preview";
            // 
            // previewTextBox
            // 
            this.previewTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.previewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.previewTextBox.IsDarkTheme = false;
            this.previewTextBox.Location = new System.Drawing.Point(7, 7);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ReadOnly = true;
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewTextBox.Size = new System.Drawing.Size(546, 254);
            this.previewTextBox.TabIndex = 0;
            // 
            // CustomizeCommitMessageDialog
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(597, 379);
            this.Controls.Add(this.detailedCommitMessageTabControl);
            this.Controls.Add(this.commitMessageTextBox);
            this.Controls.Add(this.commitMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeCommitMessageDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customize Commit Message";
            this.detailedCommitMessageTabControl.ResumeLayout(false);
            this.detailedCommitMessageTabPage.ResumeLayout(false);
            this.detailedCommitMessageTabPage.PerformLayout();
            this.previewDetailedCommitMessageTabPage.ResumeLayout(false);
            this.previewDetailedCommitMessageTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private xyLOGIX.UI.Dark.Controls.DarkButton okayButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton cancelButton;
        private xyLOGIX.UI.Dark.Controls.DarkLabel commitMessageLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox commitMessageTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkTabControl detailedCommitMessageTabControl;
        private System.Windows.Forms.TabPage detailedCommitMessageTabPage;
        private System.Windows.Forms.TabPage previewDetailedCommitMessageTabPage;
        private xyLOGIX.UI.Dark.Controls.DarkButton timezoneButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton rootDirButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton replaceWithButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton findWhatButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton shortDateButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton shortTimeButton;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox detailedCommitMessageTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel detailedCommitMessageLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox previewTextBox;
    }
}