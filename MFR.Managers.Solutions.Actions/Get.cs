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
        /// Visual Studio Solution (*.sln) file in the
        /// </summary>
        /// <param name="pathname"></param>
        /// <returns></returns>
        public static IEnumerable<string> SolutionPathsInFolder(string pathname)
        {
            var result = Enumerable.Empty<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Is.Folder(pathname)) return result;

                result = Directory.EnumerateFiles(
                                      pathname, "*.sln",
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