using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

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
      /// Gets a reference to the progress bar control.
      /// </summary>
      public ProgressBar ProgressBar
      {
         [DebuggerStepThrough] get => progressBar;
      }

      /// <summary>
      /// Gets or sets a string containing the new status.
      /// </summary>
      public string Status
      {
         get => statusLabel.Text;
         set { statusLabel.InvokeIfRequired(() => statusLabel.Text = value); }
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

         Status = "Calculating files to be processed...";
         Text = Application.ProductName;
      }
   }
}