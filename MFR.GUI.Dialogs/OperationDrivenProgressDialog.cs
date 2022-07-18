using MFR.GUI.Dialogs.Interfaces;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Progress dialog that always displays a Marquee progress bar during an
    /// operation.
    /// </summary>
    public partial class OperationDrivenProgressDialog : Form,
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
        public Func<object, object> Proc
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

            ProgressBar.MarqueeAnimationSpeed = 30;
            ProgressBar.Style = ProgressBarStyle.Marquee;
            Text = Application.ProductName;
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
            e.Result = Proc(e.Argument);
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
