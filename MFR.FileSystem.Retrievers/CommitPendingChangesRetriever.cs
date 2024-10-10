using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves lists of file-system entries that should be processed by an
    /// operation that wants to commit the results of the processing of projects to the
    /// various GIt repository(ies) that may be contained within the directory tree of
    /// the starting folder.
    /// </summary>
    public class CommitPendingChangesRetriever : CommitToGitRetrieverBase
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:MFR.FileSystem.Retrievers.CommitPendingChangesRetriever" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CommitPendingChangesRetriever() { }

        /// <summary>
        /// Initializes a new instance of
        /// <see cref="T:MFR.FileSystem.Retrievers.CommitPendingChangesRetriever" /> and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This constructor is marked <see langword="protected" />
        /// due to the fact that this class is marked <see langword="abstract" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected CommitPendingChangesRetriever() { }

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
        } = new CommitPendingChangesRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.CommitPendingChanges;
    }
}