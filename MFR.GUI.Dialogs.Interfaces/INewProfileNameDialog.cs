using MFR.GUI.Dialogs.Constants;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the New Profile Name dialog's interface.
    /// </summary>
    public interface INewProfileNameDialog : IForm
    {
        /// <summary>
        /// Gets or sets the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that controls what type of profile-creation operation (e.g., New, Save As etc.)
        /// is being done.
        /// </summary>
        ProfileCreateOperationType OperationType { get; set; }

        /// <summary>
        /// Gets or sets the value of the Profile Name text box.
        /// </summary>
        string ProfileName { get; set; }
    }
}