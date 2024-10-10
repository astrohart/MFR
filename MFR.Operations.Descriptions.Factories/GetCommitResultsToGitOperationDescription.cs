using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which provides user-friendly text that explains to the user that
    /// the application is currently processing committing the results of running
    /// the main renaming operations to the various local Git repository(ies) that reside within
    /// the directory tree of the root folder.
    /// </summary>
    public static class GetCommitResultsToGitOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which provides user-friendly text that explains to the user that
        /// the application is currently processing committing the results of running
        /// the main renaming operations to the various local Git repository(ies) that reside within
        /// the directory tree of the root folder.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => CommitResultsToGitOperationDescription.Instance;
    }
}