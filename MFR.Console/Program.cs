using MFR.Objects;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Operations.Events;
using System;

namespace MFR.Console
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
                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }

        private static void OnFileRenamerProcessingOperation(object sender,
           ProcessingOperationEventArgs e)
        {
            switch (e.OperationType)
            {
                case OperationType.ReplaceTextInFiles:
                    System.Console.WriteLine(
                       $"Replace Text in Files: Processing '{e.Entry}'..."
                    );
                    break;

                case OperationType.RenameFilesInFolder:
                    System.Console.WriteLine($"Rename Files: Processing '{e.Entry}'...");
                    break;

                case OperationType.RenameSubFolders:
                    System.Console.WriteLine(
                       $"Rename Subfolders: Processing '{e.Entry}'..."
                    );
                    break;
            }
        }

        private static void OnFileRenamerStatusUpdated(object sender,
           StatusUpdateEventArgs e)
        {
            System.Console.WriteLine(e.Text);
        }

        private static void OnFilesToHaveTextReplacedCounted(object sender,
           FilesOrFoldersCountedEventArgs e)
        {
            switch (e.OperationType)
            {
                case OperationType.ReplaceTextInFiles:
                    System.Console.WriteLine(
                       $"Replace Text in Files: {e.Count} files are to be processed."
                    );
                    break;

                case OperationType.RenameFilesInFolder:
                    System.Console.WriteLine(
                       $"Rename Files: {e.Count} files are to be processed."
                    );
                    break;

                case OperationType.RenameSubFolders:
                    System.Console.WriteLine(
                       $"Rename Subfolders: {e.Count} folders are to be processed."
                    );
                    break;
            }
        }
    }
}