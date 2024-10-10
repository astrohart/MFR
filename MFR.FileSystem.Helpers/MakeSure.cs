using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Creators;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Exposes static methods for assuring that certain conditions are true.
    /// </summary>
    public static class MakeSure
    {
        /// <summary>
        /// If the <paramref name="pathname" /> provided contains a fully-qualified
        /// path to a file, then this method makes sure that the folder named in the
        /// path exists.
        /// <para />
        /// If it does not, then a new folder with the specified path is created in
        /// order to hold the file.
        /// </summary>
        /// <param name="pathname">(Required.) Fully-qualified pathname of a file.</param>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the string
        /// specified in the <paramref name="pathname" /> parameter does not refer to a
        /// folder.
        /// </exception>
        public static void ContainingFolderExists(string pathname)
        {
            try
            {
                if (!DebugFileAndFolderHelper.IsValidPath(pathname))
                    return;

                var containingFolderPathname = Path.GetDirectoryName(pathname);
                DebugFileAndFolderHelper.CreateDirectoryIfNotExists(
                    containingFolderPathname
                );

                Verify.FolderWasCreated(containingFolderPathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}