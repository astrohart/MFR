using System.Diagnostics;

namespace MFR.CommandLine.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that stores
    /// the information supplied by the user on the application's command line.
    /// </summary>
    public interface ICommandLineInfo
    {
        /// <summary>
        /// Gets or sets a value that indicates that the application should quit when the
        /// operations are finished.
        /// </summary>
        bool? AutoQuitOnCompletion
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether processing starts when the application
        /// starts.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="false" />.
        /// </remarks>
        bool AutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        string FindWhat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        bool? MatchCase
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        bool? MatchExactWord
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        bool? RenameFilesInFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we are to rename folder(s) that contain
        /// Solution(s).
        /// </summary>
        bool? RenameSolutionFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        bool? RenameSubFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates that the Solution is to be reloaded when
        /// the operations are finished.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        bool? ReOpenSolution
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is set to <see langword="true" />.
        /// </remarks>
        bool? ReplaceTextInFiles
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        /// <remarks>
        /// This property's value is set to the
        /// <see cref="F:System.String.Empty" /> value if it is not specified on the
        /// command line.
        /// </remarks>
        string ReplaceWith
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        bool? ShouldCommitPendingChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        bool? ShouldCommitPostOperationChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        /// <remarks>
        /// This property's value is set to the
        /// <see cref="F:System.String.Empty" /> value if it is not specified on the
        /// command line.
        /// </remarks>
        string StartingFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to update the user's local Git
        /// repository even when running in <c>Auto Start</c> mode.
        /// </summary>
        /// <remarks>
        /// If this property has a <see langword="null" /> value, then that means
        /// the user did not specify the corresponding flag on the command line at all.
        /// <para />
        /// The default value of this property is <see langword="null" />.
        /// </remarks>
        bool? UpdateGitOnAutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }
    }
}