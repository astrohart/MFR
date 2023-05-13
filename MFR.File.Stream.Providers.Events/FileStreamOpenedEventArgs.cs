using System;
using System.IO;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileStreamOpened</c> event handlers.
    /// </summary>
    public class FileStreamOpenedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which a file stream has been successfully opened.
        /// </param>
        /// <param name="reader">
        /// (Required.) Reference to an instance of a
        /// <see cref="T:System.IO.TextReader" /> that represents the file stream thusly
        /// opened.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that corresponds to the
        /// <c>ticket</c> that subscribers can redeem at a later point to access the file
        /// stream.
        /// </param>
        public FileStreamOpenedEventArgs(string pathname, TextReader reader,
            Guid ticket)
        {
            Pathname = pathname;
            Reader = reader;
            Ticket = ticket;
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
        /// Gets a reference to an instance of <see cref="T:System.IO.TextReader" /> that
        /// represents the actual file stream on the file having the pathname specified in
        /// the
        /// <see
        ///     cref="P:MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.Pathname" />
        /// property.
        /// </summary>
        public TextReader Reader
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