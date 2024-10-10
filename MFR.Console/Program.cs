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
using xyLOGIX.Core.Debug;

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
        {
            get;
        } = GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This property has a getter and a setter, so that we can initialize it from the
        /// command line.
        /// </remarks>
        private static IProjectFileRenamerConfig CurrentConfiguration
        {
            get => ConfigProvider.CurrentConfiguration;
            set => ConfigProvider.CurrentConfiguration = value;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        private static IFileRenamer FileRenamer
        {
            get;
        } = GetFileRenamer.SoleInstance();

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

                ConfigProvider.Load();

                ParseCommandLine(args);

                FileRenamer.UpdateConfiguration(CurrentConfiguration);

                FileRenamer.StartingFrom(CurrentConfiguration.StartingFolder)
                           .AndAttachConfiguration(CurrentConfiguration);

                FileRenamer.FilesToHaveTextReplacedCounted +=
                    OnFilesToHaveTextReplacedCounted;
                FileRenamer.ProcessingOperation +=
                    OnFileRenamerProcessingOperation;
                FileRenamer.StatusUpdate += OnFileRenamerStatusUpdated;

                FileRenamer.ProcessAll(
                    CurrentConfiguration.FindWhat,
                    CurrentConfiguration.ReplaceWith
                );

                ConfigProvider.Save();

                Revoke.WindowsMessageFilter();

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }

        private static void OnDisplayHelp(object sender, DisplayHelpEventArgs e)
            => System.Console.Write(e.HelpText);

        private static void OnFileRenamerProcessingOperation(
            object sender,
            ProcessingOperationEventArgs e
        )
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

        private static void OnFileRenamerStatusUpdated(
            object sender,
            StatusUpdateEventArgs e
        )
            => System.Console.WriteLine(e.Text);

        private static void OnFilesToHaveTextReplacedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
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

        private static void ParseCommandLine(string[] args)
        {
            try
            {
                if (args == null) return;
                if (args.Length == 0) return;

                var cmdInfo = CommandLineParser.Parse(args);

                if (cmdInfo.AutoStart !=
                    CurrentConfiguration.AutoStart)
                    CurrentConfiguration.AutoStart = cmdInfo.AutoStart;
                if (!string.IsNullOrWhiteSpace(cmdInfo.FindWhat) &&
                    !cmdInfo.FindWhat.Equals(CurrentConfiguration.FindWhat))
                    CurrentConfiguration.FindWhat = cmdInfo.FindWhat;
                if (cmdInfo.MatchCase.HasValue && cmdInfo.MatchCase !=
                    CurrentConfiguration.MatchCase)
                    CurrentConfiguration.MatchCase = (bool)cmdInfo.MatchCase;
                if (cmdInfo.MatchExactWord.HasValue && cmdInfo.MatchExactWord !=
                    CurrentConfiguration.MatchExactWord)
                    CurrentConfiguration.MatchExactWord =
                        (bool)cmdInfo.MatchExactWord;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}