using System;

namespace MFR.Objects.FileSystem.Retrievers
{
    /// <summary>
    /// Implements functionality common to retrievers of data for both files and folders.
    /// </summary>
    public abstract class FileAndFolderTextValueRetrieverBase : TextValueRetrieverBase
    {
        /// <summary>
        /// Gets a string containing the text to be searched, from the
        /// file-system <paramref name="entry" /> provided, given the current
        /// <see cref="T:MFR.Objects.OperationType"/> now being processed.
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry"/> interface.
        /// </param>
        /// <returns>
        /// String containing the value data to be searched for the current
        /// operation type, or the empty string if the data source has no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry"/>, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public override string GetTextValue(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            return entry.Path;
        }
    }
}