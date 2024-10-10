using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Window that displays progress of an operation.
    /// </summary>
    [Log(AttributeExclude = true)]
    public partial class CancellableProgressDialog : DarkForm,
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
                    () => DoSetProgressBarMaximum(value)
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
                    () => DoSetProgressBarMinimum(value)
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
                    () => DoSetProgressBarValue(value)
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
        /// Raised when the user clicks the Cancel button in order to request
        /// that the operation be aborted.
        /// </summary>
        public event EventHandler CancelRequested;

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

            RedrawDisplay();
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
        /// Sets the value of the <see cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property but only after first checking that the argument of the
        /// <paramref name="value" /> parameter falls within a valid range.
        /// </summary>
        /// <param name="value">
        /// (Required.) An <see cref="T:System.Int32" /> that specifies
        /// the new value of the progress bar's maximum limit.
        /// </param>
        /// <remarks>
        /// This method stops if (a) the argument of the <paramref name="value" />
        /// parameter is negative (i.e., we do not know what a negative maximum value means
        /// in the context of a progress bar), or (b) if the argument of the
        /// <paramref name="value" /> parameter is less than, or equal to, the value of the
        /// <see cref="P:MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum" />
        /// property, or (c) if the argument of the <paramref name="value" /> parameter is
        /// less than the value of the
        /// <see cref="P:MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarValue" />
        /// property.
        /// </remarks>
        private void DoSetProgressBarMaximum(int value)
        {
            if (value < 0) return;
            if (value <= ProgressBarMinimum) return;
            if (value < ProgressBarValue) return;

            progressBar.Maximum = value;
        }

        /// <summary>
        /// Sets the value of the <see cref="P:System.Windows.Forms.ProgressBar.Minimum" />
        /// property but only after first checking that the argument of the
        /// <paramref name="value" /> parameter falls within a valid range.
        /// </summary>
        /// <param name="value">
        /// (Required.) An <see cref="T:System.Int32" /> that specifies the new value of
        /// the
        /// progress bar's minimum limit.
        /// </param>
        /// <remarks>
        /// This method stops if (a) the argument of the <paramref name="value" />
        /// parameter is negative (i.e., we do not know what a negative minimum value means
        /// in the context of a progress bar), or (b) if the argument of the
        /// <paramref name="value" /> parameter is greater than, or equal to, the value of
        /// the <see cref="P:System.Windows.Forms.ProgressBar.Maximum" /> property.
        /// </remarks>
        private void DoSetProgressBarMinimum(int value)
        {
            /* range validation */
            if (value < 0) return;
            if (value >= ProgressBarMaximum) return;

            progressBar.Minimum = value;
        }

        /// <summary>
        /// Sets the value of the <see cref="P:System.Windows.Forms.ProgressBar.Value" />
        /// property after first checking that the argument of the
        /// <paramref name="value" /> parameter is in the proper range, i.e., between the
        /// minimum and maximum, inclusive.
        /// </summary>
        /// <param name="value">
        /// (Required.) An <see cref="T:System.Int32" /> value that
        /// specifies the new value of the progress of an operation.
        /// </param>
        /// <remarks>
        /// This method stops if any of the following are true: (a) if the argument of the
        /// <paramref name="value" /> parameter is a negative number (we don't know how to
        /// display negative progress), or (b) if the argument of the
        /// <paramref name="value" /> parameter is less than the value of the
        /// <see cref="P:MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum" />
        /// property, or (c) if the argument of the <paramref name="value" /> parameter is
        /// greater than the value of the
        /// <see cref="P:MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMaximum" />
        /// property.
        /// </remarks>
        private void DoSetProgressBarValue(int value)
        {
            /*
             * If the setter is trying to set the
             * progress bar to a value outside the
             * valid range, ignore it.
             *
             * The value for the progress bar must be
             * between the Minimum and Maximum values,
             * inclusive.
             */

            if (value < 0) return;
            if (value < ProgressBarMinimum) return; // invalid value
            if (value > ProgressBarMaximum) return; // invalid value

            progressBar.Value = value;
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
        {
            OnCancelRequested();
            DialogResult = DialogResult.Cancel;
            this.InvokeIfRequired(Close); // be sure to close this window
        }

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