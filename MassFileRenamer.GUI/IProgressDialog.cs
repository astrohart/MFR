using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a progress window..
    /// </summary>
    public interface IProgressDialog : IForm
    {
        /// <summary>
        /// Raised when the user clicks the Cancel button in order to request
        /// that the operation be aborted.
        /// </summary>
        event EventHandler CancelRequested;

        /// <summary>
        /// Gets or sets a string containing the new detailed status.
        /// </summary>
        string CurrentFile
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum value of the range of the progress bar control.
        /// </summary>
        int ProgressBarMaximum
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Get or sets the minimum value of the range of the progress bar control.
        /// </summary>
        int ProgressBarMinimum
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the manner in which progress should
        /// </summary>
        ProgressBarStyle ProgressBarStyle
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the current position of the progress bar.
        /// </summary>
        int ProgressBarValue
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the new status.
        /// </summary>
        string Status
        {
            [DebuggerStepThrough]
            get;
            set;
        }

        /// <summary>
        /// Clears the status text and progress bar.
        /// </summary>
        void Reset();
    }
}