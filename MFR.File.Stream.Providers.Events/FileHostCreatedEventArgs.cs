using MFR.File.Hosts.Interfaces;
using PostSharp.Patterns.Threading;
using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileHostCreated</c> event handlers.
    /// </summary>
    [ExplicitlySynchronized]
    public class FileHostCreatedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which a file stream has been successfully opened.
        /// </param>
        /// <param name="host">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that corresponds to the
        /// <c>ticket</c> that subscribers can redeem at a later point to access the file
        /// stream.
        /// </param>
        public FileHostCreatedEventArgs(
            string pathname,
            IFileHost host,
            Guid ticket
        )
        {
            Pathname = pathname;
            Host = host;
            Ticket = ticket;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface that represents
        /// the <c>File Host</c> that was just created.
        /// </summary>
        public IFileHost Host
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file for which a file stream was successfully opened.
        /// </summary>
        public string Pathname
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> value that can be redeemed to get access to
        /// the file stream later.
        /// </summary>
        public Guid Ticket
        {
            get;
        }
    }
}