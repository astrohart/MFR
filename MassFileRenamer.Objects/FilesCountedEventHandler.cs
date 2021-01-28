namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the method signature for the handlers of the
   /// <see cref="E:MassFileRenamer.Objects.FilesCountedEventHandler.FilesCounted" />
   /// event.
   /// </summary>
   /// <param name="sender">
   /// Reference to the instance of the object that raised the
   /// event.
   /// </param>
   /// <param name="e">
   /// A
   /// <see cref="T:MassFileRenamer.Objects.FilesCountedEventArgs" /> that contains
   /// the event data.
   /// </param>
   public delegate void FilesCountedEventHandler(object sender,
      FilesCountedEventArgs e);
}