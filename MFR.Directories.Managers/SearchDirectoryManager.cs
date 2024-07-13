using MFR.Directories.Managers.Interfaces;
using MFR.FileSystem.Enumerators;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;

namespace MFR.Directories.Managers
{
    /// <summary>
    /// Manages the search folders for performing the operations requested by the user
    /// to rename projects, files, and folders.
    /// </summary>
    public class SearchDirectoryManager : ISearchDirectoryManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SearchDirectoryManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SearchDirectoryManager() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </summary>
        public static ISearchDirectoryManager Instance
        {
            get;
        } = new SearchDirectoryManager();

        /// <summary>
        /// Gets a collection of fully-qualified pathnames of folders found by this object,
        /// that
        /// should be searched for projects, files, and folders whose names should be
        /// changed.
        /// </summary>
        public IList<string> SearchDirectories
        {
            get;
        } = new List<string>();

        /// <summary>
        /// Clears the list of search folders.
        /// </summary>
        public void Clear()
        {
            if (SearchDirectories == null || !SearchDirectories.Any()) return;

            SearchDirectories.Clear();
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
        public void Search(string pathname, Predicate<string> pathFilter = null)
        {
            try
            {
                if (!Does.FolderExist(pathname)) return;

                SearchDirectories.Clear();

                var solutionFileList = Enumerate.Files(
                    pathname, "*.sln", SearchOption.AllDirectories, pathFilter
                );
                if (solutionFileList == null || !solutionFileList.Any()) return;

                SearchDirectories.AddRange(
                    solutionFileList.Select(Path.GetDirectoryName)
                                    .Distinct()
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}