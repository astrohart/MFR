using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Creators
{
    /// <summary>
    /// Methods to fluently create file system items.
    /// </summary>
    public static class Create
    {
        /// <summary>
        /// Creates a folder at the specified <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder you wish to create.
        /// </param>
        /// <remarks>
        /// If an I/O exception is thrown during the operation, then it is written to the
        /// log or the console.
        /// <para />
        /// Otherwise, if the <paramref name="path" /> parameter is passed a
        /// <see langword="null" /> or blank value, then this method does nothing.
        /// </remarks>
        public static void Folder(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return;

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}