using MFR.File.Stream.Providers.Events;
using System;
using System.Collections.Generic;
using System.IO;

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
    public interface IFileStreamProvider
    {
        /// <summary>
        /// Gets the count of file streams that are currently available.
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Object" /> that is to be
        /// used for thread synchronization.
        /// </summary>
        object SyncRoot { get; }

        /// <summary>
        /// Raised when the value of the
        /// <see cref="P:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.Count" />
        /// property has been updated.
        /// </summary>
        event EventHandler CountChanged;

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
        /// Batch-disposes the open file streams that correspond to the
        /// <paramref name="tickets" /> provided.
        /// </summary>
        /// <param name="tickets">
        /// (Required.) A collection of one or more <see cref="T:System.Guid" /> values
        /// that represent the file stream(s) to be disposed.
        /// </param>
        /// <remarks>
        /// If the <paramref name="tickets" /> is <see langword="null" /> or
        /// contains zero elements, then this method does nothing.
        /// <para />
        /// <b>NOTE:</b> Users of this object who want to dispose of all the file streams
        /// that this object manages in one go should use the
        /// <see
        ///     cref="M:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.DisposeAll" />
        /// method instead.
        /// </remarks>
        void BatchDispose(IReadOnlyCollection<Guid> tickets);

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
        IReadOnlyCollection<Guid> BatchOpenStreams(
            IReadOnlyCollection<string> pathnames);

        /// <summary>
        /// Removes all allocated <see cref="T:System.IO.TextReader" /> instances
        /// allocated thus far, from memory, and frees resources associated with them.
        /// </summary>
        /// <remarks>After calling this method, all tickets will be invalid.</remarks>
        void DisposeAll();

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
        void DisposeStream(Guid ticket, bool remove = true);

        /// <summary>
        /// Opens a file stream, represented by a <see cref="T:System.IO.TextReader" />
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
        ///     cref="M:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RedeemTicket" />
        /// method to access the corresponding file stream, or
        /// <see cref="F:System.Guid.Empty" /> if the file could not be accessed or if the
        /// <paramref name="pathname" /> parameters' argument is the blank or
        /// <see langword="null" /> <see cref="T:System.String" />, or if the
        /// <paramref name="pathname" /> does not refer to a file or the file that is
        /// referred to does not exist..
        /// </returns>
        Guid OpenStreamFor(string pathname);

        /// <summary>
        /// Provides a reference to an instance of <see cref="T:System.IO.TextReader" />
        /// that corresponds to the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// represents a <c>ticket</c> that can be redeemed for a particular
        /// <see cref="T:System.IO.TextReader" /> instance that corresponds to a file
        /// stream.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.TextReader" />
        /// that corresponds to the specified <paramref name="ticket" />, or
        /// <see langword="null" /> if either no corresponding
        /// <see cref="T:System.IO.TextReader" /> can be found in the internal
        /// collection, or if the corresponding <see cref="T:System.IO.TextReader" />
        /// instance has already been disposed or removed from the internal collection.
        /// </returns>
        StreamReader RedeemTicket(Guid ticket);
    }
}