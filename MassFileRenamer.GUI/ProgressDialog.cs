using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   public partial class ProgressDialog : Form
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.GUI.ProgressDialog" />
      /// and returns a reference
      /// to it.
      /// </summary>
      public ProgressDialog()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
      /// </summary>
      /// <param name="e">
      /// An <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// This method sets the title of the dialog to match the application's name.
      /// </remarks>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = Application.ProductName;
      }
   }
}