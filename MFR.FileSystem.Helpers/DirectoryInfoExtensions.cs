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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In DirectoryInfoExtensions.RenameTo"
            );

            var result = false;

            // Dump the parameter folderToBeRenamed to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.RenameTo: folderToBeRenamed = '{folderToBeRenamed}'"
            );

            // Dump the parameter newSubFolderPath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.RenameTo: newSubFolderPath = '{newSubFolderPath}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the folderToBeRenamed parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, folderToBeRenamed, is
            // null. If it is, send an error to the log file and quit.
            if (folderToBeRenamed == null)
            {
                // the parameter folderToBeRenamed is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: A null reference was passed for the folderToBeRenamed parameter.  This parameter is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "DirectoryInfoExtensions.RenameTo: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** We have been passed a valid object reference for the folderToBeRenamed parameter."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'newSubFolderPath' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(newSubFolderPath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.RenameTo: Blank value passed for the 'newSubFolderPath' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "DirectoryInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'newSubFolderPath' is not blank.  Continuing..."
            );

            // Dump the parameter maxRetries to the log
            DebugUtils.WriteLine(DebugLevel.Debug, $"DirectoryInfoExtensions.RenameTo: maxRetries = {maxRetries}");

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether 'maxRetries' is a positive number..."
            );

            if (maxRetries <= 0)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.RenameTo: The 'maxRetries' parameter can only be 1 or greater.  It's not.  Stopping."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, $"DirectoryInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "DirectoryInfoExtensions.RenameTo: Done.");

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'maxRetries' parameter is a valid value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder with path '{folderToBeRenamed.FullName}' exists on the disk..."
            );

            if (!Directory.Exists(folderToBeRenamed.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the disk.  This folder is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "DirectoryInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The folder with path '{folderToBeRenamed.FullName}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder with path '{newSubFolderPath}' already exists.  If it does, then we are deleting it and all its files and subfolders..."
            );

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

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.RenameTo: Attempting to perform the rename operation..."
                );

                if (TryRenameFolder(folderToBeRenamed, newSubFolderPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** SUCCESS *** The rename operation succeeded."
                    );

                    break;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The attempt #{attempts} did not succeed.  Waiting 50 milliseconds and trying again (unless we've hit maxRetries = {maxRetries} attempts)..."
                );

                Thread.Sleep(50);  // rest for 50 milliseconds
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"DirectoryInfoExtensions.RenameTo: Checking whether the folder with path '{newSubFolderPath}' exists..."
            );

            result = Directory.Exists(newSubFolderPath);

            if (result)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The rename operation succeeded."
                );

            DebugUtils.WriteLine(DebugLevel.Debug, $"DirectoryInfoExtensions.RenameTo: Result = {result}");

            DebugUtils.WriteLine(DebugLevel.Debug, "DirectoryInfoExtensions.RenameTo: Done.");

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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In DirectoryInfoExtensions.TryRenameFolder"
            );

            var result = false;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the folderToBeRenamed parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, folderToBeRenamed, is
            // null. If it is, send an error to the log file and quit.
            if (folderToBeRenamed == null)
            {
                // the parameter folderToBeRenamed is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: A null reference was passed for the folderToBeRenamed parameter.  This parameter is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "DirectoryInfoExtensions.TryRenameFolder: Result = {0}",
                    result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** We have been passed a valid object reference for the folderToBeRenamed parameter."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder with path '{folderToBeRenamed.FullName}' exists on the disk..."
            );

            if (!Directory.Exists(folderToBeRenamed.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the disk.  This folder is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "DirectoryInfoExtensions.TryRenameFolder: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The folder with path '{folderToBeRenamed.FullName}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'newSubFolderPath' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(newSubFolderPath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.TryRenameFolder: Blank value passed for the 'newSubFolderPath' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "DirectoryInfoExtensions.TryRenameFolder: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'newSubFolderPath' is not blank.  Continuing..."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info, "*** INFO: Attempting rename operation..."
                );

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

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: Result = {false}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "DirectoryInfoExtensions.TryRenameFolder: Done."
                );

                return false; // rename operation failed
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Determining whether the folder with the new path, '{newSubFolderPath}', exists..."
            );

            result = Directory.Exists(newSubFolderPath);

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "DirectoryInfoExtensions.TryRenameFolder: Done."
            );

            return result;
        }
    }
}