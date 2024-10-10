using System;
using System.Collections;
using System.Collections.Generic;

namespace MFR.Directories.Managers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// the search folders for performing the operations requested by the user to
    /// rename projects, files, and folders.
    /// </summary>
    public interface ISearchDirectoryManager
    {
        /// <summary>
        /// Gets a collection of fully-qualified pathnames of folders found by this object, that
        /// should be searched for projects, files, and folders whose names should be
        /// changed.
        /// </summary>
        IList<string> SearchDirectories
        {
            get;
        }

        /// <summary>
        /// Scans the folder having the specified <paramref name="pathname" /> for Visual
        /// Studio Solution (<c>*.sln</c>) files and then builds the list in the
        /// <see cref="P:MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories" />
        /// property of all the folders under the folder having the specified
        /// <paramref name="pathname" /> that contain Visual Studio Solution (<c>*.sln</c>)
        /// files.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder to scan for Visual Studio Solution (<c>*.sln</c>) files.
        /// </param>
        /// <remarks>
        /// After this method executes, callers can access the
        /// <see cref="P:MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories" />
        /// property in order to access the list of folders that was retrieved.
        /// </remarks>
        void Search(
            string pathname,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Clears the list of search folders.
        /// </summary>
        void Clear();
    }
}