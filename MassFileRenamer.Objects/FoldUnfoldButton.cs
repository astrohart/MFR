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
      }

      /// <summary>
      /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
      /// form when the form is folded.
      /// </summary>
      public Size FormFoldedSize { get; set; }

      /// <summary>
      /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
      /// form when the form is unfolded.
      /// </summary>
      public Size FormUnfoldedSize { get; set; }
   }
}