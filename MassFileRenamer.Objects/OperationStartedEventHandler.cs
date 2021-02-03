namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the method signature for the handlers of the
   /// <see
   ///    cref="E:MassFileRenamer.Objects.FileRenamer.OperationStarted" />
   /// event.
   /// </summary>
   /// <param name="sender">
   /// Reference to the instance of the object that raised the event.
   /// </param>
   /// <param name="e">
   /// A <see cref="T:MassFileRenamer.Objects.OperationStartedEventArgs" /> that
   /// contains the event data.
   /// </param>
   public delegate void OperationStartedEventHandler(object sender,
      OperationStartedEventArgs e);
}