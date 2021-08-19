using MFR.Objects.Operations.Constants;
using MFR.Objects.TextValues.Retrievers.Interfaces;
using System;

namespace MFR.Objects.TextValues.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.FileSystem.Retrievers.ITextValueRetriever" />
    /// interface.
    /// </summary>
    public static class GetTextValueRetriever
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see
        ///     cref="T:MFR.Objects.Operations.Constants.OperationType" />
        /// values
        /// that specifies which operation is currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the operation type specified by the
        /// <paramref
        ///     name="type" />
        /// parameter is not one of the supported values.
        /// </exception>
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