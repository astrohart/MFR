
namespace MassFileRenamer.GUI
{
   partial class MainWindow
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
         this.startingFolderTextBox = new System.Windows.Forms.TextBox();
         this.startingFolderLabel = new System.Windows.Forms.Label();
         this.startingFolderBrowseButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // startingFolderTextBox
         // 
         this.startingFolderTextBox.Location = new System.Drawing.Point(12, 29);
         this.startingFolderTextBox.Name = "startingFolderTextBox";
         this.startingFolderTextBox.Size = new System.Drawing.Size(542, 23);
         this.startingFolderTextBox.TabIndex = 1;
         // 
         // startingFolderLabel
         // 
         this.startingFolderLabel.AutoSize = true;
         this.startingFolderLabel.Location = new System.Drawing.Point(12, 10);
         this.startingFolderLabel.Name = "startingFolderLabel";
         this.startingFolderLabel.Size = new System.Drawing.Size(226, 15);
         this.startingFolderLabel.TabIndex = 0;
         this.startingFolderLabel.Text = "What &folder should the operation start in?";
         // 
         // startingFolderBrowseButton
         // 
         this.startingFolderBrowseButton.Location = new System.Drawing.Point(560, 26);
         this.startingFolderBrowseButton.Name = "startingFolderBrowseButton";
         this.startingFolderBrowseButton.Size = new System.Drawing.Size(24, 27);
         this.startingFolderBrowseButton.TabIndex = 2;
         this.startingFolderBrowseButton.Text = "...";
         this.startingFolderBrowseButton.UseVisualStyleBackColor = true;
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(596, 230);
         this.Controls.Add(this.startingFolderBrowseButton);
         this.Controls.Add(this.startingFolderLabel);
         this.Controls.Add(this.startingFolderTextBox);
         this.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "MainWindow";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "[AppTitle]";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox startingFolderTextBox;
      private System.Windows.Forms.Label startingFolderLabel;
      private System.Windows.Forms.Button startingFolderBrowseButton;
   }
}

