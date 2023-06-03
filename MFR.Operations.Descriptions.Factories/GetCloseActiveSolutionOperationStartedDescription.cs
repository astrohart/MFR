using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that provides a message that we display to the user when the
    /// operation of closing the active Solution that is open in a running instance of
    /// Visual Studio before we begin processing it.
    /// </summary>
    public static class GetCloseActiveSolutionOperationStartedDescription
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
        /// interface that provides a message that we display to the user when the
        /// operation of closing the active Solution that is open in a running instance of
        /// Visual Studio before we begin processing it.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => CloseActiveSolutionOperationStartedDescription.Instance;
    }
}