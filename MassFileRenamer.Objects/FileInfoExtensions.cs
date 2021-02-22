using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Helper methods for working with instances of <see cref="T:System.IO.FileInfo"/>.
    /// </summary>
    internal static class FileInfoExtensions
    {
        /// <summary>
        /// Renames a file.
        /// </summary>
        /// <param name="existingFile">
        /// A <see cref="T:System.IO.FileInfo"/> describing the file to be renamed.
        ///</param>
        /// <param name="newFilePath">
        /// String containing the pathname of the renamed file.
        /// </param>
        /// <returns><c>true</c> if the rename operation is successful; <c>false</c> otherwise.</returns>
        internal static bool RenameTo(this FileInfo existingFile, string newFilePath, int maxRetries = 5)
        {
            if (existingFile == null) return false;
            if (string.IsNullOrWhiteSpace(newFilePath)) return false;
            if (!File.Exists(existingFile.FullName)) return false;
            if (File.Exists(newFilePath)) File.Delete(newFilePath);    // overwrite a file at the new path

            var attempts = 0;

            /* File rename frequently fails due to random operating system errors.
               Try to reduce the incidence of this from occurring with a retry loop. */

            while (attempts < maxRetries)
            {
                attempts++;
                if (TryRenameFile(existingFile, newFilePath))
                    break;
                System.Threading.Thread.Sleep(50);
            }

            return File.Exists(newFilePath);    // succeeded if the file can be found at newFilePath
        }

        private static bool TryRenameFile(FileInfo existingFile, string newFilePath)
        {
            try
            {
                var _tempFileName =
                    $"{Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.tmp")}";

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

                File.Move(existingFile.FullName, _tempFileName);
                if (File.Exists(existingFile.FullName))
                    File.Delete(existingFile.FullName);

                File.Move(_tempFileName, newFilePath);
                if (File.Exists(_tempFileName)) File.Delete(_tempFileName);
            }
            catch
            {
                return false;
            }

            return File.Exists(newFilePath);  // succeeded if the file exists at path newFilePath
        }
    }
}