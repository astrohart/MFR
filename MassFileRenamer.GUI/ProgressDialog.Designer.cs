
namespace MassFileRenamer.GUI
{
   partial class ProgressDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressDialog));
         this.detailedStatusLabel = new System.Windows.Forms.Label();
         this.progressBar = new System.Windows.Forms.ProgressBar();
         this.statusLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // detailedStatusLabel
         // 
         this.detailedStatusLabel.Location = new System.Drawing.Point(12, 46);
         this.detailedStatusLabel.Name = "detailedStatusLabel";
         this.detailedStatusLabel.Size = new System.Drawing.Size(392, 46);
         this.detailedStatusLabel.TabIndex = 0;
         this.detailedStatusLabel.Text = "[Detailed Status]";
         // 
         // progressBar
         // 
         this.progressBar.Location = new System.Drawing.Point(12, 100);
         this.progressBar.MarqueeAnimationSpeed = 30;
         this.progressBar.Name = "progressBar";
         this.progressBar.Size = new System.Drawing.Size(392, 23);
         this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this.progressBar.TabIndex = 1;
         // 
         // statusLabel
         // 
         this.statusLabel.Location = new System.Drawing.Point(13, 14);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(391, 24);
         this.statusLabel.TabIndex = 2;
         this.statusLabel.Text = "[Status]";
         // 
         // ProgressDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(417, 138);
         this.ControlBox = false;
         this.Controls.Add(this.statusLabel);
         this.Controls.Add(this.progressBar);
         this.Controls.Add(this.detailedStatusLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ProgressDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "[AppTitle]";
         this.TopMost = true;
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label detailedStatusLabel;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Label statusLabel;
   }
}