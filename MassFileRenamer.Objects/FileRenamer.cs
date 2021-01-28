using System;
using System.IO;
using System.Linq;

namespace MassFileRenamer.Objects
{
   public sealed class FileRenamer : IFileRenamer
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

      /// <summary>
      /// Occurs when files to be processed have been counted.
      /// </summary>
      public event FilesCountedEventHandler FilesCounted;

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

         /*
         Console.WriteLine($"Attempting to rename subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'...");

         RenameSubFoldersOf(RootDirectoryPath, findWhat, replaceWith);

         Console.WriteLine($"*** Finished processing subfolders of '{RootDirectoryPath}'.");
         Console.WriteLine($"Renaming files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'...");

         RenameFilesInFolder(RootDirectoryPath, findWhat, replaceWith);

         Console.WriteLine($"*** Finished renaming files in subfolders of '{RootDirectoryPath}'.");
         */

         Console.WriteLine(
            $"Replacing text in files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
         );

         ReplaceTextInFiles(RootDirectoryPath, findWhat, replaceWith);

         Console.WriteLine(
            $"*** Finished replacing text in files contained inside subfolders of '{RootDirectoryPath}'."
         );
      }

      public void RenameFilesInFolder(string rootFolderPath, string findWhat,
         string replaceWith)
      {
         foreach (var filename in Directory.GetFiles(
            rootFolderPath, "*", SearchOption.AllDirectories
         ).Where(file => !FilePathValidator.ShouldSkipFile(file)))
            if (filename.Contains(findWhat))
               FileInfoFactory.Make(filename).RenameTo(
                  filename.Replace(findWhat, replaceWith)
               );
      }

      public void RenameSubFoldersOf(string rootFolderPath, string findWhat,
         string replaceWith)
      {
         foreach (var subfoldername in Directory.GetDirectories(
            rootFolderPath, "*", SearchOption.AllDirectories
         ).Where(dir => !FolderPathValidator.ShouldSkipFolder(dir)))
         {
            var dirInfo = DirectoryInfoFactory.Make(subfoldername);
            if (dirInfo == null) continue;

            var newDirName = "";
            if (!dirInfo.Name.Contains(findWhat)) continue;

            newDirName = dirInfo.Name.Replace(findWhat, replaceWith);

            newDirName =
               Path.Combine(dirInfo.Parent.FullName + @"\" + newDirName);
            dirInfo.RenameTo(newDirName);
         }
      }

      public void ReplaceTextInFiles(string rootFolderPath, string findWhat,
         string replaceWith)
      {
         var filenames = Directory
            .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
            .Where(file => !FilePathValidator.ShouldSkipFile(file)).ToList();

         OnFilesCounted(
            new FilesCountedEventArgs(
               filenames.Count, OperationType.ReplaceTextInFiles
            )
         );

         foreach (var filename in filenames)
         {
            var text = File.ReadAllText(filename);
            if (!text.Contains(findWhat)) 
               continue;

            text = text.Replace(findWhat, replaceWith);

            if (File.Exists(filename)) 
               File.Delete(filename);

            File.WriteAllText(filename, text);
         }
      }

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FilesCountedEventHandler.FilesCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" /> that
      /// contains the event data.
      /// </param>
      private void OnFilesCounted(FilesCountedEventArgs e)
         => FilesCounted?.Invoke(this, e);
   }
}