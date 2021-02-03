using System;
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

         Application.Run(new MainWindow());
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