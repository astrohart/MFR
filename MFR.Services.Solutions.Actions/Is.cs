using System;
using System.IO;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Services.Solutions.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain facts are true.
    /// </summary>
    public static class Is
    {
        /// <summary>
        /// Checks the specified <paramref name="pathname" /> to check whether it's the
        /// pathname of a folder that exists on the file system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder that exists on the file system.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> refers to
        /// a folder that exists on the file system; <see langword="false" /> otherwise, or if the
        /// <paramref name="pathname" /> parameter's argument is a <see langword="null" />
        /// reference or a blank <see cref="T:System.String" />.
        /// </returns>
        public static bool Folder(string pathname)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(pathname)) return result;

            try
            {
                // get the file attributes for file or directory

                result = File.GetAttributes(pathname)
                             .HasFlag(FileAttributes.Directory);
                if (result) result = result && Directory.Exists(pathname);
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