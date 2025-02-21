/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using MFR.GUI.Dialogs.Interfaces;
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