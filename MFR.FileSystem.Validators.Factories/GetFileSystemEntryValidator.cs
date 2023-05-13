using MFR.FileSystem.Validators.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.FileSystem.Validators.Factories
{
    /// <summary>
    /// Gets instances of objects that implement the
    /// <see
    ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
    /// interface
    /// that correspond to the type of file-system operation that is being performed.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetFileSystemEntryValidator
    {
        /// <summary>
        /// Gets a reference to an instance of an object implementing the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
        /// interface corresponding to the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value that is
        /// provided in the <paramref name="type" /> parameter.
        /// </summary>
        /// <param name="type">
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that specifies the type of file-system operation that is
        /// being performed.
        /// </param>
        /// <returns>
        /// Reference to the instance of the object implementing the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
        /// interface that corresponds to the type of file-system operation
        /// specified by the <paramref name="type" /> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no file system entry validator object available
        /// for the specified operation <paramref name="type" />.
        /// </exception>
        public static IFileSystemEntryValidator For(OperationType type)
        {
            IFileSystemEntryValidator validator = null;

            switch (type)
            {
                case OperationType.GetListOfAllSolutionFilesInDirectoryTree:
                    validator = SolutionFileValidator.Instance;
                    break;

                case OperationType.ReplaceTextInFiles:
                case OperationType.RenameFilesInFolder:
                    validator = ProjectFileValidator.Instance;
                    break;

                case OperationType.GetTopLevelSubFolders:
                case OperationType.RenameSubFolders:
                    validator = DirectoryValidator.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no file system entry validator object available for the '{type}' operation type."
                    );
            }

            return validator;
        }
    }
}
