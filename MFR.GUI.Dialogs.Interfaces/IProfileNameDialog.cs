using MFR.GUI.Dialogs.Constants;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the methods and properties of a New Profile Name dialog box.
    /// </summary>
    public interface IProfileNameDialog : IForm
    {
        /// <summary>
        /// Gets or sets the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that controls what type of profile-creation operation (e.g., New, Save As etc.)
        /// is being done.
        /// </summary>
        ProfileCreateOperationType OperationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the Profile Name text box.
        /// </summary>
        string ProfileName
        {
            get;
            set;
        }
    }
}