using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Defines an object that validates the paths of folders.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class DirectoryPathValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static DirectoryPathValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected DirectoryPathValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface that validates directory paths, specifically.
        /// </summary>
        public static IFileSystemEntryValidator Instance
        {
            get;
        } = new DirectoryPathValidator();
    }
}