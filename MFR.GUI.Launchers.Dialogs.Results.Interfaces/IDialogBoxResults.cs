using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a dialog box's results object.
    /// </summary>
    public interface IDialogBoxResults
    {
        /// <summary>
        /// Gets a <see cref="T:System.Windows.Forms.DialogResult" /> value that describes
        /// the action that the user chose in order to dismiss the dialog box.
        /// </summary>
        DialogResult DialogResult
        {
            get;
        }
    }
}