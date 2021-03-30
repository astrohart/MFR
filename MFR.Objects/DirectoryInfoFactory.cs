using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MFR.Objects
{
    /// <summary>
    /// Creates new instances of <see cref="T:System.IO.DirectoryInfo"/>.
    /// </summary>
    public static class DirectoryInfoFactory
    {
        /// <summary>
        /// Creates a new instance of <see cref="T:System.IO.DirectoryInfo"/>
        /// that wraps the folder with the specified <paramref name="path"/> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the path of the folder to be wrapped.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.DirectoryInfo"/>
        /// that represents the folder with the specified <paramref name="path"/>.
        /// </returns>
        public static DirectoryInfo Make(string path)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In DirectoryInfoFactory.Make"
            );

            // Dump the parameter path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, $"DirectoryInfoFactory.Make: path = '{path}'"
            );

            DirectoryInfo result = null;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder with path '{path}' exists on the disk..."
            );

            if (!Directory.Exists(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{path}' on the disk.  This folder is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoFactory.Make: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "DirectoryInfoFactory.Make: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The folder with path '{path}' was found on the disk.  Proceeding..."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"DirectoryInfoFactory.Make: Attempting to create a DirectoryInfo object that represents the folder with path '{path}'..."
                );

                result = new DirectoryInfo(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoFactory.Make: Result = {null}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "DirectoryInfoFactory.Make: Done."
                );

                return null;
            }

            if (result != null)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** New DirectoryInfo instance created for the folder with path '{path}'."
                );

            return result;
        }
    }
}