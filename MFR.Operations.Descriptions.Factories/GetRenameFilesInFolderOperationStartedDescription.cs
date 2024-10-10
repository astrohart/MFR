using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that explains that the application is beginning the process of
    /// renaming files in a folder according to the search-and-replace parameters that
    /// the user has requested.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameFilesInFolderOperationStartedDescription
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
        /// interface that explains that the application is beginning the process of
        /// renaming files in a folder according to the search-and-replace parameters that
        /// the user has requested.
        /// </returns>
        public static IOperationStartedDescription SoleInstance()
            => RenameFilesInFolderOperationStartedDescription.Instance;
    }
}