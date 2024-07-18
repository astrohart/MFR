using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Events;
using System.Collections.Generic;

namespace MFR.Settings.Configuration.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a
    /// config object.
    /// </summary>
    public interface IProjectFileRenamerConfig
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically terminate once the user's requested operations
        /// are complete.
        /// </summary>
        bool AutoQuitOnCompletion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the specified operation(s) should be
        /// automatically initiated when the application starts.  If this value is set to
        /// <see langword="true" /> then the application quits automatically after the
        /// specified operation(s) have been completed.
        /// </summary>
        /// <remarks>
        /// This flag is ignored if this config did not originate from the command
        /// line.
        /// </remarks>
        bool AutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the email address(es)
        /// of the author(s) of commits made to a local Git repository(ies) by this
        /// application.
        /// </summary>
        string CommitAuthorEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the name of the
        /// author(s) of commits made to a local Git repository(ies) by this application.
        /// </summary>
        string CommitAuthorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of a collection, each of whose elements are of
        /// type <see cref="T:System.String" />, representing the list of errant processes
        /// we should attempt to kill prior to the beginning of an operation.
        /// </summary>
        IList<string> ErrantProcessesList
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text to be found that was most-recently specified
        /// by the user.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings consisting of the most-recently
        /// utilized values for Find What.
        /// </summary>
        IList<string> FindWhatHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to a collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances, that represents
        /// all the operations the user can perform with this application.
        /// </summary>
        IList<IOperationTypeInfo> InvokableOperations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the form is in the Folded state.
        /// </summary>
        /// <remarks>
        /// If this value is <see langword="true" /> when the form is loaded, then ensure
        /// that the form displays in the folded state.
        /// </remarks>
        bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this config was specified by the
        /// user on the command line.
        /// </summary>
        bool IsFromCommandLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the case on
        /// found text.
        /// </summary>
        bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the whole
        /// word on found text.
        /// </summary>
        bool MatchExactWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for pending changes that are committed prior to the start of the
        /// operations.
        /// </summary>
        string PendingChangesCommitMessageFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for pending changes that are committed prior to the
        /// start of the operations.
        /// </summary>
        string PendingChangesDetailedCommitMessageFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for the changed files once the operations have been completed.
        /// </summary>
        string PostOperationCommitMessageFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or set a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for the changed files once the operations have been
        /// completed.
        /// </summary>
        string PostOperationDetailedCommitMessageFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the application should prompt the user
        /// if it detects that one or more instances of Visual Studio are open, but none of
        /// them have the target Solution(s) loaded.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// <para />
        /// Set to <see langword="false" /> to suppress the display of the warning message
        /// box.  <b>NOTE:</b> If users suppress the message box, and one or more of the
        /// target Solution(s) are indeed loaded by a running instance of Visual Studio,
        /// then there may be file-sharing/permissions issues during the operation(s).
        /// </remarks>
        bool PromptUserToReloadOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically push the commits it creates to the remote
        /// repository when done with the requested operation(s).
        /// </summary>
        /// <remarks>This property is set to <see langword="true" /> by default.</remarks>
        bool PushChangesToRemoteWhenDone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        bool RenameFilesInFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename folders that
        /// contain Visual Studio Solution (<c>*.sln</c>) files.
        /// </summary>
        bool RenameSolutionFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        bool RenameSubFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a flag that indicates whether to attempt to close and
        /// then re-open the Visual Studio solution, if open, that contains the
        /// project(s) being renamed.
        /// <para />
        /// </summary>
        /// <remarks>
        /// If this set to <see langword="true" />, and the containing solution is open,
        /// then the solution will be closed prior to the start of the selected
        /// operation(s) and then re-opened when the selected operation(s) are complete.
        /// </remarks>
        bool ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should replace text
        /// in files.
        /// </summary>
        bool ReplaceTextInFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text that found text should be replaced with.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Replace With.
        /// </summary>
        IList<string> ReplaceWithHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a number from 0...N, where N is the number of option
        /// tabs, of the one that is currently selected.
        /// </summary>
        int SelectedOptionTab
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        bool ShouldCommitPendingChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        bool ShouldCommitPostOperationChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        string StartingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        IList<string> StartingFolderHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to update the user's local Git
        /// repository even when running in <c>Auto Start</c> mode.
        /// </summary>
        /// <remarks>The default value of this property is <see langword="true" />.</remarks>
        bool UpdateGitOnAutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfig.ProjectFileRenamerConfig.StartingFolder" />
        /// property has been updated.
        /// </summary>
        event StartingFolderChangedEventHandler StartingFolderChanged;

        /// <summary>
        /// Determines whether the specified object is equal to the current
        /// object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current
        /// object; otherwise, <see langword="false" />.
        /// </returns>
        bool Equals(object obj);

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        int GetHashCode();

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        void Reset();
    }
}