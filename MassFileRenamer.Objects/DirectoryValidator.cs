using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines an object that validates the paths of folders.
    /// </summary>
    public class DirectoryValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DirectoryValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected DirectoryValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MassFileRenamer.Objects.DirectoryValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static DirectoryValidator Instance
        {
            get;
        } = new DirectoryValidator();

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
            if (string.IsNullOrWhiteSpace(entry.Path)) return false;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder with the path '{entry.Path}' exists on the disk..."
            );

            bool result;

            try
            {
                result = Directory.Exists(entry.Path);
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
                    $"*** SUCCESS *** The folder having path '{entry.Path}' was found on the disk."
                );
            else
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system was unable to find the folder having path '{entry.Path}' on the disk."
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
            => entry == null || string.IsNullOrWhiteSpace(entry.Path) ||
               !Directory.Exists(entry.Path) ||
               entry.Path.Contains("packages") || entry.Path.Contains(".git") ||
               entry.Path.Contains(".vs") || entry.Path.Contains(@"\bin") ||
               entry.Path.Contains(@"\obj") || Path.GetFileName(entry.Path)
                                                   .StartsWith(".");

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
                throw new DirectoryNotFoundException(
                    $"The system cannot find the folder with path '{entry.Path}' on the disk."
                );
        }
    }
}