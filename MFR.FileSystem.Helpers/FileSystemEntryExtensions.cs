using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using Alphaleonis.Win32.Filesystem;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Helper methods for objects that implement the
    /// <see
    ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileSystemEntryExtensions
    {
        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface into
        /// an instance of a <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" /> object.
        /// <para />
        /// The <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" /> object is initialized
        /// with the value of the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />
        /// that has been initialized with the value of the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required property,
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
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
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface into
        /// an instance of a <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> object.
        /// <para />
        /// The <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> object is initialized with
        /// the value of the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> that
        /// has been initialized with the value of the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required property,
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
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