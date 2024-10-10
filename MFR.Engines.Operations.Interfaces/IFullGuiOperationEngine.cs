using System;
using System.Windows.Forms;

namespace MFR.Engines.Operations.Interfaces
{
    public interface IFullGuiOperationEngine : IOperationEngine
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the progress dialog.
        /// </summary>
        IWin32Window DialogOwner
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Engines.FullGuiOperationEngine.DialogOwner" /> property is
        /// updated.
        /// </summary>
        event EventHandler DialogOwnerChanged;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Sets the owner window of all dialog boxes displayed by this component.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the new owner window.
        /// </param>
        /// <remarks>
        /// Typically, this method would be called by passing a reference to the
        /// main window of the application.
        /// <para />
        /// </remarks>
        void SetDialogOwner(IWin32Window owner);

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        void ShowCalculatingProgressBar(string text, bool canCancel = true);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(bool canCancel);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        void ShowProgressDialog(IWin32Window owner);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(IWin32Window owner, bool canCancel);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();
    }
}