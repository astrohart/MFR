using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.FileSystem.Validators
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
        /// <see cref="T:MFR.FileSystem.Validators.DirectoryValidator" />.
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
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
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
            if (string.IsNullOrWhiteSpace(entry.Path)) return false;

            var result = false;

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

            return result;
        }

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
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
        /// and the pathname stored in the entry refers to a file-system object that
        /// exists on the disk, then this method does nothing.
        /// <para />
        /// If an object instance variable or property has a
        /// <see
        ///     langword="null" />
        /// reference, or if the pathname stored in the entry
        /// refers to a file-system object that does not exist on the disk, then
        /// an exception is thrown.
        /// </remarks>
        public override void IsValid(IFileSystemEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException(nameof(entry));

            if (!DoesExist(entry))
                throw new DirectoryNotFoundException(
                    $"The system cannot find the folder with pathname '{entry.Path}' on the disk."
                );
        }

        /// <summary>
        /// Determines whether the file system entry at the specified
        /// <paramref name="pathname" />, be it a file or a folder, exists.
        /// <para />
        /// Since a different API is used to determine whether files or directories exist,
        /// this method must be overriden by child classes.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname
        /// of the resource whose existence must be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the resource exists at the pathname specified;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// The purpose of this method is really to provide resource-existence detection
        /// services to the public overload of this method, and so it can be used in the
        /// body of, e.g., the
        /// <see cref="M:MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldSkip" />
        /// method.
        /// </remarks>
        protected override bool DoesExist(string pathname)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(pathname)) return result;

            try
            {
                result = Directory.Exists(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}
