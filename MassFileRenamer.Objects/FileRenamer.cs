using System;
using System.IO;
using System.Linq;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Provides file- an folder-rename services.
   /// </summary>
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
      /// Occurs when files to be renamed have been counted.
      /// </summary>
      public event FilesCountedEventHandler FilesToBeRenamedCounted;

      /// <summary>
      /// Occurs when files to be processed have been counted.
      /// </summary>
      public event FilesCountedEventHandler FilesToHaveTextReplacedCounted;

      /// <summary>
      /// Occurs when an operation is about to be processed for a file or a folder.
      /// </summary>
      public event ProcessingOperationEventHandler ProcessingOperation;

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

         Console.WriteLine(
            $"Attempting to rename subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
         );

         RenameSubFoldersOf(RootDirectoryPath, findWhat, replaceWith);

         Console.WriteLine(
            $"*** Finished processing subfolders of '{RootDirectoryPath}'."
         );
         Console.WriteLine(
            $"Renaming files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
         );

         RenameFilesInFolder(RootDirectoryPath, findWhat, replaceWith);

         Console.WriteLine(
            $"*** Finished renaming files in subfolders of '{RootDirectoryPath}'."
         );

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
         var filenames = Directory
            .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
            .Where(file => !FilePathValidator.ShouldSkipFile(file))
            .Where(filename => filename.Contains(findWhat)).ToList();

         OnFilesToBeRenamedCounted(
            new FilesCountedEventArgs(
               filenames.Count, OperationType.RenameFiles
            )
         );

         foreach (var filename in filenames)
         {
            OnProcessingOperation(
               new ProcessingOperationEventArgs(
                  filename, OperationType.RenameFiles
               )
            );

            FileInfoFactory.Make(filename).RenameTo(
               filename.Replace(findWhat, replaceWith)
            );
         }
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

      /// <summary>
      /// Iterates recursively through a directory tree, starting at the folder
      /// with pathname <paramref name="rootFolderPath" /> and replacing every
      /// occurrence of the text specified by the <paramref name="findWhat" />
      /// parameter with the text specified by the
      /// <paramref
      ///    name="replaceWith" />
      /// parameter. A case-sensitive, not-in-whole-word
      /// search is performed.
      /// </summary>
      /// <param name="rootFolderPath">
      /// (Required.) Pathname of the folder where the operation is to start.
      /// </param>
      /// <param name="findWhat">
      /// (Required.) Text to be found in each file contained in the directory tree.
      /// </param>
      /// <param name="replaceWith">
      /// (Optional.) Text to replace all the instances of
      /// <paramref
      ///    name="findWhat" />
      /// with. If this parameter is blank (the default), then
      /// the text is deleted.
      /// </param>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if either the <paramref name="rootFolderPath" /> or the
      /// <paramref name="findWhat" /> parameters are blank.
      /// </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// Thrown if the folder with pathname specified by the
      /// <paramref
      ///    name="rootFolderPath" />
      /// does not exist.
      /// </exception>
      /// <exception cref="T:System.IO.IOException">
      /// Thrown if a file operation does not succeed.
      /// </exception>
      public void ReplaceTextInFiles(string rootFolderPath, string findWhat,
         string replaceWith = "")
      {
         if (string.IsNullOrWhiteSpace(rootFolderPath))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(rootFolderPath)
            );
         if (!Directory.Exists(rootFolderPath))
            throw new DirectoryNotFoundException(
               $"The specified folder, with pathname '{rootFolderPath}', could not be located on the disk."
            );
         if (string.IsNullOrWhiteSpace(findWhat))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(findWhat)
            );

         var filenames = Directory
            .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
            .Where(file => !FilePathValidator.ShouldSkipFile(file)).ToList();

         OnFilesToHaveTextReplacedCounted(
            new FilesCountedEventArgs(
               filenames.Count, OperationType.ReplaceTextInFiles
            )
         );

         foreach (var filename in filenames)
         {
            OnProcessingOperation(
               new ProcessingOperationEventArgs(
                  filename, OperationType.ReplaceTextInFiles
               )
            );

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
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.FilesToBeRenamedCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" /> that
      /// contains the event data.
      /// </param>
      private void OnFilesToBeRenamedCounted(FilesCountedEventArgs e)
         => FilesToBeRenamedCounted?.Invoke(this, e);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.FilesToHaveTextReplacedCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" /> that
      /// contains the event data.
      /// </param>
      private void OnFilesToHaveTextReplacedCounted(FilesCountedEventArgs e)
         => FilesToHaveTextReplacedCounted?.Invoke(this, e);

      /// <summary>
      /// Raises the <see cref="E:MassFileRenamer.Objects.ProcessingOperation" /> event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
      /// that contains the event data.
      /// </param>
      private void OnProcessingOperation(ProcessingOperationEventArgs e)
         => ProcessingOperation?.Invoke(this, e);
   }
}