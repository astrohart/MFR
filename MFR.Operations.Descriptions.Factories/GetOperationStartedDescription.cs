using MFR.Operations.Constants;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IOperationStartedDescription" />
    /// interface.
    /// </summary>
    public static class GetOperationStartedDescription
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IOperationStartedDescription" />
        /// interface,
        /// corresponding to the specified operation <paramref name="type" /> ,
        /// and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the <see cref="T:MFR.OperationType" />
        /// values that specifies the operation type you want the descriptive
        /// text for.
        /// </param>
        /// <returns>
        /// String containing the text to describe the operation, or blank if a
        /// handler corresponding to the specified
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value can
        /// be found.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MFR.OperationType" /> value
        /// specified in the <paramref name="type" /> parameter does not have a
        /// corresponding Operation Started Description object associated with it.
        /// </exception>
        public static string For(OperationType type)
        {
            string description;

            switch (type)
            {
                case OperationType.CloseActiveSolution:
                    description = CloseActiveSolutionOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.FindVisualStudio:
                    description = FindVisualStudioOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.GettingListOfFilesToBeRenamed:
                    description =
                        GettingListOfFilesToBeRenamedOperationStartedDescription
                            .Instance.Text;
                    break;

                case OperationType.InitializeApplication:
                    description =
                        InitializeApplicationOperationStartedDescription
                            .Instance.Text;
                    break;

                case OperationType.OpenActiveSolution:
                    description = OpenActiveSolutionOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.RenameFilesInFolder:
                    description = RenameFilesInFolderOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.ReplaceTextInFiles:
                    description = ReplaceTextInFilesOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.RenameSubFolders:
                    description = RenameSubFoldersOperationStartedDescription
                                  .Instance.Text;
                    break;

                case OperationType.GetListOfAllSolutionFilesInDirectoryTree:
                    description =
                        GetListOfAllSolutionFilesInDirectoryTreeOperationStartedDescription
                            .Instance.Text;
                    break;

                case OperationType.CheckingWhetherChosenFolderContainsSolutions:
                    description =
                        CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription
                            .Instance.Text;
                    break;

                default:
                    description = string.Empty;
                    break;
            }

            return description;
        }
    }
}