using System;
using System.IO;
using xyLOGIX.Core.Debug;
using Thread = System.Threading.Thread;

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

            if (!string.IsNullOrWhiteSpace(existingFile.FullName) &&
                Path.GetExtension(existingFile.FullName) == ".csproj")
            {
                System.Diagnostics.Debugger.Launch();
                System.Diagnostics.Debugger.Break();
            }

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

            // Dump the parameter maxRetries to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileInfoExtensions.RenameTo: maxRetries = '{maxRetries}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the existingFile parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, existingFile, is null. If
            // it is, send an error to the log file and quit.
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
                File.Delete(newFilePath); // overwrite a file at the new path

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
                if (TryRenameFile(existingFile, newFilePath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** SUCCESS *** The file rename operation succeeded on attempt #{attempts}."
                    );
                    break;
                }
            }

            DebugUtils.WriteLine(
                DebugLevel.Error,
                $"FileInfoExtensions.RenameTo: Attempt #{attempts} failed.  Retrying in 50 milliseconds..."
            );

            Thread.Sleep(50);

            return File.Exists(newFilePath
                ); // succeeded if the file can be found at newFilePath
        }

        private static bool TryRenameFile(FileInfo existingFile, string newFilePath)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In FileInfoExtensions.TryRenameFile");

            var result = false;

            // Dump the parameter existingFile.FullName to the log
            DebugUtils.WriteLine(DebugLevel.Debug, $"FileInfoExtensions.TryRenameFile: existingFile.FullName = '{existingFile.FullName}'");

            // Dump the parameter newFilePath to the log
            DebugUtils.WriteLine(DebugLevel.Debug, $"FileInfoExtensions.TryRenameFile: newFilePath = '{newFilePath}'");

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
                DebugUtils.WriteLine(DebugLevel.Debug, $"FileInfoExtensions.TryRenameFile: _tempFileName = '{_tempFileName}'");

                /*
               if (File.Exists(_tempFileName))
                   File.Delete(_tempFileName);

               if (existingFile.Exists)
               {
                   existingFile.CopyTo(_tempFileName);
                   existingFile.Delete();
               }

               var newFileInfo = new FileInfo(_tempFileName);

               if (newFileInfo.Exists)
               {
                   newFileInfo.CopyTo(newFilePath);
                   newFileInfo.Delete();
               }
               */

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.TryRenameFile: Moving file '{existingFile.FullName}' to '{newFilePath}'..."
                );

                File.Move(existingFile.FullName, _tempFileName);
                if (File.Exists(existingFile.FullName))
                    File.Delete(existingFile.FullName);

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
                        DebugLevel.Debug, $"FileInfoExtensions.TryRenameFile: Result = {result}"
                    );

                    DebugUtils.WriteLine(DebugLevel.Debug, "FileInfoExtensions.TryRenameFile: Done.");

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The file with path '{_tempFileName}' was found on the disk.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileInfoExtensions.TryRenameFile: Attempting to move file '{_tempFileName}' to '{newFilePath}'..."
                );

                File.Move(_tempFileName, newFilePath);
                if (File.Exists(_tempFileName)) File.Delete(_tempFileName);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                System.Diagnostics.Debugger.Launch();
                System.Diagnostics.Debugger.Break();

                return false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the destination file, '{newFilePath}', exists..."
            );

            result =
                File.Exists(
                    newFilePath
                ); // succeeded if the file exists at path newFilePath

            DebugUtils.WriteLine(DebugLevel.Debug, $"FileInfoExtensions.TryRenameFile: Result = {result}");

            DebugUtils.WriteLine(DebugLevel.Debug, "FileInfoExtensions.TryRenameFile: Done.");

            return result;
        }
    }
}