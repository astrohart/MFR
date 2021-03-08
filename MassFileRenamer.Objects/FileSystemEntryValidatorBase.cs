namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the common methods, properties, events, and other functionality
    /// for all types of file-system-entry validator object.
    /// </summary>
    public abstract class
        FileSystemEntryValidatorBase : IFileSystemEntryValidator
    {
        /// <summary>
        /// Determines whether the specified file-system
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
        public abstract bool DoesExist(IFileSystemEntry entry);

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
        public abstract bool ShouldSkip(IFileSystemEntry entry);

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
        public abstract void Validate(IFileSystemEntry entry);
    }
}