using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects.FileSystem.Helpers
{
    /// <summary>
    /// Provides helper methods for working with instances of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo"/>.
    /// </summary>
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Determines whether the specified <paramref name="file"/> has a zero length.
        /// </summary>
        /// <param name="file">
        /// (Required.) Reference to an instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo"/> that describes the file to be checked.
        /// </param>
        /// <returns><see langword="true" /> if the <paramref name="file"/> parameter is not <see langword="null" />, if the file it refers to exists on the disk, and if the file's length is zero.  Otherwise, or if an operating system error occurred, <see langword="false" /> is returned.</returns>
        public static bool IsZeroLengthFile(this FileInfo file)
        {
            var result = false;

            try
            {
                if (file == null) return result;

                if (!file.Exists) return result;

                result = file.Length == 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        public static bool RenameTo(this FileInfo source, string dest)
        {
            var result = false;

            try
            {
                if (source == null) return result;

                if (!source.Exists) return result;

                if (string.IsNullOrWhiteSpace(dest)) return result;

                if (!dest.IsAbsolutePath()) return result;

                if (source.FullName.EqualsNoCase(dest)) return result;

                result = source.TryRenameTo(dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        private static bool TryRenameTo(this FileInfo source, string newPath,
            int maxRetries = 5)
        {
            var result = false;

            if (maxRetries <= 0) return result;

            if (source == null) return result;

            if (!source.Exists) return result;

            if (string.IsNullOrWhiteSpace(newPath)) return result;

            var attempts = 0;
            while (!result && attempts < maxRetries)
                try
                {
                    attempts++;

                    var oldPath = source.FullName;

                    if (source.IsLocked()) return result;

                    result = source.MoveTo(
                                       newPath,
                                       MoveOptions.CopyAllowed |
                                       MoveOptions.ReplaceExisting |
                                       MoveOptions.WriteThrough
                                   )
                                   .Exists && !File.Exists(oldPath);
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