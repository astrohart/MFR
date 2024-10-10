using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain circumstances are true in regard to presently-held data.
    /// </summary>
    public static class Is
    {
        /// <summary>
        /// Determines whether the name of the folder having the specified
        /// <paramref name="pathname" />, along with the name of the <c>.csproj</c> file
        /// that we assume is within said folder, is identically equal to the specified
        /// <paramref name="replaceWith" /> text.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in the directory tree of the starting folder.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the text to replace the search value with.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the names match; <see langword="false" />
        /// otherwise, or if a required folder or file doesn't exist.
        /// </returns>
        public static bool TargetFolderMatchingReplaceWith(
            string pathname,
            string replaceWith
        )
        {
            var result = false;

            try
            {
                if (!Does.FolderExist(pathname)) return result;
                if (string.IsNullOrWhiteSpace(replaceWith)) return result;

                var directoryName = Path.GetFileName(pathname);
                if (string.IsNullOrWhiteSpace(directoryName))
                    return result;

                var csprojFilePathname = Path.Combine(
                    pathname, $"{directoryName}.csproj"
                );
                if (!Does.FileExist(csprojFilePathname)) return result;

                var csprojFileNameWithoutExtension =
                    Path.GetFileNameWithoutExtension(csprojFilePathname);
                if (string.IsNullOrWhiteSpace(csprojFileNameWithoutExtension))
                    return result;

                result = replaceWith.Equals(directoryName) &&
                         replaceWith.Equals(csprojFileNameWithoutExtension);
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