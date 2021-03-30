using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects
{
    /// <summary>
    /// Defines an object that validates the paths of files.
    /// </summary>
    public class FileValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FileValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FileValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Objects.FileValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FileValidator Instance
        {
            get;
        } = new FileValidator();

        /// <summary>
        /// Determines whether the specified file-system
        /// <paramref
        ///     name="entry" />
        /// exists on the disk.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file-system <paramref name="entry" />
        /// exists on the disk; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public override bool DoesExist(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            if (string.IsNullOrWhiteSpace(entry.Path))
                return false;

            var result = false;

            try
            {
                result = File.Exists(entry.Path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a folder is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the folder cannot be located on the disk.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a file is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the file cannot be located on the disk.
        /// </exception>
        /// <remarks>
        /// If the properties of the <paramref name="entry" /> have valid data
        /// and the path stored in the entry refers to a file-system object that
        /// exists on the disk, then this method does nothing.
        /// <para />
        /// If an object instance variable or property has a
        /// <see
        ///     langword="null" />
        /// reference, or if the path stored in the entry
        /// refers to a file-system object that does not exist on the disk, then
        /// an exception is thrown.
        /// </remarks>
        public override void IsValid(IFileSystemEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException(nameof(entry));

            if (!DoesExist(entry))
                throw new FileNotFoundException(
                    "The system cannot find the file specified.", entry.Path
                );
        }

        /// <summary>
        /// Determines whether the file-system entry with the specified
        /// <paramref name="path" /> should be skipped during an operation.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname on the disk of the
        /// file-system entry that is to potentially be skipped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> is returned by this method if the file-system
        /// entry with the specified <paramref name="path" /> is to be skipped by
        /// the operation; otherwise, <see langword="false" />.
        /// </returns>
        public override bool ShouldSkip(string path)
        {
            var result = false;

            try
            {
                result = string.IsNullOrWhiteSpace(path) ||
                         string.IsNullOrWhiteSpace(Path.GetExtension(path)) ||
                         !File.Exists(path) || path.Contains("packages") ||
                         path.Contains(".git") || path.Contains(".vs") ||
                         path.Contains(@"\bin") || path.Contains(@"\obj") ||
                         Path.GetFileName(path)
                             .StartsWith(".") || MakeNewFileInfo.ForPath(path)
                             .IsZeroLengthFile() || Path.GetExtension(path)
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