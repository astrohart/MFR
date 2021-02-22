using System.IO;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Helper methods for working with instances of <see cref="T:System.IO.DirectoryInfo"/>.
   /// </summary>
   internal static class DirectoryInfoExtensions
   {
      /// <summary>
      /// Renames a folder.
      /// </summary>
      /// <param name="folderToBeRenamed">
      /// A <see cref="T:System.IO.DirectoryInfo"/> describing the folder to be renamed.
      /// </param>
      /// <param name="newSubFolderPath">
      /// String containing the pathname of the renamed folder.
      /// </param>
      /// <returns>
      /// <c>true</c> if the rename operation is successful; <c>false</c> otherwise.
      /// </returns>
      internal static bool RenameTo(this DirectoryInfo folderToBeRenamed,
         string newSubFolderPath)
      {
         if (folderToBeRenamed == null) return false;
         if (string.IsNullOrWhiteSpace(newSubFolderPath)) return false;

         // stop if the destination already exists.
         if (Directory.Exists(newSubFolderPath))
             Directory.Delete(newSubFolderPath, true);

         try
         {
             if (!folderToBeRenamed.Exists)
                 return false;

             folderToBeRenamed.MoveTo(newSubFolderPath);
         }
         catch
         {
            return false; // rename operation failed
         }

         return true; // succeeded
      }
   }
}