using MFR.File.Hosts.Factories;
using MFR.File.Hosts.Interfaces;
using MFR.File.Stream.Providers.Events;
using MFR.File.Stream.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Collections;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;
using xyLOGIX.TicketedProvider;
using xyLOGIX.TicketedProvider.Events;

namespace MFR.File.Stream.Providers
{
    /// <summary>
    /// Manages a collection of file streams open on a large group of text files.
    /// <para />
    /// Allows disparate parts of the application to access these file streams through
    /// a ticket system.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class FileHostProvider : TicketedObjectProviderBase<IFileHost>,
        IFileHostProvider
    {
        /// <summary>
        /// Dictionary that implements the internal collection.
        /// </summary>
        [Reference]
        private readonly IDictionary<Guid, IFileHost> _internalCollection =
            new ObservableDictionary<Guid, IFileHost>();

        /// <summary>
        /// Sets up a 1-to-1 correspondence between a file's pathname and a ticket that is
        /// created for it.
        /// </summary>
        [Reference]
        private readonly IDictionary<string, Guid> _mapOfPathnamesToTickets =
            new ObservableDictionary<string, Guid>();

        /// <summary>
        /// Sets up a 1-to-1 correspondence between a specific file stream ticket and the
        /// fully-qualified pathname of the associated file on the file system.
        /// </summary>
        [Reference]
        private readonly IDictionary<Guid, string> _mapOfTicketsToPathnames =
            new ObservableDictionary<Guid, string>();

        /// <summary>
        /// Keeps track of whether this object has been disposed.
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FileHostProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FileHostProvider() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileHostProvider" />
        /// interface.
        /// </summary>
        public static IFileHostProvider Instance
        {
            get;
        } = new FileHostProvider();

        /// <summary>
        /// Gets a reference to an internal dictionary to be used for storing items.
        /// </summary>
        /// <remarks>
        /// Child classes must statically initialize this property with an
        /// instance of
        /// <see cref="T:xyLOGIX.Collections.ObservableDictionary`2" />.
        /// </remarks>
        protected override IDictionary<Guid, IFileHost> InternalCollection
            => _internalCollection;

        /// <summary>
        /// Gets a value indicating whether this object has been disposed.
        /// </summary>
        /// <remarks>
        /// If the value of this property is set to <see langword="true" />, then
        /// the
        /// <see cref="E:xyLOGIX.TicketedProvider.TicketedObjectProviderBase`1.Disposed" />
        /// event is raised.
        /// </remarks>
        public override bool IsDisposed
        {
            get => _disposed;
            protected set {
                var changed = value && !_disposed.Equals(value);
                _disposed = value;
                if (changed) OnDisposed();
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the most-recently
        /// removed pathname of a file stream mapped to a given ticket.
        /// </summary>
        /// <remarks>This property is for internal use only.</remarks>
        private string LastPathnameRemoved
        {
            get;
            set;
        }

        /// <summary>
        /// Sets up a 1-to-1 correspondence between a file's pathname and a ticket that is
        /// created for it.
        /// </summary>
        private IDictionary<string, Guid> MapOfPathnamesToTickets
            => _mapOfPathnamesToTickets;

        /// <summary>
        /// Sets up a 1-to-1 correspondence between a specific file stream ticket and the
        /// fully-qualified pathname of the associated file on the file system.
        /// </summary>
        private IDictionary<Guid, string> MapOfTicketsToPathnames
            => _mapOfTicketsToPathnames;

        /// <summary>
        /// Gets a reference to an instance of an object that is to be used for thread
        /// synchronization purposes.
        /// </summary>
        private static object SyncRoot
        {
            get;
        } = new object();

        /// <summary>
        /// Occurs when an exception was caught during an attempt to open a
        /// <c>FileStream</c> upon a particular file.
        /// </summary>
        public event FileHostCreateFailedEventHandler FileHostCreateFailed;

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
            var result = new ConcurrentBag<Guid>();

            try
            {
                if (pathnames == null) return result;
                if (pathnames.ToArray()
                             .Length == 0) return result;

                result =
                    new ConcurrentBag<Guid>(pathnames.Select(OpenStreamFor));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new ConcurrentBag<Guid>();
            }

            return result;
        }

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
        public string GetPathnameForTicket(Guid ticket)
        {
            var result = string.Empty;

            try
            {
                if (ticket.IsZero()) return result;
                if (InternalCollection == null) return result;
                if (InternalCollection.ToArray()
                                      .Length == 0) return result;
                if (MapOfTicketsToPathnames == null) return result;
                if (MapOfTicketsToPathnames.ToArray()
                                           .Length == 0) return result;
                if (!MapOfTicketsToPathnames.TryGetValue(ticket, out result))
                    return result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Given a fully-qualified <paramref name="pathname" /> of a file on the file
        /// system,
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
        public Guid GetTicketForPathname(string pathname)
        {
            var result = Guid.Empty;

            try
            {
                if (InternalCollection == null) return result;
                if (InternalCollection.ToArray()
                                      .Length == 0) return result;

                if (string.IsNullOrWhiteSpace(pathname)) return result;

                if (MapOfPathnamesToTickets == null) return result;
                if (MapOfPathnamesToTickets.ToArray()
                                           .Length == 0) return result;
                if (!MapOfPathnamesToTickets.TryGetValue(pathname, out result))
                    return result;

                /*
                 * OKAY, check whether there is an orphaned pathname-ticket association
                 * present.  This is true if there is/are entry(ies) in the maps of
                 * pathnames to tickets or vice versa, but there is not an open file stream
                 * stored in our internal collection associated with the ticket that
                 * corresponds to the supplied pathname.
                 *
                 * This keeps our bijective maps referentially consistent.
                 */

                if (!result.IsZero() && !InternalCollection.ContainsKey(result))
                {
                    RemovePathnameMappingFor(result);
                    result = Guid.Empty;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Guid.Empty;
            }

            return result;
        }

        /// <summary>
        /// Opens a file stream, represented by a <see cref="T:System.IO.FileHost" />
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
        /// method to access the corresponding file stream, or
        /// <see cref="F:System.Guid.Empty" /> if the file could not be accessed or if the
        /// <paramref name="pathname" /> parameters' argument is the blank or
        /// <see langword="null" /> <see cref="T:System.String" />, or if the
        /// <paramref name="pathname" /> does not refer to a file or the file that is
        /// referred to does not exist.
        /// </returns>
        /// <remarks>
        /// If the file having the specified <paramref name="pathname" /> already
        /// has a stream opened upon it, then the ticket that corresponds to that stream is
        /// returned.
        /// </remarks>
        public Guid OpenStreamFor(string pathname)
        {
            var result = Guid.Empty;
            IFileHost newFileHost = default;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Alphaleonis.Win32.Filesystem.File.Exists(pathname))
                    return result;

                /*
                 * No sense in re-opening a stream on a file for which a stream is already open.
                 */

                if (FileStreamAlreadyOpenedFor(pathname))
                    return GetTicketForPathname(pathname);

                lock (SyncRoot)
                {
                    var fileEncoding = Determine.FileEncoding(pathname);
                    newFileHost = MakeNewFileHost.ForPath(pathname)
                                                 .HavingEncoding(fileEncoding)
                                                 .AndStream(
                                                     Measure.FileLength(
                                                         pathname
                                                     ) > 0L
                                                         ? Alphaleonis.Win32
                                                             .Filesystem.File
                                                             .Open(
                                                                 pathname,
                                                                 FileMode.Open,
                                                                 FileAccess
                                                                     .ReadWrite,
                                                                 FileShare.None
                                                             )
                                                         : System.IO.Stream.Null
                                                 );
                }

                if (newFileHost == null)
                    OnFileHostCreateFailed(
                        new FileHostCreateFailedEventArgs(
                            pathname,
                            new Exception(
                                $"Failed to open a new FileStream upon the file '{pathname}'."
                            )
                        )
                    );

                result = Store(newFileHost);

                OnFileHostCreated(pathname, result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnFileHostCreateFailed(
                    new FileHostCreateFailedEventArgs(pathname, ex)
                );

                result = Guid.Empty;

                newFileHost
                    ?.Dispose(); // attempt to dispose the new file stream in the event that open failed.
            }

            return result;
        }

        /// <summary>
        /// Rewinds the file stream associated with the specified
        /// <paramref name="ticket" />, if any corresponding stream is even present in the
        /// internal collection.
        /// </summary>
        /// <param name="ticket">
        /// A <see cref="T:System.Guid" /> value that corresponds to
        /// the already-open file stream that is to be rewound.
        /// </param>
        /// <remarks>
        /// If successful, this method retrieves the file stream open on a file
        /// that corresponds to the specified <paramref name="ticket" />, and then moves
        /// its file pointer to the beginning of the stream.
        /// <para />
        /// If an I/O exception or other error occurs, if the stream that corresponds to
        /// the specified <paramref name="ticket" /> cannot be obtained from the internal
        /// collection, or if the stream is already positioned at the beginning of the
        /// data, then the method does nothing.
        /// </remarks>
        public void RewindStream(Guid ticket)
        {
            try
            {
                if (ticket.IsZero()) return;

                var fileHost = Redeem(ticket);
                if (!(fileHost.Stream is FileStream fileStream)) return;
                if (fileStream.Position == 0L) return;

                fileStream.Seek(0L, SeekOrigin.Begin);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Rewinds the file stream associated with the specified
        /// <paramref name="fileHost" />, if any corresponding <c>Stream</c> is even open
        /// in the first place.
        /// </summary>
        /// <param name="fileHost">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface, representing
        /// the file host whose <c>Stream</c> is to be rewound.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is provided as the argument of the
        /// <paramref name="fileHost" /> parameter, then this method does nothing.
        /// <para />
        /// If successful, this method retrieves the file stream open on a file that
        /// corresponds to the specified <paramref name="ticket" />, and then moves its
        /// file pointer to the beginning of the stream.
        /// <para />
        /// If an I/O exception or other error occurs, if the <c>Stream</c> that
        /// corresponds to the specified <paramref name="fileHost" /> cannot be obtained
        /// from the internal collection, or if the <c>Stream</c> is already positioned at
        /// the beginning of the data, then the method does nothing.
        /// </remarks>
        public void RewindStream(IFileHost fileHost)
        {
            try
            {
                if (fileHost == null) return;
                if (!(fileHost.Stream is FileStream fileStream)) return;
                if (fileStream.Position == 0L) return;

                fileStream.Seek(0L, SeekOrigin.Begin);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.TicketedProvider.TicketedObjectProviderBase`1.DisposingTicketedObject" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.TicketedProvider.Events.DisposingTicketedObjectEventArgs" />
        /// that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected override void OnDisposingTicketedObject(
            DisposingTicketedObjectEventArgs e
        )
        {
            base.OnDisposingTicketedObject(e);

            LastPathnameRemoved = RemovePathnameMappingFor(e.Ticket);
        }

        /// <summary>
        /// Called when a <c>File Host</c> object instance is freshly created for the file
        /// having the specified <paramref name="pathname" /> and corresponding to the
        /// specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which a new <c>File Host</c> object instance has just
        /// been created.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// corresponds to the new <c>File Host</c>
        /// </param>
        protected virtual void OnFileHostCreated(string pathname, Guid ticket)
            /*
             * Tie together the pathname with the new ticket.
             */
            => CreateTicketToPathnameMapping(pathname, ticket);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileHostCreateFailed(
            FileHostCreateFailedEventArgs e
        )
            => FileHostCreateFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.TicketedProvider.TicketedObjectProviderBase.TicketedObjectDisposalRequested" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:xyLOGIX.TicketedProvider.Events.TicketedObjectDisposalRequestedEventArgs`1" />
        /// that contains the event data.
        /// </param>
        protected override void OnTicketedObjectDisposalRequested(
            TicketedObjectDisposalRequestedEventArgs<IFileHost> e
        )
        {
            base.OnTicketedObjectDisposalRequested(e);

            try
            {
                if (e.ObjectToDispose == null) return;

                e.ObjectToDispose.Dispose();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.TicketedProvider.TicketedObjectProviderBase.TicketedObjectDisposed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.TicketedProvider.Events.TicketedObjectDisposedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected override void OnTicketedObjectDisposed(
            TicketedObjectDisposedEventArgs e
        )
        {
            base.OnTicketedObjectDisposed(e);

            LastPathnameRemoved =
                string.Empty; // clear out the LastPathnameRemoved property since we've used it now
        }

        /// <summary>
        /// Associates the specified <paramref name="pathname" /> with the corresponding
        /// file stream <paramref name="ticket" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of a file on the file system, on which a
        /// file
        /// stream has been opened and which has the specified <paramref name="ticket" />.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> that is the
        /// ticket for the open file stream on the file having the specified
        /// <paramref name="pathname" />.
        /// </param>
        private void CreateTicketToPathnameMapping(string pathname, Guid ticket)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return;
                if (ticket.IsZero()) return;

                if (MapOfTicketsToPathnames == null) return;
                if (MapOfPathnamesToTickets == null) return;

                lock (SyncRoot)
                {
                    MapOfTicketsToPathnames[ticket] = pathname;
                    MapOfPathnamesToTickets[pathname] = ticket;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Determines whether a file stream has already been opened for a file having the
        /// specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that should be checked for having an active file stream
        /// opened on it.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if an open file stream exists on the file
        /// having the specified <paramref name="pathname" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        private bool FileStreamAlreadyOpenedFor(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                var ticket = GetTicketForPathname(pathname);
                if (ticket.IsZero()) return result;

                if (InternalCollection.ToArray()
                                      .Length == 0)
                    return result;

                result = InternalCollection.TryGetValue(ticket, out _);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Breaks the link between a file's fully-qualified pathname and the particular
        /// <paramref name="ticket" /> that can be redeemed for its corresponding file
        /// stream.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that can
        /// ordinarily be redeemed to acquire the stream for a corresponding file.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// fully-qualified pathname of the file upon which the stream corresponding to the
        /// specified <paramref name="ticket" />  was initially opened.
        /// </returns>
        private string RemovePathnameMappingFor(Guid ticket)
        {
            var result = string.Empty;

            try
            {
                result = GetPathnameForTicket(ticket);
                if (string.IsNullOrWhiteSpace(result)) return result;
                if (MapOfTicketsToPathnames == null) return result;
                if (MapOfTicketsToPathnames.ToArray()
                                           .Length == 0) return result;
                if (!MapOfTicketsToPathnames.TryGetValue(ticket, out result))
                    return result;

                lock (SyncRoot)
                    MapOfTicketsToPathnames.Remove(ticket);

                if (MapOfPathnamesToTickets == null) return result;
                if (MapOfPathnamesToTickets.ToArray()
                                           .Length == 0) return result;
                if (!MapOfPathnamesToTickets.TryGetValue(result, out _))
                    return result;

                lock (SyncRoot)
                    MapOfPathnamesToTickets.Remove(result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}