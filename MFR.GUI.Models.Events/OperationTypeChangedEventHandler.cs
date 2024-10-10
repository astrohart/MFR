namespace MFR.GUI.Models.Events
{
    /// <summary>
    /// Represents a handler for a <c>OperationTypeChanged</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.GUI.Models.Events.OperationTypeChangedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>OperationTypeChanged</c> event.
    /// </remarks>
    public delegate void OperationTypeChangedEventHandler(
        object sender,
        OperationTypeChangedEventArgs e
    );
}