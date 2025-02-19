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
using MFR.GUI.Processors.Validators.Factories;
using MFR.GUI.Processors.Validators.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;
using xyLOGIX.Win32.Interact;

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
            [DebuggerStepThrough] get;
        } = new Guid("ce26f41b-78f8-4093-ab60-91fbb069c70b");

        /// <summary>
        /// Gets a value indicating whether the application should automatically process
        /// operations requested by the user from the command line.
        /// </summary>
        public bool AutoStart
        {
            [DebuggerStepThrough] get => CommandLineInfo.AutoStart;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </summary>
        public ICommandLineInfo CommandLineInfo
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] private set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" />
        /// interface.
        /// </summary>
        private static ICommandLineParser CommandLineParser
        {
            [DebuggerStepThrough] get;
        } = GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Validators.Interfaces.ICommandLineProcessorTypeValidator" />
        /// interface.
        /// </summary>
        private static ICommandLineProcessorTypeValidator
            CommandLineProcessorTypeValidator
        {
            [DebuggerStepThrough] get;
        } = GetCommandLineProcessorTypeValidator.SoleInstance();

        /// <summary>
        /// Gets or sets a value that indicates whether the user specified any arguments on
        /// this application's command line at startup or not.
        /// </summary>
        public bool CommandLineSpecified
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
        /// interface.
        /// </summary>
        private static ICommandLineValidator CommandLineValidator
        {
            [DebuggerStepThrough] get;
        } = GetCommandLineValidator.SoleInstance();

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
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Application.ProjectFileRenamerApp" />.
        /// </summary>
        public static IWinApp Instance
        {
            [DebuggerStepThrough] get;
        } = new ProjectFileRenamerApp();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
        {
            [DebuggerStepThrough] get;
        } = GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        private static IRootDirectoryPathValidator RootDirectoryPathValidator
        {
            [DebuggerStepThrough] get;
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
        public void WinInit([NotLogged] string[] args)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.WinInit: Arrived at the application entry-point..."
                );

                args = FixArguments(args);

                if (!InitApplication(args))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** Failed to initialize the application."
                    );

                    Messages.ShowStopError(
                        "An error occurred while initializing the application.  The application will now terminate."
                    );

                    Environment.Exit(-1);
                }

                OnInitialized();

                ProcessCommandLine();

                ExitApplication();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

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
        /// Gets the command-line arguments passed to the application, and fixes any that
        /// are malformed.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" /> values, each of which
        /// corresponds to a value that was passed by the user on the application's command
        /// line.
        /// </param>
        /// <returns>
        /// If successful, an array of <see cref="T:System.String" /> values, each of which
        /// corresponds to a value that was passed by the user on the application's command
        /// line, with each value's format aligned with what we expect; otherwise, the
        /// empty array is returned.
        /// </returns>
        [return: NotLogged]
        private string[] FixArguments([NotLogged] string[] args)
        {
            var result = new AdvisableCollection<string>();

            try
            {
                if (args == null) return result.ToArray();
                if (args.Length <= 0) return result.ToArray();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.FixArguments: Fixing malformed command-line arguments..."
                );

                /*
                 * Make sure any args of the format <c>--flag="value"</c> are fixed if they are missing
                 * the first double-quote character after the equals sign.
                 */

                foreach (var arg in args)
                {
                    if (string.IsNullOrWhiteSpace(arg)) continue;

                    var argToUse = arg;

                    if (!arg.StartsWith(
                            "--", StringComparison.OrdinalIgnoreCase
                        ))
                    {
                        result.Add(argToUse);
                        continue;
                    }

                    if (!arg.Contains("="))
                    {
                        result.Add(argToUse);
                        continue;
                    }

                    if (arg.Contains("=\""))
                    {
                        result.Add(argToUse);
                        continue;
                    }

                    argToUse = arg.Replace("=", "=\"");
                    result.Add(argToUse);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new AdvisableCollection<string>();
            }

            return result.ToArray();
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
        private bool InitApplication([NotLogged] string[] args)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.InitApplication: Initializing the application..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.InitApplication: Setting up the display of the application and its window(s)..."
                );

                SetDisplayParameters();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.InitApplication: Configuring what to do when an exception is thrown..."
                );

                SetUpExceptionHandling();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.InitApplication: Subscribing to notification(s) about invalid command-line parameter(s)..."
                );

                SetUpCommandLineValidation();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.InitApplication: Loading profile(s)..."
                );

                // Load the config from the file system.
                ProfileProvider.Load();

                ConfigProvider.Load();

                var cmdInfo = ParseCommandLine(args);
                if (cmdInfo != null &&
                    Does.DirectoryExist(cmdInfo.StartingFolder))
                    ConfigProvider.CurrentConfig.StartingFolder =
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
        /// Raises the
        /// <see cref="E:MFR.GUI.Application.ProjectFileRenamerApp.Initialized" /> event.
        /// </summary>
        protected virtual void OnInitialized()
            => Initialized?.Invoke(this, EventArgs.Empty);

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
        [return: NotLogged]
        private ICommandLineInfo ParseCommandLine([NotLogged] string[] args)
        {
            var result = MakeNewCommandLineInfo.FromScratch();

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ParseCommandLine: Checking whether the 'args' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, args, is null. If it is, send an 
                // error to the log file and quit, returning the default return value of this
                // method.
                if (args == null)
                {
                    // The parameter, 'args', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "ProjectFileRenamerApp.ParseCommandLine: *** ERROR *** A null reference was passed for the 'args' method parameter.  Stopping..."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ParseCommandLine: *** SUCCESS *** We have been passed a valid object reference for the 'args' method parameter.  Proceeding..."
                );

                CommandLineSpecified = args.Length > 0;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ParseCommandLine *** INFO: Checking whether the array, 'args', has greater than zero elements..."
                );

                // Check whether the array, 'args', has greater than zero elements.  If it is empty,
                // then write an error message to the log file, and then terminate the execution of this method.
                // It is preferred for the array to have greater than zero elements.
                if (args.Length <= 0)
                {
                    // The array, 'args', has zero elements, and we can't proceed if this is so.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "ProjectFileRenamerApp.ParseCommandLine *** ERROR *** The array, 'args', has zero elements.  Stopping..."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"ProjectFileRenamerApp.ParseCommandLine *** SUCCESS *** {args.Length} element(s) were found in the 'args' array.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ParseCommandLine: Checking whether greater than zero argument(s) were passed to the application on its command line..."
                );

                CommandLineParser.DisplayHelp += OnCommandLineParserDisplayHelp;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ParseCommandLine: Instructing the Command Line Parser component to parse the command-line argument(s)..."
                );

                result = CommandLineInfo = CommandLineParser.Parse(args);

                if (!CommandLineValidator.Validate(CommandLineInfo))
                    Environment.Exit(-1); // kill this app
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = MakeNewCommandLineInfo.FromScratch();
            }

            return result;
        }

        /// <summary>
        /// Takes actions based on what arguments were passed to the application.
        /// </summary>
        private void ProcessCommandLine() /*
                                           * If the user specified one or more argument(s) on the command line of this
                                           * application, translate those parameters into config settings for this
                                           * run.
                                           */
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ProcessCommandLine: Attempting to discover the type of command-line argument(s) that were passed to the application..."
                );

                var commandLineProcessorType =
                    Get.CurrentCommandLineProcessorType(
                        CommandLineSpecified, AutoStart
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** ProjectFileRenamerApp.ProcessCommandLine: Checking whether the command-line processor type, '{commandLineProcessorType}', is within the defined value set..."
                );

                // Check to see whether the command-line processor type is within the defined value set.
                // If this is not the case, then write an error message to the log file
                // and then terminate the execution of this method.
                if (!CommandLineProcessorTypeValidator.IsValid(
                        commandLineProcessorType
                    ))
                {
                    // The command-line processor type is NOT within the defined value set.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR: The command-line processor type, '{commandLineProcessorType}', is NOT within the defined value set.  Stopping..."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"ProjectFileRenamerApp.ProcessCommandLine: *** SUCCESS *** The command-line processor type, '{commandLineProcessorType}', is within the defined value set.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"ProjectFileRenamerApp.ProcessCommandLine: Attempting to obtain a Command Line Processor component for the command-line processor type, '{commandLineProcessorType}'..."
                );

                var processor = GetCommandLineProcessor
                                .OfType(commandLineProcessorType)
                                .HavingCommandLineInfo(CommandLineInfo);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ProcessCommandLine: Checking whether the variable 'processor' has a null reference for a value..."
                );

                // Check to see if the variable, processor, is null. If it is,
                // send an error to the log file and quit, returning from the method.
                if (processor == null)
                {
                    // the variable processor is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "ProjectFileRenamerApp.ProcessCommandLine: *** ERROR ***  The 'processor' variable has a null reference.  Stopping..."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, processor, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ProcessCommandLine: *** SUCCESS *** The 'processor' variable has a valid object reference for its value.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.ProcessCommandLine: Instructing the Command Line Processor to process the command-line argument(s)..."
                );

                processor.Process();
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
            try
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application
                      .SetCompatibleTextRenderingDefault(false);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Configures the application's handling of validation failures of the
        /// command-line parameters.
        /// </summary>
        private void SetUpCommandLineValidation()
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.SetUpCommandLineValidation: Checking whether the property, 'CommandLineValidator', has a null reference for a value..."
                );

                // Check to see if the required property, 'CommandLineValidator', has a null reference for a value. 
                // If that is the case, then we will write an error message to the log file, and then
                // terminate the execution of this method.
                if (CommandLineValidator == null)
                {
                    // The property, 'CommandLineValidator', has a null reference for a value.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "ProjectFileRenamerApp.SetUpCommandLineValidation: *** ERROR *** The property, 'CommandLineValidator', has a null reference for a value.  Stopping..."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectFileRenamerApp.SetUpCommandLineValidation: *** SUCCESS *** The property, 'CommandLineValidator', has a valid object reference for its value.  Proceeding..."
                );

                CommandLineValidator.CommandLineInfoInvalid +=
                    OnCommandLineInfoInvalid;
                RootDirectoryPathValidator.RootDirectoryInvalid +=
                    OnRootDirectoryInvalid;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Configures the application's handling of exceptions that are not
        /// caught elsewhere.
        /// </summary>
        private static void SetUpExceptionHandling()
        {
            try
            {
                System.Windows.Forms.Application.SetUnhandledExceptionMode(
                    UnhandledExceptionMode.CatchException
                );
                System.Windows.Forms.Application.ThreadException +=
                    OnThreadException;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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
    }
}