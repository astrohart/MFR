using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface and which provides user-friendly text that explains to the user that
    /// the application is getting ready to begin the process of renaming folders
    /// within a directory tree according to a text-replacement pattern that was
    /// specified by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameSubFoldersOperationStartedDescription
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
        /// the application is getting ready to begin the process of renaming folders
        /// within a directory tree according to a text-replacement pattern that was
        /// specified by the user.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => RenameSubFoldersOperationStartedDescription.Instance;
    }
}