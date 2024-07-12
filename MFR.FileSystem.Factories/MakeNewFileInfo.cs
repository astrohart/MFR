using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;
using FileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace MFR.FileSystem.Factories
{
    /// <summary>
    /// Creates new instances of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> and returns
    /// references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewFileInfo
    {
        /// <summary>
        /// Creates a new instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />,
        /// initializes it with the <paramref name="path" /> specified, and
        /// returns it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of a file on the file system.
        /// </param>
        /// <returns>
        /// A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />, initialized with the specified
        /// <paramref name="path" />.<para/><see langword="null" /> is returned if the operation failed.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="path" />
        /// parameter, cannot be located on the file system.
        /// </exception>
        public static FileInfo ForPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    "The system cannot locate the file specified.", path
                );

            FileInfo result;

            try
            {
                /*
                 * We add extra robustness here, since this a File I/O
                 * operation.  The operation may fail because the provided
                 * path may refer to a file that can't be accessed by the
                 * user, or any one of a myriad other reasons.
                 *
                 * If this is so, then we set the result variable to null
                 * as a signal to the caller of this method that the operation
                 * failed.
                 */

                result = new FileInfo(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> for the
        /// file whose path is specified by the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface, a reference to which is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter.
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that contains the file's path.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> that
        /// is initialized with the path to the file referred to by the value of
        /// the <paramref name="entry" /> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required
        /// <see
        ///     cref="P:MFR.FileSystem.Interfaces.IFileSystemEntry.Path" />
        /// property is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static FileInfo FromFileSystemEntry(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (string.IsNullOrWhiteSpace(entry.Path))
                throw new ArgumentException(
                    "The path of the FileSystemEntry provided cannot be blank.",
                    nameof(entry.Path)
                );

            return ForPath(entry.Path);
        }
    }
}
