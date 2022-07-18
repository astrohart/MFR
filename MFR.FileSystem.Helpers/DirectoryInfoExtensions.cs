using System;
using Alphaleonis.Win32.Filesystem;
using System.Threading;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Helper methods for working with instances of <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo"/>.
    /// </summary>
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// Renames a folder.
        /// </summary>
        /// <param name="folderToBeRenamed">
        /// A <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo"/> describing the folder to
        /// be renamed.
        /// </param>
        /// <param name="newSubFolderPath">
        /// String containing the pathname of the renamed folder.
        /// </param>
        /// <param name="maxRetries">
        /// (Optional.) Set to the maximum retries before giving up. Default is 5.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the rename operation is successful; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// A <paramref name="maxRetries"/> parameter is necessary since, during
        /// rename operations, random exceptions keep popping up. Therefore, we
        /// retry the operation until either (a) the operation succeeded, or (b)
        /// the max number of retries has been hit.
        /// </remarks>
        public static bool RenameTo(this DirectoryInfo folderToBeRenamed,
            string newSubFolderPath, int maxRetries = 5)
        {
            // write the name of the current class and method we are now
            var result = false;
            // Check to see if the required parameter, folderToBeRenamed, is
            if (folderToBeRenamed == null)
            {
                // the parameter folderToBeRenamed is required.
                // stop.
                return result;
            }
            if (string.IsNullOrWhiteSpace(newSubFolderPath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.RenameTo: Blank value passed for the 'newSubFolderPath' parameter. This parameter is required."
                );
                return result;
            }
            if (maxRetries <= 0)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.RenameTo: The 'maxRetries' parameter can only be 1 or greater.  It's not.  Stopping."
                );
                return result;
            }
            if (!Directory.Exists(folderToBeRenamed.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the disk.  This folder is required to exist in order for us to proceed."
                );
                return result;
            }
            // if the destination already exists, then delete it recursively
            if (Directory.Exists(newSubFolderPath))
                Directory.Delete(newSubFolderPath, true);

            var attempts = 0;

            while (attempts < maxRetries)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info, $"*** INFO: On attempt #{attempts + 1}..."
                );

                attempts++;
                if (TryRenameFolder(folderToBeRenamed, newSubFolderPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** SUCCESS *** The rename operation succeeded."
                    );

                    break;
                }
                Thread.Sleep(50);  // rest for 50 milliseconds
            }
            result = Directory.Exists(newSubFolderPath);

            if (result)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The rename operation succeeded."
                );

            return result;
        }

        /// <summary>
        /// Attempts to perform the folder rename operation.
        /// </summary>
        /// <param name="folderToBeRenamed">
        /// (Required.) Reference to an instance of <see
        /// cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo"/> that represents the folder to be renamed.
        /// </param>
        /// <param name="newSubFolderPath">
        /// (Required.) String containing the new path of the renamed folder.
        /// </param>
        /// <returns>
        /// </returns>
        private static bool TryRenameFolder(DirectoryInfo folderToBeRenamed,
            string newSubFolderPath)
        {
            // write the name of the current class and method we are now
            var result = false;
            // Check to see if the required parameter, folderToBeRenamed, is
            if (folderToBeRenamed == null)
            {
                // the parameter folderToBeRenamed is required.
                // stop.
                return result;
            }
            if (!Directory.Exists(folderToBeRenamed.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the disk.  This folder is required to exist in order for us to proceed."
                );
                return result;
            }
            if (string.IsNullOrWhiteSpace(newSubFolderPath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.TryRenameFolder: Blank value passed for the 'newSubFolderPath' parameter. This parameter is required."
                );
                return result;
            }
            try
            {
                folderToBeRenamed.MoveTo(newSubFolderPath);

                if (Directory.Exists(newSubFolderPath))
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** SUCCESS *** Rename operation succeeded."
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
                return false; // rename operation failed
            }
            result = Directory.Exists(newSubFolderPath);
            return result;
        }
    }
}
