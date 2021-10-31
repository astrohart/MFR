using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;

namespace MFR.GUI.Launchers.Dialogs.Params
{
    /// <summary>
    /// Parameters for launching a Profile Name dialog box.
    /// </summary>
    public class ProfileNameDialogLaunchParams : DialogLaunchParamBase,
        IProfileNameDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that indicates how the dialog box is being used.
        /// </summary>
        public ProfileCreateOperationType OperationType
        {
            get;
            set;
        }
    }
}