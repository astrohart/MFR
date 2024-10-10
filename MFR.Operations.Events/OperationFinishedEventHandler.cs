namespace MFR.Operations.Events
{
    /// <summary>
    /// Represents a handler for an OperationFinished event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Operations.Events.OperationFinishedEventArgs"/>
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle
    /// the OperationFinished event.
    /// </remarks>
    public delegate void OperationFinishedEventHandler(object sender,
       OperationFinishedEventArgs e);
}