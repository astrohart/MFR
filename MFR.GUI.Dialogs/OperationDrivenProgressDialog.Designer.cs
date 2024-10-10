namespace MFR.GUI.Dialogs
{
    partial class OperationDrivenProgressDialog
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationDrivenProgressDialog));
            this.statusLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.progressBar = new xyLOGIX.UI.Dark.Controls.DarkProgressBar();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusLabel.IsDarkTheme = false;
            this.statusLabel.Location = new System.Drawing.Point(13, 13);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(419, 57);
            this.statusLabel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.progressBar.DrawBlendShadow = false;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.progressBar.IsDarkTheme = true;
            this.progressBar.Location = new System.Drawing.Point(16, 85);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.MarqueeIncrement = 5;
            this.progressBar.MarqueeWidth = 50F;
            this.progressBar.Name = "progressBar";
            this.progressBar.Percentage = 0;
            this.progressBar.ProgressBarColor = System.Drawing.SystemColors.Highlight;
            this.progressBar.ShowBorder = true;
            this.progressBar.ShowText = false;
            this.progressBar.Size = new System.Drawing.Size(416, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            // 
            // OperationDrivenProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 122);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationDrivenProgressDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationDrivenProgressDialog";
            this.ResumeLayout(false);

        }
        private xyLOGIX.UI.Dark.Controls.DarkProgressBar progressBar;
        private xyLOGIX.UI.Dark.Controls.DarkLabel statusLabel;
    }
}