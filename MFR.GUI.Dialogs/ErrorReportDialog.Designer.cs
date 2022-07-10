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
            this.mainInstructionLabel = new System.Windows.Forms.Label();
            this.bevel = new System.Windows.Forms.GroupBox();
            this.secondaryInstructionLabel = new System.Windows.Forms.Label();
            this.tertiaryInstructionLabel = new System.Windows.Forms.Label();
            this.viewReportLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reproductionStepsLabel = new System.Windows.Forms.Label();
            this.reproductionStepsTextBox = new System.Windows.Forms.TextBox();
            this.sendReportButton = new System.Windows.Forms.Button();
            this.dontSendReportButton = new System.Windows.Forms.Button();
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
            this.mainInstructionLabel.Location = new System.Drawing.Point(88, 25);
            this.mainInstructionLabel.Name = "mainInstructionLabel";
            this.mainInstructionLabel.Size = new System.Drawing.Size(175, 20);
            this.mainInstructionLabel.TabIndex = 0;
            this.mainInstructionLabel.Text = "Sorry, an error occurred";
            // 
            // bevel
            // 
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
            this.secondaryInstructionLabel.Location = new System.Drawing.Point(12, 95);
            this.secondaryInstructionLabel.Name = "secondaryInstructionLabel";
            this.secondaryInstructionLabel.Size = new System.Drawing.Size(334, 17);
            this.secondaryInstructionLabel.TabIndex = 2;
            this.secondaryInstructionLabel.Text = "[AppTitle] encountered a problem and needs to close.";
            // 
            // tertiaryInstructionLabel
            // 
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
            this.reproductionStepsLabel.Location = new System.Drawing.Point(18, 216);
            this.reproductionStepsLabel.Name = "reproductionStepsLabel";
            this.reproductionStepsLabel.Size = new System.Drawing.Size(187, 15);
            this.reproductionStepsLabel.TabIndex = 5;
            this.reproductionStepsLabel.Text = "Please tell us what led to the error.";
            // 
            // reproductionStepsTextBox
            // 
            this.reproductionStepsTextBox.Location = new System.Drawing.Point(21, 235);
            this.reproductionStepsTextBox.Multiline = true;
            this.reproductionStepsTextBox.Name = "reproductionStepsTextBox";
            this.reproductionStepsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reproductionStepsTextBox.Size = new System.Drawing.Size(453, 129);
            this.reproductionStepsTextBox.TabIndex = 6;
            // 
            // sendReportButton
            // 
            this.sendReportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendReportButton.Location = new System.Drawing.Point(390, 379);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.Size = new System.Drawing.Size(87, 27);
            this.sendReportButton.TabIndex = 8;
            this.sendReportButton.Text = "&Send report";
            this.sendReportButton.UseVisualStyleBackColor = true;
            this.sendReportButton.Click += new System.EventHandler(this.OnClickSendReportButton);
            // 
            // dontSendReportButton
            // 
            this.dontSendReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dontSendReportButton.Location = new System.Drawing.Point(297, 379);
            this.dontSendReportButton.Name = "dontSendReportButton";
            this.dontSendReportButton.Size = new System.Drawing.Size(87, 27);
            this.dontSendReportButton.TabIndex = 7;
            this.dontSendReportButton.Text = "&Don\'t send";
            this.dontSendReportButton.UseVisualStyleBackColor = true;
            // 
            // ErrorReportDialog
            // 
            this.AcceptButton = this.sendReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.sendReportButton;
            this.ClientSize = new System.Drawing.Size(489, 418);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[AppTitle]";
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox appIconPictureBox;
        private System.Windows.Forms.Label mainInstructionLabel;
        private System.Windows.Forms.GroupBox bevel;
        private System.Windows.Forms.Label secondaryInstructionLabel;
        private System.Windows.Forms.Label tertiaryInstructionLabel;
        private System.Windows.Forms.LinkLabel viewReportLinkLabel;
        private System.Windows.Forms.Label reproductionStepsLabel;
        private System.Windows.Forms.TextBox reproductionStepsTextBox;
        private System.Windows.Forms.Button sendReportButton;
        private System.Windows.Forms.Button dontSendReportButton;
    }
}