using MFR.GUI.Launchers.Dialogs;
using MFR.GUI.Windows;
using MFR.Objects.CommandLine;
using MFR.Objects.CommandLine.Constants;
using MFR.Objects.CommandLine.Validators.Events;
using MFR.Objects.CommandLine.Validators.Factories;
using MFR.Objects.Configuration.Providers;
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
        /// Gets a reference to an instance of a
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.CommandLineInfo" />
        /// object that is
        /// initialized with the values specified (if any) by the user on this
        /// application's command line.
        /// </summary>
        public static CommandLineInfo CommandLineInfo
        {
            get;
            private set;
        }

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

            SetUpExceptionHandling();

            SetUpLogging();

            SetUpCommandLineValidation();

            // Load the configuration from the disk.
            ConfigurationProvider.Load();

            ParseCommandLine(args);

            ProcessCommandLine();

            // Save changes in the configuration back out to the disk.
            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid" />
        /// event raised by the command-line validator object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
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
        /// <see
        ///     cref="E:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid" />
        /// event raised by the root-directory validator object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
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

            ErrorDialogLauncher.Display(Application.OpenForms[0], e.Exception);
        }

        /// <summary>
        /// Initializes a new instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.CommandLineInfo" />
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
            CommandLineInfo = !args.Any()
                ? new CommandLineInfo()
                : CommandLineInfo.ParseCommandLine(args);

            if (!GetCommandLineValidator.SoleInstance()
                                        .IsValid(CommandLineInfo))
                Environment.Exit(-1); // kill this app
        }

        /// <summary>
        /// Takes actions based on what arguments were passed to the application.
        /// </summary>
        private static void ProcessCommandLine()
        {
            // Set the starting folder in the configuration (unless the user did
            // not pass anything on the command line, in which case the value
            // from the user will be the default value of My Documents) to that
            // which the user has specified on the command line.
            if (!Directories.MyDocuments.Equals(
                CommandLineInfo.RootDirectory
            )) // we do not need any more checks here due to the command-line validation that occurs
                ConfigurationProvider.Configuration.StartingFolder =
                    CommandLineInfo.RootDirectory;

            Application.Run(MainWindow.Instance);
        }

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
            GetCommandLineValidator.SoleInstance()
                                   .CommandLineInfoInvalid +=
                OnCommandLineInfoInvalid;
            GetRootDirectoryValidator.SoleInstance()
                                     .RootDirectoryInvalid +=
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