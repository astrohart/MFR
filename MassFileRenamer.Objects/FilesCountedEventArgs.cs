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
      /// <see
      ///    cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" />
      /// and returns a
      /// reference to it.
      /// </summary>
      /// <param name="count">
      /// (Required.) A zero or positive integer specifying the number of files
      /// to be processed by the operation.
      /// </param>
      /// <param name="operation">
      /// (Required.) One of the
      /// <see
      ///    cref="T:MassFileRenamer.Objects.OperationType" />
      /// values that specifies
      /// the operation being performed.
      /// </param>
      public FilesCountedEventArgs(int count, OperationType operation)
      {
         Count = count;
         Operation = operation;
      }

      /// <summary>
      /// Gets the count of files to be processed.
      /// </summary>
      public int Count { get; }

      /// <summary>
      /// Gets the type of operation being performed.
      /// </summary>
      public OperationType Operation { get; }
   }
}