using MFR.Operations.Descriptions.Interfaces;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that provides a message that we display to the user when the
    /// operation of checking whether a given folder even contains Visual Studio
    /// Solutions, is starting.
    /// </summary>
    public static class
        GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription
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
        /// operation of checking whether a given folder even contains Visual Studio
        /// Solutions, is starting.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription
                .Instance;
    }
}