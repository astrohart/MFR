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
    /// Defines an object that validates the paths of Visual Studio Solution (those
    /// whose names have the extension <c>.sln</c>) files.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class SolutionFileValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SolutionFileValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SolutionFileValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface and which validates the pathnames of Visual Studio Solution (*.sln)
        /// files.
        /// </summary>
        public static IFileSystemEntryValidator Instance
        {
            get;
        } = new SolutionFileValidator();

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

            try
            {
                // Should skip the file if its fully-qualified pathname is blank.
                if (string.IsNullOrWhiteSpace(path)) return result;

                // Should skip the file if its filename extension is not '.sln'.
                if (!Path.GetExtension(path)
                         .IsAnyOf(".sln")) return result;

                // Should skip the file if the base class says so
                if (base.ShouldSkip(path)) return result;

                // Should skip the file if the fully-qualified pathname of the file has no filename extension.
                if (string.IsNullOrWhiteSpace(Path.GetExtension(path)))
                    return result;

                // Skip the file if the file is a zero-length file.
                result = MakeNewFileInfo.ForPath(path)
                                        .IsZeroLengthFile();
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