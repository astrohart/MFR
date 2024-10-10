using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which provides user-friendly text that explains that the
    /// application is currently in the process of renaming subfolders of the root
    /// directory.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameSubFoldersOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which provides user-friendly text that explains that the
        /// application is currently in the process of renaming subfolders of the root
        /// directory.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => RenameSubFoldersOperationDescription.Instance;
    }
}