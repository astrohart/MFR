using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Filters.Interfaces;
using System;

namespace MFR.FileSystem.Filters
{
    /// <summary>
    /// Object that implements the
    /// <see cref="T:MFR.FileSystem.Filters.Interfaces.IFolderFilter" /> interface.
    /// <para />
    /// This object allows us to decide whether certain facts are true or not about
    /// specific files and folders.
    /// </summary>
    public class FolderFilter : IFolderFilter
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.FileSystem.Filters.FolderFilter" /> and returns a reference to
        /// it.
        /// </summary>
        /// <param name="searchPath">
        /// (Required.) String that contains the fully-qualified
        /// pathname of the folder to be searched.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="searchPath" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public FolderFilter(string searchPath)
        {
            if (string.IsNullOrWhiteSpace(searchPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(searchPath)
                );
            SearchPath = searchPath;
        }

        /// <summary>
        /// Gets a reference to this object instance.
        /// </summary>
        /// <remarks>
        /// This property is here to maintain method call semantics.
        /// </remarks>
        public IFolderFilter Contains
            => this;

        /// <summary>
        /// Gets or sets a string that contains the fully-qualified pathname of the
        /// directory to be searched for a file or a folder.
        /// </summary>
        public string SearchPath
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
        public bool File(string pathPart)
        {
            if (string.IsNullOrWhiteSpace(pathPart)) return false;

            if (string.IsNullOrWhiteSpace(SearchPath)) return false;

            return Alphaleonis.Win32.Filesystem.File.Exists(
                Path.Combine(SearchPath, Path.GetFileName(pathPart))
            );
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
        /// <see langword="true" /> if the folder contains the path;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool Folder(string pathPart)
        {
            if (string.IsNullOrWhiteSpace(pathPart)) return false;

            if (string.IsNullOrWhiteSpace(SearchPath)) return false;

            return Directory.Exists(
                Path.Combine(SearchPath, Path.GetFileName(pathPart))
            );
        }
    }
}