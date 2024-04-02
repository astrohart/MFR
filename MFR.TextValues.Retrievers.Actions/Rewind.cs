using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.TextValues.Retrievers.Actions
{
    /// <summary>
    /// Exposes static methods to rewind, e.g., set the file pointer to the beginning,
    /// file streams.
    /// </summary>
    public static class Rewind
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
        /// Rewinds the file stream, e.g., moves its file pointer back to the beginning of
        /// the file and releases all buffered data, that corresponds to the specified
        /// <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> that identifies
        /// the file stream to be rewound.
        /// </param>
        /// <remarks>
        /// This method does nothing if the <paramref name="ticket" />  is set to the Zero
        /// GUID, or if the corresponding file stream's file pointer already points to the
        /// beginning of the file.
        /// <para />
        /// This method will do a cursory refresh of any buffered data, regardless of
        /// whether the stream ends up needing to be rewound or not.
        /// </remarks>
        public static void FileStream(Guid ticket)
        {
            try
            {
                if (ticket.IsZero()) return;

                FileHostProvider.RewindStream(ticket);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}