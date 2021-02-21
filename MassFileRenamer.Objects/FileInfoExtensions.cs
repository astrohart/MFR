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
      internal static bool RenameTo(this FileInfo existingFile, string newFilePath)
      {
         if (existingFile == null) return false;
         if (string.IsNullOrWhiteSpace(newFilePath)) return false;
         if (!File.Exists(existingFile.FullName)) return false;
         if (File.Exists(newFilePath)) File.Delete(newFilePath);    // overwrite a file at the new path

         var _tempFileName = $"{Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.tmp")}";

         if (File.Exists(_tempFileName))
            File.Delete(_tempFileName);

         existingFile.MoveTo(_tempFileName);

         /* If there is no folder into which to move the file, then stop. */
         if (!Directory.Exists(Path.GetDirectoryName(newFilePath)))
             return false;

         existingFile.MoveTo(newFilePath);

         return true;    // succeeded
      }
   }}