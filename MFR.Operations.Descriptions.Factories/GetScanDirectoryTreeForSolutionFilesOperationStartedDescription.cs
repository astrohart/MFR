using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that announces we are beginning the process of scanning a directory
    /// tree for Visual Studio Solution (<c>*.sln</c>) files.
    /// </summary>
    public static class
        GetScanDirectoryTreeForSolutionFilesOperationStartedDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface that announces we are beginning the process of scanning a directory
        /// tree for Visual Studio Solution (<c>*.sln</c>) files.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => ScanDirectoryTreeForSolutionFilesOperationStartedDescription
                .Instance;
    }
}