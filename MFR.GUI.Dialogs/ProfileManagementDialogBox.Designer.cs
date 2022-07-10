
namespace MFR.GUI.Dialogs
{
    partial class ProfileManagementDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileManagementDialogBox));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.profilesListBoxLabel = new System.Windows.Forms.Label();
            this.profilesListBox = new System.Windows.Forms.ListBox();
            this.renameProfileButton = new System.Windows.Forms.Button();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(508, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(415, 312);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // profilesListBoxLabel
            // 
            this.profilesListBoxLabel.AutoSize = true;
            this.profilesListBoxLabel.Location = new System.Drawing.Point(13, 13);
            this.profilesListBoxLabel.Name = "profilesListBoxLabel";
            this.profilesListBoxLabel.Size = new System.Drawing.Size(49, 15);
            this.profilesListBoxLabel.TabIndex = 2;
            this.profilesListBoxLabel.Text = "&Profiles:";
            // 
            // profilesListBox
            // 
            this.profilesListBox.FormattingEnabled = true;
            this.profilesListBox.ItemHeight = 15;
            this.profilesListBox.Location = new System.Drawing.Point(13, 32);
            this.profilesListBox.Name = "profilesListBox";
            this.profilesListBox.ScrollAlwaysVisible = true;
            this.profilesListBox.Size = new System.Drawing.Size(489, 274);
            this.profilesListBox.TabIndex = 3;
            // 
            // renameProfileButton
            // 
            this.renameProfileButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.renameProfileButton.Location = new System.Drawing.Point(508, 32);
            this.renameProfileButton.Name = "renameProfileButton";
            this.renameProfileButton.Size = new System.Drawing.Size(87, 27);
            this.renameProfileButton.TabIndex = 4;
            this.renameProfileButton.Text = "&Rename...";
            this.renameProfileButton.UseVisualStyleBackColor = true;
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteProfileButton.Location = new System.Drawing.Point(508, 65);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(87, 27);
            this.deleteProfileButton.TabIndex = 5;
            this.deleteProfileButton.Text = "&Delete";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            // 
            // ProfileManagementDialogBox
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(604, 353);
            this.Controls.Add(this.deleteProfileButton);
            this.Controls.Add(this.renameProfileButton);
            this.Controls.Add(this.profilesListBox);
            this.Controls.Add(this.profilesListBoxLabel);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileManagementDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Profiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label profilesListBoxLabel;
        private System.Windows.Forms.ListBox profilesListBox;
        private System.Windows.Forms.Button renameProfileButton;
        private System.Windows.Forms.Button deleteProfileButton;
    }
}