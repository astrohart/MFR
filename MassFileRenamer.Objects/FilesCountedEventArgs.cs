using System;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the data that is passed by all events of type
   /// <see cref="T:MassFileRenamer.Objects.FilesCountedEventHandler" />.
   /// </summary>
   public class FilesCountedEventArgs : OperationEventArgs
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
      /// <param name="type">
      /// (Required.) One of the
      /// <see
      ///    cref="T:MassFileRenamer.Objects.OperationType" />
      /// values that specifies
      /// the operation being performed.
      /// </param>
      public FilesCountedEventArgs(int count, OperationType type) : base(type)
      {
         Count = count;
      }

      /// <summary>
      /// Gets the count of files to be processed.
      /// </summary>
      public int Count { get; }
   }
}