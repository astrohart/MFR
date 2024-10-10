using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that describes, using user-friendly text, that the  application is
    /// about to begin the operation of replacing textual content within the files
    /// under the specified starting directory according to the text-replacement
    /// pattern that was specified by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetReplaceTextInFilesOperationStartedDescription
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
        /// interface that describes, using user-friendly text, that the  application is
        /// about to begin the operation of replacing textual content within the files
        /// under the specified starting directory according to the text-replacement
        /// pattern that was specified by the user.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => ReplaceTextInFilesOperationStartedDescription.Instance;
    }
}