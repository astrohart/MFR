using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IOperationStartedDescription" />
    /// interface.
    /// </summary>
    public static class GetOperationStartedDescription
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IOperationStartedDescription" />
        /// interface, corresponding to the specified operation
        /// <paramref
        ///     name="type" />
        /// , and returns a reference to it.
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
        ///     cref="T:MassFileRenamer.Objects.IOperationStartedDescription" />
        /// interface that corresponds to the specified operation
        /// <paramref
        ///     name="type" />
        /// , or <see langword="null" /> if no such object can be located.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MassFileRenamer.Objects.OperationType" />
        /// value specified in the <paramref name="type" /> parameter does not
        /// have a corresponding Operation Started Description object associated
        /// with it.
        /// </exception>
        public static IOperationTypeStartedDescription For(OperationType type)
        {
            IOperationTypeStartedDescription description;

            switch (type)
            {
                case OperationType.CloseActiveSolution:
                    description = CloseActiveSolutionOperationTypeStartedDescription
                        .Instance;
                    break;

                case OperationType.FindVisualStudio:
                    description = FindVisualStudioOperationTypeStartedDescription
                        .Instance;
                    break;

                case OperationType.GettingListOfFilesToBeRenamed:
                    description =
                        GettingListOfFilesToBeRenamedOperationTypeStartedDescription
                            .Instance;
                    break;

                case OperationType.OpenActiveSolution:
                    description = OpenActiveSolutionOperationTypeStartedDescription
                        .Instance;
                    break;

                case OperationType.RenameFilesInFolder:
                    description = RenameFilesInFolderOperationTypeStartedDescription
                        .Instance;
                    break;

                case OperationType.ReplaceTextInFiles:
                    description = ReplaceTextInFilesOperationTypeStartedDescription
                        .Instance;
                    break;

                case OperationType.RenameSubFolders:
                    description = RenameSubFoldersOperationTypeStartedDescription
                        .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no Operation Started Description object available that corresponds to the operation type '{type}'."
                    );
            }

            return description;
        }
    }
}