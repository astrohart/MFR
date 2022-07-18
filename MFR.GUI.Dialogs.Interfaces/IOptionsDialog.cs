using MFR.GUI.Dialogs.Events;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a dialog box that
    /// allows the user to configure the application.
    /// </summary>
    public interface IOptionsDialog : IForm
    {
        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        event ModifiedEventHandler Modified;

        /// <summary>
        /// Gets or sets the text of the Configuration File Pathname text box.
        /// </summary>
        string ConfigPathname
        {
            get; set;
        }

        /// <summary>
        /// Gets a value that indicates whether the data in this dialog box has
        /// been modified.
        /// </summary>
        bool IsModified
        {
            get;
        }

        /// <summary>
        /// Gets or sets the value of the Reopen Visual Studio Solution checkbox
        /// </summary>
        bool ShouldReOpenVisualStudioSolution
        {
            get; set;
        }
    }
}
