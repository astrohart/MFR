using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileStreamDisposed</c> event handlers.
    /// </summary>
    public class FileStreamDisposedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> that corresponds to the
        /// <c>ticket</c> that now no longer works.
        /// </param>
        public FileStreamDisposedEventArgs(Guid ticket)
        {
            Ticket = ticket;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> that corresponds to the <c>ticket</c> that
        /// now no longer works.
        /// </summary>
        public Guid Ticket
        {
            get;
        }
    }
}