namespace MassFileRenamer.Objects
{
   public interface IFileRenamer
   {
      string RootDirectoryPath { get; }

      /// <summary>
      /// Occurs when files to be processed have been counted.
      /// </summary>
      event FilesCountedEventHandler FilesToHaveTextReplacedCounted;

      /// <summary>
      /// Occurs when an operation is about to be processed for a file or a folder.
      /// </summary>
      event ProcessingOperationEventHandler ProcessingOperation;

      void ProcessAll(string findWhat, string replaceWith);

      void RenameFilesInFolder(string rootFolderPath, string findWhat,
         string replaceWith);

      void RenameSubFoldersOf(string rootFolderPath, string findWhat,
         string replaceWith);

      void ReplaceTextInFiles(string rootFolderPath, string findWhat,
         string replaceWith);
   }
}