using MFR.GUI.Dialogs.Constants;
using PostSharp.Patterns.Diagnostics;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfileNameDialogResults
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name to give the Profile.
        /// </param>
        /// <param name="type">
        /// (Required.) A
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> that
        /// describes for what operation the dialog box is being summoned.
        /// </param>
        /// <param name="dialogResult">
        /// (Required.) A <see cref="T:System.Windows.Forms.DialogResult" /> that indicates
        /// how the user dismissed the dialog box.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface.
        /// </returns>
        public static IProfileNameDialogLaunchResults WithPropertyValues(
            string profileName, ProfileCreateOperationType type, DialogResult dialogResult)
            => new ProfileNameDialogLaunchLaunchResults(profileName, type, dialogResult);
    }
}