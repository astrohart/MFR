using MassFileRenamer.Objects;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets the title text that should be utilized for the main application window.
        /// </summary>
        public static string MainWindowTitle
            => $"{ShortCompanyName} {ProductNameWithoutCompany}";

        /// <summary>
        /// Gets the product name without the company name.
        /// </summary>
        private static string ProductNameWithoutCompany
            => Application.ProductName.Replace(ShortCompanyName, string.Empty);

        /// <summary>
        /// Gets the short name (without prefixes or suffixes) of the company
        /// that manufactured this tool.
        /// </summary>
        public static string ShortCompanyName
            => Application.CompanyName.Replace(", LLC", string.Empty);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.ThreadException += OnThreadException;
            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogFileManager.InitializeLogging(
                false, infrastructureType: LoggingInfrastructureType.PostSharp
            );

            // Load the configuration from the disk.
            ConfigurationProvider.Load();

            Application.Run(
                new MainWindow(ConfigurationProvider.ConfigurationFilePath)
            );

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