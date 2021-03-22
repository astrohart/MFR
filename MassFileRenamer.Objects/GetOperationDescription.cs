using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IOperationDescription" />
    /// interface.
    /// </summary>
    public static class GetOperationDescription
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IOperationDescription" />
        /// interface,
        /// corresponding to the specified operation <paramref name="type" />,
        /// and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// specifies the operation type you want the descriptive text for.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IOperationDescription" />
        /// interface
        /// that corresponds to the specified operation <paramref name="type" />,
        /// or <see langword="null" /> if no such object can be located.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MassFileRenamer.Objects.OperationType" />
        /// value specified in the <paramref name="type" /> parameter does not
        /// have a corresponding Operation Description object associated with it.
        /// </exception>
        public static IOperationTypeDescription For(OperationType type)
        {
            IOperationTypeDescription typeDescription;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    typeDescription = RenameFilesInFolderOperationTypeDescription
                        .Instance;
                    break;

                case OperationType.ReplaceTextInFiles:
                    typeDescription = ReplaceTextInFilesOperationTypeDescription
                        .Instance;
                    break;

                case OperationType.RenameSubFolders:
                    typeDescription = RenameSubFoldersOperationTypeDescription.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no Operation Description object available that corresponds to the operation type '{type}'."
                    );
            }

            return typeDescription;
        }
    }
}