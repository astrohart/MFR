using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves lists of file-system entries that should be processed by an
    /// operation that wants to commit the results of the processing of projects to the
    /// various GIt repository(ies) that may be contained within the directory tree of
    /// the starting folder..
    /// </summary>
    public class CommitResultsToGitRetriever : CommitToGitRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommitResultsToGitRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommitResultsToGitRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that represents an object that retrieves the pathname(s) of the
        /// various subfolders of the directory tree of the starting folder, that contain
        /// the various Git repository(ies) that may exist.
        /// </summary>
        public static IFileSystemEntryListRetriever Instance
        {
            get;
        } = new CommitResultsToGitRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.CommitResultsToGit;
    }
}