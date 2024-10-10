using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that represents the description to display to the user when we are
    /// beginning the operation to rename the folder that a Solution lives in.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameSolutionFoldersOperationStartedDescription
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
        /// interface that represents the description to display to the user when we are
        /// beginning the operation to rename the folder that a Solution lives in.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => RenameSolutionFoldersOperationStartedDescription.Instance;
    }
}