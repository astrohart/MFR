using MassFileRenamer.GUI.Properties;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Backends.Console;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

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

         LoggingServices.DefaultBackend = new ConsoleLoggingBackend();

         Application.Run(new MainWindow(FindConfigFile()));
      }

      private static string FindConfigFile()
      {
         var configDir = Path.GetDirectoryName(Application.ExecutablePath);
         if (!Directory.Exists(configDir))
            throw new DirectoryNotFoundException(
               Resources.Error_ConfigFileNotFound
            );
         var configFile = Path.Combine(configDir, Resources.ConfigFilename);
         if (!File.Exists(configFile))
            throw new FileNotFoundException(
               Resources.Error_ConfigFileNotFound, configFile
            );
         return configFile;
      }

      private static void OnThreadException(object sender,
         ThreadExceptionEventArgs e)
      {
         MessageBox.Show(
            e.Exception.Message, Application.ProductName, MessageBoxButtons.OK,
            MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
         );
      }
   }
}