using PostSharp.Patterns.Diagnostics;
using System;
using System.Runtime.InteropServices;
using System.Text;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Win32
{
    /// <summary>
    /// Definitions of native Win32 API method calls that can be used to activate
    /// functionality found in the Microsoft Windows operating system.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class NativeMethods
    {
        /// <summary>
        /// Gets the maximum length of a shortened path, in characters, not counting the
        /// terminating null character.
        /// </summary>
        private const int MAX_LENGTH = 75;

        /// <summary>
        /// Truncates a path to fit within a certain number of characters by replacing path
        /// components with ellipses.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname to be truncated.
        /// </param>
        /// <returns>A <see cref="T:System.String" /> containing the truncated path.</returns>
        public static string PathCompactPathEx(string path)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(path)) return result;

                var length = path.Length;
                if (length <= 0) return result;
                if (length < MAX_LENGTH) return path;

                var sb = new StringBuilder(length + 1);
                PathCompactPathEx(sb, path, MAX_LENGTH + 1, 0);
                result = sb.ToString();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Truncates a path to fit within a certain number of characters by replacing path
        /// components with ellipses.
        /// </summary>
        /// <param name="pszOut">
        /// (Required.) A <see cref="T:System.Text.StringBuilder" />
        /// that receives the result.
        /// </param>
        /// <param name="szPath">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the pathname to be truncated.
        /// </param>
        /// <param name="cchMax">
        /// (Required.) The maximum number of characters to be
        /// contained in the new <see cref="T:System.String" />, including the terminating
        /// null character. For example, if <paramref name="cchMax" /> = 8, the resulting
        /// <see cref="T:System.String" /> can contain a maximum of 7 characters plus the
        /// terminating null character.
        /// </param>
        /// <param name="dwFlags">(Required.) Reserved.  Set to zero.</param>
        /// <returns></returns>
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        private static extern bool PathCompactPathEx(
            [Out] StringBuilder pszOut,
            string szPath,
            int cchMax,
            int dwFlags
        );
    }
}