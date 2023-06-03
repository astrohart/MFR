using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface and which emits user-friendly text that explains that the application
    /// is starting the operation of reloading the Visual Studio Solution(s) that
    /// contain the item(s) that were processed.
    /// </summary>
    public static class GetOpenActiveSolutionOperationStartedDescription
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
        /// interface and which emits user-friendly text that explains that the application
        /// is starting the operation of reloading the Visual Studio Solution(s) that
        /// contain the item(s) that were processed.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => OpenActiveSolutionOperationStartedDescription.Instance;
    }
}