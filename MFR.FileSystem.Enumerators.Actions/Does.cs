using System;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.FileSystem.Enumerators.Actions
{
    /// <summary>
    /// Exposes static methods to determine the state of the system and/or data.
    /// </summary>
    public static class Does
    {
        /// <summary>
        /// Determines whether at least one file that matches the specified wildcard
        /// pattern exists in the folder having the specified
        /// <paramref name="folderPathname" />, or its subfolders.  Returns the instant it
        /// finds even the first file in the group.
        /// </summary>
        /// <param name="folderPathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder from which the search should be started.
        /// </param>
        /// <param name="pattern">
        /// (Required.) A <see cref="T:System.String" /> containing the wildcard pattern to
        /// use to search for file(s) matching the criteria.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the folder having the specified
        /// <paramref name="folderPathname" />, or one of its children or descendants,
        /// contains even one file that matches the <paramref name="pattern" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool FolderHaveAtLeastOneFileMatching(string folderPathname,
            string pattern)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(folderPathname)) return result;
                if (!Directory.Exists(folderPathname)) return result;
                if (string.IsNullOrWhiteSpace(pattern)) return result;

                result = Directory.EnumerateDirectories(
                                      folderPathname, "*",
                                      SearchOption.TopDirectoryOnly
                                  )
                                  .SelectMany(
                                      dir => Directory.EnumerateFiles(
                                          dir, pattern,
                                          SearchOption.AllDirectories
                                      )
                                  )
                                  .Any() || Directory.EnumerateFiles(
                        folderPathname, pattern, SearchOption.TopDirectoryOnly
                    )
                    .Any();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}
