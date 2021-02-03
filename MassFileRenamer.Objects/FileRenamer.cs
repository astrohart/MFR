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
      public FileRenamer()
      {
         RootDirectoryPath = string.Empty;
      }

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
      public event FilesOrFoldersCountedEventHandler FilesToBeRenamedCounted;

      /// <summary>
      /// Occurs when files to be processed have been counted.
      /// </summary>
      public event FilesOrFoldersCountedEventHandler
         FilesToHaveTextReplacedCounted;

      /// <summary>
      /// Occurs when an operation has completed.
      /// </summary>
      public event OperationFinishedEventHandler OperationFinished;

      /// <summary>
      /// Occurs when an operation is about to be processed for a file or a folder.
      /// </summary>
      public event ProcessingOperationEventHandler ProcessingOperation;

      /// <summary>
      /// Occurs when a textual status message is available for display.
      /// </summary>
      public event StatusUpdateEventHandler StatusUpdate;

      /// <summary>
      /// Occurs when subfolders to be renamed have been counted.
      /// </summary>
      public event FilesOrFoldersCountedEventHandler
         SubfoldersToBeRenamedCounted;

      /// <summary>
      /// Gets a string containing the full pathname of the folder where all
      /// operations start.
      /// </summary>
      public string RootDirectoryPath { get; private set; }

      /// <summary>
      /// Executes the Rename Subfolders, Rename Files, and Replace Text in
      /// Files operation on all the folders and files in the root folder with
      /// the pathname stored in the
      /// <see
      ///    cref="P:MassFileRenamer.Objects.FileRenamer.RootDirectoryPath" />
      /// property.
      /// </summary>
      /// <param name="findWhat">
      /// (Required.) String containing the text to search for.
      /// </param>
      /// <param name="replaceWith">
      /// (Required.) String containing the text to replace the text specified
      /// by <paramref name="findWhat" /> with.
      /// </param>
      /// <param name="pathFilter">
      /// (Optional.) If specified, a delegate that accepts as its sole
      /// parameter a string containing the pathname to the item currently being
      /// processed, and that returns a Boolean value. If the value returned is
      /// <c>true</c>, the item with the pathname matching that of the input is
      /// included in the operations; <c>false</c> means the item is excluded.
      /// </param>
      public void ProcessAll(string findWhat, string replaceWith,
         Func<string, bool> pathFilter = null)
      {
         if (string.IsNullOrWhiteSpace(RootDirectoryPath))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(RootDirectoryPath)
            );
         if (string.IsNullOrWhiteSpace(findWhat))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(findWhat)
            );
         if (string.IsNullOrWhiteSpace(replaceWith))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(replaceWith)
            );

         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"Attempting to rename subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
            )
         );

         RenameSubFoldersOf(
            RootDirectoryPath, findWhat, replaceWith, pathFilter
         );

         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"*** Finished processing subfolders of '{RootDirectoryPath}'."
            )
         );
         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"Renaming files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
            )
         );

         RenameFilesInFolder(
            RootDirectoryPath, findWhat, replaceWith, pathFilter
         );

         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"*** Finished renaming files in subfolders of '{RootDirectoryPath}'."
            )
         );

         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"Replacing text in files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
            )
         );

         ReplaceTextInFiles(
            RootDirectoryPath, findWhat, replaceWith, pathFilter
         );

         OnStatusUpdate(
            new StatusUpdateEventArgs(
               $"*** Finished replacing text in files contained inside subfolders of '{RootDirectoryPath}'."
            )
         );
      }

      /// <summary>
      /// Renames all the files in the all the subfolders etc., recursively, of
      /// the folder whose pathname is specified by the
      /// <paramref
      ///    name="rootFolderPath" />
      /// parameter.
      /// </summary>
      /// <param name="rootFolderPath">
      /// (Required.) String containing the full pathname of an existing
      /// directory on the computer that is to be where the operation is started.
      /// </param>
      /// <param name="findWhat">
      /// (Required.) String containing the text to search for.
      /// </param>
      /// <param name="replaceWith">
      /// (Required.) String containing the text to replace the text specified
      /// by <paramref name="findWhat" /> with.
      /// </param>
      /// <param name="pathFilter">
      /// (Optional.) If specified, a delegate that accepts as its sole
      /// parameter a string containing the pathname to the item currently being
      /// processed, and that returns a Boolean value. If the value returned is
      /// <c>true</c>, the item with the pathname matching that of the input is
      /// included in the operations; <c>false</c> means the item is excluded.
      /// </param>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if either the <paramref name="rootFolderPath" />,
      /// <paramref
      ///    name="findWhat" />
      /// , or <paramref name="replaceWith" /> parameters are blank.
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
      public void RenameFilesInFolder(string rootFolderPath, string findWhat,
         string replaceWith, Func<string, bool> pathFilter = null)
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
         if (string.IsNullOrWhiteSpace(replaceWith))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(replaceWith)
            );

         var filenames = Directory
            .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
            .Where(file => !FilePathValidator.ShouldSkipFile(file))
            .Where(filename => filename.Contains(findWhat)).ToList();

         OnFilesToBeRenamedCounted(
            new FilesOrFoldersCountedEventArgs(
               filenames.Count, OperationType.RenameFiles
            )
         );

         foreach (var filename in filenames.Where(
            filename => pathFilter == null || pathFilter(filename)
         ))
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

         OnOperationFinished(
            new OperationFinishedEventArgs(OperationType.RenameFiles)
         );
      }

      /// <summary>
      /// Recursively renames all the subfolders in the folder having a pathname
      /// specified by <paramref name="rootFolderPath" />, replacing any
      /// occurrences of the text in the <paramref name="findWhat" /> parameter
      /// with the values in the <paramref name="replaceWith" /> parameter.
      /// </summary>
      /// <param name="rootFolderPath">
      /// (Required.) String containing the full pathname of an existing
      /// directory on the computer that is to be where the operation is started.
      /// </param>
      /// <param name="findWhat">
      /// (Required.) String containing the text to search for.
      /// </param>
      /// <param name="replaceWith">
      /// (Required.) String containing the text to replace the text specified
      /// by <paramref name="findWhat" /> with.
      /// </param>
      /// <param name="pathFilter">
      /// (Optional.) If specified, a delegate that accepts as its sole
      /// parameter a string containing the pathname to the item currently being
      /// processed, and that returns a Boolean value. If the value returned is
      /// <c>true</c>, the item with the pathname matching that of the input is
      /// included in the operations; <c>false</c> means the item is excluded.
      /// </param>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if either the <paramref name="rootFolderPath" />,
      /// <paramref
      ///    name="findWhat" />
      /// , or <paramref name="replaceWith" /> parameters are blank.
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
      public void RenameSubFoldersOf(string rootFolderPath, string findWhat,
         string replaceWith, Func<string, bool> pathFilter = null)
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
         if (string.IsNullOrWhiteSpace(replaceWith))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(replaceWith)
            );

         var subFolders = Directory.GetDirectories(
            rootFolderPath, "*", SearchOption.AllDirectories
         ).Where(dir => !FolderPathValidator.ShouldSkipFolder(dir)).ToList();

         OnSubfoldersToBeRenamedCounted(
            new FilesOrFoldersCountedEventArgs(
               subFolders.Count, OperationType.RenameSubFolders
            )
         );

         foreach (var dirInfo in subFolders
            .Where(
               subFolderName => pathFilter == null || pathFilter(subFolderName)
            ).Select(DirectoryInfoFactory.Make).Where(
               dirInfo => dirInfo != null && dirInfo.Name.Contains(findWhat)
            ))
         {
            OnProcessingOperation(
               new ProcessingOperationEventArgs(
                  dirInfo.FullName, OperationType.RenameSubFolders
               )
            );

            dirInfo.RenameTo(
               Path.Combine(
                  dirInfo.Parent.FullName,
                  dirInfo.Name.Replace(findWhat, replaceWith)
               )
            );
         }

         OnOperationFinished(
            new OperationFinishedEventArgs(OperationType.RenameSubFolders)
         );
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
      /// <param name="pathFilter">
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
         string replaceWith = "", Func<string, bool> pathFilter = null)
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
            new FilesOrFoldersCountedEventArgs(
               filenames.Count, OperationType.ReplaceTextInFiles
            )
         );

         foreach (var filename in filenames.Where(
            filename => pathFilter == null || pathFilter(filename)
         ))
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

         OnOperationFinished(
            new OperationFinishedEventArgs(OperationType.ReplaceTextInFiles)
         );
      }

      /// <summary>
      /// Executes the Rename Subfolders, Rename Files, and Replace Text in
      /// Files operation on all the folders and files in the root folder with
      /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
      /// </summary>
      /// <param name="rootDirectoryPath">
      /// Path to the recursion root.
      /// </param>
      /// <param name="findWhat">
      /// (Required.) String containing the text to search for.
      /// </param>
      /// <param name="replaceWith">
      /// (Required.) String containing the text to replace the text specified
      /// by <paramref name="findWhat" /> with.
      /// </param>
      /// <param name="pathFilter">
      /// (Optional.) If specified, a delegate that accepts as its sole
      /// parameter a string containing the pathname to the item currently being
      /// processed, and that returns a Boolean value. If the value returned is
      /// <c>true</c>, the item with the pathname matching that of the input is
      /// included in the operations; <c>false</c> means the item is excluded.
      /// </param>
      public void ProcessAll(string rootDirectoryPath, string findWhat,
         string replaceWith, Func<string, bool> pathFilter = null)
      {
         if (string.IsNullOrWhiteSpace(rootDirectoryPath))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(rootDirectoryPath)
            );

         RootDirectoryPath = rootDirectoryPath;

         ProcessAll(findWhat, replaceWith, pathFilter);
      }

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.FilesToBeRenamedCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
      /// that
      /// contains the event data.
      /// </param>
      private void OnFilesToBeRenamedCounted(FilesOrFoldersCountedEventArgs e)
         => FilesToBeRenamedCounted?.Invoke(this, e);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.FilesToHaveTextReplacedCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
      /// that
      /// contains the event data.
      /// </param>
      private void OnFilesToHaveTextReplacedCounted(
         FilesOrFoldersCountedEventArgs e)
         => FilesToHaveTextReplacedCounted?.Invoke(this, e);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.OperationFinished" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// An <see cref="T:MassFileRenamer.Objects.OperationFinishedEventArgs" />
      /// that contains the event data.
      /// </param>
      private void OnOperationFinished(OperationFinishedEventArgs e)
         => OperationFinished?.Invoke(this, e);

      /// <summary>
      /// Raises the <see cref="E:MassFileRenamer.Objects.ProcessingOperation" /> event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
      /// that contains the event data.
      /// </param>
      private void OnProcessingOperation(ProcessingOperationEventArgs e)
         => ProcessingOperation?.Invoke(this, e);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.StatusUpdate" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.StatusUpdateEventArgs" /> that
      /// contains the event data.
      /// </param>
      private void OnStatusUpdate(StatusUpdateEventArgs e)
         => StatusUpdate?.Invoke(this, e);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FileRenamer.SubfoldersToBeRenamedCounted" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
      /// that
      /// contains the event data.
      /// </param>
      private void OnSubfoldersToBeRenamedCounted(
         FilesOrFoldersCountedEventArgs e)
         => SubfoldersToBeRenamedCounted?.Invoke(this, e);
   }
}