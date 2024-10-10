using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
    /// interface that validates whether directories exist on the file system.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetDirectoryPathValidator
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface  that validates whether directories exist on the file system.
        /// </returns>
        public static IFileSystemEntryValidator SoleInstance()
            => DirectoryPathValidator.Instance;
    }
}