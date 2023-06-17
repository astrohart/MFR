using MFR.File.Stream.Providers.Events;
using MFR.File.Stream.Providers.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.File.Stream.Providers
{
    /// <summary>
    /// Manages a collection of file streams open on a large group of text files.
    /// <para />
    /// Allows disparate parts of the application to access these file streams through
    /// a ticket system.
    /// </summary>
    public class FileStreamProvider : IFileStreamProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FileStreamProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FileStreamProvider() { }

        /// <summary>
        /// Gets the count of file streams that are currently available.
        /// </summary>
        public int Count
            => InternalFileStreamCollection.Count;

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        public static IFileStreamProvider Instance
        {
            get;
        } = new FileStreamProvider();

        /// <summary>
        /// Dictionary that maps a <see cref="T:System.Guid" /> value (serving as a
        /// <c>ticket</c>) to a reference to an instance of
        /// <see cref="T:System.IO.StreamReader" /> that can be used to access a text file.
        /// </summary>
        private IDictionary<Guid, StreamReader> InternalFileStreamCollection
        {
            get;
        } = new Dictionary<Guid, StreamReader>();

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Object" /> that is to be
        /// used for thread synchronization.
        /// </summary>
        public object SyncRoot
        {
            get;
        } = new object();

        /// <summary>
        /// Raised when the value of the
        /// <see cref="P:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.Count" />
        /// property has been updated.
        /// </summary>
        public event EventHandler CountChanged;

        /// <summary>
        /// Raised when any of the file streams that are managed by this object are
        /// disposed by it.
        /// </summary>
        public event FileStreamDisposedEventHandler FileStreamDisposed;

        /// <summary>
        /// Raised when this object has successfully processed a request to open a stream
        /// on a particular file.
        /// </summary>
        public event FileStreamOpenedEventHandler FileStreamOpened;

        /// <summary>
        /// Occurs when a <c>FileStream</c> is about to be opened upon a particular file.
        /// </summary>
        public event FileStreamOpeningEventHandler FileStreamOpening;

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
        public void BatchDispose(IReadOnlyCollection<Guid> tickets)
        {
            try
            {
                if (tickets == null || !tickets.Any()) return;
                if (tickets.All(ticket => Guid.Empty.Equals(ticket)))
                    return;
                if (!tickets.Intersect(InternalFileStreamCollection.Keys)
                            .Any())
                    return;

                foreach (var ticket in tickets)
                    DisposeStream(ticket);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

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
        public IReadOnlyCollection<Guid> BatchOpenStreams(
            IReadOnlyCollection<string> pathnames
        )
        {
            var result = new List<Guid>();

            try
            {
                if (pathnames == null || !pathnames.Any()) return result;

                result.AddRange(pathnames.Select(OpenStreamFor));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<Guid>();
            }

            return result;
        }

        /// <summary>
        /// Removes all allocated <see cref="T:System.IO.StreamReader" /> instances
        /// allocated thus far, from memory, and frees resources associated with them.
        /// </summary>
        /// <remarks>After calling this method, all tickets will be invalid.</remarks>
        public void DisposeAll()
        {
            try
            {
                if (!InternalFileStreamCollection.Any()) return;

                // Read the keys backwards
                foreach (var ticket in InternalFileStreamCollection.Keys
                             .Reverse())
                    DisposeStream(ticket, false);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
            finally
            {
                if (Count > 0)
                    InternalFileStreamCollection
                        .Clear(); // get rid of any stragglers
            }
        }

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
        public void DisposeStream(Guid ticket, bool remove = true)
        {
            try
            {
                if (Guid.Empty.Equals(ticket)) return;
                lock (SyncRoot)
                {
                    if (!InternalFileStreamCollection.ContainsKey(ticket))
                        return;

                    var correspondingReader =
                        InternalFileStreamCollection[ticket];
                    if (correspondingReader == null)
                        return;

                    var pathname = ((FileStream)correspondingReader.BaseStream)
                        .Name;

                    correspondingReader.Close();
                    correspondingReader.Dispose();

                    if (remove)
                        InternalFileStreamCollection.Remove(ticket);

                    OnFileStreamDisposed(
                        new FileStreamDisposedEventArgs(pathname, ticket)
                    );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Opens a file stream, represented by a <see cref="T:System.IO.StreamReader" />
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
        public Guid OpenStreamFor(string pathname)
        {
            var result = Guid.Empty;
            StreamReader newReader = default;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Alphaleonis.Win32.Filesystem.File.Exists(pathname))
                    return result;

                lock (SyncRoot)
                {
                    OnFileStreamOpening(
                        new FileStreamOpeningEventArgs(pathname)
                    );

                    // Create a ticket that can be used to access this file stream
                    result = Guid.NewGuid();

                    newReader = new StreamReader(pathname);
                    if (newReader == null)
                        OnFileStreamOpenFailed(
                            new FileStreamOpenFailedEventArgs(
                                pathname,
                                new Exception(
                                    $"Failed to open a new FileStream upon the file '{pathname}'."
                                )
                            )
                        );

                    InternalFileStreamCollection[result] = newReader;

                    OnFileStreamOpened(
                        new FileStreamOpenedEventArgs(
                            pathname, newReader, result
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnFileStreamOpenFailed(
                    new FileStreamOpenFailedEventArgs(pathname, ex)
                );

                result = Guid.Empty;

                newReader
                    ?.Dispose(); // attempt to dispose the new file stream in the event that open failed.
            }

            return result;
        }

        /// <summary>
        /// Provides a reference to an instance of <see cref="T:System.IO.StreamReader" />
        /// that corresponds to the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// represents a <c>ticket</c> that can be redeemed for a particular
        /// <see cref="T:System.IO.StreamReader" /> instance that corresponds to a file
        /// stream.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.StreamReader" />
        /// that corresponds to the specified <paramref name="ticket" />, or
        /// <see langword="null" /> if either no corresponding
        /// <see cref="T:System.IO.StreamReader" /> can be found in the internal
        /// collection, or if the corresponding <see cref="T:System.IO.StreamReader" />
        /// instance has already been disposed or removed from the internal collection.
        /// </returns>
        public StreamReader RedeemTicket(Guid ticket)
        {
            lock (SyncRoot)
            {
                StreamReader result = default;

                try
                {
                    if (Guid.Empty.Equals(ticket)) return result;
                    if (!InternalFileStreamCollection.ContainsKey(ticket))
                        return result;

                    result = InternalFileStreamCollection[ticket];
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = default;
                }

                return result;
            }
        }

        /// <summary>
        /// Occurs when an exception was caught during an attempt to open a
        /// <c>FileStream</c> upon a particular file.
        /// </summary>
        public event FileStreamOpenFailedEventHandler FileStreamOpenFailed;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.FileStreamProvider.CountChanged" />
        /// event.
        /// </summary>
        protected virtual void OnCountChanged()
            => CountChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.FileStreamProvider.FileStreamDisposed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileStreamDisposed(
            FileStreamDisposedEventArgs e
        )
            => FileStreamDisposed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.FileStreamProvider.FileStreamOpened" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileStreamOpened(FileStreamOpenedEventArgs e)
            => FileStreamOpened?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileStreamOpenFailed(
            FileStreamOpenFailedEventArgs e
        )
            => FileStreamOpenFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.FileStreamProvider.FileStreamOpening" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileStreamOpening(FileStreamOpeningEventArgs e)
            => FileStreamOpening?.Invoke(this, e);
    }
}