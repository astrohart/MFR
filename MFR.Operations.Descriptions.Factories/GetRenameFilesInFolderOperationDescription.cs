using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which emits user-friendly text that describes that the
    /// application is renaming files in a folder.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameFilesInFolderOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which emits user-friendly text that describes that the
        /// application is renaming files in a folder.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => RenameFilesInFolderOperationDescription.Instance;
    }
}