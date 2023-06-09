using MFR.Operations.Constants;

namespace MFR.GUI.Models.Constants.Factories
{
    public static class GetOperationName
    {
        public static string For(OperationType type)
        {
            var result = string.Empty;

            switch (type)
            {
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