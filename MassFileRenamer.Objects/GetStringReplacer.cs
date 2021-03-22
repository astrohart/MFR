using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
    /// interface.
    /// </summary>
    public static class GetStringReplacer
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
        /// interface and
        /// returns a reference to it, for the given
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// value.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
        /// interface that corresponds to the specified type of operation.
        /// </returns>
        public static IStringReplacerFactory For(OperationType type)
        {
            IStringReplacerFactory factory = null;
            
            switch (type)
            {
                case OperationType.GettingListOfFilesToBeRenamed:
                    break;
                case OperationType.RenameFilesInFolder:
                    factory = RenameFilesInFolderStringReplacerFactory.Instance;
                    break;
                case OperationType.ReplaceTextInFiles:
                    factory = ReplaceTextInFilesStringReplacerFactory.Instance;
                    break;
                case OperationType.RenameSubFolders:
                    factory = RenameSubFoldersStringReplacerFactory.Instance;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return factory;
        }
    }
}