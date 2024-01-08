using MFR.FileSystem.Enumerators;
using System;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to explore hypothetical situations with data.
    /// </summary>
    public static class Would
    {
        /// <summary>
        /// Determines whether the user would accidentally nuke an existing folder or
        /// project in their root directory tree by proceeding, given the specified
        /// <paramref name="rootFolderPath" />  and the specified
        /// <paramref name="replaceWith" />  text.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in which the user desires the operation(s) to start.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) Text to replace all occurrences of the
        /// <c>Find What</c> text with.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the user stands a chance of nuking existing
        /// changes.
        /// </returns>
        public static bool UserOverwriteExistingDirectory(
            string rootFolderPath,
            string replaceWith
        )
        {
            var result = false;

            try
            {
                if (!Does.FolderExist(rootFolderPath)) return result;
                if (string.IsNullOrWhiteSpace(replaceWith)) return result;

                result = Enumerate.Directories(
                                      rootFolderPath, "*",
                                      SearchOption.AllDirectories
                                  )
                                  .Where(
                                      dir => !dir.Contains("packages") &&
                                             !dir.Contains(".git") &&
                                             !dir.Contains(".vs") &&
                                             !dir.Contains("bin") &&
                                             !dir.Contains("obj")
                                  )
                                  .Any(
                                      subFolder
                                          => Is.TargetFolderMatchingReplaceWith(
                                              subFolder, replaceWith
                                          )
                                  );
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