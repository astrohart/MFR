using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Managers.Solutions.Actions
{
    /// <summary>
    /// Exposes static methods, e.g., to get data sets from the system.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Gets an enumerable collection of strings, each of which is the pathname of a
        /// Visual Studio Solution (*.sln) file in the root folder that has the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in which to search.
        /// </param>
        /// <returns>
        /// THe empty enumerable is returned if the specified
        /// <paramref name="pathname" /> is blank, or if an error occurs during the search
        /// operation; otherwise, an enumerable collection of
        /// <see cref="T:System.String" />s is returned, each element of which is the
        /// pathname of a <c>*.sln</c> file in the folder having the specified
        /// <paramref name="pathname" />.
        /// </returns>
        public static IEnumerable<string> SolutionPathsInFolder(string pathname)
        {
            var result = Enumerable.Empty<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Is.Folder(pathname)) return result;

                result = Directory.EnumerateFiles(
                                      pathname, 
                                      "*.sln",
                                      SearchOption.AllDirectories
                                  )
                                  .Where(
                                      file => !Should.SkipSolutionFile(file)
                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }
    }
}