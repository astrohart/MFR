namespace MFR.Operations.Events
{
    /// <summary>
    /// Represents a handler for a DataOperationError event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Operations.Events.DataOperationErrorEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle
    /// the DataOperationError event.
    /// </remarks>
    public delegate void DataOperationErrorEventHandler(object sender,
        DataOperationErrorEventArgs e);
}