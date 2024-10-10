namespace MFR.GUI.Dialogs
{
    partial class ProfileNameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileNameDialog));
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.readMoreAboutProfilesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Location = new System.Drawing.Point(13, 17);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(242, 15);
            this.profileNameLabel.TabIndex = 0;
            this.profileNameLabel.Text = "&What name do you want for the new Profile?";
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(16, 36);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(450, 23);
            this.profileNameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(379, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Location = new System.Drawing.Point(278, 96);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(87, 27);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "&Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // readMoreAboutProfilesLinkLabel
            // 
            this.readMoreAboutProfilesLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.readMoreAboutProfilesLinkLabel.AutoSize = true;
            this.readMoreAboutProfilesLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.readMoreAboutProfilesLinkLabel.Location = new System.Drawing.Point(16, 66);
            this.readMoreAboutProfilesLinkLabel.Name = "readMoreAboutProfilesLinkLabel";
            this.readMoreAboutProfilesLinkLabel.Size = new System.Drawing.Size(140, 15);
            this.readMoreAboutProfilesLinkLabel.TabIndex = 5;
            this.readMoreAboutProfilesLinkLabel.TabStop = true;
            this.readMoreAboutProfilesLinkLabel.Text = "Read more about Profiles";
            this.readMoreAboutProfilesLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.readMoreAboutProfilesLinkLabel.Click += new System.EventHandler(this.OnClickReadMoreAboutProfilesLinkLabel);
            // 
            // ProfileNameDialog
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(478, 140);
            this.Controls.Add(this.readMoreAboutProfilesLinkLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.profileNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileNameDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.LinkLabel readMoreAboutProfilesLinkLabel;
    }
}