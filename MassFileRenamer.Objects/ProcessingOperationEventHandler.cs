﻿namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the method signature for the handlers of the
   /// <see
   ///    cref="E:MassFileRenamer.Objects.ProcessingOperationEventHandler.ProcessingOperation" />
   /// event.
   /// </summary>
   /// <param name="sender">
   /// Reference to the instance of the object that raised the event.
   /// </param>
   /// <param name="e">
   /// A <see cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
   /// that contains the event data.
   /// </param>
   public delegate void ProcessingOperationEventHandler(object sender,
      ProcessingOperationEventArgs e);
}