namespace MFR.CommandLine.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that stores
    /// the information supplied by the user on the application's command line.
    /// </summary>
    public interface ICommandLineInfo
    {
        /// <summary>
        /// Gets or sets a value indicating whether processing starts when the application
        /// starts.
        /// </summary>
        bool AutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        bool MatchWholeWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        bool RenameFilesInFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we are to rename folder(s) that contain
        /// Solution(s).
        /// </summary>
        bool RenameSolutionFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        bool RenameSubFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates that the Solution is to be reloaded when
        /// the operations are finished.
        /// </summary>
        bool? ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        bool ReplaceTextInFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        string ReplaceWith
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
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        string StartingFolder
        {
            get;
            set;
        }
    }
}