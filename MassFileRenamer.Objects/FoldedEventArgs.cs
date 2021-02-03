using System;
using System.Drawing;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Contains information for a Folded event.
   /// </summary>
   public class FoldedEventArgs : EventArgs
   {
      /// <summary>
      /// Constructs a new instance of <see cref="T:MassFileRenamer.Objects.FoldedEventArgs" /> and returns a reference to it.
      /// </summary>
      /// <param name="folded">New folded state of the parent form.</param>
      /// <param name="size">New size of the parent form.</param>
      public FoldedEventArgs(bool folded, Size size)
      {
         Folded = folded;
         Size = size;
      }

      /// <summary>
      /// Gets the new folded state of the parent form.
      /// </summary>
      public bool Folded { get; }

      /// <summary>
      /// Gets the new size of the parent form.
      /// </summary>
      public Size Size { get; }
   }
}