using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever" />
    /// interface.
    /// </summary>
    /// <remarks>
    /// These objects enumerate objects on the file system according to search
    /// criteria specified by the user.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class GetFileSystemEntryListRetriever
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value that
        /// corresponds to the type of operation currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that corresponds to the specified <paramref name="type" />
        /// of operation.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface available that corresponds to the specified operation
        /// <paramref name="type" />.
        /// </exception>
        public static IFileSystemEntryListRetriever For(OperationType type)
        {
            IFileSystemEntryListRetriever result;

            switch (type)
            {
                case OperationType.CommitPendingChanges:
                    result = GetCommitPendingChangesRetriever.SoleInstance();
                    break;

                case OperationType.CommitResultsToGit:
                    result = GetCommitResultsToGitRetriever.SoleInstance();
                    break;

                case OperationType.RenameFilesInFolder:
                    result = GetFilesToRenameRetriever.SoleInstance();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = GetTextInFilesRetriever.SoleInstance();
                    break;

                case OperationType.RenameSubFolders:
                    result = GetFolderToRenameRetriever.SoleInstance();
                    break;

                case OperationType.RenameSolutionFolders:
                    result = GetSolutionFoldersToRenameRetriever.SoleInstance();
                    break;

                case OperationType.ScanDirectoryTreeForSolutionFiles:
                    result = GetSolutionFilePathRetriever.SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no file or folder list retriever object available for the '{type}' operation type."
                    );
            }

            return result;
        }
    }
}