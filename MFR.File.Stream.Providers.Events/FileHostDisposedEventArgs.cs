using PostSharp.Patterns.Threading;
using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileHostDisposed</c> event handlers.
    /// </summary>
    [ExplicitlySynchronized]
    public class FileHostDisposedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileHostDisposedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that previously had a file stream opened on it.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> that corresponds to the
        /// <c>ticket</c> that now no longer works.
        /// </param>
        public FileHostDisposedEventArgs(string pathname, Guid ticket)
        {
            Pathname = pathname;
            Ticket = ticket;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file on which the disposed stream was previously opened.
        /// </summary>
        public string Pathname
        {
            get;
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