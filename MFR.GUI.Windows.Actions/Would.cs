using MFR.FileSystem.Enumerators;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to explore hypothetical situations with data.
    /// </summary>
    public static class Would
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only for the <see cref="T:MFR.GUI.Windows.Actions.Would"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Would() { }

        /// <summary>
        /// Portions of a path that should exclude a folder from a scan.
        /// </summary>
        private static string[] TheBathPathParts =
        {
            @"\packages\",
            @"\.git\",
            @"\bin\",
            @"\obj\"
        };

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

                var folderSet = Enumerate.Directories(
                    rootFolderPath, "*",
                    SearchOption.AllDirectories
                );

                Parallel.ForEach(
                    folderSet, (dir, state) =>
                    {
                        if (dir.ContainsAnyOf(TheBathPathParts)) return;
                        if (!Is.TargetFolderMatchingReplaceWith(
                                dir, replaceWith
                            )) return;

                        result = true;
                        state.Stop();
                    }
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