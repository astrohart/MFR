namespace MFR.Events
{
    /// <summary>
    /// Represents a handler for a <c>Error</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Events.ErrorEventArgs" /> that contains the event data.
    /// </param>
    /// <remarks>
    /// The <c>Error</c> event is typically raised when an error occurs that's not
    /// triggered by an actual <see cref="T:System.Exception" />.
    /// <para />
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>Error</c> event.
    /// </remarks>
    public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
}