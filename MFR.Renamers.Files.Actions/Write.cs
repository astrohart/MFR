using System;
using xyLOGIX.Core.Debug;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to write data, e.g., to files or other data sources.
    /// </summary>
    public static class Write
    {
        /// <summary>
        /// Writes the specified <paramref name="contents" /> to the file having the
        /// specified <paramref name="path" />.
        /// <para />
        /// If the file already exists, then it is deleted.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to be written to the disk.
        /// </param>
        /// <param name="contents">
        /// (Required.) A <see cref="T:System.String" /> containing the contents of the new
        /// file.
        /// </param>
        public static void FileContent(string path, string contents)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path)) return;
                if (string.IsNullOrWhiteSpace(contents)) return;

                Alphaleonis.Win32.Filesystem.File.WriteAllText(path, contents);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}