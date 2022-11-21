using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Factories;
using MFR.CommandLine.Parsers.Interfaces;
using MFR.CommandLine.Translators;
using MFR.CommandLine.Validators.Events;
using MFR.CommandLine.Validators.Factories;
using MFR.CommandLine.Validators.Interfaces;
using MFR.Common;
using MFR.Directories.Validators.Events;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.GUI.Displayers;
using MFR.GUI.Windows;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </summary>
        public static ICommandLineInfo CommandLineInfo
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" />
        /// interface.
        /// </summary>
        private static ICommandLineParser CommandLineParser
            => GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets or sets a value that indicates whether the user specified any arguments on
        /// this application's command line at startup or not.
        /// </summary>
        public static bool CommandLineSpecified
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
        /// interface.
        /// </summary>
        private static ICommandLineValidator CommandLineValidator
            => GetCommandLineValidator.SoleInstance();

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the actions
        /// associated with it.
        /// </remarks>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
            => GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryValidator RootDirectoryValidator
            => GetRootDirectoryValidator.SoleInstance();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">
        /// (Optional.) Array of strings, each of which represents a different
        /// command-line argument passed to this application.
        /// </param>
        [STAThread]
        public static void Main(string[] args)
        {
            SetDisplayParameters();

            SetUpLogging();

            Register.WindowsMessageFilter();

            SetUpExceptionHandling();

            SetUpCommandLineValidation();

            // Load the configuration from the disk.
            ProfileProvider.Load();

            ConfigurationProvider.Load();

            ParseCommandLine(args);

            ProcessCommandLine();

            // Save changes in the configuration back out to the disk.
            // Also writes the path to the config file to the Registry.
            //
            // NOTE: Do NOT save the configuration settings in the event
            // that the user is running this app from the command line.
            // Ditto for profiles.
            ConfigurationProvider.Save();

            ProfileProvider.Save();

            Revoke.WindowsMessageFilter();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid" />
        /// event raised by the command-line validator object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by showing an error message to the user.
        /// </remarks>
        private static void OnCommandLineInfoInvalid(object sender,
            CommandLineInfoInvalidEventArgs e)
            => ShowValidationFailureMessage(e.Message);

        /// <summary>
        /// Handles the
        /// <see cref="E:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser.DisplayHelp" />
        /// event raised by the command-line parser.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>This meethod shows a message box and then quits the application.</remarks>
        private static void OnCommandLineParserDisplayHelp(object sender,
            DisplayHelpEventArgs e)
        {
            MessageBox.Show(
                e.HelpText, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
            );

            Environment.Exit(-1);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid" />
        /// event raised by the root-directory validator object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by showing an error message to the user.
        /// </remarks>
        private static void OnRootDirectoryInvalid(object sender,
            RootDirectoryInvalidEventArgs e)
            => ShowValidationFailureMessage(e.Message);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.Application.ThreadException" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// The sender of this event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.Threading.ThreadExceptionEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// The event that this handler responds to typically is raised by the
        /// application when an exception is thrown but goes unhandled by a
        /// try/catch block that is not there in the code
        /// <para />
        /// This handler responds to the event by writing the exception
        /// information to the log file and then by displaying a user-friendly
        /// error dialog box.
        /// <para />
        /// From the dialog box thus displayed, the user can click a button to
        /// open a Notepad window displaying the exception's type name, message,
        /// and stack trace.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnThreadException(object sender,
            ThreadExceptionEventArgs e)
        {
            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);

            // and which allows the user to choose to send an error report.
            Display.ErrorReportDialog(e.Exception);
        }

        /// <summary>
        /// Initializes a new instance of
        /// <see
        ///     cref="T:MFR.CommandLine.CommandLineInfo" />
        /// from the
        /// arguments passed by the user on the command line, and initializes
        /// the <see cref="P:MFR.GUI.Program.CommandLineInfo" /> property with a
        /// reference to it.
        /// </summary>
        /// <param name="args">
        /// (Optional.) Array of strings, each of which represents a different
        /// command-line argument passed to this application.
        /// </param>
        /// <remarks>
        /// This method also runs validation rules on the command-line parameters.
        /// <para />
        /// If any validation failures occur, then the app is terminated.
        /// </remarks>
        private static void ParseCommandLine(string[] args)
        {
            CommandLineSpecified = args.Any();

            if (!args.Any())
                return; // This app can be launched with no command-line arguments.

            CommandLineParser.DisplayHelp += OnCommandLineParserDisplayHelp;
            CommandLineInfo = CommandLineParser.Parse(args);

            if (!CommandLineValidator.Validate(CommandLineInfo))
                Environment.Exit(-1); // kill this app
        }

        /// <summary>
        /// Takes actions based on what arguments were passed to the application.
        /// </summary>
        private static void ProcessCommandLine()
        {
            /*
             * If the user specified one or more argument(s) on the command line of this
             * application, translate those parameters into configuration settings for this
             * run.
             */

            if (CommandLineSpecified)
            {
                /*
                 * If we are here, then the user specified arguments on the command line.
                 * If Auto-Start was requested, translate the entirety of the command-line
                 * arguments into the current configuration, overwriting whatever was read in
                 * from the configuration file on the disk.
                 *
                 * If Auto-Start mode is not requested, then simply overwrite the Starting
                 * Folder setting in the loaded configuration with the Starting Folder that
                 * is supplied on the command line.
                 */

                if (AutoStart)
                    ConfigurationProvider.CurrentConfiguration =
                        CommandLineInfo.ToConfiguration();
                else
                    ConfigurationProvider.CurrentConfiguration.StartingFolder =
                        CommandLineInfo.StartingFolder;
            }
                

            Application.Run(MainWindow.Instance);
        }

        /// <summary>
        /// Gets a value indicating whether the application should automatically process operations requested by the user from the command line.
        /// </summary>
        private static bool AutoStart
            => CommandLineInfo.AutoStart;

        /// <summary>
        /// Configures the display settings, such as DPI-awareness and visual
        /// styles etc.
        /// </summary>
        private static void SetDisplayParameters()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        /// <summary>
        /// Configures the application's handling of validation failures of the
        /// command-line parameters.
        /// </summary>
        private static void SetUpCommandLineValidation()
        {
            CommandLineValidator.CommandLineInfoInvalid +=
                OnCommandLineInfoInvalid;
            RootDirectoryValidator.RootDirectoryInvalid +=
                OnRootDirectoryInvalid;
        }

        /// <summary>
        /// Configures the application's handling of exceptions that are not
        /// caught elsewhere.
        /// </summary>
        private static void SetUpExceptionHandling()
        {
            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );
            Application.ThreadException += OnThreadException;
        }

        /// <summary>
        /// Configures the logging infrastructure.
        /// </summary>
        private static void SetUpLogging()
            => LogFileManager.InitializeLogging(
                true, infrastructureType: LoggingInfrastructureType.PostSharp
            );

        /// <summary>
        /// Shows the error <paramref name="message" /> to the user.
        /// </summary>
        /// <param name="message">
        /// (Required.) String containing the message to be displayed.
        /// </param>
        /// <remarks>
        /// If the string value in <paramref name="message" /> is blank, then
        /// this method does nothing.
        /// </remarks>
        private static void ShowValidationFailureMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            MessageBox.Show(
                message, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
            );
        }
    }
}