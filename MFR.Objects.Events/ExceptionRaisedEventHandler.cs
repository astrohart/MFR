namespace MFR.Objects.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of a(n) ExceptionRaised event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Objects.Events.ExceptionRaisedEventArgs"/> that
    /// contains the event data.
    /// </param>
    public delegate void ExceptionRaisedEventHandler(object sender,
        ExceptionRaisedEventArgs e);
}