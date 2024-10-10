using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that provides user-friendly text that indicates we are calculating
    /// the list of files that need to be renamed.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class
        GetCalculateListOfFilesToBeRenamedOperationStartedDescription
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
        /// interface that provides user-friendly text that indicates we are calculating
        /// the list of files that need to be renamed.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => CalculateListOfFilesToBeRenamedOperationStartedDescription
                .Instance;
    }
}