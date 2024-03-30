using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Defines an object that validates the paths of folders.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class GitRepositoryFolderPathValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static GitRepositoryFolderPathValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected GitRepositoryFolderPathValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface that validates directory paths, specifically, those that are supposed to
        /// contain a local Git repository.  We know this is so if the directory's path, with
        /// <c>.git</c> appended to it, exists.
        /// </summary>
        public static IFileSystemEntryValidator Instance
        {
            get;
        } = new GitRepositoryFolderPathValidator();

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the provided filesystem
        /// <paramref name="entry" /> is valid; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If the properties of the <paramref name="entry" /> have valid data
        /// and the path stored in the entry refers to a file-system object that
        /// exists on the disk, then this method returns <see langword="true" />.
        /// <para />
        /// If an object instance variable or property has a
        /// <see
        ///     langword="null" />
        /// reference, or if the path stored in the entry
        /// refers to a file-system object that does not exist on the disk, then
        /// this method returns <see langword="false" />.
        /// </remarks>
        public override bool IsValid(IFileSystemEntry entry)
        {
            bool result;

            try
            {
                /*
                 * Do the usual validation as defined by the base
                 * class, but then also verify that the entry's pathname
                 * is that of a folder, and that the pathname <folder>\.git
                 * in fact, exists.
                 */

                result = base.IsValid(entry) && Is.Folder(entry.Path) &&
                         Does.FolderExist(Path.Combine(entry.Path, ".git"));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}