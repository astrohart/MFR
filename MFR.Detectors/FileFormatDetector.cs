using MFR.Detectors.Actions;
using MFR.Detectors.Constants;
using MFR.Detectors.Interfaces;
using MFR.Detectors.Models.Factories;
using MFR.Detectors.Models.Interfaces;
using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Factories.Actions;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Detectors
{
    /// <summary>
    /// A detector of the format of files on the disk.
    /// </summary>
    /// <remarks>
    /// This object can prove useful for the <c>Replace Text in Files</c> operation.
    /// <para />
    /// As it goes without saying that we do not need to text-replacement in a binary
    /// file, we use this object to screen out those files that would not make sense to
    /// be included in a <c>Replace Text in Files</c> operation.
    /// </remarks>
    public class FileFormatDetector : IFileFormatDetector
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FileFormatDetector() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FileFormatDetector() { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object is used to retrieve file streams that have already been
        /// opened on files in order to more quickly and efficiently run detection on them.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static IFileStreamProvider FileStreamProvider
        {
            get;
        } = GetFileStreamProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Detectors.Interfaces.IFileFormatDetector" /> interface.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IFileFormatDetector Instance
        {
            get;
        } = new FileFormatDetector();

        /// <summary>
        /// Reference to an instance of an object that can be used for thread
        /// synchronization.
        /// </summary>
        [Log(AttributeExclude = true)]
        private static object SyncRoot
        {
            get;
        } = new object();

        /// <summary>
        /// Examines the file having the specified <paramref name="pathname" /> and
        /// attempts to determine its format (binary or ASCII).
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the file to have detection run on it.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Detectors.Models.IFileFormatDetectionResult" /> interface that
        /// contains data on the file's format.
        /// </returns>
        public IFileFormatDetectionResult DetectFileFormat(string pathname)
        {
            IFileFormatDetectionResult result = default;

            try
            {
                if (!Does.FileExist(pathname)) return result;

                var ticket = GetFileStreamForFile(pathname);
                if (Guid.Empty == ticket) return result;

                result = DetectFileFormat(pathname, ticket);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Examines the file having the specified <paramref name="pathname" /> and
        /// attempts to determine its format (binary or ASCII).
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the file to have detection run on it.
        /// </param>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that is
        /// used to access the file stream that is open on the desired file.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Detectors.Models.IFileFormatDetectionResult" /> interface that
        /// contains data on the file's format.
        /// </returns>
        public IFileFormatDetectionResult DetectFileFormat(
            string pathname,
            Guid ticket
        )
        {
            IFileFormatDetectionResult result = default;

            try
            {
                lock (SyncRoot)
                {
                    FileStreamProvider.RewindStream(ticket);

                    // obtain the file stream that corresponds to the ticket and rewind it
                    var stream = FileStreamProvider.RedeemTicket(ticket);
                    if (stream == null) return result;

                    if (stream.BaseStream.Length <= 0L) return result;

                    result = MakeNewFileFormatDetectionResult.ForFile(
                        FileStreamProvider.GetPathnameForTicket(ticket)
                    );

                    int ch;
                    while ((ch = stream.Read()) != -1)
                        if (Determine.WhetherCharacterIsControlCharacter(ch))
                        {
                            if (result == null) return result;

                            result = result.HavingFileFormat(
                                DetectedFileFormat.Binary
                            );
                            break;
                        }

                    if (result == null) return result;

                    result = result.HavingFileFormat(DetectedFileFormat.ASCII);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Attempts to detect whether the file that is represented by an open file stream
        /// that corresponds to the specified <paramref name="ticket" /> is a binary or
        /// ASCII file.
        /// <para />
        /// NOTE: This method assumes that it is not being passed Unicode files ever.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that is
        /// used to access the file stream that is open on the desired file.
        /// </param>
        /// <returns>
        /// One of the <see cref="T:MFR.Detectors.Constants.DetectedFileFormat" />
        /// enumeration values that corresponds to the detected format of the file.
        /// </returns>
        /// <remarks>
        /// Callers must call the
        /// <see
        ///     cref="M:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RewindStream" />
        /// method on the specified <paramref name="ticket" /> before the stream is read
        /// from again.
        /// </remarks>
        public DetectedFileFormat DetectFileFormat(Guid ticket)
        {
            var result = DetectedFileFormat.Unknown;

            try
            {
                if (ticket.IsZero()) return result;

                FileStreamProvider.RewindStream(ticket);

                var stream = FileStreamProvider.RedeemTicket(ticket);
                if (stream == null) return result;

                int ch;
                while ((ch = stream.Read()) != -1)
                    if (Determine.WhetherCharacterIsControlCharacter(ch))
                    {
                        result = DetectedFileFormat.Binary;
                        return result;
                    }

                result = DetectedFileFormat.ASCII;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = DetectedFileFormat.Unknown;
            }

            return result;
        }

        /// <summary>
        /// Attempts to look up the <c>ticket</c> for the file stream that has been opened
        /// on the file having the specified <paramref name="pathname" />.
        /// <para />
        /// If a stream has not been opened on the file, then one is opened for it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which a file-stream ticket is to be retrieved.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Guid" /> value that serves as the <c>ticket</c>
        /// for the file stream that has been opened on the file having the specified
        /// <paramref name="pathname" />.
        /// </returns>
        /// <remarks>
        /// If the file having the specified <paramref name="pathname" /> could
        /// not be opened, or does not exist, or if another error occurs, then the
        /// <see cref="F:System.Guid.Empty" /> value is returned.
        /// </remarks>
        private static Guid GetFileStreamForFile(string pathname)
        {
            var result = Guid.Empty;

            try
            {
                // this call won't open a duplicate stream on the
                // file if one is already open.
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