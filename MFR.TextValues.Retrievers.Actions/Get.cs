using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.TextValues.Retrievers.Synchronization.Factories;
using MFR.TextValues.Retrievers.Synchronization.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Text;
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
    [Log(AttributeExclude = true)]
    public static class Get
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileHostProvider" />
        /// interface.
        /// </summary>
        private static IFileHostProvider FileHostProvider
        {
            get;
        } = GetFileHostProvider.SoleInstance();

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

                    FileHostProvider.RewindStream(ticket); // just in case

                    /*
                     * OKAY, we were passed a GUID that serves as a "ticket" or "coupon"
                     * that we "redeem" with the FileHostProvider object to get a reference
                     * to a FileStream object that had been opened on the file previously.
                     *
                     */
                    var fileHost = FileHostProvider.Redeem(ticket);
                    if (fileHost == null) return result;
                    if (fileHost.OriginalLength <= 0L) return result;
                    if (fileHost.Accessor == null) return result;

                    result = ReadTextFromMemory(
                        fileHost.Encoding, fileHost.Accessor,
                        fileHost.OriginalLength
                    );

                    FileHostProvider.RewindStream(ticket);
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
        public static async Task<string> FileDataAsync(Guid ticket)
        {
            var result = string.Empty;
            StreamReader sr = default;

            try
            {
                result = await SemaphoreLocker.LockAsync(
                    async () =>
                    {
                        if (ticket.IsZero()) return result;

                        FileHostProvider.RewindStream(ticket); // just in case

                        /*
                         * OKAY, we were passed a GUID that serves as a "ticket" or "coupon"
                         * that we "redeem" with the FileHostProvider object to get a reference
                         * to a FileStream object that had been opened on the file previously.
                         *
                         */
                        var fileHost = FileHostProvider.Redeem(ticket);
                        if (fileHost == null) return result;
                        if (fileHost.OriginalLength <= 0L) return result;
                        if (fileHost.Accessor == null) return result;

                        result = ReadTextFromMemory(
                            fileHost.Encoding, fileHost.Accessor,
                            fileHost.OriginalLength
                        );

                        FileHostProvider.RewindStream(ticket);
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

                result = FileHostProvider.OpenStreamFor(pathname);
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
        /// Reads text from a memory-mapped file accessor.
        /// </summary>
        /// <param name="encoding">
        /// (Required.) Reference to an instance of <see cref="T:System.Text.Encoding" />
        /// that represents the text encoding of the file.
        /// </param>
        /// <param name="accessor">The memory-mapped file accessor.</param>
        /// <param name="length">The length of the text to read.</param>
        /// <returns>The text read from memory.</returns>
        /// <remarks>
        /// This method reads text from a memory-mapped file accessor and returns it as a
        /// string.
        /// It reads the specified length of bytes from the accessor and decodes them using
        /// UTF-8 encoding.
        /// </remarks>
        private static string ReadTextFromMemory(
            Encoding encoding,
            UnmanagedMemoryAccessor accessor,
            long length
        )
        {
            var result = string.Empty;

            try
            {
                var bytes = new byte[length];
                accessor.ReadArray(0, bytes, 0, (int)length);
                result = encoding.GetString(bytes);
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }
    }
}