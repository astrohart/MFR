using MFR.Operations.Interfaces;

namespace MFR.FileSystem.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a POCO that
    /// encapsulates data about a file-system entry.
    /// </summary>
    public interface IFileSystemEntry : IOperationTypeSpecificObject
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
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        string Path
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
        IFileSystemEntry AndHavingUserState(dynamic userState);
    }
}