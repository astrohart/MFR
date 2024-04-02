using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.TextValues.Retrievers.Actions
{
    /// <summary>
    /// Exposes static methods to release system resources.
    /// </summary>
    public static class Dispose
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
        /// Releases the open file stream that is referred to by the specified
        /// <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> that identifies
        /// the file stream to be closed.
        /// </param>
        /// <remarks>
        /// The reference to the closed file stream is itself removed from the
        /// internal collection of streams; therefore, after this method returns, the
        /// specified <paramref name="ticket" />  is no longer redeemable.
        /// </remarks>
        public static void FileStream(Guid ticket)
        {
            try
            {
                if (ticket.IsZero()) return;

                FileHostProvider.DisposeObject(ticket);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}