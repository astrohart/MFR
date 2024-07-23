using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

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
        /// Determines whether the specified file system <paramref name="entry" /> object
        /// is valid or not.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <remarks>
        /// To count as valid, the specified <paramref name="entry" /> must not be
        /// set to a <see langword="null" /> reference, and it must refer to a file or
        /// folder that actually exists on the file system.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified file-system
        /// <paramref name="entry" /> is valid; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsValid(IFileSystemEntry entry)
        {
            bool result;

            try
            {
                result = entry != null && Does.FileSystemEntryExist(entry.Path);
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