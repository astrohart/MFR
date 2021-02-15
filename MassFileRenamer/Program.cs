using MassFileRenamer.Objects;
using System;

namespace MassFileRenamer
{
   /// <summary>
   /// Provides the application-level functionality.
   /// </summary>
   public static class Program
   {
       /// <summary>
      /// Application entry point.
      /// </summary>
      public static void Main()
      {
         try
         {
            const string rootDir =
               @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor";

            var renamer = new FileRenamer(rootDir);

            renamer.FilesToHaveTextReplacedCounted +=
               OnFilesToHaveTextReplacedCounted;
            renamer.ProcessingOperation += OnFileRenamerProcessingOperation;
            renamer.StatusUpdate += OnFileRenamerStatusUpdated;

            renamer.ProcessAll(
               @"MassFileRenamer",
               @"PortfolioMonitor.Products"
            );
            Console.ReadKey();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
         }
      }

      private static void OnFileRenamerProcessingOperation(object sender,
         ProcessingOperationEventArgs e)
      {
         switch (e.OperationType)
         {
            case OperationType.ReplaceTextInFiles:
               Console.WriteLine(
                  $"Replace Text in Files: Processing '{e.Pathname}'..."
               );
               break;

            case OperationType.RenameFilesInFolder:
               Console.WriteLine($"Rename Files: Processing '{e.Pathname}'...");
               break;

            case OperationType.RenameSubFolders:
               Console.WriteLine(
                  $"Rename Subfolders: Processing '{e.Pathname}'..."
               );
               break;
         }
      }

      private static void OnFileRenamerStatusUpdated(object sender,
         StatusUpdateEventArgs e)
      {
         Console.WriteLine(e.Text);
      }

      private static void OnFilesToHaveTextReplacedCounted(object sender,
         FilesOrFoldersCountedEventArgs e)
      {
         switch (e.OperationType)
         {
            case OperationType.ReplaceTextInFiles:
               Console.WriteLine(
                  $"Replace Text in Files: {e.Count} files are to be processed."
               );
               break;

            case OperationType.RenameFilesInFolder:
               Console.WriteLine(
                  $"Rename Files: {e.Count} files are to be processed."
               );
               break;

            case OperationType.RenameSubFolders:
               Console.WriteLine(
                  $"Rename Subfolders: {e.Count} folders are to be processed."
               );
               break;
         }
      }
   }
}