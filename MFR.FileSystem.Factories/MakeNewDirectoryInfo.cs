using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Factories
{
    /// <summary>
    /// Creates new instances of
    /// <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewDirectoryInfo
    {
        /// <summary>
        /// Creates a new instance of
        /// <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />
        /// that wraps the folder with the specified <paramref name="path" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the path of the folder to be wrapped.
        /// </param>
        /// <returns>
        /// Reference to an instance of
        /// <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />
        /// that represents the folder with the specified <paramref name="path" />.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="path" /> references a folder that does not exist, or if
        /// the <paramref name="path" /> folder is passed a string that is not the pathname
        /// of a folder, or if <paramref name="path" /> is blank, or if an I/O or other
        /// exception was thrown during the creation process, then this method returns
        /// <see langword="null" />.
        /// </remarks>
        public static DirectoryInfo ForPath(string path)
        {
            DirectoryInfo result = null;

            if (string.IsNullOrWhiteSpace(path)) return result;
            
            if (!Directory.Exists(path)) return result;

            try
            {
                result = new DirectoryInfo(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                return null;
            }

            return result;
        }
    }
}