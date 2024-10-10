using System.ComponentModel;
using System.Windows.Forms;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs
{
    partial class CancellableProgressDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancellableProgressDialog));
            this.currentFileLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.progressBar = new xyLOGIX.UI.Dark.Controls.DarkProgressBar();
            this.statusLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.cancelButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.currentFileLabel.IsDarkTheme = false;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 56);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(392, 36);
            this.currentFileLabel.TabIndex = 1;
            this.currentFileLabel.UseWaitCursor = true;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.progressBar.DrawBlendShadow = false;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.progressBar.IsDarkTheme = true;
            this.progressBar.Location = new System.Drawing.Point(12, 99);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.MarqueeIncrement = 5;
            this.progressBar.MarqueeWidth = 50F;
            this.progressBar.Name = "progressBar";
            this.progressBar.Percentage = 0;
            this.progressBar.ProgressBarColor = System.Drawing.SystemColors.Highlight;
            this.progressBar.ShowBorder = true;
            this.progressBar.ShowText = false;
            this.progressBar.Size = new System.Drawing.Size(296, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            this.progressBar.UseWaitCursor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusLabel.IsDarkTheme = false;
            this.statusLabel.Location = new System.Drawing.Point(13, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(391, 47);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.UseWaitCursor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.IsDarkTheme = true;
            this.cancelButton.Location = new System.Drawing.Point(318, 99);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseWaitCursor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // CancellableProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(417, 138);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.currentFileLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancellableProgressDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AppTitle]";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        private xyLOGIX.UI.Dark.Controls.DarkLabel currentFileLabel;
        private xyLOGIX.UI.Dark.Controls.DarkLabel statusLabel;
        private xyLOGIX.UI.Dark.Controls.DarkButton cancelButton;
        private xyLOGIX.UI.Dark.Controls.DarkProgressBar progressBar;
    }
}