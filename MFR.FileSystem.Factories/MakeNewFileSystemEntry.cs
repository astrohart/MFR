using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewFileSystemEntry
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface, for
        /// the <paramref name="path" /> specified, and returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file-system entry (file or folder).
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface,
        /// initialized with the specified <paramref name="path" />, or <see langword="null" /> if either an exception is thrown during the create operation or if <paramref name="path"/> is a blank value.
        /// </returns>
        /// <remarks>
        /// NOTE: The caller must also call the
        /// <see cref="M:MFR.IOperationSpecificObject.AndOperationType" />
        /// method,
        /// and, optionally, the
        /// <see
        ///     cref="M:MFR.IFileSystemEntry.WithUserState" />
        /// fluent-builder methods on the result.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static IFileSystemEntry ForPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );

            IFileSystemEntry result;

            try
            {
                result = new FileSystemEntry(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }
    }
}
