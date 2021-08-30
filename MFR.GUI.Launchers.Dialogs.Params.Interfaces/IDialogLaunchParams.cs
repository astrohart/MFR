using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Params.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a parameter POCO for
    /// launching a dialog box.
    /// </summary>
    /// <remarks>
    /// This interface exposes the methods and properties that are common to all
    /// parameter POCOs for launching dialog boxes.
    /// </remarks>
    public interface IDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the new dialog box.
        /// </summary>
        IWin32Window Owner
        {
            get;
            set;
        }
    }
}