using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface that provides a descriptive text string that explains to the user of
    /// the application that we are scanning a directory tree for (<c>*.sln</c>) files
    /// that are within it, and then are opening each of them in Visual Studio.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetLoadAllSolutionsInFolderOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface that provides a descriptive text string that explains to the user of
        /// the application that we are scanning a directory tree for (<c>*.sln</c>) files
        /// that are within it, and then are opening each of them in Visual Studio.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => LoadAllSolutionsInFolderOperationDescription.Instance;
    }
}