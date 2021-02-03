using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Displays the main window of the application.
   /// </summary>
   public partial class MainWindow : Form, IMainWindow
   {
      /// <summary>
      /// Reference to the presenter for this form.
      /// </summary>
      private IMainWindowPresenter _presenter;

      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.GUI.MainWindow" />
      /// and returns a reference to it.
      /// </summary>
      public MainWindow()
      {
         InitializeComponent();

         _presenter = new MainWindowPresenter();
      }

      /// <summary>
      /// Gets a reference to the control that allows the user to specify the
      /// path to the starting folder.
      /// </summary>
      public TextBox StartingFolderTextBox
      {
         [DebuggerStepThrough] get;
         private set;
      }

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
      public string Version { get; } = Assembly.GetExecutingAssembly().GetName()
         .Version.ToString();

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
      /// </summary>
      /// <param name="e">
      /// An <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = $"{Application.ProductName} {Version}";
      }

      /// <summary>
      /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
      /// for the Cancel button.
      /// </summary>
      /// <param name="sender">
      /// The sender of this event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// This handler closes the application window (and thereby exits the application
      /// itself) when the user clicks the Cancel button on the main window.
      /// </remarks>
      private void OnClickCancel(object sender, EventArgs e)
         => Close();
   }
}