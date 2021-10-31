using MFR.GUI.Dialogs.Constants;

namespace MFR.GUI.Launchers.Dialogs.Params.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a parameter POCO for
    /// launching the Profile Name dialog.
    /// </summary>
    public interface IProfileNameDialogLaunchParams : IDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that indicates how the dialog box is being used.
        /// </summary>
        ProfileCreateOperationType OperationType
        {
            get;
            set;
        }
    }
}