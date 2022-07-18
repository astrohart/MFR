using MFR.FileSystem.Interfaces;
using MFR.Operations;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.FileSystem
{
    /// <summary>
    /// POCO to encapsulate the details of a file-system entry, such as a file
    /// or a folder.
    /// </summary>
    public class FileSystemEntry : OperationTypeSpecificObjectBase, IFileSystemEntry
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.FileSystem.FileSystemEntry" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of the file-system entry.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public FileSystemEntry(string path)
        {
            /*
             * OKAY, this class is POCO-ish, and normally, we do
             * not throw exceptions, EVER, from the constructor
             * of a POCO! However, here we have to check for a
             * blank input because we attempt to automatically
             * initialize the ContainingFolder property from the
             * path specified -- if the path parameter is blank,
             * then we're screwed.  Not only that, it represents
             * a major error in this program, since we are technically
             * only supposed to be creating these objects for
             * non-blank path values.
             */
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            ContainingFolder = System.IO.Path.GetDirectoryName(path);
            Path = path;
        }

        /// <summary>
        /// Gets or sets the pathname of the parent folder of this file system entry.
        /// </summary>
        public string ContainingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        [Log(AttributeExclude = true)]
        public string Path
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
        [Log(AttributeExclude = true)]
        public dynamic UserState
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
