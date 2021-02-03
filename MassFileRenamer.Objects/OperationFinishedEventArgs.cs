namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Contains the data for a OperationFinished event.
   /// </summary>
   public class OperationFinishedEventArgs : OperationEventArgs
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.Objects.OperationEventArgs" />
      /// and returns a
      /// reference to it.
      /// </summary>
      /// <param name="type">
      /// (Required.) One of the
      /// <see
      ///    cref="T:MassFileRenamer.Objects.OperationType" />
      /// values that specifies
      /// the operation being performed.
      /// </param>
      public OperationFinishedEventArgs(OperationType type) : base(type) { }
   }
}