using MFR.Common;
using MFR.GUI.Actions;
using MFR.GUI.Application.Factories;
using MFR.GUI.Application.Interfaces;
using MFR.GUI.Properties;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Interop.Processes.Actions;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Program" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Program() { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface.
        /// </summary>
        private static IWinApp Application
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerApp.SoleInstance();

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the currently-loaded config file.
        /// </summary>
        private static string ConfigFilePath
        {
            [DebuggerStepThrough] get => ConfigProvider.ConfigFilePath;
        }

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
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">
        /// (Optional.) Array of strings, each of which represents a different
        /// command-line argument passed to this application.
        /// </param>
        [STAThread]
        public static void Main([NotLogged] string[] args)
        {
            SetUpLogging(); // has to be called here for the log file to be stored in the proper location.

            if (!Register.WindowsMessageFilter())
            {
                Messages.ShowStopError(
                    Resources.Error_FailedRegisterWindowsMessageFilter
                );
                return;
            }

            InitializeSystemCommandRunner();

            Application.WinInit(args);

            Revoke.WindowsMessageFilter();
        }

        /// <summary>
        /// Initializes the events and properties of a <c>System Command Runner</c> object;
        /// aka, the <see cref="T:xyLOGIX.Interop.Processes.Actions.Run" /> class.
        /// </summary>
        private static void InitializeSystemCommandRunner()
        {
            try
            {
                Run.DataReceived -= OnRunDataReceived;
                Run.DataReceived += OnRunDataReceived;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Handles the <see cref="E:xyLOGIX.Interop.Processes.Actions.Run.DataReceived" />
        /// event raised by the <see cref="T:xyLOGIX.Interop.Processes.Actions.Run" />
        /// class when its methods are called to execute processes.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by writing the results of executing system
        /// commands to the log file.
        /// </remarks>
        private static void OnRunDataReceived(
            object sender,
            DataReceivedEventArgs e
        )
        {
            if (e == null) return;
            if (string.IsNullOrWhiteSpace(e.Data)) return;

            DebugUtils.WriteLine(
                DebugLevel.Info, $"*** DEBUG *** {e.Data.Trim()}"
            );
        }

        private static void OnConfigProviderConfigFilePathChanged(
            object sender,
            EventArgs e
        )
            => Messages.ShowInformation(
                $"The new config file pathname is '{ConfigFilePath}"
            );

        /// <summary>
        /// Configures the logging infrastructure.
        /// </summary>
        private static void SetUpLogging()
            => LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
    }
}