using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Defines an object that validates the paths of files.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProjectFileValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProjectFileValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProjectFileValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface that validates project files.
        /// </summary>
        public static IFileSystemEntryValidator Instance
        {
            get;
        } = new ProjectFileValidator();

        /// <summary>
        /// Determines whether the file-system entry with the specified
        /// <paramref name="path" /> should be skipped during an operation.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname on the file system of the
        /// file-system entry that is to potentially be skipped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> is returned by this method if the file-system
        /// entry with the specified <paramref name="path" /> is to be skipped by
        /// the operation; otherwise, <see langword="false" />.
        /// </returns>
        public override bool ShouldSkip(string path)
        {
            var result = true;

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = base.ShouldSkip(path) ||
                         string.IsNullOrWhiteSpace(Path.GetExtension(path)) ||
                         MakeNewFileInfo.ForPath(path)
                                        .IsZeroLengthFile() || Path
                             .GetExtension(path)
                             .IsAnyOf(
                                 ".exe", ".bat", ".com", ".pif", ".rar", ".zip"
                             );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true; // skip the file if an error occurred
            }

            return result;
        }
    }
}