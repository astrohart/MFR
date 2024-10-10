using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Provides helper methods for working with instances of
    /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Determines whether the specified <paramref name="file" /> has a zero length.
        /// </summary>
        /// <param name="file">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// that describes the
        /// file to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="file" /> parameter is
        /// not <see langword="null" />, if the file it refers to exists on the
        /// disk, and if the file's length is zero. Otherwise, or if an
        /// operating system error occurred, <see langword="false" /> is returned.
        /// </returns>
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

        /// <summary>
        /// Renames a file.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// instance that refers to the existing file.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the fully-qualified pathname of hte
        /// file's new name.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation was successful;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// If <paramref name="source" /> is <see langword="null" /> or
        /// <paramref
        ///     name="dest" />
        /// is blank, or some other issue occurs, then this method
        /// returns <see langword="false" />.
        /// </remarks>
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

        /// <summary>
        /// Makes multiple attempts to perform the file-rename operation.<para/>Called by the <see cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo"/> method.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// instance that refers to the existing file.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the fully-qualified pathname of hte
        /// file's new name.
        /// </param>
        /// <param name="maxRetries">(Required.) Count of retries to perform before giving up, in case the operation experiences an operating system error.</param>
        /// <returns><see langword="true" /> if the operation was successfully carried out; <see langword="false" /> otherwise.</returns>
        [Log(AttributeExclude = true)]
        private static bool TryRenameTo(this FileInfo source, string dest,
            int maxRetries = 5)
        {
            var result = false;

            if (maxRetries <= 0) return result;

            if (source == null) return result;

            if (!source.Exists) return result;

            if (string.IsNullOrWhiteSpace(dest)) return result;

            var attempts = 0;
            while (!result && attempts < maxRetries)
                try
                {
                    attempts++;

                    // Save the previous path of the file.  The source
                    // variable will refer to the file's new name after
                    // the move operation is complete.
                    var oldPath = source.FullName;

                    if (source.IsLocked()) return result;

                    result = source.MoveTo(
                                       dest,
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