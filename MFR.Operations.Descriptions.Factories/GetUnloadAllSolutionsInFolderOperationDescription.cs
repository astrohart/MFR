using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which provides user-friendly text that explains that the
    /// application is currently attempting to close all the instances of Visual Studio
    /// Solution(s) that this application may be working on.
    /// </summary>
    public static class GetUnloadAllSolutionsInFolderOperationDescription
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
        /// application is currently attempting to close all the instances of Visual Studio
        /// Solution(s) that this application may be working on.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => UnloadAllSolutionsInFolderOperationDescription.Instance;
    }
}