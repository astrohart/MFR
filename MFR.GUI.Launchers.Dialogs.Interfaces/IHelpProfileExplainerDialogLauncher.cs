using MFR.GUI.Dialogs.Events;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that launches
    /// the Help dialog that explains how Profiles work.
    /// </summary>
    public interface IHelpProfileExplainerDialogLauncher
    {
        /// <summary>
        /// Displays a user-friendly dialog box that provides Help on Profiles.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// This object acts as the parent window of the dialog box.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the means used by the user to dismiss the dialog.
        /// </returns>
        DialogResult Launch(IWin32Window owner);
    }
}