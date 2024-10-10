using System.ComponentModel;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs
{
    partial class ErrorReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorReportDialog));
            this.appIconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainInstructionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.bevel = new xyLOGIX.UI.Dark.Controls.DarkGroupBox();
            this.secondaryInstructionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.tertiaryInstructionLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.viewReportLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reproductionStepsLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.reproductionStepsTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.sendReportButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.dontSendReportButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.nameOfUserLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.nameOfUserTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.emailAddressOfUserTextBox = new xyLOGIX.UI.Dark.Controls.DarkTextBox();
            this.emailOfUserLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appIconPictureBox
            // 
            this.appIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appIconPictureBox.Image")));
            this.appIconPictureBox.Location = new System.Drawing.Point(13, 13);
            this.appIconPictureBox.Name = "appIconPictureBox";
            this.appIconPictureBox.Size = new System.Drawing.Size(48, 48);
            this.appIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIconPictureBox.TabIndex = 0;
            this.appIconPictureBox.TabStop = false;
            // 
            // mainInstructionLabel
            // 
            this.mainInstructionLabel.AutoSize = true;
            this.mainInstructionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.mainInstructionLabel.IsDarkTheme = false;
            this.mainInstructionLabel.Location = new System.Drawing.Point(88, 25);
            this.mainInstructionLabel.Name = "mainInstructionLabel";
            this.mainInstructionLabel.Size = new System.Drawing.Size(175, 20);
            this.mainInstructionLabel.TabIndex = 0;
            this.mainInstructionLabel.Text = "Sorry, an error occurred";
            // 
            // bevel
            // 
            this.bevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bevel.IsDarkTheme = false;
            this.bevel.Location = new System.Drawing.Point(15, 76);
            this.bevel.Name = "bevel";
            this.bevel.Size = new System.Drawing.Size(459, 2);
            this.bevel.TabIndex = 1;
            this.bevel.TabStop = false;
            // 
            // secondaryInstructionLabel
            // 
            this.secondaryInstructionLabel.AutoSize = true;
            this.secondaryInstructionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.secondaryInstructionLabel.IsDarkTheme = false;
            this.secondaryInstructionLabel.Location = new System.Drawing.Point(12, 95);
            this.secondaryInstructionLabel.Name = "secondaryInstructionLabel";
            this.secondaryInstructionLabel.Size = new System.Drawing.Size(334, 17);
            this.secondaryInstructionLabel.TabIndex = 2;
            this.secondaryInstructionLabel.Text = "[AppTitle] encountered a problem and needs to close.";
            // 
            // tertiaryInstructionLabel
            // 
            this.tertiaryInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tertiaryInstructionLabel.IsDarkTheme = false;
            this.tertiaryInstructionLabel.Location = new System.Drawing.Point(15, 132);
            this.tertiaryInstructionLabel.Name = "tertiaryInstructionLabel";
            this.tertiaryInstructionLabel.Size = new System.Drawing.Size(459, 33);
            this.tertiaryInstructionLabel.TabIndex = 3;
            this.tertiaryInstructionLabel.Text = "An error report has been generated.  Click \"Send Report\" to help us analyze the c" +
    "ause of the problem and explore solutions.";
            // 
            // viewReportLinkLabel
            // 
            this.viewReportLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.viewReportLinkLabel.AutoSize = true;
            this.viewReportLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewReportLinkLabel.Location = new System.Drawing.Point(18, 184);
            this.viewReportLinkLabel.Name = "viewReportLinkLabel";
            this.viewReportLinkLabel.Size = new System.Drawing.Size(67, 15);
            this.viewReportLinkLabel.TabIndex = 4;
            this.viewReportLinkLabel.TabStop = true;
            this.viewReportLinkLabel.Text = "View report";
            this.viewReportLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClickedViewErrorReportLinkLabel);
            // 
            // reproductionStepsLabel
            // 
            this.reproductionStepsLabel.AutoSize = true;
            this.reproductionStepsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.reproductionStepsLabel.IsDarkTheme = false;
            this.reproductionStepsLabel.Location = new System.Drawing.Point(18, 216);
            this.reproductionStepsLabel.Name = "reproductionStepsLabel";
            this.reproductionStepsLabel.Size = new System.Drawing.Size(187, 15);
            this.reproductionStepsLabel.TabIndex = 5;
            this.reproductionStepsLabel.Text = "Please tell us what led to the error.";
            // 
            // reproductionStepsTextBox
            // 
            this.reproductionStepsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.reproductionStepsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reproductionStepsTextBox.CueText = "";
            this.reproductionStepsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.reproductionStepsTextBox.Location = new System.Drawing.Point(21, 235);
            this.reproductionStepsTextBox.Multiline = true;
            this.reproductionStepsTextBox.Name = "reproductionStepsTextBox";
            this.reproductionStepsTextBox.ReadOnly = true;
            this.reproductionStepsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reproductionStepsTextBox.Size = new System.Drawing.Size(453, 129);
            this.reproductionStepsTextBox.TabIndex = 6;
            // 
            // sendReportButton
            // 
            this.sendReportButton.AcceptBorderColor = System.Drawing.SystemColors.Highlight;
            this.sendReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.sendReportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendReportButton.IsDarkTheme = true;
            this.sendReportButton.Location = new System.Drawing.Point(390, 442);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.Padding = new System.Windows.Forms.Padding(5);
            this.sendReportButton.Size = new System.Drawing.Size(87, 27);
            this.sendReportButton.TabIndex = 12;
            this.sendReportButton.Text = "&Send report";
            this.sendReportButton.Click += new System.EventHandler(this.OnClickSendReportButton);
            // 
            // dontSendReportButton
            // 
            this.dontSendReportButton.AcceptBorderColor = System.Drawing.SystemColors.Highlight;
            this.dontSendReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dontSendReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dontSendReportButton.IsDarkTheme = true;
            this.dontSendReportButton.Location = new System.Drawing.Point(297, 442);
            this.dontSendReportButton.Name = "dontSendReportButton";
            this.dontSendReportButton.Padding = new System.Windows.Forms.Padding(5);
            this.dontSendReportButton.Size = new System.Drawing.Size(87, 27);
            this.dontSendReportButton.TabIndex = 11;
            this.dontSendReportButton.Text = "&Don\'t send";
            // 
            // nameOfUserLabel
            // 
            this.nameOfUserLabel.AutoSize = true;
            this.nameOfUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.nameOfUserLabel.IsDarkTheme = false;
            this.nameOfUserLabel.Location = new System.Drawing.Point(21, 376);
            this.nameOfUserLabel.Name = "nameOfUserLabel";
            this.nameOfUserLabel.Size = new System.Drawing.Size(42, 15);
            this.nameOfUserLabel.TabIndex = 7;
            this.nameOfUserLabel.Text = "&Name:";
            // 
            // nameOfUserTextBox
            // 
            this.nameOfUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.nameOfUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOfUserTextBox.CueText = "Your Name (optional)";
            this.nameOfUserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.nameOfUserTextBox.Location = new System.Drawing.Point(69, 374);
            this.nameOfUserTextBox.Name = "nameOfUserTextBox";
            this.nameOfUserTextBox.Size = new System.Drawing.Size(405, 23);
            this.nameOfUserTextBox.TabIndex = 8;
            // 
            // emailAddressOfUserTextBox
            // 
            this.emailAddressOfUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.emailAddressOfUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailAddressOfUserTextBox.CueText = "email@domain.com (optional)";
            this.emailAddressOfUserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.emailAddressOfUserTextBox.Location = new System.Drawing.Point(69, 403);
            this.emailAddressOfUserTextBox.Name = "emailAddressOfUserTextBox";
            this.emailAddressOfUserTextBox.Size = new System.Drawing.Size(405, 23);
            this.emailAddressOfUserTextBox.TabIndex = 10;
            // 
            // emailOfUserLabel
            // 
            this.emailOfUserLabel.AutoSize = true;
            this.emailOfUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.emailOfUserLabel.IsDarkTheme = false;
            this.emailOfUserLabel.Location = new System.Drawing.Point(21, 405);
            this.emailOfUserLabel.Name = "emailOfUserLabel";
            this.emailOfUserLabel.Size = new System.Drawing.Size(39, 15);
            this.emailOfUserLabel.TabIndex = 9;
            this.emailOfUserLabel.Text = "&Email:";
            // 
            // ErrorReportDialog
            // 
            this.AcceptButton = this.sendReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CancelButton = this.sendReportButton;
            this.ClientSize = new System.Drawing.Size(489, 481);
            this.Controls.Add(this.emailAddressOfUserTextBox);
            this.Controls.Add(this.emailOfUserLabel);
            this.Controls.Add(this.nameOfUserTextBox);
            this.Controls.Add(this.nameOfUserLabel);
            this.Controls.Add(this.dontSendReportButton);
            this.Controls.Add(this.sendReportButton);
            this.Controls.Add(this.reproductionStepsTextBox);
            this.Controls.Add(this.reproductionStepsLabel);
            this.Controls.Add(this.viewReportLinkLabel);
            this.Controls.Add(this.tertiaryInstructionLabel);
            this.Controls.Add(this.secondaryInstructionLabel);
            this.Controls.Add(this.bevel);
            this.Controls.Add(this.mainInstructionLabel);
            this.Controls.Add(this.appIconPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorReportDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[AppTitle]";
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox appIconPictureBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel mainInstructionLabel;
        private xyLOGIX.UI.Dark.Controls.DarkGroupBox bevel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel secondaryInstructionLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel tertiaryInstructionLabel;
        private System.Windows.Forms.LinkLabel viewReportLinkLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel reproductionStepsLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox reproductionStepsTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkButton sendReportButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton dontSendReportButton;
        private xyLOGIX.UI.Dark.Controls.DarkLabel nameOfUserLabel;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox nameOfUserTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkTextBox emailAddressOfUserTextBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel emailOfUserLabel;
    }
}