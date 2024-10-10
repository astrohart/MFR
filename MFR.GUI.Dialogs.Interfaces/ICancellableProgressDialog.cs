using System;
using System.Diagnostics;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a progress window..
    /// </summary>
    public interface ICancellableProgressDialog : IProgressDialog
    {
        /// <summary>
        /// Raised when the user clicks the Cancel button in order to request
        /// that the operation be aborted.
        /// </summary>
        event EventHandler CancelRequested;

        /// <summary>
        /// Gets or sets a value indicating whether the operation can be cancelled.
        /// </summary>
        bool CanCancel
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a string containing the new detailed status.
        /// </summary>
        string CurrentFile
        {
            [DebuggerStepThrough]
            get;
            set;
        }
    }
}