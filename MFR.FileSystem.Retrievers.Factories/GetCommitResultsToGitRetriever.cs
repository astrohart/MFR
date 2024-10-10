using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that represents an object that retrieves the pathname(s) of the
    /// various subfolders of the directory tree of the starting folder, that contain
    /// the various Git repository(ies) that may exist.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class GetCommitResultsToGitRetriever
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that represents an object that retrieves the pathname(s) of the
        /// various subfolders of the directory tree of the starting folder, that contain
        /// the various Git repository(ies) that may exist.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => CommitResultsToGitRetriever.Instance;
    }
}