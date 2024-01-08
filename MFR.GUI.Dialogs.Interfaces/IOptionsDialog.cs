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
        /// Gets or sets the value of the
        /// <b>Exit the Application When Operations Are Complete</b> checkbox.
        /// </summary>
        bool AutoQuitOnCompletion { get; set; }

        /// <summary>
        /// Gets or sets the text of the configuration File Pathname text box.
        /// </summary>
        string ConfigPathname { get; set; }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Do not warn when Visual Studio is open but target Solution(s) aren't loaded</b>
        /// checkbox
        /// </summary>
        bool DontPromptUserToReloadOpenSolution { get; set; }

        /// <summary>
        /// Gets a value that indicates whether the data in this dialog box has
        /// been modified.
        /// </summary>
        bool IsModified { get; }

        /// <summary>
        /// Gets or sets the value of the <b>Reopen Visual Studio Solution</b> checkbox.
        /// </summary>
        bool ReOpenSolution { get; set; }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Pending Changes</b> checkbox.
        /// </summary>
        bool ShouldCommitPendingChanges { get; set; }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Post-Operation Changes</b>
        /// checkbox.
        /// </summary>
        bool ShouldCommitPostOperationChanges { get; set; }

        /// <summary>
        /// Gets or sets the value of the <b>Push Changes To Remote When Done</b> checkbox.
        /// </summary>
        bool PushChangesToRemoteWhenDone { get; set; }

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        event ModifiedEventHandler Modified;
    }
}