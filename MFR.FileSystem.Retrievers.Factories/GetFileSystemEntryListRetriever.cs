using MFR.Objects.FileSystem.Retrievers.Interfaces;
using MFR.Objects.Operations.Constants;
using System;

namespace MFR.Objects.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntryListRetriever" />
    /// interface.
    /// </summary>
    /// <remarks>
    /// These objects enumerate objects on the file system according to search
    /// criteria specified by the user.
    /// </remarks>
    public class GetFileSystemEntryListRetriever
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Objects.Operations.Constants.OperationType" />
        /// value that
        /// corresponds to the type of operation currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that corresponds to the specified <paramref name="type" />
        /// of operation.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface available that corresponds to the specified operation
        /// <paramref name="type" />.
        /// </exception>
        public static IFileSystemEntryListRetriever For(OperationType type)
        {
            IFileSystemEntryListRetriever retriever;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    retriever = FilesToRenameRetriever.Instance;
                    break;

                case OperationType.ReplaceTextInFiles:
                    retriever = TextInFilesRetriever.Instance;
                    break;

                case OperationType.RenameSubFolders:
                    retriever = FolderToRenameRetriever.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no file or folder list retriever object available for the '{type}' operation type."
                    );
            }

            return retriever;
        }
    }
}