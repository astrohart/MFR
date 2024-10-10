namespace MFR.FileSystem.Filters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// determines whether facts are true about files and folders.
    /// </summary>
    public interface IFolderFilter
    {
        /// <summary>
        /// Gets a reference to this object instance.
        /// </summary>
        /// <remarks>
        /// This property is here to maintain method call semantics.
        /// </remarks>
        IFolderFilter Contains
        {
            get;
        }

        /// <summary>
        /// Gets or sets a string that contains the fully-qualified pathname of the
        /// directory to be searched for a file or a folder.
        /// </summary>
        string SearchPath
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether the
        /// <see cref="P:MFR.FileSystem.Filters.FolderFilter.SearchPath" />.
        /// </summary>
        /// <param name="pathPart">
        /// (Required.) String containing the part of the path to
        /// search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the exists at the complete path;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool File(string pathPart);

        /// <summary>
        /// Determines whether the
        /// <see cref="P:MFR.FileSystem.Filters.FolderFilter.SearchPath" />.
        /// </summary>
        /// <param name="pathPart">
        /// (Required.) String containing the part of the path to
        /// search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the folder contains the path;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool Folder(string pathPart);
    }
}