using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IOperationDescription" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetOperationDescription
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IOperationDescription" />
        /// interface,
        /// corresponding to the specified operation <paramref name="type" />,
        /// and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that specifies the operation type you want the descriptive
        /// text for.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IOperationDescription" />
        /// interface that
        /// corresponds to the specified operation <paramref name="type" />, or
        /// <see langword="null" /> if no such object can be located.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MFR.Operations.Constants.OperationType" /> value
        /// specified in the <paramref name="type" /> parameter does not have a
        /// corresponding Operation Description object associated with it.
        /// </exception>
        public static IOperationDescription For(OperationType type)
        {
            IOperationDescription result;

            switch (type)
            {
                case OperationType.CleanFiles:
                    result = GetCleanFilesOperationDescription.SoleInstance();
                    break;

                case OperationType.CommitPendingChanges:
                    result = GetCommitPendingChangesOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.CommitResultsToGit:
                    result = GetCommitResultsToGitOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.LoadAllSolutionsInFolder:
                    result = GetLoadAllSolutionsInFolderOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameFilesInFolder:
                    result = GetRenameFilesInFolderOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSolutionFolders:
                    result = GetRenameSolutionFoldersOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSubFolders:
                    result = GetRenameSubFoldersOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = GetReplaceTextInFilesOperationDescription
                        .SoleInstance();
                    break;

                case OperationType.UnloadAllSolutionsInFolder:
                    result = GetUnloadAllSolutionsInFolderOperationDescription
                        .SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no Operation Description object available that corresponds to the operation type '{type}'."
                    );
            }

            return result;
        }
    }
}