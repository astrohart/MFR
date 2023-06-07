
namespace MFR.GUI.Controls
{
    partial class DarkListBuilderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftListBoxLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.leftListBox = new xyLOGIX.UI.Dark.Controls.DarkListBox();
            this.addButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.addAllButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.removeButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.removeAllButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.rightListBox = new xyLOGIX.UI.Dark.Controls.DarkListBox();
            this.rightListBoxLabel = new xyLOGIX.UI.Dark.Controls.DarkLabel();
            this.moveDownButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.moveUpButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // leftListBoxLabel
            // 
            this.leftListBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.leftListBoxLabel.IsDarkTheme = true;
            this.leftListBoxLabel.Location = new System.Drawing.Point(14, 4);
            this.leftListBoxLabel.Name = "leftListBoxLabel";
            this.leftListBoxLabel.Size = new System.Drawing.Size(266, 13);
            this.leftListBoxLabel.TabIndex = 0;
            this.leftListBoxLabel.Text = "&Available items:";
            // 
            // leftListBox
            // 
            this.leftListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.leftListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.IsDarkTheme = false;
            this.leftListBox.ItemHeight = 15;
            this.leftListBox.Location = new System.Drawing.Point(14, 22);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.Size = new System.Drawing.Size(266, 287);
            this.leftListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.IsDarkTheme = false;
            this.addButton.Location = new System.Drawing.Point(286, 51);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(5);
            this.addButton.Size = new System.Drawing.Size(125, 27);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add >";
            this.addButton.Click += new System.EventHandler(this.OnClickAddButton);
            // 
            // addAllButton
            // 
            this.addAllButton.IsDarkTheme = false;
            this.addAllButton.Location = new System.Drawing.Point(286, 84);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Padding = new System.Windows.Forms.Padding(5);
            this.addAllButton.Size = new System.Drawing.Size(125, 27);
            this.addAllButton.TabIndex = 3;
            this.addAllButton.Text = "A&dd All >>";
            this.addAllButton.Click += new System.EventHandler(this.OnClickAddAllButton);
            // 
            // removeButton
            // 
            this.removeButton.IsDarkTheme = false;
            this.removeButton.Location = new System.Drawing.Point(286, 132);
            this.removeButton.Name = "removeButton";
            this.removeButton.Padding = new System.Windows.Forms.Padding(5);
            this.removeButton.Size = new System.Drawing.Size(125, 27);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "< &Remove";
            this.removeButton.Click += new System.EventHandler(this.OnClickRemoveButton);
            // 
            // removeAllButton
            // 
            this.removeAllButton.IsDarkTheme = false;
            this.removeAllButton.Location = new System.Drawing.Point(286, 165);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Padding = new System.Windows.Forms.Padding(5);
            this.removeAllButton.Size = new System.Drawing.Size(125, 27);
            this.removeAllButton.TabIndex = 5;
            this.removeAllButton.Text = "<< Re&move All";
            this.removeAllButton.Click += new System.EventHandler(this.OnClickRemoveAllButton);
            // 
            // rightListBox
            // 
            this.rightListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.rightListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.IsDarkTheme = false;
            this.rightListBox.ItemHeight = 15;
            this.rightListBox.Location = new System.Drawing.Point(417, 22);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.Size = new System.Drawing.Size(266, 287);
            this.rightListBox.TabIndex = 7;
            // 
            // rightListBoxLabel
            // 
            this.rightListBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.rightListBoxLabel.IsDarkTheme = true;
            this.rightListBoxLabel.Location = new System.Drawing.Point(417, 4);
            this.rightListBoxLabel.Name = "rightListBoxLabel";
            this.rightListBoxLabel.Size = new System.Drawing.Size(266, 15);
            this.rightListBoxLabel.TabIndex = 6;
            this.rightListBoxLabel.Text = "&Selected items:";
            // 
            // moveDownButton
            // 
            this.moveDownButton.IsDarkTheme = false;
            this.moveDownButton.Location = new System.Drawing.Point(286, 248);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Padding = new System.Windows.Forms.Padding(5);
            this.moveDownButton.Size = new System.Drawing.Size(125, 27);
            this.moveDownButton.TabIndex = 9;
            this.moveDownButton.Text = "Move &Down";
            this.moveDownButton.Click += new System.EventHandler(this.OnClickMoveDownButton);
            // 
            // moveUpButton
            // 
            this.moveUpButton.IsDarkTheme = false;
            this.moveUpButton.Location = new System.Drawing.Point(286, 215);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Padding = new System.Windows.Forms.Padding(5);
            this.moveUpButton.Size = new System.Drawing.Size(125, 27);
            this.moveUpButton.TabIndex = 8;
            this.moveUpButton.Text = "Move &Up";
            this.moveUpButton.Click += new System.EventHandler(this.OnClickMoveUpButton);
            // 
            // DarkListBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.rightListBoxLabel);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addAllButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.leftListBox);
            this.Controls.Add(this.leftListBoxLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsDarkTheme = true;
            this.Name = "DarkListBuilderControl";
            this.Size = new System.Drawing.Size(700, 327);
            this.ResumeLayout(false);

        }

        #endregion

        private xyLOGIX.UI.Dark.Controls.DarkLabel leftListBoxLabel;
        private xyLOGIX.UI.Dark.Controls.DarkListBox leftListBox;
        private xyLOGIX.UI.Dark.Controls.DarkButton addButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton addAllButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton removeButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton removeAllButton;
        private xyLOGIX.UI.Dark.Controls.DarkListBox rightListBox;
        private xyLOGIX.UI.Dark.Controls.DarkLabel rightListBoxLabel;
        private xyLOGIX.UI.Dark.Controls.DarkButton moveDownButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton moveUpButton;
    }
}
