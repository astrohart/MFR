using System;
using System.IO;
using System.Linq;

namespace MassFileRenamer.Objects
{
   public class FileRenamer : IFileRenamer
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FileRenamer" />
      /// and returns a reference
      /// to it.
      /// </summary>
      /// <param name="rootDirectoryPath">
      /// Path to the recursion root.
      /// </param>
      public FileRenamer(string rootDirectoryPath)
      {
         if (string.IsNullOrWhiteSpace(rootDirectoryPath))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(rootDirectoryPath)
            );

         RootDirectoryPath = rootDirectoryPath;
      }

      public string RootDirectoryPath { get; }

      public void ProcessAll(string findWhat, string replaceWith)
      {
         if (string.IsNullOrWhiteSpace(findWhat))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(findWhat)
            );
         if (string.IsNullOrWhiteSpace(replaceWith))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(replaceWith)
            );

         RenameSubFoldersOf(RootDirectoryPath, findWhat, replaceWith);

         RenameFilesInFolder(RootDirectoryPath, findWhat, replaceWith);

         ReplaceTextInFiles(RootDirectoryPath, findWhat, replaceWith);
      }

      public void RenameFilesInFolder(string path, string findWhat,
         string replaceWith)
      {
         if (FolderPathValidator.ShouldSkipFolder(path)) return;
         if (string.IsNullOrWhiteSpace(findWhat)) return;
         if (string.IsNullOrWhiteSpace(replaceWith)) return;

         var rootFolder = DirectoryInfoFactory.Make(path);
         if (rootFolder == null)
            throw new InvalidOperationException(
               $"Could not retrieve file system information for the folder '{rootFolder}'."
            );

         var files = rootFolder.GetFiles();
         if (!files.Any()) return;
         var subFolders = rootFolder.GetDirectories(
            "*", SearchOption.TopDirectoryOnly
         );

         // NOTE: We do not check here whether there are any subfolders or not,
         // we purely recurse (or don't). This is because, as we are doing a
         // rename-files algorithm, a folder not having any subfolders, in
         // principle, should not stop our action; the fact that a folder does
         // not have any *FILES* should.
         foreach (var subFolder in subFolders.Where(
            subFolder
               => !FolderPathValidator.ShouldSkipFolder(subFolder.FullName)
         ))
            RenameFilesInFolder(
               $@"{subFolder.Parent.FullName}\{subFolder.Name}", findWhat,
               replaceWith
            );

         foreach (var file in files.Where(
            file => !FilePathValidator.ShouldSkipFile(file.FullName)
         ))
         {
            var existingFileName = file.Name;
            var existingFilePath = file.FullName;

            // QC - the file to be renamed must contain the findWhat value as part of its name.
            if (!existingFileName.Contains(findWhat))
               continue;

            var newFileName = existingFileName.Replace(findWhat, replaceWith);
            if (string.IsNullOrWhiteSpace(newFileName))
               continue; // every file must have a non blank name

            if (existingFilePath.Equals(newFileName))
               continue; // skip current file if no rename needs to be done

            if (string.IsNullOrWhiteSpace(file.DirectoryName))
               continue;

            var newFilePath = Path.Combine(file.DirectoryName, newFileName);
            if (!file.RenameTo(newFilePath)) continue;

            // QC -- if the existing file path is the same as the new file's
            // path, no file-rename operation actually occurred.
            if (existingFilePath.Equals(newFilePath))
               throw new InvalidOperationException(
                  $"Failed to rename the file '{existingFilePath}'.  The new name is the same as the old name."
               );

            // QC -- if the file does not exist at the new path, then we failed.
            if (!File.Exists(newFilePath))
               throw new InvalidOperationException(
                  $"Failed to rename the file '{existingFilePath}'.  The file with the new name does not exist."
               );
         }
      }

      public void RenameSubFoldersOf(string path, string findWhat,
         string replaceWith)
      {
         if (string.IsNullOrWhiteSpace(path))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(path)
            );
         if (string.IsNullOrWhiteSpace(findWhat))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(findWhat)
            );
         if (string.IsNullOrWhiteSpace(replaceWith))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(replaceWith)
            );

         if (FolderPathValidator.ShouldSkipFolder(path)) return;
         if (string.IsNullOrWhiteSpace(findWhat)) return;

         var rootFolder = DirectoryInfoFactory.Make(path);
         if (rootFolder == null)
            throw new InvalidOperationException(
               $"Could not retrieve file system information for the folder '{rootFolder}'."
            );

         var subFolders = rootFolder.GetDirectories(
            "*", SearchOption.TopDirectoryOnly
         );

         // NOTE: Here, checking whether there are subfolders of the current
         // folder DOES matter, since this is a rename-all
         // -the subfolders-of-the-current-folder algorithm.
         if (!subFolders.Any()) return;
         foreach (var subFolder in subFolders)
         {
            if (FolderPathValidator.ShouldSkipFolder(subFolder.FullName))
               continue;
            RenameSubFoldersOf(
               subFolder.Parent.FullName + @"\" + subFolder.Name, findWhat,
               replaceWith
            );
            var existingSubFolderName = subFolder.Name;
            if (!existingSubFolderName.Contains(findWhat))
               continue;

            // Do a string.Replace on the existingSubFolderName (not the whole
            // path, just the name of the lowest-level folder in the current
            // pathname), everywhere we see the value in findWhat, we replace
            // with replaceWith.
            var newSubFolderName =
               existingSubFolderName.Replace(findWhat, replaceWith);
            var newSubFolderPath =
               $@"{subFolder.Parent.FullName}\{newSubFolderName}";

            if (!subFolder.RenameTo(newSubFolderPath))
               throw new InvalidOperationException(
                  $"Failed to rename the subfolder '{existingSubFolderName}'."
               );
         }
      }

      public void ReplaceTextInFiles(string rootFolderPath, string findWhat,
         string replaceWith)
      {
         if (string.IsNullOrWhiteSpace(findWhat))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(findWhat)
            );

         if (FolderPathValidator.ShouldSkipFolder(rootFolderPath)) return;

         if (string.IsNullOrWhiteSpace(findWhat)) return;

         // NOTE: The replaceWith parameter isn't checked here. That is because
         //       it may be a blank value. In this event, the caller of this
         // method is trying to erase the desired text from the file entirely.

         var rootFolder = DirectoryInfoFactory.Make(rootFolderPath);
         if (rootFolder == null)
            throw new InvalidOperationException(
               $"Could not retrieve file system information for the folder '{rootFolder}'."
            );

         var files = rootFolder.GetFiles();
         if (!files.Any()) return;
         var subFolders = rootFolder.GetDirectories(
            "*", SearchOption.TopDirectoryOnly
         );

         // NOTE: We do not check here whether there are any subfolders or not,
         //       we purely recurse (or don't). This is because, as we are doing
         // a replace-in-files algorithm, a folder not having any subfolders, in
         // principle, should not stop our action; the fact that a folder does
         // not have any *FILES* should.
         foreach (var subFolder in subFolders)
         {
            if (FolderPathValidator.ShouldSkipFolder(subFolder.FullName))
               continue;
            ReplaceTextInFiles(
               subFolder.Parent.FullName + @"\" + subFolder.Name, findWhat,
               replaceWith
            );
         }

         foreach (var file in files)
         {
            var existingFilePath = file.FullName;
            if (FilePathValidator.ShouldSkipFile(existingFilePath))
               continue;
            if (!file.Exists) continue; // skip to the next file
            try
            {
               // suck in the file's text
               var existingFileText = File.ReadAllText(file.FullName);

               // NOTE: Normally, we'd print the value of the variable
               //       existingFileText for debugging purposes; however, since
               // this particular variable holds the data of a potentially
               // lengthy file, we will not print the contents of the
               // existingFileText variable out at this point. Confirm that the
               // text is not blank
               if (string.IsNullOrWhiteSpace(existingFileText))
                  continue; // file is blank; we can't process it

               // Confirm that the text to be found is actually present in the
               // text just read. If this is not the case, then there is no
               // point in doing the replacement at all.
               if (!existingFileText.Contains(findWhat))
                  continue; // file has text, but the findWhat value has not been found.

               // Do the replacement. This is a case-sensitive operation without
               // regard for matching the whole word.
               var newFileText =
                  existingFileText.Replace(findWhat, replaceWith);

               // Overwrite any existing file. If the new textual content is
               // blank, then the file will remain erased.
               if (File.Exists(existingFilePath))
                  File.Delete(existingFilePath);

               // If the newFileText value is null or the empty string, then
               // simply erase the file.
               if (string.IsNullOrEmpty(newFileText))
                  continue; // skip to the next file in the list

               // Write out the new text to the file, overwriting any existing file.
               File.WriteAllText(existingFilePath, newFileText);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
            }
         }
      }
   }
}