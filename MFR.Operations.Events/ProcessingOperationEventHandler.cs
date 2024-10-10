namespace MFR.Operations.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of a ProcessingOperation event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Operations.Events.ProcessingOperationEventArgs"/>
    /// that contains the event data.
    /// </param>
    public delegate void ProcessingOperationEventHandler(object sender,
       ProcessingOperationEventArgs e);
}