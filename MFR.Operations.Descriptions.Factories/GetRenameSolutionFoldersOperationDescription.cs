using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface that represents the text that is displayed while we are renaming the
    /// folder(s) of Solution(s) that are found within the search directory tree.
    /// </summary>
    public static class GetRenameSolutionFoldersOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface that represents the text that is displayed while we are renaming the
        /// folder(s) of Solution(s) that are found within the search directory tree.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => RenameSolutionFoldersOperationDescription.Instance;
    }
}