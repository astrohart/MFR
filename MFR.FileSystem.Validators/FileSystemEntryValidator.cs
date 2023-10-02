using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Validates the values of the properties of instances of objects that
    /// implement the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileSystemEntryValidator
    {
        /// <summary>
        /// Validates the <paramref name="entry" /> specified.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown in the event that the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property of
        /// the object referenced by the <paramref name="entry" /> parameter is a
        /// blank or <see langword="null" /> string.
        /// </exception>
        public static void ValidateFileSystemEntry(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            if (string.IsNullOrWhiteSpace(entry.Path))
                throw new InvalidOperationException(
                    "The file system entry's path has not been specified."
                );
        }
    }
}
