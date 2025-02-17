using MFR.CommandLine.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.CommandLine.Models
{
    /// <summary>
    /// Encapsulates this application's command line arguments.
    /// </summary>
    /// <remarks>
    /// This class depends on the <c>FluentCommandLineParser</c> NuGet package.
    /// </remarks>
    public class CommandLineInfo : ICommandLineInfo
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.CommandLine.Models.CommandLineInfo" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CommandLineInfo() { }

        /// <summary>
        /// Initializes a new instance of
        /// <see cref="T:MFR.CommandLine.Models.CommandLineInfo" /> and returns a reference
        /// to it.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This constructor is marked <see langword="protected" />
        /// due to the fact that this class is marked <see langword="abstract" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public CommandLineInfo() { }

        /// <summary>
        /// Gets or sets a value indicating whether processing starts when the application
        /// starts.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="false" />.
        /// </remarks>
        public bool AutoStart
        {
            get;
            set;
        } = false;

        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        public string FindWhat
        {
            get;
            set;
        } = "";

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? MatchCase
        {
            get;
            set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? MatchExactWord
        {
            get;
            set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool RenameFilesInFolder
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value indicating whether we are to rename folder(s) that contain
        /// Solution(s).
        /// </summary>
        public bool RenameSolutionFolders
        {
            get;
            set;
        } = false;

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool RenameSubFolders
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value that indicates that the Solution is to be reloaded when
        /// the operations are finished.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ReOpenSolution
        {
            get;
            set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is set to <see langword="true" />.
        /// </remarks>
        public bool ReplaceTextInFiles
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        /// <remarks>
        /// This property's value is set to the
        /// <see cref="F:System.String.Empty" /> value if it is not specified on the
        /// command line.
        /// </remarks>
        public string ReplaceWith
        {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ShouldCommitPendingChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ShouldCommitPostOperationChanges
        {
            get;
            set;
        } = null;

        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        public string StartingFolder
        {
            get;
            set;
        } = string.Empty;
    }
}