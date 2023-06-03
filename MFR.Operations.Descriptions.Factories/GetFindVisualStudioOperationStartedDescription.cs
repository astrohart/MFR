using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that provides a user-friendly text status message that tells the user
    /// that the application is beginning the process of determining whether the
    /// Solution containing the project(s) and file(s) to be processed is currently
    /// open in a running instance of Visual Studio.
    /// </summary>
    public static class GetFindVisualStudioOperationStartedDescription
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
        /// interface that provides a user-friendly text status message that tells the user
        /// that the application is beginning the process of determining whether the
        /// Solution containing the project(s) and file(s) to be processed is currently
        /// open in a running instance of Visual Studio.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => FindVisualStudioOperationStartedDescription.Instance;
    }
}