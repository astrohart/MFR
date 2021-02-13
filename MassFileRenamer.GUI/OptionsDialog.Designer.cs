
namespace MassFileRenamer.GUI
{
    partial class OptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.configPathnameLabel = new System.Windows.Forms.Label();
            this.configPathnameBrowseButton = new System.Windows.Forms.Button();
            this.configPathnameTextBox = new System.Windows.Forms.TextBox();
            this.configPathnamePromptLabel = new System.Windows.Forms.Label();
            this.configPathBrowseBox = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(242, 392);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(87, 27);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.OnClickApply);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(149, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(56, 392);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.configPathnamePromptLabel);
            this.generalTabPage.Controls.Add(this.configPathnameTextBox);
            this.generalTabPage.Controls.Add(this.configPathnameBrowseButton);
            this.generalTabPage.Controls.Add(this.configPathnameLabel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 24);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(308, 345);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // configPathnameLabel
            // 
            this.configPathnameLabel.AutoSize = true;
            this.configPathnameLabel.Location = new System.Drawing.Point(4, 57);
            this.configPathnameLabel.Name = "configPathnameLabel";
            this.configPathnameLabel.Size = new System.Drawing.Size(160, 15);
            this.configPathnameLabel.TabIndex = 1;
            this.configPathnameLabel.Text = "&Configuration file pathname:";
            // 
            // configPathnameBrowseButton
            // 
            this.configPathnameBrowseButton.Location = new System.Drawing.Point(266, 74);
            this.configPathnameBrowseButton.Name = "configPathnameBrowseButton";
            this.configPathnameBrowseButton.Size = new System.Drawing.Size(25, 23);
            this.configPathnameBrowseButton.TabIndex = 3;
            this.configPathnameBrowseButton.Text = "...";
            this.configPathnameBrowseButton.UseVisualStyleBackColor = true;
            this.configPathnameBrowseButton.Click += new System.EventHandler(this.OnClickConfigPathnameBrowseButton);
            // 
            // configPathnameTextBox
            // 
            this.configPathnameTextBox.Location = new System.Drawing.Point(7, 75);
            this.configPathnameTextBox.Name = "configPathnameTextBox";
            this.configPathnameTextBox.Size = new System.Drawing.Size(253, 23);
            this.configPathnameTextBox.TabIndex = 2;
            this.configPathnameTextBox.TextChanged += new System.EventHandler(this.OnTextChangedConfiguraitonFilePathname);
            // 
            // configPathnamePromptLabel
            // 
            this.configPathnamePromptLabel.Location = new System.Drawing.Point(7, 7);
            this.configPathnamePromptLabel.Name = "configPathnamePromptLabel";
            this.configPathnamePromptLabel.Size = new System.Drawing.Size(295, 37);
            this.configPathnamePromptLabel.TabIndex = 0;
            this.configPathnamePromptLabel.Text = "Where on your computer should we store the configuration file?";
            // 
            // configPathBrowseBox
            // 
            this.configPathBrowseBox.DefaultExt = "json";
            this.configPathBrowseBox.FileName = "config.json";
            this.configPathBrowseBox.Filter = "JavaScript Over Network (JSON) Files (*.json)|*.json|All Files (*.*)|*.*";
            this.configPathBrowseBox.RestoreDirectory = true;
            this.configPathBrowseBox.Title = "Browse";
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(341, 431);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Label configPathnameLabel;
        private System.Windows.Forms.TextBox configPathnameTextBox;
        private System.Windows.Forms.Button configPathnameBrowseButton;
        private System.Windows.Forms.Label configPathnamePromptLabel;
        private System.Windows.Forms.OpenFileDialog configPathBrowseBox;
    }
}