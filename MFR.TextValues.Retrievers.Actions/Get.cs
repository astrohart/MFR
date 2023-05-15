using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Factories.Actions;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.TextValues.Retrievers.Actions
{
    public static class Get
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        private static IFileStreamProvider FileStreamProvider
            => GetFileStreamProvider.SoleInstance();

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
        /// <remarks>
        /// The <paramref name="ticket" /> becomes invalid once this method is
        /// called.
        /// </remarks>
        public static string FileData(Guid ticket)
        {
            var result = string.Empty;

            try
            {
                if (Guid.Empty.Equals(ticket)) return result;

                var stream = FileStreamProvider.RedeemTicket(ticket);
                if (stream == null) return result;

                result = stream.ReadToEnd();

                FileStreamProvider.DisposeStream(ticket);
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