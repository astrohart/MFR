using MFR.GUI.Models.Constants;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Models.Constants.Factories
{
    /// <summary>
    /// Exposes methods to obtain the names of operations.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetOperationName
    {
        /// <summary>
        /// Given the specified operation <paramref name="type" />, retrieves a
        /// <see cref="T:System.String" /> that contains the corresponding operation name.
        /// <para />
        /// This <see cref="T:System.String" /> should be used for displaying information
        /// about the operation in UI/UX elements.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// specifies the operation for which to obtain the corresponding user-interface
        /// text.
        /// </param>
        /// <returns>
        /// If the specified
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration value is
        /// supported, a <see cref="T:System.String" /> that corresponds to the operation
        /// for use in displaying information about the operation in the user interface; if
        /// the specified operation <paramref name="type" />  is not supported, then the
        /// <see cref="F:System.String.Empty" /> value will be returned.
        /// </returns>
        public static string For(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
                case OperationType.CleanFiles:
                    result = OperationNames.CleanFiles;
                    break;

                case OperationType.RenameFilesInFolder:
                    result = OperationNames.RenameFilesInFolder;
                    break;

                case OperationType.RenameSolutionFolders:
                    result = OperationNames.RenameSolutionFolders;
                    break;

                case OperationType.RenameSubFolders:
                    result = OperationNames.RenameSubFolders;
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = OperationNames.ReplaceTextInFiles;
                    break;

                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }
    }
}