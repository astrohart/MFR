namespace MFR.GUI.Dialogs
{
    partial class CustomizeOperationsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeOperationsDialog));
            this.cancelButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.okayButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.operationListBuilder = new xyLOGIX.UI.Dark.Controls.DarkListBuilderControl();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.IsDarkTheme = true;
            this.cancelButton.Location = new System.Drawing.Point(719, 46);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.IsDarkTheme = true;
            this.okayButton.Location = new System.Drawing.Point(719, 13);
            this.okayButton.Name = "okayButton";
            this.okayButton.Padding = new System.Windows.Forms.Padding(5);
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            // 
            // operationListBuilder
            // 
            this.operationListBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.operationListBuilder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.operationListBuilder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.operationListBuilder.IsDarkTheme = true;
            this.operationListBuilder.Location = new System.Drawing.Point(13, 13);
            this.operationListBuilder.Name = "operationListBuilder";
            this.operationListBuilder.Size = new System.Drawing.Size(700, 325);
            this.operationListBuilder.TabIndex = 0;
            // 
            // CustomizeOperationsDialog
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(827, 350);
            this.Controls.Add(this.operationListBuilder);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeOperationsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custmize Operations";
            this.ResumeLayout(false);

        }

        private xyLOGIX.UI.Dark.Controls.DarkButton cancelButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton okayButton;
        private xyLOGIX.UI.Dark.Controls.DarkListBuilderControl operationListBuilder;
    }
}