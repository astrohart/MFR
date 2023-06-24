using MFR.Detectors.Models;
using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Factories.Actions;
using System;
using xyLOGIX.Core.Debug;

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
    public class FileFormatDetector
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object is used to retrieve file streams that have already been
        /// opened on files in order to more quickly and efficiently run detection on them.
        /// </remarks>
        private static IFileStreamProvider FileStreamProvider
        {
            get;
        } = GetFileStreamProvider.SoleInstance();

        /// <summary>
        /// Reference to an instance of an object that can be used for thread
        /// synchronization.
        /// </summary>
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
                if (!Does.FileExist(pathname)) return result; s
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        public IFileFormatDetectionResult DetectFileFormat(Guid ticket)
        {
            IFileFormatDetectionResult result = default;

            try
            {
                lock (SyncRoot)
                {
                    // obtain the file stream that corresponds to the ticket and rewind it
                    var stream = FileStreamProvider.RedeemTicket(ticket);
                    if (stream == null) return result;
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

        private Guid GetFileStreamForFile(string pathname)
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