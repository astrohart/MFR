using System;
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
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(MainWindow.Instance);
      }
   }
}