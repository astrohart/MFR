using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using xyLOGIX.FileSystem.Enumerable.Factories;

namespace MFR.FileSystem.Enumerators
{
    /// <summary>
    /// Exposes static methods to search the file system.
    /// </summary>
    public static class Enumerate
    {
        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <param name="searchOption">
        /// (Required.) A
        /// <see cref="T:System.IO.SearchOption" /> value that specifies whether the search
        /// should list results from the current folder only, or subfolders as well.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of
        /// <see cref="T:System.Predicate{System.String}" /> that determines whether a
        /// given pathname must be included in the search results.
        /// <para />
        /// If this parameter is passed a <see langword="null" /> reference as an argument,
        /// then no path filter is applied.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// </returns>
        /// <remarks>
        /// This method searches either the top-level folder only, or all subfolders, as
        /// dictated by the argument of the <paramref name="searchOption" /> parameter.
        /// </remarks>
        [return: NotLogged]
        public static IEnumerable<string> Directories(
            string path,
            string searchPattern,
            SearchOption searchOption,
            Predicate<string> pathFilter = null
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(searchOption)
                                          .WithOptionalPathFilter(pathFilter)
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those folders in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Directories(string path)
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern("*")
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those folders in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Directories(
            string path,
            string searchPattern
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those files in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(string path)
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern("*")
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForFilesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those files in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(
            string path,
            string searchPattern
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForFilesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <param name="searchOption">
        /// (Required.) A
        /// <see cref="T:System.IO.SearchOption" /> value that specifies whether the search
        /// should list results from the current folder only, or subfolders as well.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of
        /// <see cref="T:System.Predicate{System.String}" /> that determines whether a
        /// given pathname must be included in the search results.
        /// <para />
        /// If this parameter is passed a <see langword="null" /> reference as an argument,
        /// then no path filter is applied.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method searches either the top-level folder only, or all subfolders, as
        /// dictated by the argument of the <paramref name="searchOption" /> parameter.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(
            string path,
            string searchPattern,
            SearchOption searchOption,
            Predicate<string> pathFilter = null
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(searchOption)
                                          .WithOptionalPathFilter(pathFilter)
                                          .ForFilesOnly();
    }
}