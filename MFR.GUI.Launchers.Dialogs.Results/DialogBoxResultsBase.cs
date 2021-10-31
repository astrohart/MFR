using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results
{
    /// <summary>
    /// Methods and properties common to all results objects for dialog boxes.
    /// </summary>
    public abstract class DialogBoxResultsBase : IDialogBoxResults
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Results.DialogBoxResultsBase" /> class.
        /// </summary>
        protected DialogBoxResultsBase(DialogResult dialogResult)
        {
            DialogResult = dialogResult;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Windows.Forms.DialogResult" /> value that describes
        /// the action that the user chose in order to dismiss the dialog box.
        /// </summary>
        public DialogResult DialogResult
        {
            get;
        }
    }
}