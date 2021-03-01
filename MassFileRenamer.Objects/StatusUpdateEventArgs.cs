using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MassFileRenamer.Objects.StatusUpdateEventHandler"/>.
    /// </summary>
    public class StatusUpdateEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.StatusUpdateEventArgs"/> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the status message text that is meant
        /// for display to the user.
        /// </param>
        public StatusUpdateEventArgs(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Gets the textual status message that is meant for display to the user.
        /// </summary>
        public string Text
        {
            get;
        }
    }
}