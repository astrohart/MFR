using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface and which provides user-friendly text that explains to the user that
    /// the application is getting ready to begin the process of committing the results of running
    /// the main renaming operations to the various local Git repository(ies) that reside within
    /// the directory tree of the root folder.
    /// </summary>
    public static class GetCommitResultsToGitOperationStartedDescription
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
        /// interface and which provides user-friendly text that explains to the user that
        /// the application is getting ready to begin the process of committing the results of running
        /// the main renaming operations to the various local Git repository(ies) that reside within
        /// the directory tree of the root folder.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => CommitResultsToGitOperationStartedDescription.Instance;
    }
}