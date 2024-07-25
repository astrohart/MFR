using MFR.GUI.Dialogs.Events;
using MFR.GUI.Models.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
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
        bool AutoQuitOnCompletion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Email</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        string CommitAuthorEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Name</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        string CommitAuthorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text of the configuration File Pathname text box.
        /// </summary>
        string ConfigPathname
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Do not warn when Visual Studio is open but target Solution(s) aren't loaded</b>
        /// checkbox
        /// </summary>
        bool DontPromptUserToReloadOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface,
        /// representing the process(es), if running, that should be forcibly terminated
        /// prior to the execution of the <c>Rename Files in Folder</c> and
        /// <c>Rename Sub Folders</c> operations.
        /// </summary>
        IList<IErrantProcessInfo> ErrantProcesses
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a value that indicates whether the user has configured more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool HasErrantProcesses
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether an entry is currently selected in the
        /// <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if an entry is currently selected in the
        /// <b>Errant Processes</b> list box; <see langword="false" /> otherwise.
        /// </returns>
        bool IsErrantProcessSelected
        {
            [DebuggerStepThrough] get;
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
        /// Gets or sets the value of the <b>Push Changes To Remote When Done</b> checkbox.
        /// </summary>
        bool PushChangesToRemoteWhenDone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Reopen Visual Studio Solution</b> checkbox.
        /// </summary>
        bool ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface that
        /// represents the item that is currently selected, if any, in the
        /// <b>Errant Processes</b> list box on the <b>General</b> tab.
        /// </summary>
        /// <remarks>
        /// If there are no items currently in the list box, or none are currently
        /// selected, then this property returns a <see langword="null" /> reference.
        /// </remarks>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface;
        /// otherwise, a <see langword="null" /> reference is returned.
        /// </returns>
        IErrantProcessInfo SelectedErrantProcess
        {
            get;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Pending Changes</b> checkbox.
        /// </summary>
        bool ShouldCommitPendingChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Post-Operation Changes</b>
        /// checkbox.
        /// </summary>
        bool ShouldCommitPostOperationChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Update Local Git Repos When Automatically Started</b> checkbox.
        /// </summary>
        bool UpdateGitOnAutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        event ModifiedEventHandler Modified;
    }
}