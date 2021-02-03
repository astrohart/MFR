using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Displays the main window of the application.
   /// </summary>
   public partial class MainWindow : Form
   {
      /// <summary>
      /// Gets a reference to the one and only instance of <see cref="T:MassFileRenamer.GUI.MainWindow"/>.
      /// </summary>
      public static MainWindow Instance { get; } = new MainWindow();

      /// <summary>
      /// Empty, static constructor to prohibit direct allocation of this class.
      /// </summary>
      static MainWindow() { }

      /// <summary>
      /// Empty, protected constructor to prohibit direct allocation of this class.
      /// </summary>
      protected MainWindow()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
      /// </summary>
      /// <param name="e">
      /// An <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = $"{Application.ProductName} {Application.ProductVersion}";
      }
   }
}