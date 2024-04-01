using MFR.File.Stream.Providers.Events;
using System;
using System.Collections.Generic;
using System.IO;
using xyLOGIX.TicketedProvider.Interfaces;

namespace MFR.File.Stream.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that allocates
    /// instances of <see cref="T:System.IO.TextReader" /> and hands out
    /// <see cref="T:System.Guid" /> <c>ticket</c> values that other parts of the
    /// application can then redeem to access the allocated
    /// <see cref="T:System.IO.TextReader" /> instance for later use.
    /// <para />
    /// Also provides a method to dispose all the allocated
    /// <see cref="T:System.IO.TextReader" /> instances previously allocated (e.g.,
    /// when the application shuts down).
    /// </summary>
    /// <remarks>
    /// All <see cref="T:System.IO.TextReader" /> instances provided by this class are
    /// thread-safe.
    /// </remarks>
    public interface IFileStreamProvider : ITicketedObjectProvider<StreamReader>
    {
        /// <summary>
        /// Raised when any of the file streams that are managed by this object are
        /// disposed by it.
        /// </summary>
        event FileStreamDisposedEventHandler FileStreamDisposed;

        /// <summary>
        /// Raised when this object has successfully processed a request to open a stream
        /// on a particular file.
        /// </summary>
        event FileStreamOpenedEventHandler FileStreamOpened;

        /// <summary>
        /// Occurs when an exception was caught during an attempt to open a
        /// <c>FileStream</c> upon a particular file.
        /// </summary>
        event FileStreamOpenFailedEventHandler FileStreamOpenFailed;

        /// <summary>
        /// Occurs when a <c>FileStream</c> is about to be opened upon a particular file.
        /// </summary>
        event FileStreamOpeningEventHandler FileStreamOpening;

        /// <summary>
        /// Opens file streams for the files specified in the <paramref name="pathnames" />
        /// collection, in batch.  Returns a collection of <see cref="T:System.Guid" />
        /// values, each of which represents the corresponding opened file stream.  If a
        /// </summary>
        /// <param name="pathnames">
        /// (Required.) A collection of one or more <see cref="T:System.String" /> values,
        /// each of which represents a file to be opened.
        /// </param>
        /// <returns>
        /// A collection of one or more <see cref="T:System.Guid" /> values, each
        /// of which corresponds in a 1-to-1 fashion to the file(s) that have been
        /// specified.  If a particular file could not be opened, its corresponding entry
        /// in the returned collection will be the <see cref="F:System.Guid.Empty" />
        /// value.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="pathnames" /> collection is
        /// <see langword="null" /> or the empty collection, then this method returns the
        /// empty collection.
        /// </remarks>
        IList<Guid> BatchOpenStreams(
            IList<string> pathnames
        );

        /// <summary>
        /// Disposes, i.e., closes the file and releases all resources, for the file stream
        /// that corresponds to the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// A <see cref="T:System.Guid" /> value that corresponds to
        /// the file stream you wish to close.
        /// </param>
        /// <param name="remove">
        /// (Optional.) Indicates whether to remove the disposed stream from our internal
        /// collection.  <see langword="true" /> is the default.
        /// </param>
        /// <remarks>
        /// If the Zero GUID is passed as the argument of the <paramref name="ticket" />
        /// parameter, or if the specified <paramref name="ticket" /> is not present in the
        /// internal list.
        /// </remarks>
        new void DisposeObject(Guid ticket, bool remove = true);

        /// <summary>
        /// Attempts to look up the fully-qualified pathname of the file on whom a file
        /// stream corresponding to the specified <paramref name="ticket" /> has been
        /// opened.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// should correspond to a file that currently has a stream opened upon it.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the file on whom the file stream corresponding to
        /// the specified <paramref name="ticket" /> is opened.
        /// </returns>
        /// <remarks>
        /// If this method cannot locate the corresponding pathname of the file
        /// stream that goes with the <paramref name="ticket" />, or if the
        /// <paramref name="ticket" /> provided is not mapped to any open file stream, then
        /// this method returns the <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        string GetPathnameForTicket(Guid ticket);

        /// <summary>
        /// Given a fully-qualified <paramref name="pathname" /> of a file on the disk,
        /// upon which a file stream has been opened, or we think has been opened, and
        /// finds the corresponding ticket that can be redeemed to access a reference
        /// to that stream. .
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file on which you think a stream might be open.
        /// </param>
        /// <returns>
        /// If a file stream is open on the file having the specified
        /// <paramref name="pathname" />, the <see cref="T:System.Guid" /> value that
        /// indicates which ticket can be redeemed to this object in order to get access to
        /// that stream, is returned.
        /// <para />
        /// Otherwise, if there is no file stream currently open upon the file having the
        /// specified <paramref name="pathname" />, or if the specified
        /// <paramref name="pathname" /> is invalid or refers to a file that does not
        /// exist, then the <see cref="F:System.Guid.Empty" /> value is returned.
        /// </returns>
        Guid GetTicketForPathname(string pathname);

        /// <summary>
        /// Opens a object, represented by a object
        /// instance, on the text file having the specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to have a stream opened for it.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Guid" /> value that represents a <c>ticket</c> that can
        /// be redeemed later on with the
        /// <see
        ///     cref="M:xyLOGIX.TicketedProvider.Interfaces.ITicketedObjectProvider`1.Redeem" />
        /// method to access the corresponding object, or
        /// <see cref="F:System.Guid.Empty" /> if the file could not be accessed or if the
        /// <paramref name="pathname" /> parameters' argument is the blank or
        /// <see langword="null" /> <see cref="T:System.String" />, or if the
        /// <paramref name="pathname" /> does not refer to a file or the file that is
        /// referred to does not exist..
        /// </returns>
        Guid OpenStreamFor(string pathname);

        /// <summary>
        /// Rewinds the object associated with the specified
        /// <paramref name="ticket" />, if any corresponding stream is even present in the
        /// internal collection.
        /// </summary>
        /// <param name="ticket">
        /// A <see cref="T:System.Guid" /> value that corresponds to
        /// the already-open object that is to be rewound.
        /// </param>
        /// <remarks>
        /// If successful, this method retrieves the object open on a file
        /// that corresponds to the specified <paramref name="ticket" />, and then moves
        /// its file pointer to the beginning of the stream.
        /// <para />
        /// If an I/O exception or other error occurs, if the stream that corresponds to
        /// the specified <paramref name="ticket" /> cannot be obtained from the internal
        /// collection, or if the stream is already positioned at the beginning of the
        /// data, then the method does nothing.
        /// </remarks>
        void RewindStream(Guid ticket);
    }
}