using MFR.GUI.Dialogs.Interfaces;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Window that displays progress of an operation.
    /// </summary>
    public partial class CancellableProgressDialog : Form,
        ICancellableProgressDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.CancellableProgressDialog" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public CancellableProgressDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Raised when the user clicks the Cancel button in order to request
        /// that the operation be aborted.
        /// </summary>
        public event EventHandler CancelRequested;

        /// <summary>
        /// Gets or sets a value indicating whether the operation can be cancelled.
        /// </summary>
        public bool CanCancel
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the new detailed status.
        /// </summary>
        public string CurrentFile
        {
            [DebuggerStepThrough] get => currentFileLabel.Text;
            set
                => currentFileLabel.InvokeIfRequired(
                    () =>
                    {
                        currentFileLabel.Text = value;
                    }
                );
        }

        /// <summary>
        /// Gets a reference to the progress bar control.
        /// </summary>
        public ProgressBar ProgressBar
        {
            [DebuggerStepThrough] get => progressBar;
        }

        /// <summary>
        /// Gets or sets the maximum value of the range of the progress bar control.
        /// </summary>
        public int ProgressBarMaximum
        {
            [DebuggerStepThrough] get => progressBar.Maximum;
            set
                => progressBar.InvokeIfRequired(
                    () => progressBar.Maximum = value
                );
        }

        /// <summary>
        /// Get or sets the minimum value of the range of the progress bar control.
        /// </summary>
        public int ProgressBarMinimum
        {
            [DebuggerStepThrough] get => progressBar.Minimum;
            set
                => progressBar.InvokeIfRequired(
                    () => progressBar.Minimum = value
                );
        }

        /// <summary>
        /// Gets or sets the manner in which progress should
        /// </summary>
        public ProgressBarStyle ProgressBarStyle
        {
            [DebuggerStepThrough] get => progressBar.Style;
            set
                => progressBar.InvokeIfRequired(
                    () => progressBar.Style = value
                );
        }

        /// <summary>
        /// Gets or sets the current position of the progress bar.
        /// </summary>
        public int ProgressBarValue
        {
            [DebuggerStepThrough] get => progressBar.Value;
            set
                => progressBar.InvokeIfRequired(
                    () => progressBar.Value = value
                );
        }

        /// <summary>
        /// Gets or sets a string containing the new status.
        /// </summary>
        public string Status
        {
            [DebuggerStepThrough] get => statusLabel.Text;
            set => statusLabel.InvokeIfRequired(() => statusLabel.Text = value);
        }

        /// <summary>
        /// Clears the status text and progress bar.
        /// </summary>
        public void Reset()
        {
            ProgressBarStyle = ProgressBarStyle.Continuous;
            ProgressBarMinimum = 0;
            ProgressBarMaximum = 100;
            ProgressBarValue = 0;

            Status = string.Empty;

            /*
             * By default, show and enable the Cancel button.
             */

            cancelButton.Visible = cancelButton.Enabled = true;

            currentFileLabel.Text = statusLabel.Text = string.Empty;

            this.InvokeIfRequired(RedrawDisplay);
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.CancellableProgressDialog.CancelRequested" />
        /// event.
        /// </summary>
        protected virtual void OnCancelRequested()
            => CancelRequested?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method sets the title of the dialog to match the application's name.
        /// </remarks>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Status = "Calculating files to be processed...";
            ProgressBar.MarqueeAnimationSpeed = 30;
            ProgressBar.Style = ProgressBarStyle.Marquee;
            Text = Application.ProductName;

            cancelButton.Enabled = CanCancel;
            cancelButton.Visible = CanCancel;
            CancelButton = CanCancel ? cancelButton : null;
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            RedrawDisplay();
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// for the Cancel button.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called when the user chooses the Cancel button or
        /// presses the ESCAPE key. This method responds merely by raising the
        /// <see cref="E:MFR.GUI.CancellableProgressDialog.CancelRequested" />
        /// event. This event directs the caller of this dialog box to attempt
        /// to abort the operation and close down this dialog box from its GUI thread.
        /// </remarks>
        private void OnCancel(object sender, EventArgs e)
            => OnCancelRequested();

        /// <summary>
        /// Directs the application to update the user's display.
        /// </summary>
        private void RedrawDisplay()
        {
            Update();
            Refresh();
            Application.DoEvents();
        }
    }
}
