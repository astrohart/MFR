namespace MFR.GUI.Controls.Events
{
    /// <summary>
    /// Handler for a cancellable event that occurs with respect to either the
    /// left-hand side or right-hand side of a list-builder control.
    /// </summary>
    /// <param name="sender">(Required.) Reference to the object that raised the event.</param>
    /// <param name="e">
    /// (Required.) A
    /// <see cref="T:MFR.GUI.Controls.Events.ListBuilderCancelEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void ListBuilderCancelEventHandler(object sender,
        ListBuilderCancelEventArgs e);
}