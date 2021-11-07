using MFR.Common;
using MFR.Events;
using MFR.Events.Common;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Renamers.Files;
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
        [STAThread]
        public static void Main()
        {
            try
            {
                Register.WindowsMessageFilter();

                const string rootDir =
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor";

                var renamer = new FileRenamer(rootDir);

                renamer.FilesToHaveTextReplacedCounted +=
                    OnFilesToHaveTextReplacedCounted;
                renamer.ProcessingOperation += OnFileRenamerProcessingOperation;
                renamer.StatusUpdate += OnFileRenamerStatusUpdated;

                renamer.ProcessAll(
                    @"MassFileRenamer", @"PortfolioMonitor.Products"
                );

                Revoke.WindowsMessageFilter();

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
                    System.Console.WriteLine(
                        $"Rename Files: Processing '{e.Entry}'..."
                    );
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
            => System.Console.WriteLine(e.Text);

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