using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
   public partial class ProgressDialog : Form
   {
      /// <summary>
      /// Empty, static constructor to prohibit direct allocation of this class.
      /// </summary>
      static ProgressDialog() { }

      /// <summary>
      /// Empty, protected constructor to prohibit direct allocation of this class.
      /// </summary>
      protected ProgressDialog()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Gets a reference to the one and only instance of
      /// <see cref="T:MassFileRenamer.GUI.ProgressDialog" />.
      /// </summary>
      public static ProgressDialog Instance { get; } = new ProgressDialog();

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