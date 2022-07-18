using MFR.FileSystem.Interfaces;

namespace MFR.FileSystem.Validators.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a file-system-entry
    /// validator object.
    /// </summary>
    /// <remarks>
    /// Such an object is one that uses information about the type of operation
    /// being performed, as well as a pathname to a file or a folder, in order
    /// to determine whether the pathname is valid.
    /// </remarks>
    public interface IFileSystemEntryValidator
    {
        /// <summary>
        /// Determines whether the specified file-system s
        /// <paramref
        ///     name="entry" />
        /// exists on the disk.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file-system <paramref name="entry" />
        /// exists on the disk; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        bool DoesExist(IFileSystemEntry entry);

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a folder is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the folder cannot be located on the disk.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a file is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the file cannot be located on the disk.
        /// </exception>
        /// <remarks>
        /// If the properties of the <paramref name="entry" /> have valid data
        /// and the path stored in the entry refers to a file-system object that
        /// exists on the disk, then this method does nothing.
        /// <para />
        /// If an object instance variable or property has a
        /// <see
        ///     langword="null" />
        /// reference, or if the path stored in the entry
        /// refers to a file-system object that does not exist on the disk, then
        /// an exception is thrown.
        /// </remarks>
        void IsValid(IFileSystemEntry entry);

        /// <summary>
        /// Determines whether the file-system entry with the specified
        /// <paramref name="path" /> should be skipped during an operation.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname on the disk of the
        /// file-system entry that is to potentially be skipped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> is returned by this method if the file-system
        /// entry with the specified <paramref name="path" /> is to be skipped by
        /// the operation; otherwise, <see langword="false" />.
        /// </returns>
        bool ShouldSkip(string path);

        /// <summary>
        /// Gets a value determining whether the file system entry having the specified
        /// <paramref name="path" /> should be not be skipped.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a folder or a
        /// file.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file or folder specified should not be
        /// skipped during the current operation; <see langword="false" /> otherwise.
        /// </returns>
        bool ShouldNotSkip(string path);
    }
}
