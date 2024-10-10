using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface and which provides user-friendly text that explains to the user that
    /// the application is getting ready to begin the process of committing the
    /// baseline pending changes of the user's code as it exists in the Git
    /// repository(ies) that exist within the starting folder's directory tree.
    /// </summary>
    public static class GetCommitPendingChangesOperationStartedDescription
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
        /// the application is getting ready to begin the process of committing the
        /// baseline pending changes of the user's code as it exists in the Git
        /// repository(ies) that exist within the starting folder's directory tree.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => CommitResultsToGitOperationStartedDescription.Instance;
    }
}