using System;
using System.IO;
using System.Threading;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Helper methods for working with instances of <see cref="T:System.IO.FileInfo"/>.
    /// </summary>
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Renames a file.
        /// </summary>
        /// <param name="existingFile">
        /// A <see cref="T:System.IO.FileInfo"/> describing the file to be renamed.
        /// </param>
        /// <param name="newFilePath">
        /// String containing the pathname of the renamed file.
        /// </param>
        /// <returns>
        /// <c>true</c> if the rename operation is successful; <c>false</c> otherwise.
        /// </returns>
        public static bool RenameTo(this FileInfo existingFile,
            string newFilePath, int maxRetries = 5)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileInfoExtensions.RenameTo"
            );

            var result = false;

            // Dump the parameter existingFile to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.RenameTo: existingFile = '{existingFile}'"
            );

            // Dump the parameter newFilePath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.RenameTo: newFilePath = '{newFilePath}'"
            );

            /*
             * OKAY, we need to do bounds-checking on the maxRetries parameter.
             * Since this is a count, it must be a positive number and 1 or greater.
             */

            // Dump the parameter maxRetries to the log
            DebugUtils.WriteLine(DebugLevel.Debug, $"FileInfoExtensions.RenameTo: maxRetries = {maxRetries}");

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'maxRetries parameter (whose value is supposed to be a count) is 1 or greater..."
            );

            if (maxRetries <= 0)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR *** The 'maxRetries' parameter has a value that is zero or less.  This is not the range that a count of items or a length can have."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, $"FileInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done.");

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The 'maxRetries' parameter has a value that is 1 or greater, which is valid."
            );

            // Check to see if the required parameter, existingFile, is null. If
            // it is, send an error to the log file and quit.
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the existingFile parameter has a null reference for a value..."
            );

            if (existingFile == null)
            {
                // the parameter existingFile is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: A null reference was passed for the existingFile parameter.  This parameter is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "FileInfoExtensions.RenameTo: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** We have been passed a valid object reference for the existingFile parameter."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'newFilePath' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(newFilePath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileInfoExtensions.RenameTo: Blank value passed for the 'newFilePath' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'newFilePath' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{existingFile.FullName}' exists on the disk..."
            );

            if (!File.Exists(existingFile.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the file having the path '{existingFile.FullName}' on the disk.  This file is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{existingFile.FullName}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Detecting if the file '{newFilePath}' exists.  If it does, then we are deleting it..."
            );

            if (File.Exists(newFilePath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** THe file with path '{newFilePath}' was found on the disk.  We need to overwrite this file, so we are attempting to delete it..."
                );

                File.Delete(newFilePath); // overwrite a file at the new path

                if (!File.Exists(newFilePath))
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** SUCCESS *** The file with path '{newFilePath}' was deleted."
                    );
                else
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Failed to delete the file with path '{newFilePath}'."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug, $"FileInfoExtensions.RenameTo: Result = {result}"
                    );

                    DebugUtils.WriteLine(DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done.");

                    return result;
                }
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileInfoExtensions.RenameTo: Proceeding to run the file rename algorithm and attempt at most {maxRetries} times..."
            );

            var attempts = 0;

            /* File rename frequently fails due to random operating system errors.
               Try to reduce the incidence of this from occurring with a retry loop. */

            while (attempts < maxRetries)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Currently on attempt #{attempts + 1}..."
                );

                attempts++;
                if (!TryRenameFile(existingFile, newFilePath))
                    continue;

                /*
                 * If we are here, then the rename operation is successful; so, in this case,
                 * we stop the loop.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file rename operation succeeded on attempt #{attempts}."
                );
                break;
            }

            DebugUtils.WriteLine(
                DebugLevel.Error,
                $"FileInfoExtensions.RenameTo: Attempt #{attempts} failed.  Retrying in 50 milliseconds..."
            );

            Thread.Sleep(50);

            return
                File.Exists(
                    newFilePath
                ); // succeeded if the file can be found at newFilePath
        }

        private static bool TryRenameFile(FileInfo existingFile,
            string newFilePath)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileInfoExtensions.TryRenameFile"
            );

            var result = false;

            // Dump the parameter existingFile.FullName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.TryRenameFile: existingFile.FullName = '{existingFile.FullName}'"
            );

            // Dump the parameter newFilePath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.TryRenameFile: newFilePath = '{newFilePath}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'newFilePath' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(newFilePath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileInfoExtensions.RenameTo: Blank value passed for the 'newFilePath' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'newFilePath' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{existingFile.FullName}' exists on the disk..."
            );

            if (!File.Exists(existingFile.FullName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the file having the path '{existingFile.FullName}' on the disk.  This file is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.RenameTo: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileInfoExtensions.RenameTo: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{existingFile.FullName}' was found on the disk.  Proceeding..."
            );

            try
            {
                var _tempFileName =
                    $"{Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.tmp")}";

                // Dump the variable _tempFileName to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.TryRenameFile: _tempFileName = '{_tempFileName}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.TryRenameFile: Moving file '{existingFile.FullName}' to '{newFilePath}'..."
                );

                existingFile.CopyTo(_tempFileName);

                /*
                 * OKAY, we need to confirm (a) the move operation happened successfully by
                 * ensuring that the existing file indeed was moved to the temporary location.
                 * If this is not the case, then the file at the temporary location will not
                 * exist -- and then we can conclude that this attempt to rename the file has
                 * failed.  If everything worked, then delete the source file (it now lives
                 * in the temporary spot.)
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file with path '{_tempFileName}' exists on the disk..."
                );

                if (!File.Exists(_tempFileName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The system could not locate the file having the path '{_tempFileName}' on the disk.  This file is required to exist in order for us to proceed."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileInfoExtensions.TryRenameFile: Result = {false}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "FileInfoExtensions.TryRenameFile: Done."
                    );

                    return false;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{_tempFileName}' was found on the disk.  Proceeding..."
                );

                /*
                 * Double-check that the existing file is still present.  If that is so, then delete it (since,
                 * if we're here, the move operation to the temporary location was successful.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file with path '{existingFile.FullName}' exists on the disk..."
                );

                if (!File.Exists(existingFile.FullName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The system could not locate the file having the path '{existingFile.FullName}' on the disk.  This file is required to exist in order for us to proceed."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileInfoExtensions.TryRenameFile: Result = {false}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "FileInfoExtensions.TryRenameFile: Done."
                    );

                    return false;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{existingFile.FullName}' was found on the disk.  Proceeding..."
                );

                /*
                 * NOTE: We will leave the source file in the source location, so that we can use it as a backup
                 * in our next retry attempt. Only when the file has been successfully transferred to the destination,
                 * then can we erase the source file.
                 */

                /*
                 * OKAY, now it is time to complete the second stage of the file moving process -- that is, moving the file
                 * from the temporary file folder to its destination.  We do a copy operation instead, so that it preserves
                 * the file in the source location, in case an error occurs.  Before we begin though, we need to double-
                 * check whether the file exists at the destination already; in this event, delete the destination file
                 * before making a new copy at that same location.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file '{newFilePath}' already exists..."
                );

                if (File.Exists(newFilePath))
                {
                    /*
                     * If we are here, then the destination file already exists in the destination location.
                     * We want to ensure the latest version of the file is transferred.  Therefore, we will
                     * delete the file that is already at the destination in preparation for the next file-copy
                     * operation.
                     */

                    DebugUtils.WriteLine(
                        DebugLevel.Warning,
                        $"*** WARNING: The file at the destination path, '{newFilePath}', already exists."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** INFO: Overwriting the file at '{newFilePath}' in order to make way for the new version..."
                    );

                    File.Delete(newFilePath);

                    if (!File.Exists(newFilePath))
                        DebugUtils.WriteLine(
                            DebugLevel.Info,
                            $"*** SUCCESS *** The file with path '{newFilePath}' was deleted."
                        );
                    else

                        // Oops, an error occurred. Better fail, so that a retry
                        // attempt can be made.
                        return false;
                }

                /*
                 * OKAY, so if we are here, now we are ready to transfer the file from the temporary
                 * location to the destination location.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.TryRenameFile: Attempting to move file '{_tempFileName}' to '{newFilePath}'..."
                );

                File.Copy(_tempFileName, newFilePath);

                /*
                 * Did it work?  If so, then the file with path specified by the 'newFilePath' parameter
                 * will exist on the disk.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file with path '{newFilePath}' exists on the disk..."
                );

                if (!File.Exists(newFilePath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The system could not locate the file having the path '{newFilePath}' on the disk.  This file is required to exist in order for us to proceed."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileInfoExtensions.TryRenameFile: Result = {false}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "FileInfoExtensions.TryRenameFile: Done."
                    );

                    return
                        false; /* for some inexplicable reason, the copy operation failed. */
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{newFilePath}' was found on the disk.  Proceeding..."
                );

                /*
                 * OKAY, if we are here, then the transfer operation succeeded.  If that is the case,
                 * then -- after checking whether they still exist on the disk -- delete the temporary
                 * file and the source file.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file with path '{_tempFileName}' exists on the disk.  If it does, we will attempt to delete it..."
                );

                if (File.Exists(_tempFileName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** INFO: We found the file having path '_tempFileName' on the disk.  Attempting to delete it..."
                    );

                    File.Delete(_tempFileName);

                    /*
                     * OKAY, check whether the file whose path is contained in the _tempFileName variable
                     * still exists. If it does not, then the operation was successful.  If it still
                     * exists, then this method should fail.
                     */

                    if (File.Exists(_tempFileName))
                    {
                        /*
                         * Write an error to the log that indicates the attempt to delete the file
                         * was not successful.  Then, cause the method to terminate, returning the
                         * default return value.
                         */

                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            $"*** ERROR *** The attempt to delete the file having path '{_tempFileName}' was not successful."
                        );

                        DebugUtils.WriteLine(
                            DebugLevel.Debug,
                            $"m.TryRenameFile: Result = {result}"
                        );

                        DebugUtils.WriteLine(
                            DebugLevel.Debug,
                            "FileInfoExtensions.TryRenameFile: Done."
                        );

                        return result;
                    }
                }

                /*
                 * If we are here, then the attempt to delete the file was successful.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{_tempFileName}' was deleted successfully.  Proceeding..."
                );

                /*
                 * OKAY, now we need to remove the original source file.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Checking whether the file with path '{existingFile.FullName}' exists on the disk.  If it does, we will attempt to delete it..."
                );

                if (File.Exists(existingFile.FullName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** INFO: We found the file having path 'existingFile.FullName' on the disk.  Attempting to delete it..."
                    );

                    File.Delete(existingFile.FullName);

                    /*
                     * OKAY, check whether the file whose path is contained in the existingFile.FullName variable
                     * still exists. If it does not, then the operation was successful.  If it still
                     * exists, then this method should fail.
                     */

                    if (File.Exists(existingFile.FullName))
                    {
                        /*
                         * Write an error to the log that indicates the attempt to delete the file
                         * was not successful.  Then, cause the method to terminate, returning the
                         * default return value.
                         */

                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            $"*** ERROR *** The attempt to delete the file having path '{existingFile.FullName}' was not successful."
                        );

                        DebugUtils.WriteLine(
                            DebugLevel.Debug,
                            $"m.TryRenameFile: Result = {result}"
                        );

                        DebugUtils.WriteLine(
                            DebugLevel.Debug,
                            "FileInfoExtensions.TryRenameFile: Done."
                        );

                        return result;
                    }
                }

                /*
                 * If we are here, then the attempt to delete the file was successful.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{existingFile.FullName}' was deleted successfully.  Proceeding..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                return false;
            }

            /*
             * OKAY, so now we test whether the file exists at the destination path.
             * If this is so, then we can report success by setting the result variable
             * to TRUE and then returning it to the caller of this method.
             */

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the destination file, '{newFilePath}', exists..."
            );

            result =
                File.Exists(
                    newFilePath
                ); // succeeded if the file exists at path newFilePath

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.TryRenameFile: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "FileInfoExtensions.TryRenameFile: Done."
            );

            return result;
        }
    }
}