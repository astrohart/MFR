using MFR.Detectors.Constants;
using MFR.Detectors.Models.Interfaces;
using System;

namespace MFR.Detectors.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that can
    /// detect the difference between ASCII (non-Unicode) and binary-formatted files..
    /// </summary>
    public interface IFileFormatDetector
    {
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
        IFileFormatDetectionResult DetectFileFormat(string pathname);

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
        IFileFormatDetectionResult DetectFileFormat(
            string pathname,
            Guid ticket
        );

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
        DetectedFileFormat DetectFileFormat(Guid ticket);
    }
}