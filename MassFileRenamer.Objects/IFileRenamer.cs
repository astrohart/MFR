namespace MassFileRenamer.Objects
{
   public interface IFileRenamer
   {
      string RootDirectoryPath { get; }

      /// <summary>
      /// Occurs when files to be renamed have been counted.
      /// </summary>
      event FilesOrFoldersCountedEventHandler FilesToBeRenamedCounted;

      /// <summary>
      /// Occurs when files to have text replaced in them have been counted.
      /// </summary>
      event FilesOrFoldersCountedEventHandler FilesToHaveTextReplacedCounted;

      /// <summary>
      /// Occurs when an operation is about to be processed for a file or a folder.
      /// </summary>
      event ProcessingOperationEventHandler ProcessingOperation;

      /// <summary>
      /// Occurs when a textual status message is available for display.
      /// </summary>
      event StatusUpdateEventHandler StatusUpdate;

      void ProcessAll(string findWhat, string replaceWith);

      void RenameFilesInFolder(string rootFolderPath, string findWhat,
         string replaceWith);

      void RenameSubFoldersOf(string rootFolderPath, string findWhat,
         string replaceWith);

      void ReplaceTextInFiles(string rootFolderPath, string findWhat,
         string replaceWith);
   }
}