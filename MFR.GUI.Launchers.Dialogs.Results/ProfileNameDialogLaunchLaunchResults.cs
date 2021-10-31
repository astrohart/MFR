using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results
{
    /// <summary>
    /// Results from a dialog box that prompts the user for the name to use for a
    /// Profile.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileNameDialogLaunchLaunchResults : DialogBoxResultsBase,
        IProfileNameDialogLaunchResults
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogLaunchLaunchResults" />
        /// and returns a reference to it.
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
        public ProfileNameDialogLaunchLaunchResults(string profileName,
            ProfileCreateOperationType type, DialogResult dialogResult) : base(
            dialogResult
        )
        {
            CreateOperationType = type;
            ProfileName = profileName;
        }

        /// <summary>
        /// Gets or sets of the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> values
        /// that says what use case this dialog is being used for.
        /// </summary>
        public ProfileCreateOperationType CreateOperationType
        {
            get;
        }

        /// <summary>
        /// Gets or sets a string that contains the name that the user wants to assign to
        /// the Profile.
        /// </summary>
        public string ProfileName
        {
            get;
        }
    }
}