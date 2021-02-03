using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   public partial class MainWindow : Form
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
      /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = $"{Application.ProductName} {Application.ProductVersion}";
      }
   }
}