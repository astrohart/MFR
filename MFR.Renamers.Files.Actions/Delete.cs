using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to delete data.
    /// </summary>
    public static class Delete
    {
        /// <summary>
        /// If it exists, deletes the file having the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that is to be deleted from the file system.
        /// </param>
        /// <remarks>
        /// If the file having the specified <paramref name="pathname" /> does not
        /// exist, then this method does nothing.
        /// </remarks>
        public static void File(string pathname)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return;
                if (!Does.FileExist(pathname)) return;

                Alphaleonis.Win32.Filesystem.File.Delete(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}