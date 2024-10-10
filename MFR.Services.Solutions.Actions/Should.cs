using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Services.Solutions.Actions
{
    /// <summary>
    /// Exposes static methods that run rules to determine whether certain actions
    /// should be taken on data.
    /// </summary>
    public static class Should
    {
        /// <summary>
        /// Determines whether a Visual Studio Solution (*.sln) file with the
        /// <paramref name="pathname" /> should be skipped in a search.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> provided
        /// should not be included in the results; <see langword="false" /> otherwise.
        /// </returns>
        public static bool SkipSolutionFile(string pathname)
        {
            var result = false;

            try
            {
                result = string.IsNullOrWhiteSpace(pathname) ||
                         !File.Exists(pathname) || !".sln".Equals(
                             Path.GetExtension(pathname)
                                 .ToLowerInvariant()
                         ) || (pathname.Contains(".git") &&
                               pathname.Contains(".vs") &&
                               pathname.Contains("packages"));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}