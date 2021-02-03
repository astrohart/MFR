using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Button that shows "More &gt;&gt;" or "Less &lt;&lt;" depending on whether
   /// a form is folded or unfolded.
   /// </summary>
   public class FoldUnfoldButton : Button
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FoldUnfoldButton" />
      /// and returns a
      /// reference to it.
      /// </summary>
      public FoldUnfoldButton()
      {
         FormFoldedSize = Size.Empty;
         FormUnfoldedSize = Size.Empty;
         IsFolded = true; // form starts out folded typically
      }

      /// <summary>
      /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
      /// form when the form is folded.
      /// </summary>
      [EditorBrowsable(EditorBrowsableState.Always)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Description(
         "Gets or sets the size of the parent form when the form is folded."
      )]
      public Size FormFoldedSize { get; set; }

      /// <summary>
      /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
      /// form when the form is unfolded.
      /// </summary>
      [EditorBrowsable(EditorBrowsableState.Always)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Description(
         "Gets or sets the size of the parent form when the form is unfolded."
      )]
      public Size FormUnfoldedSize { get; set; }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public bool IsFolded { get; set; }

      /// <summary>
      /// Occurs when the Folded state of the parent form is to be changed.
      /// </summary>
      public event FormFoldedEventHandler FormFolded;

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
      /// </summary>
      /// <param name="e">
      /// An <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      protected override void OnClick(EventArgs e)
      {
         base.OnClick(e);

         ToggleFolded();
      }

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FoldUnfoldButton.Folded" />
      /// event.
      /// </summary>
      protected virtual void OnFormFolded(FormFoldedEventArgs e)
      {
         FormFolded?.Invoke(this, e);
      }

      private void ToggleFolded()
      {
         IsFolded = !IsFolded;

         Text = IsFolded ? "&More >>" :  "&Less <<";
         Invalidate();

         OnFormFolded(
            new FormFoldedEventArgs(
               IsFolded, IsFolded ? FormFoldedSize : FormUnfoldedSize
            )
         );
      }
   }
}