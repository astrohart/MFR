namespace MassFileRenamer.Objects
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
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <c>true</c> if the file-system <paramref name="entry" /> exists on
        /// the disk; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        bool DoesExist(IFileSystemEntry entry);

        /// <summary>
        /// Determines whether the specified file-system
        /// <paramref
        ///     name="entry" />
        /// should be skipped during an operation.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <c>true</c> is returned by this method if the file-system specified
        /// <paramref name="entry" /> is to be skipped by the operation;
        /// otherwise, <c>false</c> is returned.
        /// </returns>
        bool ShouldSkip(IFileSystemEntry entry);

        /// <summary>
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <c>null</c> value.
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
        /// If an object instance variable or property has a <c>null</c>
        /// reference, or if the path stored in the entry refers to a
        /// file-system object that does not exist on the disk, then an
        /// exception is thrown.
        /// </remarks>
        void Validate(IFileSystemEntry entry);
    }
}