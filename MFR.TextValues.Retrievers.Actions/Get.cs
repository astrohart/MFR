using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.TextValues.Retrievers.Synchronization.Factories;
using MFR.TextValues.Retrievers.Synchronization.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;

namespace MFR.TextValues.Retrievers.Actions
{
    /// <summary>
    /// Exposes static methods, e.g., to retrieve data from text files.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        private static IFileStreamProvider FileStreamProvider
        {
            get;
        } = GetFileStreamProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
        /// interface.
        /// </summary>
        private static ISemaphoreLocker SemaphoreLocker
        {
            get;
        } = GetSemaphoreLocker.SoleInstance();

        private static SemaphoreSlim StreamReadSemaphore
        {
            get;
        } = new SemaphoreSlim(0);

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Object" /> that is to be
        /// used for thread synchronization.
        /// </summary>
        private static object SyncRoot
        {
            get;
        } = new object();

        /// <summary>
        /// Extracts the data from the file having a stream open on it that corresponds to
        /// the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// serves a <c>ticket</c> that can be used to extract the data from a stream that
        /// is open on the corresponding file.
        /// </param>
        /// <param name="dispose">
        /// (Optional.) Indicates whether the underlying file stream
        /// should be disposed when this method has finished executing;
        /// <see langword="false" /> is the default.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the content of the
        /// corresponding file, or <see cref="F:System.String.Empty" /> if the content
        /// could not be obtained.
        /// </returns>
        [return: NotLogged]
        public static string FileData(Guid ticket, bool dispose = false)
        {
            var result = string.Empty;

            lock (SyncRoot)
                try
                {
                    if (ticket.IsZero()) return result;

                    FileStreamProvider.RewindStream(ticket); // just in case

                    /*
                     * OKAY, we were passed a GUID that serves as a "ticket" or "coupon"
                     * that we "redeem" with the FileStreamProvider object to get a reference
                     * to a FileStream object that had been opened on the file previously.
                     *
                     */
                    var stream = FileStreamProvider.Redeem(ticket);
                    if (stream == null) return result;

                    result = stream.ReadToEnd();

                    FileStreamProvider.RewindStream(ticket);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }
                finally
                {
                    if (dispose) 
                        Dispose.FileStream(ticket);
                }

            return result;
        }

        /// <summary>
        /// Extracts the data from the file having a stream open on it that corresponds to
        /// the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// serves a <c>ticket</c> that can be used to extract the data from a stream that
        /// is open on the corresponding file.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the content of the
        /// corresponding file, or <see cref="F:System.String.Empty" /> if the content
        /// could not be obtained.
        /// </returns>
        [return: NotLogged]
        public static async Task<string> FileDataAsync(
            Guid ticket
            )
        {
            var result = string.Empty;
            StreamReader sr = default;

            try
            {
                result = await SemaphoreLocker.LockAsync(
                    async () =>
                    {
                        if (ticket.IsZero()) return result;

                        /*
                         * OKAY, we were passed a GUID that serves as a "ticket" or "coupon"
                         * that we "redeem" with the FileStreamProvider object to get a reference
                         * to a FileStream object that had been opened on the file previously.
                         *
                         * This FileStream object provides the service of asynchronously reading
                         * the file's content so that the application can perform faster.
                         */

                        sr = FileStreamProvider.Redeem(ticket);
                        if (sr == null) return result;



                        return result;
                    }
                );
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
        /// Gets a <see cref="T:System.Guid" /> value that serves as a <c>ticket</c> that
        /// can be later used to extract the data from the file having the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that is the
        /// fully-qualified pathname of a file upon which to open a file stream.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Guid" /> value that serves as a <c>ticket</c>
        /// that can be later used to extract the data from the file having the specified
        /// <paramref name="pathname" />, or <see cref="T:System.Guid.Empty" /> if a stream
        /// could not be opened on the specified file, or some other error occurred.
        /// </returns>
        public static Guid FileTicket(string pathname)
        {
            var result = Guid.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Does.FileSystemEntryExist(pathname)) return result;
                if (Is.Folder(pathname)) return result;

                result = FileStreamProvider.OpenStreamFor(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Guid.Empty;
            }

            return result;
        }
    }
}