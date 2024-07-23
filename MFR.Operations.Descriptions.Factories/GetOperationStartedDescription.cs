using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Obtains references to instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that change depending on the strategy desired.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetOperationStartedDescription
    {
        /// <summary>
        /// Obtains a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface which corresponds to the specified meeting <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// describes the type of operation that is to be performed by the application..
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface which corresponds to the specific enumeration value that is specified
        /// for the argument of the <paramref name="type" /> parameter.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the enumeration value passed for the argument of the
        /// <paramref name="type" /> parameter.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no corresponding concrete type defined that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface and which corresponds to the specific enumeration value that was
        /// passed for the argument of the <paramref name="type" /> parameter, if it is not
        /// supported.
        /// </exception>
        public static IOperationStartedDescription For(OperationType type)
        {
            IOperationStartedDescription result;

            switch (type)
            {
                case OperationType.CalculateListOfFilesToBeRenamed:
                    result =
                        GetCalculateListOfFilesToBeRenamedOperationStartedDescription
                            .SoleInstance();
                    break;

                case OperationType.CheckingWhetherChosenFolderContainsSolutions:
                    result =
                        GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription
                            .SoleInstance();
                    break;

                case OperationType.CleanFiles:
                    result = GetCleanFilesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CloseActiveSolutions:
                    result = GetCloseActiveSolutionOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CommitPendingChanges:
                    result = GetCommitPendingChangesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CommitResultsToGit:
                    result = GetCommitResultsToGitOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.FindVisualStudio:
                    result = GetFindVisualStudioOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.InitializeApplication:
                    result = GetInitializeApplicationOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.OpenActiveSolutions:
                    result = GetOpenActiveSolutionOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameFilesInFolder:
                    result = GetRenameFilesInFolderOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSolutionFolders:
                    result = GetRenameSolutionFoldersOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSubFolders:
                    result = GetRenameSubFoldersOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = GetReplaceTextInFilesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.ScanDirectoryTreeForSolutionFiles:
                    result =
                        GetScanDirectoryTreeForSolutionFilesOperationStartedDescription
                            .SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"The type of operation to be performed, '{type}', is not supported."
                    );
            }

            return result;
        }
    }
}