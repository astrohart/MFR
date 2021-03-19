using PostSharp.Patterns.Diagnostics;
using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// POCO to encapsulate the details of a file-system entry, such as a file
    /// or a folder.
    /// </summary>
    public class FileSystemEntry : OperationSpecificObjectBase, IFileSystemEntry
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileSystemEntry" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of the file-system entry.
        /// </param>
        public FileSystemEntry(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)] public override OperationType OperationType
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        [Log(AttributeExclude = true)] public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user state.
        /// </summary>
        /// <remarks>
        /// For example, if the file-system entry is representing a text file,
        /// then this property might contain the file's contents from them
        /// having been previously read in.
        /// </remarks>
        [Log(AttributeExclude = true)] public dynamic UserState
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
        public IFileSystemEntry AndHavingUserState(dynamic userState)
        {
            UserState = userState ??
                        throw new ArgumentNullException(nameof(userState));

            return this;
        }
    }
}