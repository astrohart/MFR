﻿using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IFileSystemEntryListRetriever" />
    /// interface.
    /// </summary>
    /// <remarks>
    /// These objects enumerate objects on the file system according to search
    /// criteria specified by the user.
    /// </remarks>
    public class GetFileSystemEntryListRetriever
    {
        public static IFileSystemEntryListRetriever For(OperationType type)
        {
            IFileSystemEntryListRetriever retriever = null;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    retriever = new FilesToRenameRetriever();
                    break;

                case OperationType.ReplaceTextInFiles:
                    retriever = new TextInFilesRetriever();
                    break;

                case OperationType.RenameSubFolders:
                    retriever = new FolderToRenameRetriever();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type, null
                    );
            }

            return retriever;
        }
    }
}