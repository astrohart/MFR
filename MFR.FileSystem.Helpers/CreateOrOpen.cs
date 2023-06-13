using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Exposes static methods for creating and/or opening file streams.
    /// </summary>
    public static class CreateOrOpen
    {
        /// <summary>
        /// Creates a blank file having the specified <paramref name="pathname" />. This
        /// method also attempts to create a new folder to store the file in,
        /// if it does not already exist.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the new file that is to be created.
        /// </param>
        /// <returns>
        /// String containing the fully-qualified pathname to the file that was created.
        /// <para />
        /// This value is blank if the file was not able to be created; e.g., due to
        /// permissions.
        /// </returns>
        public static string TextFile(string pathname)
        {
            var result = string.Empty;

            try
            {
                if (!DebugFileAndFolderHelper.IsValidPath(pathname))
                    return result;
                if (File.Exists(pathname)) return result = pathname;

                MakeSure.ContainingFolderExists(pathname);

                File.CreateText(pathname)
                    .Close();

                result = File.Exists(pathname) ? pathname : string.Empty;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}