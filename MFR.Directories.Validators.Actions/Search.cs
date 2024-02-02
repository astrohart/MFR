using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Directories.Validators.Actions
{
    /// <summary>
    /// Exposes static methods to search for files and folders.
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// Searches the specified <paramref name="folder" />, and all its subfolders, for
        /// file(s) matching the specified <paramref name="extensionPattern" />.
        /// </summary>
        /// <param name="folder">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the folder in which to begin the search.
        /// </param>
        /// <param name="extensionPattern">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the glob pattern, e.g., <c>*.sln</c>, that designates the file(s)
        /// that are to be matched by the search.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the argument of either
        /// the <paramref name="folder" /> or the <paramref name="extensionPattern" />
        /// parameters is a <see langword="null" /> reference, the
        /// <see cref="F:System.String.Empty" /> value, or a <see cref="T:System.String" />
        /// that contains only whitespace.
        /// <para />
        /// If the argument of the <paramref name="folder" /> parameter refers to a folder
        /// that does not exist on the file system, then this method also returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if at least one file is found in the directory
        /// tree of the specified <paramref name="folder" /> whose filename matches the
        /// specified <paramref name="extensionPattern" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool ForFilesHavingExtension(
            string folder,
            string extensionPattern
        )
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension: Determining whether the folder '{folder}' or file(s) whose extensions match the pattern '{extensionPattern}'..."
                );

                if (!Does.DirectoryExist(folder)) return result;

                result = Does.FolderHaveAtLeastOneFileMatching(
                    folder, extensionPattern
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Search.ForFilesHavingExtension: Result = {result}"
            );

            return result;
        }
    }
}