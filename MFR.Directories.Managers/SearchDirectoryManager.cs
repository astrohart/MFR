using MFR.Directories.Managers.Interfaces;
using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Directories.Managers
{
    public class SearchDirectoryManager : ISearchDirectoryManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SearchDirectoryManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
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

        public IList<string> SearchDirectories
        {
            get;
        } = new List<string>();

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
        public void GetSearchDirectories(
            string pathname,
            Predicate<string> pathFilter = null
        )
        {
            try
            {
                if (!Does.FolderExist(pathname)) return;

                SearchDirectories.Clear();

                var solutionFileList = Enumerate.Files(
                                                    pathname, "*.sln",
                                                    SearchOption.AllDirectories,
                                                    pathFilter
                                                )
                                                .AsParallel()
                                                .ToList();
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