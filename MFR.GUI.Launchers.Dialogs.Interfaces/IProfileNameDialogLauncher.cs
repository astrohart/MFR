using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;

namespace MFR.GUI.Launchers.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Profile Name dialog launcher.
    /// </summary>
    public interface IProfileNameDialogLauncher
    {
        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with selecting a new
        /// name for a new or existing profile.
        /// </summary>
        /// <param name="parms">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
        /// interface.
        /// <para />
        /// This object contains the input parameter variables for the Profile Name dialog
        /// box.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface.
        /// <para />
        /// This object's properties' values contain the values chosen by the user,
        /// including the <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the button the user clicked in order to dismiss the dialog box.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="parms" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        IProfileNameDialogLaunchResults Launch(
            IProfileNameDialogLaunchParams parms);
    }
}