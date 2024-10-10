using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Folder Selection dialog box.
    /// </summary>
    public interface IFolderSelectDialog : IDisposable
    {
        /// <summary>
        /// Gets the fully-qualified pathname of the folder that the user selected.
        /// </summary>
        string FileName
        {
            get;
        }

        /// <summary>
        /// Gets/Sets the initial folder to be selected. A <see langword="null" /> value selects
        /// the current directory.
        /// </summary>
        string InitialDirectory
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a string containing the text to be displayed in the title bar 
        /// </summary>
        string Title
        {
            get; set;
        }

        /// <summary>
        /// Shows the form as a modal dialog box.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is already visible.
        /// -or- The form being shown is disabled.
        /// -or- The form being shown is not a top-level window.
        /// -or- The form being shown as a dialog box is already a modal form.
        /// -or- The current process is not running in user interactive mode (for
        /// more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        DialogResult ShowDialog();

        /// <summary>
        /// Shows the form as a modal dialog box with the specified owner.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements
        /// <see
        ///   cref="T:System.Windows.Forms.IWin32Window" />
        /// that represents the
        /// top-level window that will own the modal dialog box.
        /// </param>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The form specified in the <paramref name="owner" /> parameter is the same
        /// as the form being shown.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is already visible.
        /// -or- The form being shown is disabled.
        /// -or- The form being shown is not a top-level window.
        /// -or- The form being shown as a dialog box is already a modal form.
        /// -or- The current process is not running in user interactive mode (for
        /// more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        DialogResult ShowDialog(IWin32Window owner);
    }
}