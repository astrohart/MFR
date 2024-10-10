using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
    /// interface that validates directory paths, specifically, those that are supposed to
    /// contain a local Git repository.  We know this is so if the directory's path, with
    /// <c>.git</c> appended to it, exists.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetGitRepositoryFolderPathValidator
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface that validates directory paths, specifically, those that are supposed to
        /// contain a local Git repository.  We know this is so if the directory's path, with
        /// <c>.git</c> appended to it, exists.
        /// </returns>
        public static IFileSystemEntryValidator SoleInstance()
            => GitRepositoryFolderPathValidator.Instance;
    }
}