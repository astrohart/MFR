using MFR.Objects.FileSystem.Interfaces;
using System;
using System.IO;

namespace MFR.Objects.FileSystem.Helpers
{
    /// <summary>
    /// Helper methods for objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" />
    /// interface.
    /// </summary>
    public static class FileSystemEntryExtensions
    {
        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface into
        /// an instance of a <see cref="T:System.IO.DirectoryInfo" /> object.
        /// <para />
        /// The <see cref="T:System.IO.DirectoryInfo" /> object is initialized
        /// with the value of the
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// property.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.DirectoryInfo" />
        /// that has been initialized with the value of the
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// property.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required property,
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// , is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static DirectoryInfo ToDirectoryInfo(this IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            if (string.IsNullOrWhiteSpace(entry.Path))
                throw new ArgumentException(
                    "The 'Path' property of the IFileSystemEntry passed is blank or whitespace.",
                    nameof(entry.Path)
                );

            return new DirectoryInfo(entry.Path);
        }

        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface into
        /// an instance of a <see cref="T:System.IO.FileInfo" /> object.
        /// <para />
        /// The <see cref="T:System.IO.FileInfo" /> object is initialized with
        /// the value of the
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// property.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.FileInfo" /> that
        /// has been initialized with the value of the
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// property.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required property,
        /// <see
        ///     cref="P:MFR.Objects.IFileSystemEntry.Path" />
        /// , is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static FileInfo ToFileInfo(this IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            if (string.IsNullOrWhiteSpace(entry.Path))
                throw new ArgumentException(
                    "The 'Path' property of the IFileSystemEntry passed is blank or whitespace.",
                    nameof(entry.Path)
                );

            return new FileInfo(entry.Path);
        }
    }
}