using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates new instances of <see cref="T:System.IO.FileInfo" /> and returns
    /// references to them.
    /// </summary>
    public static class MakeNewFileInfo
    {
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

        /// <summary>
        /// Creates a new instance of <see cref="T:System.IO.FileInfo" />,
        /// initializes it with the <paramref name="path" /> specified, and
        /// returns it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of a file on the disk.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.IO.FileInfo" />, initialized with the specified
        /// <paramref name="path" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="path" />
        /// parameter, cannot be located on the disk.
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

            return new FileInfo(path);
        }
    }
}