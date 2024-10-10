using MFR.Operations.Interfaces;
using System;

namespace MFR.FileSystem.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a POCO that
    /// encapsulates data about a file-system entry.
    /// </summary>
    public interface IFileSystemEntry : IOperationTypeSpecificObject,
        IEquatable<IFileSystemEntry>
    {
        /// <summary>
        /// Gets or sets the pathname of the parent folder of this file system entry.
        /// </summary>
        string ContainingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value that indicates whether the file system entry exists.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the file system entry exists;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool Exists
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the entry represents a file or a folder on the
        /// file system.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if this file system entry is folder;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool IsFolder
        {
            get;
        }

        /// <summary>
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a truncated version of the
        /// value of the <see cref="P:MFR.FileSystem.FileSystemEntry.Path" /> property.
        /// </summary>
        string ShortPath
        {
            get;
        }

        /// <summary>
        /// Gets or sets user state.
        /// </summary>
        /// <remarks>
        /// For example, if the file-system entry is representing a text file,
        /// then this property might contain the file's contents from them
        /// having been previously read in.
        /// </remarks>
        dynamic UserState
        {
            get;
            set;
        }

        /// <summary>
        /// Associates user state information, such as file contents or other
        /// data, with this file-system entry.
        /// </summary>
        /// <param name="userState">
        /// (Required.) Reference to an instance of an object that serves as
        /// user state information.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="userState" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        IFileSystemEntry SetUserState(dynamic userState);
    }
}