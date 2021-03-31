using System;

namespace MFR.Objects.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.FileSystem.Retrievers.ITextValueRetriever" />
    /// interface.
    /// </summary>
    public static class GetTextValueRetriever
    {
        public static ITextValueRetriever For(OperationType type)
        {
            ITextValueRetriever retriever = null;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    retriever = FilenameTextValueRetriever.Instance;
                    break;

                case OperationType.ReplaceTextInFiles:
                    retriever = TextInFileTextValueRetriever.Instance;
                    break;

                case OperationType.RenameSubFolders:
                    retriever = FolderTextValueRetriever.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no text-value retriever object available for the operation type '{type}'."
                    );
            }

            return retriever;
        }
    }
}