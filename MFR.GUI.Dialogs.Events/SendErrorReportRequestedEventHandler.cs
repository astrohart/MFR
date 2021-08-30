namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Represents a handler for a SendErrorReportRequested event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs"/> that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the SendErrorReportRequested event.
    /// </remarks>
    public delegate void SendErrorReportRequestedEventHandler(object sender,
        SendErrorReportRequestedEventArgs e);
}