using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.FileSystem.Factories.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain conditions are met by data.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class Is
    {
        /// <summary>
        /// Determines whether the file system entry having the specified
        /// <paramref name="pathname" /> is a folder or not.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file system entry to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file system entry having the specified
        /// <paramref name="pathname" /> is a folder; <see langword="false" /> otherwise.
        /// </returns>
        public static bool Folder(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                // get the file attributes for file or directory
                var attr = File.GetAttributes(pathname);
                if (attr == null) return result;

                //detect whether its a directory or file
                result = (attr & FileAttributes.Directory) ==
                         FileAttributes.Directory;
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