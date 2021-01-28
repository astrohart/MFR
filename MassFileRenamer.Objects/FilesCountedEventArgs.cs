using System;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the data that is passed by all events of type
   /// <see cref="T:MassFileRenamer.Objects.FilesCountedEventHandler" />.
   /// </summary>
   public class FilesCountedEventArgs : EventArgs
   {
      /// <summary>
      /// Creates a new instance of
      /// <see cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" /> and returns a
      /// reference to it.
      /// </summary>
      public FilesCountedEventArgs(OperationType operation)
      {
         Operation = operation;
      }

      /// <summary>
      /// Gets the type of operation being performed.
      /// </summary>
      public OperationType Operation { get; }
   }
}