using System;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a dialog box that
    /// displays a marquee progress bar while an operation of indeterminate length
    /// proceeds.
    /// </summary>
    public interface IOperationDrivenProgressDialog : IProgressDialog
    {
        /// <summary>
        /// Gets or sets a reference to an object to be supplied to the code that is
        /// executed by this dialog.
        /// </summary>
        object Argument
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Func" /> delegate that refers to code to
        /// be executed while the dialog is displayed.  When the code finishes, the dialog
        /// is dismissed.
        /// </summary>
        Delegate Proc
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that is supplied as the result of
        /// the code that is executed by this dialog.
        /// </summary>
        dynamic Result
        {
            get; set;
        }
    }
}