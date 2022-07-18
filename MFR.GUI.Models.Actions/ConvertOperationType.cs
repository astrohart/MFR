using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Models.Actions
{
    /// <summary>
    /// Methods for converting <see cref="T:MFR.Operations.Constants.OperationType" />
    /// values to descriptive strings.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ConvertOperationType
    {
        /// <summary>
        /// Converts the specified <see cref="T:MFR.Operations.Constants.OperationType" />
        /// value into a descriptive string, e.g., for display in a GUI.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the supported
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> values.
        /// </param>
        /// <returns>
        /// If a supported <see cref="T:MFR.Operations.Constants.OperationType" />
        /// value is passed for the <paramref name="type" /> parameter, then a descriptive
        /// string corresponding to it is returned.
        /// <para />
        /// Otherwise, the return value is the <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string ToString(OperationType type)
        {
            string result;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    result = "Rename Files in Folder";
                    break;

                case OperationType.RenameSubFolders:
                    result = "Rename Subfolders";
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = "Replace Text in Files";
                    break;

                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }
    }
}
