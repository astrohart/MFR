using MFR.GUI.Launchers.Dialogs;
using MFR.GUI.Windows;
using MFR.Objects;
using MFR.Objects.Configuration.Providers;
using PostSharp.Patterns.Diagnostics;
using System;
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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );
            Application.ThreadException += OnThreadException;

            LogFileManager.InitializeLogging(
                true, infrastructureType: LoggingInfrastructureType.PostSharp
            );

            // Load the configuration from the disk.
            ConfigurationProvider.Load();

            Application.Run(MainWindow.Instance);

            // Save changes in the configuration back out to the disk.
            ConfigurationProvider.Save();
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.Application.ThreadException" />
        /// event
        /// raised by the application when an exception is thrown but goes
        /// unhandled by a try/catch block that is not there in the code.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This handler responds to the event by writing the exception
        /// information to the log file and then by displaying a user-friendly
        /// error dialog box.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnThreadException(object sender,
            ThreadExceptionEventArgs e)
        {
            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);

            ErrorDialogLauncher.Display(Application.OpenForms[0], e.Exception);
        }
    }
}