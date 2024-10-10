namespace MFR.Events.Common
{
    /// <summary>
    /// Defines the method signature for the handlers of the <see
    /// cref="E:MFR.IFileRenamer.StatusUpdate"/> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.StatusUpdateEventArgs"/> that
    /// contains the event data.
    /// </param>
    public delegate void StatusUpdateEventHandler(object sender,
       StatusUpdateEventArgs e);
}