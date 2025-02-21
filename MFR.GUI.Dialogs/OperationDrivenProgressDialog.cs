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
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Forms;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Progress dialog that always displays a Marquee progress bar during an
    /// operation.
    /// </summary>
    [Log(AttributeExclude = true)]
    public partial class OperationDrivenProgressDialog : DarkForm,
        IOperationDrivenProgressDialog
    {
        /// <summary>
        /// A <see cref="T:System.ComponentModel.BackgroundWorker" /> that manages the work
        /// done by this Progress Dialog's work.
        /// </summary>
        private BackgroundWorker _worker;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.OperationDrivenProgressDialog" /> and returns a
        /// reference to it.
        /// </summary>
        public OperationDrivenProgressDialog()
        {
            InitializeComponent();

            InitializeBackgroundWorker();

            Clear();
        }

        /// <summary>
        /// Gets or sets a reference to an object to be supplied to the code that is
        /// executed by this dialog.
        /// </summary>
        public object Argument
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Func" /> delegate, taking an object as a
        /// parameter and returning an object as a result, that refers to code to be
        /// executed while the dialog is displayed.  When the code finishes, the dialog is
        /// dismissed.
        /// </summary>
        public Delegate Proc
        {
            get;
            set;
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
        /// Gets a reference to an instance of an object that is supplied as the result of
        /// the code that is executed by this dialog.
        /// </summary>
        public object Result
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the new status.
        /// </summary>
        public string Status
        {
            [DebuggerStepThrough] get => statusLabel.Text;
            set => statusLabel.Text = value;
        }

        /// <summary>
        /// Clears the status text and progress bar.
        /// </summary>
        public void Reset()
        {
            ProgressBarStyle = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 30;
            Status = string.Empty;

            this.InvokeIfRequired(RedrawDisplay);
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeStartPosition();

            InitializeProgressBar();

            UpdateCaption();

            MessageHelper.RequestProgressClose += OnRequestClose;
            MessageHelper.RequestSplashOrProgressClose += OnRequestClose;
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Proc == null) return;

            if (FormStartPosition.CenterParent == StartPosition)
                CenterToParent();
            else
                CenterToScreen();

            Application.DoEvents();

            _worker.RunWorkerAsync(Argument);
        }

        /// <summary>
        /// Resets all properties to their default values.
        /// </summary>
        private void Clear()
        {
            Argument = Result = null;
            Proc = null;
        }

        /// <summary>
        /// Initializes the internal
        /// <see cref="T:System.ComponentModel.BackgroundWorker" /> object.
        /// </summary>
        private void InitializeBackgroundWorker()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += OnDoWork;
            _worker.RunWorkerCompleted += OnRunWorkerCompleted;
        }

        private void InitializeProgressBar()
        {
            ProgressBar.MarqueeAnimationSpeed = 30;
            ProgressBar.Style = ProgressBarStyle.Marquee;
        }

        /// <summary>
        /// Sets the value of the <see cref="P:System.Windows.Forms.Form.StartPosition" />
        /// property to either
        /// <see cref="F:System.Windows.Forms.FormStartPosition.CenterParent" /> or
        /// <see cref="F:System.Windows.Forms.FormStartPosition.CenterScreen" />, depending
        /// on whether we have an owner window.
        /// </summary>
        private void InitializeStartPosition()
            => StartPosition = Owner != null
                ? FormStartPosition.CenterParent
                : FormStartPosition.CenterScreen;

        /// <summary>
        /// Handles the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" />
        /// event raised by the internal background worker managed by this dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.DoWorkEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method runs the code referred to by the contents of the delegate
        /// referred to by the
        /// <see cref="P:MFR.GUI.Dialogs.OperationDrivenProgressDialog.Proc" /> property.
        /// </remarks>
        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            if (Proc == null) return;

            // Execute the 'proc'
            e.Result = Proc is Action
                ? Proc.DynamicInvoke()
                : Proc.DynamicInvoke(e.Argument);
        }

        /// <summary>
        /// Closes this dialog when requested to, say, when we are about to show a message
        /// box to the interactive user.
        /// </summary>
        private void OnRequestClose()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.ComponentModel.BackgroundWorker.RunWorkerCompleted" />
        /// event raised by the internal background worker thread managed by this dialog
        /// box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by gathering the result of the operation and then
        /// dismissing the dialog box.
        /// </remarks>
        private void OnRunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
            Result = e.Result;

            DialogResult = DialogResult.OK;
            Close();
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

        /// <summary>
        /// Updates the window's caption to reflect the new value.
        /// </summary>
        /// <param name="caption">
        /// (Optional.) A <see cref="T:System.String" /> containing the new caption text.
        /// </param>
        /// <remarks>
        /// If the blank string is passed for the <paramref name="caption" />
        /// parameter, then this method sets the window caption to match the value of the
        /// <see cref="P:System.Windows.Forms.Application.ProductName" /> property.
        /// </remarks>
        private void UpdateCaption(string caption = "")
            => Text = !string.IsNullOrWhiteSpace(caption)
                ? caption
                : Application.ProductName;
    }
}