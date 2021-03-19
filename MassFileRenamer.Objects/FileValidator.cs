using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
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
        /// <see cref="T:MassFileRenamer.Objects.FileValidator" />.
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
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <c>true</c> if the file-system <paramref name="entry" /> exists on
        /// the disk; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public override bool DoesExist(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            if (string.IsNullOrWhiteSpace(entry.Path)) 
                return false;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{entry.Path}' exists on the disk..."
            );

            bool result;

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

            if (result)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{entry.Path}' has been located on the disk."
                );
            else
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not find the file having the path '{entry.Path}' on the disk."
                );

            return result;
        }

        /// <summary>
        /// Determines whether the specified file-system
        /// <paramref
        ///     name="entry" />
        /// should be skipped during an operation.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <c>true</c> is returned by this method if the file-system specified
        /// <paramref name="entry" /> is to be skipped by the operation;
        /// otherwise, <c>false</c> is returned.
        /// </returns>
        public override bool ShouldSkip(IFileSystemEntry entry)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In FileValidator.ShouldSkip");

            if (entry != null) DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileValidator.ShouldSkip: Determining whether the file having path '{entry.Path}' should be skipped..."
            );

            bool result;

            try
            {
                result = entry == null || string.IsNullOrWhiteSpace(entry.Path) ||
                         string.IsNullOrWhiteSpace(Path.GetExtension(entry.Path)) ||
                         !File.Exists(entry.Path) ||
                         entry.Path.Contains("packages") ||
                         entry.Path.Contains(".git") || entry.Path.Contains(".vs") ||
                         entry.Path.Contains(@"\bin") ||
                         entry.Path.Contains(@"\obj") || Path.GetFileName(entry.Path)
                             .StartsWith(".");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            if (result && entry != null)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileValidator.ShouldSkip: The file having path '{entry.Path}' should be skipped."
                );

            DebugUtils.WriteLine(DebugLevel.Debug, $"FileValidator.ShouldSkip: Result = {result}");

            DebugUtils.WriteLine(DebugLevel.Debug, "FileValidator.ShouldSkip: Done.");

            return result;
        }

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <c>null</c> value.
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
        /// If an object instance variable or property has a <c>null</c>
        /// reference, or if the path stored in the entry refers to a
        /// file-system object that does not exist on the disk, then an
        /// exception is thrown.
        /// </remarks>
        public override void Validate(IFileSystemEntry entry)
        {
            if (entry == null) 
                throw new ArgumentNullException(nameof(entry));

            if (!DoesExist(entry))
                throw new FileNotFoundException(
                    "The system cannot find the file specified.", entry.Path
                );
        }
    }
}