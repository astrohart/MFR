using System.Diagnostics;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Defines the public-exposed methods and properties of the main window of
   /// the application.
   /// </summary>
   public interface IMainWindow : IWin32Window
   {
      /// <summary>
      /// Gets a reference to the control that allows the user to specify the
      /// path to the starting folder.
      /// </summary>
      TextBox StartingFolderTextBox { [DebuggerStepThrough] get; }

      /// <summary>
      /// Gets a string containing this application's version.
      /// </summary>
      /// <remarks>
      /// Thanks to
      /// <a
      ///    href="
      /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/d9a69018-4840-4aeb-b9f1-4d98ab35f782/applicationproductversion?forum=csharpgeneral
      /// ">
      /// Kiran
      /// Suthar
      /// </a>
      /// 's answer on the Microsoft forums.
      /// </remarks>
      string Version { get; }
   }
}