using MFR.Engines.Replacement.Intefaces;
using MFR.Operations.Constants;
using System;

namespace MFR.Engines.Replacement.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.ITextReplacementEngine" />
    /// interface.
    /// </summary>
    public static class GetTextReplacementEngine
    {
        /// <summary>
        /// Gets an instance of the object that implements the
        /// <see
        ///     cref="T:MFR.ITextReplacementEngine" />
        /// interface
        /// corresponding to the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// specified.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// specifies which operation is being performed.
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.ITextReplacementEngine" />
        /// interface
        /// corresponding to the operation of the <paramref name="type" />
        /// specified, or <see langword="null" /> if no object supports the specified
        /// <paramref name="type" /> of operation.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <paramref name="type" /> parameter specifies an
        /// operation modality that is not supported.
        /// </exception>
        public static ITextReplacementEngine For(OperationType type)
        {
            ITextReplacementEngine engine;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    engine = new FileNameReplacementEngine();
                    break;

                case OperationType.ReplaceTextInFiles:
                    engine = new TextInFileReplacementEngine();
                    break;

                case OperationType.RenameSubFolders:
                    engine = new FolderNameReplacementEngine();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"Creating a text-replacement engine for the operation type '{type}' is not supported."
                    );
            }

            return engine;
        }
    }
}
