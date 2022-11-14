using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Factories;
using MFR.CommandLine.Parsers.Interfaces;
using MFR.Common;
using MFR.Events;
using MFR.Events.Common;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Renamers.Files.Factories;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using System;

namespace MFR.Console
{
    /// <summary>
    /// Provides the application-level functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" />
        /// interface.
        /// </summary>
        private static ICommandLineParser CommandLineParser
            => GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface.
        /// </summary>
        private static IConfiguration Configuration
            => ConfigurationProvider.Configuration;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        private static IFileRenamer FileRenamer
            => GetFileRenamer.SoleInstance();

        /// <summary>
        /// Application entry point.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                Register.WindowsMessageFilter();

                CommandLineParser.DisplayHelp += OnDisplayHelp;

                ConfigurationProvider.Load();

                FileRenamer.UpdateConfiguration(Configuration);

                FileRenamer.StartingFrom(Configuration.StartingFolder)
                           .AndAttachConfiguration(Configuration);

                FileRenamer.FilesToHaveTextReplacedCounted +=
                    OnFilesToHaveTextReplacedCounted;
                FileRenamer.ProcessingOperation +=
                    OnFileRenamerProcessingOperation;
                FileRenamer.StatusUpdate += OnFileRenamerStatusUpdated;

                FileRenamer.ProcessAll(
                    Configuration.FindWhat, Configuration.ReplaceWith
                );

                ConfigurationProvider.Save();

                Revoke.WindowsMessageFilter();

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }

        private static void OnDisplayHelp(object sender, DisplayHelpEventArgs e)
        {

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