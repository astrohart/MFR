﻿namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
    /// interface.
    /// </summary>
    public static class MakeNewFileSystemEntry
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
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
        ///     cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
        /// interface,
        /// initialized with the specified <paramref name="path" />.
        /// </returns>
        /// <remarks>
        /// NOTE: The caller must also call the
        /// <see cref="M:MassFileRenamer.Objects.IOperationSpecificObject.AndOperationType" /> method,
        /// and, optionally, the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IFileSystemEntry.WithUserState" />
        /// fluent-builder methods on the result.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <c>null</c> string for a value.
        /// </exception>
        public static IFileSystemEntry ForPath(string path)
            => new FileSystemEntry(path);
    }
}