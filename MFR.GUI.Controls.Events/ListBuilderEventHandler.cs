using System;

namespace MFR.GUI.Controls.Events
{
    /// <summary>
    /// Handler for an event that occurs with respect to either the left-hand side or
    /// the right-hand side of a list-builder control.
    /// </summary>
    /// <param name="sender">(Required.) Reference to the object that raised the event.</param>
    /// <param name="e">
    /// (Required.) A <see cref="T:System.EventArgs" /> that contains the
    /// event data.
    /// </param>
    public delegate void ListBuilderEventHandler(object sender, EventArgs e);
}