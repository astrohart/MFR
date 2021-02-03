namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the data that is passed by all events of type <see cref="T:MassFileRenamer.Objects.OperationStartedEventHandler"/>.
   /// </summary>
   public class OperationStartedEventArgs : OperationEventArgs
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
      public OperationStartedEventArgs(OperationType type) : base(type) { }
   }
}