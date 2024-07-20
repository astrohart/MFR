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
                    $"Search.ForFilesHavingExtension: Determining whether the folder '{folder}', or its subfolder(s), contains at least one file(s) whose extensions match the pattern '{extensionPattern}'..."
                );

                // Dump the parameter folder to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Search.ForFilesHavingExtension: folder = '{folder}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension *** INFO: Checking whether the folder with path '{folder}' exists on the file system..."
                );

                if (!Does.FolderExist(folder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"Search.ForFilesHavingExtension: *** ERROR *** The system could not locate the folder having the path '{folder}' on the file system.  This folder is required to exist in order for us to proceed."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Search.ForFilesHavingExtension: Result = {result}"
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension: *** SUCCESS *** The folder with path '{folder}' was found on the file system.  Proceeding..."
                );

                // Dump the parameter extensionPattern to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Search.ForFilesHavingExtension: extensionPattern = '{extensionPattern}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the value of the 'extensionPattern' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(extensionPattern))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Search.ForFilesHavingExtension: Blank value passed for the 'extensionPattern' parameter. This parameter is required."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Search.ForFilesHavingExtension: Result = {result}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "Search.ForFilesHavingExtension: Done."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'extensionPattern' is not blank.  Continuing..."
                );

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