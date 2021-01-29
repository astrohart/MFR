using MassFileRenamer.Objects;
using System;

namespace MassFileRenamer
{
   public static class Program
   {
      public static void Main()
      {
         try
         {
            const string rootDir =
               @"C:\Users\Administrator\source\repos\astrohart\Nomics.Api";

            var renamer = new FileRenamer(rootDir);

            renamer.FilesCounted += OnFileRenamerCountedFiles;
            renamer.ProcessingOperation += OnFileRenamerProcessingOperation;

            renamer.ProcessAll(
               "Nomics.Api.Endpoints.Params",
               "Nomics.Api.Endpoints.Requests.Params.Currencies"
            );
            Console.ReadKey();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
         }
      }

      private static void OnFileRenamerCountedFiles(object sender,
         FilesCountedEventArgs e)
      {
         switch (e.OperationType)
         {
            case OperationType.ReplaceTextInFiles:
               Console.WriteLine(
                  $"Replace Text in Files: {e.Count} files are to be processed."
               );
               break;

            case OperationType.RenameFiles:
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

            case OperationType.RenameFiles:
               Console.WriteLine($"Rename Files: Processing '{e.Pathname}'...");
               break;

            case OperationType.RenameSubFolders:
               Console.WriteLine(
                  $"Rename Subfolders: Processing '{e.Pathname}'..."
               );
               break;
         }
      }
   }
}