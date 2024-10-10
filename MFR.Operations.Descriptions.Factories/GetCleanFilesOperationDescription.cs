using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which provides user-friendly text that explains to the user that
    /// the application is currently processing committing the user's existing, pending
    /// changes to the various local Git repository(ies) that reside within the
    /// directory tree of the root folder, in order to baseline the current version of
    /// the user's code.
    /// </summary>
    public static class GetCleanFilesOperationDescription
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
        /// the application is currently processing committing the user's existing, pending
        /// changes to the various local Git repository(ies) that reside within the
        /// directory tree of the root folder, in order to baseline the current version of
        /// the user's code.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => CleanFilesOperationDescription.Instance;
    }
}