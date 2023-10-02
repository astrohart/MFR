using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to write data, e.g., to files or other data sources.
    /// </summary>
    public static class Write
    {
        /// <summary>
        /// Writes the specified <paramref name="contents" /> to the file having the
        /// specified <paramref name="pathname" />.
        /// <para />
        /// If the file already exists, then it is deleted.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to be written to the disk.
        /// </param>
        /// <param name="contents">
        /// (Required.) A <see cref="T:System.String" /> containing the contents of the new
        /// file.
        /// </param>
        public static void FileContent(string pathname, string contents)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return;
                if (string.IsNullOrWhiteSpace(contents)) return;

                var fileEncoding = Determine.FileEncoding(pathname);

                Alphaleonis.Win32.Filesystem.File.WriteAllText(pathname, contents, fileEncoding);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}