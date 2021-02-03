
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
         this.startingFolderLabel = new System.Windows.Forms.Label();
         this.startingFolderBrowseButton = new System.Windows.Forms.Button();
         this.findWhatLabel = new System.Windows.Forms.Label();
         this.replaceWithLabel = new System.Windows.Forms.Label();
         this.performOperationButton = new System.Windows.Forms.Button();
         this.foldButton = new MassFileRenamer.Objects.FoldUnfoldButton();
         this.startingFolderComboBox = new System.Windows.Forms.ComboBox();
         this.findWhatcomboBox = new System.Windows.Forms.ComboBox();
         this.replaceWithComboBox = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
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
         this.startingFolderBrowseButton.Click += new System.EventHandler(this.OnClickBrowse);
         // 
         // findWhatLabel
         // 
         this.findWhatLabel.AutoSize = true;
         this.findWhatLabel.Location = new System.Drawing.Point(9, 65);
         this.findWhatLabel.Name = "findWhatLabel";
         this.findWhatLabel.Size = new System.Drawing.Size(109, 15);
         this.findWhatLabel.TabIndex = 3;
         this.findWhatLabel.Text = "&Text to be replaced:";
         // 
         // replaceWithLabel
         // 
         this.replaceWithLabel.AutoSize = true;
         this.replaceWithLabel.Location = new System.Drawing.Point(9, 119);
         this.replaceWithLabel.Name = "replaceWithLabel";
         this.replaceWithLabel.Size = new System.Drawing.Size(64, 15);
         this.replaceWithLabel.TabIndex = 5;
         this.replaceWithLabel.Text = "&With what:";
         // 
         // performOperationButton
         // 
         this.performOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.performOperationButton.Location = new System.Drawing.Point(436, 167);
         this.performOperationButton.Name = "performOperationButton";
         this.performOperationButton.Size = new System.Drawing.Size(148, 27);
         this.performOperationButton.TabIndex = 8;
         this.performOperationButton.Text = "&Perform Operation";
         this.performOperationButton.UseVisualStyleBackColor = true;
         this.performOperationButton.Click += new System.EventHandler(this.OnClickPerformOperation);
         // 
         // foldButton
         // 
         this.foldButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.foldButton.Enabled = false;
         this.foldButton.FormFoldedSize = new System.Drawing.Size(612, 243);
         this.foldButton.FormUnfoldedSize = new System.Drawing.Size(612, 510);
         this.foldButton.Location = new System.Drawing.Point(15, 167);
         this.foldButton.Name = "foldButton";
         this.foldButton.Size = new System.Drawing.Size(87, 27);
         this.foldButton.TabIndex = 7;
         this.foldButton.Text = "&More >>";
         this.foldButton.UseVisualStyleBackColor = true;
         this.foldButton.FormFolded += new MassFileRenamer.Objects.FormFoldedEventHandler(this.OnFormFolded);
         // 
         // startingFolderTextBox
         // 
         this.startingFolderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.startingFolderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.startingFolderComboBox.FormattingEnabled = true;
         this.startingFolderComboBox.Location = new System.Drawing.Point(15, 29);
         this.startingFolderComboBox.Name = "startingFolderComboBox";
         this.startingFolderComboBox.Size = new System.Drawing.Size(539, 23);
         this.startingFolderComboBox.TabIndex = 1;
         // 
         // findWhatTextBox
         // 
         this.findWhatcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.findWhatcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.findWhatcomboBox.FormattingEnabled = true;
         this.findWhatcomboBox.Location = new System.Drawing.Point(15, 84);
         this.findWhatcomboBox.Name = "findWhatcomboBox";
         this.findWhatcomboBox.Size = new System.Drawing.Size(572, 23);
         this.findWhatcomboBox.TabIndex = 4;
         // 
         // replaceWithTextBox
         // 
         this.replaceWithComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.replaceWithComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.replaceWithComboBox.FormattingEnabled = true;
         this.replaceWithComboBox.Location = new System.Drawing.Point(15, 138);
         this.replaceWithComboBox.Name = "replaceWithComboBox";
         this.replaceWithComboBox.Size = new System.Drawing.Size(572, 23);
         this.replaceWithComboBox.TabIndex = 6;
         // 
         // MainWindow
         // 
         this.AcceptButton = this.performOperationButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(596, 204);
         this.Controls.Add(this.replaceWithComboBox);
         this.Controls.Add(this.findWhatcomboBox);
         this.Controls.Add(this.startingFolderComboBox);
         this.Controls.Add(this.foldButton);
         this.Controls.Add(this.performOperationButton);
         this.Controls.Add(this.replaceWithLabel);
         this.Controls.Add(this.findWhatLabel);
         this.Controls.Add(this.startingFolderBrowseButton);
         this.Controls.Add(this.startingFolderLabel);
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

      private System.Windows.Forms.Label startingFolderLabel;
      private System.Windows.Forms.Button startingFolderBrowseButton;
      private System.Windows.Forms.Label findWhatLabel;
      private System.Windows.Forms.Label replaceWithLabel;
      private System.Windows.Forms.Button performOperationButton;
      private MassFileRenamer.Objects.FoldUnfoldButton foldButton;
      private System.Windows.Forms.ComboBox startingFolderComboBox;
      private System.Windows.Forms.ComboBox findWhatcomboBox;
      private System.Windows.Forms.ComboBox replaceWithComboBox;
   }
}

