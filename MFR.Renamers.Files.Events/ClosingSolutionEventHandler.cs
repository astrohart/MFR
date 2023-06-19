namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Represents a handler for a <c>ClosingSolution</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Renamers.Files.Events.ClosingSolutionEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>ClosingSolution</c> event.
    /// </remarks>
    public delegate void ClosingSolutionEventHandler(
        object sender,
        ClosingSolutionEventArgs e
    );
}