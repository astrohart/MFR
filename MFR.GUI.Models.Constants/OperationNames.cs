using MFR.GUI.Models.Constants.Properties;

namespace MFR.GUI.Models.Constants
{
    /// <summary>
    /// Standardized names of operations.
    /// </summary>
    public static class OperationNames
    {
        /// <summary>
        /// Name of the <c>Clean Files</c> operation.
        /// </summary>
        public static readonly string CleanFiles =
            Resources.OperationName_CleanFiles;

        /// <summary>
        /// Name of the <c>Rename Files</c> operation.
        /// </summary>
        public static readonly string RenameFilesInFolder =
            Resources.OperationName_RenameFiles;

        /// <summary>
        /// Name of the <c>Rename Folder(s) that Contain Solution(s)</c> operation.
        /// </summary>
        public static readonly string RenameSolutionFolders =
            Resources.OperationName_RenameSolutionFolders;

        /// <summary>
        /// Name of the <c>Rename Subfolders</c> operation.
        /// </summary>
        public static readonly string RenameSubFolders =
            Resources.OperationName_RenameSubfolders;

        /// <summary>
        /// Name of the <c>Replace Text in Files</c> operation.
        /// </summary>
        public static readonly string ReplaceTextInFiles =
            Resources.OperationName_ReplaceTextInFiles;
    }
}