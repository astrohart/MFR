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

            Application.Run(
                new MainWindow(ConfigurationProvider.ConfigurationFilePath)
            );

            ConfigurationProvider.SaveConfigurationPath();
        }

        private static void InitApplication()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In Program.InitApplication"
            );

            try
            {
                ConfigurationProvider.LoadConfigurationPath();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                MessageBox.Show(
                    ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );

                Environment.Exit(-1);
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** Loaded the path of the configuration file from the system Registry."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "Program.InitApplication: Done."
            );
        }

        private static void OnThreadException(object sender,
            ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                e.Exception.Message, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
            );
        }
    }
}