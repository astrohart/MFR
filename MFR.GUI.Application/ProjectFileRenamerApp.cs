using MFR.CommandLine.Models.Factories;
using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Factories;
using MFR.CommandLine.Parsers.Interfaces;
using MFR.CommandLine.Validators.Events;
using MFR.CommandLine.Validators.Factories;
using MFR.CommandLine.Validators.Interfaces;
using MFR.Directories.Validators.Events;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.GUI.Actions;
using MFR.GUI.Application.Interfaces;
using MFR.GUI.Displayers;
using MFR.GUI.Processors.Factories;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;

namespace MFR.GUI.Application
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public class ProjectFileRenamerApp : IWinApp
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProjectFileRenamerApp() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProjectFileRenamerApp() { }

        /// <summary>
        /// A <see cref="T:System.Guid" /> that uniquely identifies this product.
        /// </summary>
        public Guid AppId
        {
            get;
        } = new Guid("ce26f41b-78f8-4093-ab60-91fbb069c70b");

        /// <summary>
        /// Gets a value indicating whether the application should automatically process
        /// operations requested by the user from the command line.
        /// </summary>
        public bool AutoStart
            => CommandLineInfo.AutoStart;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </summary>
        public ICommandLineInfo CommandLineInfo
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
        {
            get;
        } = GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets or sets a value that indicates whether the user specified any arguments on
        /// this application's command line at startup or not.
        /// </summary>
        public bool CommandLineSpecified
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
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Application.ProjectFileRenamerApp" />.
        /// </summary>
        public static IWinApp Instance
        {
            get;
        } = new ProjectFileRenamerApp();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
        {
            get;
        } = GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryPathValidator RootDirectoryPathValidator
        {
            get;
        } = GetRootDirectoryPathValidator.SoleInstance();

        /// <summary>
        /// Occurs when the application has been initialized, but has not yet processed the
        /// command line.
        /// </summary>
        public event EventHandler Initialized;

        /// <summary>
        /// Called to instruct the application to begin processing.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" />
        /// values, each of which corresponds to a value that was passed by the user on the
        /// application's command line.
        /// </param>
        public void WinInit(string[] args)
        {
            if (!InitApplication(args))
                Environment.Exit(-1);

            OnInitialized();

            ProcessCommandLine();

            ExitApplication();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Application.ProjectFileRenamerApp.Initialized" /> event.
        /// </summary>
        protected virtual void OnInitialized()
            => Initialized?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Performs operations that should be undertaken when the application exits.
        /// </summary>
        private static void ExitApplication()
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ExitApplication: Preparing to terminate the application..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ExitApplication: Attempting to save the user configuration settings..."
                );

                ConfigProvider.Save();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ExitApplication: *** SUCCESS *** User configuration settings have been SAVED.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ExitApplication: Attempting to save the configured profile(s)..."
                );

                ProfileProvider.Save();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ExitApplication: *** SUCCESS *** Configured profile(s) have been SAVED.  Proceeding..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Determines whether the app was auto-started.  It does this by scanning the
        /// command-line arguments.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" />
        /// values, each of which corresponds to a value that was passed by the user on the
        /// application's command line.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the application was auto-started;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If one of the arguments is <c>--autoStart</c>, then the app was auto-started;
        /// otherwise, it was not.
        /// </remarks>
        private static bool IsAutoStarted(IEnumerable<string> args)
            => args.Any(arg => "--autoStart".EqualsNoCase(arg));

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
        private static void OnCommandLineInfoInvalid(
            object sender,
            CommandLineInfoInvalidEventArgs e
        )
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
        /// <remarks>This method shows a message box and then quits the application.</remarks>
        private static void OnCommandLineParserDisplayHelp(
            object sender,
            DisplayHelpEventArgs e
        )
        {
            MessageBox.Show(
                e.HelpText, System.Windows.Forms.Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );

            Environment.Exit(-1);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid" />
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
        private static void OnRootDirectoryInvalid(
            object sender,
            RootDirectoryInvalidEventArgs e
        )
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
        private static void OnThreadException(
            object sender,
            ThreadExceptionEventArgs e
        )
        {
            try
            {
                // dump all the exception info to the log
                DebugUtils.LogException(e.Exception);

                // and which allows the user to choose to send an error report.
                Display.ErrorReportDialog(e.Exception);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Configures the display settings, such as DPI-awareness and visual
        /// styles etc.
        /// </summary>
        private static void SetDisplayParameters()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(
                false
            );
        }

        /// <summary>
        /// Configures the application's handling of exceptions that are not
        /// caught elsewhere.
        /// </summary>
        private static void SetUpExceptionHandling()
        {
            System.Windows.Forms.Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );
            System.Windows.Forms.Application.ThreadException +=
                OnThreadException;
        }

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
        private static void ShowValidationFailureMessage(
            [NotLogged] string message
        )
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            MessageBox.Show(
                message, System.Windows.Forms.Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
            );
        }

        /// <summary>
        /// Called to perform a one-time initialization of the application.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" />
        /// values, each of which corresponds to a value that was passed by the user on the
        /// application's command line.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the application was initialized
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        private bool InitApplication(string[] args)
        {
            var result = false;

            try
            {
                SetDisplayParameters();

                SetUpExceptionHandling();

                SetUpCommandLineValidation();

                // Load the config from the file system.
                ProfileProvider.Load();

                ConfigProvider.Load();

                var cmdInfo = ParseCommandLine(args);
                if (cmdInfo != null &&
                    Does.DirectoryExist(cmdInfo.StartingFolder))
                    ConfigProvider.CurrentConfiguration.StartingFolder =
                        cmdInfo.StartingFolder;

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
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
        private ICommandLineInfo ParseCommandLine(string[] args)
        {
            ICommandLineInfo result = default;

            try
            {
                CommandLineSpecified = args.Any();

                if (!args.Any())
                {
                    result = CommandLineInfo =
                        MakeNewCommandLineInfo.FromScratch();
                    return
                        result; // This app can be launched with no command-line arguments.
                }

                CommandLineParser.DisplayHelp += OnCommandLineParserDisplayHelp;
                result = CommandLineInfo = CommandLineParser.Parse(args);

                if (!CommandLineValidator.Validate(CommandLineInfo))
                    Environment.Exit(-1); // kill this app
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Takes actions based on what arguments were passed to the application.
        /// </summary>
        private void ProcessCommandLine()
            /*
             * If the user specified one or more argument(s) on the command line of this
             * application, translate those parameters into config settings for this
             * run.
             */
            => GetCommandLineProcessor.OfType(
                                          Get.CommandLineProcessorType(
                                              CommandLineSpecified, AutoStart
                                          )
                                      )
                                      .HavingCommandLineInfo(CommandLineInfo)
                                      .Process();

        /// <summary>
        /// Configures the application's handling of validation failures of the
        /// command-line parameters.
        /// </summary>
        private void SetUpCommandLineValidation()
        {
            CommandLineValidator.CommandLineInfoInvalid +=
                OnCommandLineInfoInvalid;
            RootDirectoryPathValidator.RootDirectoryInvalid +=
                OnRootDirectoryInvalid;
        }
    }
}