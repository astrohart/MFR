namespace MFR.GUI.Controls.Events
{
    /// <summary>
    /// Handler for an event that occurs with respect to either the left-hand side or
    /// the right-hand side of a list-builder control.
    /// </summary>
    /// <param name="sender">(Required.) Reference to the object that raised the event.</param>
    /// <param name="e">
    /// (Required.) A <see cref="T:MFR.GUI.Controls.Events.ListBuilderEventArgs" />
    /// that contains the event data.
    /// <para />
    /// This object is utilized to explain to the handler of the event, to which side
    /// (left or right) of the list-builder control that this event pertains to.
    /// </param>
    public delegate void ListBuilderEventHandler(object sender,
        ListBuilderEventArgs e);
}