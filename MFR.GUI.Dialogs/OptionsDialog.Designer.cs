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
            this.configurationTabPage = new System.Windows.Forms.TabPage();
            this.configPathnamePromptLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.configPathnameTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.configPathnameBrowseButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.configPathnameLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.visualStudioTabPage = new System.Windows.Forms.TabPage();
            this.reOpenSolutionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.reOpenSolutionCheckBox = new System.Windows.Forms.CheckBox();
            this.configPathBrowseBox = new System.Windows.Forms.OpenFileDialog();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.optionsTabControl.SuspendLayout();
            this.configurationTabPage.SuspendLayout();
            this.visualStudioTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(366, 392);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(87, 27);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "&Apply";
            this.applyButton.Click += new System.EventHandler(this.OnClickApply);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(273, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(180, 392);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.configurationTabPage);
            this.optionsTabControl.Controls.Add(this.visualStudioTabPage);
            this.optionsTabControl.Controls.Add(this.generalTabPage);
            this.optionsTabControl.Location = new System.Drawing.Point(13, 13);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(444, 373);
            this.optionsTabControl.TabIndex = 0;
            // 
            // configurationTabPage
            // 
            this.configurationTabPage.Controls.Add(this.configPathnamePromptLabel);
            this.configurationTabPage.Controls.Add(this.configPathnameTextBox);
            this.configurationTabPage.Controls.Add(this.configPathnameBrowseButton);
            this.configurationTabPage.Controls.Add(this.configPathnameLabel);
            this.configurationTabPage.Location = new System.Drawing.Point(4, 24);
            this.configurationTabPage.Name = "configurationTabPage";
            this.configurationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.configurationTabPage.Size = new System.Drawing.Size(436, 345);
            this.configurationTabPage.TabIndex = 0;
            this.configurationTabPage.Text = "Configuration";
            this.configurationTabPage.UseVisualStyleBackColor = true;
            // 
            // configPathnamePromptLabel
            // 
            this.configPathnamePromptLabel.Location = new System.Drawing.Point(17, 17);
            this.configPathnamePromptLabel.Name = "configPathnamePromptLabel";
            this.configPathnamePromptLabel.Size = new System.Drawing.Size(295, 37);
            this.configPathnamePromptLabel.TabIndex = 0;
            this.configPathnamePromptLabel.Text = "Where on your computer should we store the configuration file?";
            // 
            // configPathnameTextBox
            // 
            this.configPathnameTextBox.Location = new System.Drawing.Point(17, 85);
            this.configPathnameTextBox.Name = "configPathnameTextBox";
            this.configPathnameTextBox.Size = new System.Drawing.Size(382, 23);
            this.configPathnameTextBox.TabIndex = 2;
            this.configPathnameTextBox.TextChanged += new System.EventHandler(this.OnTextChangedConfiguraitonFilePathname);
            // 
            // configPathnameBrowseButton
            // 
            this.configPathnameBrowseButton.Location = new System.Drawing.Point(405, 85);
            this.configPathnameBrowseButton.Name = "configPathnameBrowseButton";
            this.configPathnameBrowseButton.Size = new System.Drawing.Size(25, 23);
            this.configPathnameBrowseButton.TabIndex = 3;
            this.configPathnameBrowseButton.Text = "...";
            this.configPathnameBrowseButton.Click += new System.EventHandler(this.OnClickConfigPathnameBrowseButton);
            // 
            // configPathnameLabel
            // 
            this.configPathnameLabel.AutoSize = true;
            this.configPathnameLabel.Location = new System.Drawing.Point(14, 67);
            this.configPathnameLabel.Name = "configPathnameLabel";
            this.configPathnameLabel.Size = new System.Drawing.Size(200, 15);
            this.configPathnameLabel.TabIndex = 1;
            this.configPathnameLabel.Text = "&CurrentConfiguration file pathname:";
            // 
            // visualStudioTabPage
            // 
            this.visualStudioTabPage.Controls.Add(this.reOpenSolutionLabel);
            this.visualStudioTabPage.Controls.Add(this.reOpenSolutionCheckBox);
            this.visualStudioTabPage.Location = new System.Drawing.Point(4, 24);
            this.visualStudioTabPage.Name = "visualStudioTabPage";
            this.visualStudioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visualStudioTabPage.Size = new System.Drawing.Size(436, 345);
            this.visualStudioTabPage.TabIndex = 1;
            this.visualStudioTabPage.Text = "Visual Studio";
            this.visualStudioTabPage.UseVisualStyleBackColor = true;
            // 
            // reOpenSolutionLabel
            // 
            this.reOpenSolutionLabel.Location = new System.Drawing.Point(39, 14);
            this.reOpenSolutionLabel.Name = "reOpenSolutionLabel";
            this.reOpenSolutionLabel.Size = new System.Drawing.Size(331, 38);
            this.reOpenSolutionLabel.TabIndex = 1;
            this.reOpenSolutionLabel.Text = "Close and then re-open containing solution before\r\nand after operation(s)";
            // 
            // reOpenSolutionCheckBox
            // 
            this.reOpenSolutionCheckBox.AutoSize = true;
            this.reOpenSolutionCheckBox.Checked = true;
            this.reOpenSolutionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reOpenSolutionCheckBox.Location = new System.Drawing.Point(18, 18);
            this.reOpenSolutionCheckBox.Name = "reOpenSolutionCheckBox";
            this.reOpenSolutionCheckBox.Size = new System.Drawing.Size(15, 14);
            this.reOpenSolutionCheckBox.TabIndex = 0;
            this.reOpenSolutionCheckBox.UseVisualStyleBackColor = true;
            // 
            // configPathBrowseBox
            // 
            this.configPathBrowseBox.DefaultExt = "json";
            this.configPathBrowseBox.FileName = "config.json";
            this.configPathBrowseBox.Filter = "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*";
            this.configPathBrowseBox.RestoreDirectory = true;
            this.configPathBrowseBox.Title = "Browse";
            // 
            // generalTabPage
            // 
            this.generalTabPage.Location = new System.Drawing.Point(4, 24);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(436, 345);
            this.generalTabPage.TabIndex = 2;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
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
            this.configurationTabPage.ResumeLayout(false);
            this.configurationTabPage.PerformLayout();
            this.visualStudioTabPage.ResumeLayout(false);
            this.visualStudioTabPage.PerformLayout();
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
        private System.Windows.Forms.CheckBox reOpenSolutionCheckBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel reOpenSolutionLabel;
        private TabPage generalTabPage;
    }
}