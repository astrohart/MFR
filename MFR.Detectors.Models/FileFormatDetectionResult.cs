using MFR.Detectors.Constants;
using MFR.Detectors.Models.Interfaces;
using System;

namespace MFR.Detectors.Models
{
    /// <summary>
    /// Encapsulates the result of running detection on the format of a particular file
    /// on the disk.
    /// </summary>
    public class FileFormatDetectionResult : IFileFormatDetectionResult
    {
        /// <summary>
        /// Gets or sets one of the
        /// <see cref="T:MFR.Detectors.Constants.DetectedFileFormat" /> enumeration values
        /// that indicates the detected format of the file.
        /// </summary>
        public DetectedFileFormat FileFormat
        {
            get;
            set;
        } = DetectedFileFormat.Unknown;

        /// <summary>
        /// Gets or sets a <see cref="T:System.Guid" /> value that serves as a
        /// <c>FileStreamProvider</c> ticket.
        /// </summary>
        /// <remarks>
        /// Sometimes, detection may have been run on an already-open file stream
        /// stored in the internal collection of the object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface instead of its pathname.
        /// <para />
        /// This property serves to help applications map the detection result to a ticket
        /// rather than a pathname.  Either this property or the
        /// <see cref="P:MFR.Detectors.Models.FileFormatDetectionResult.Pathname" />
        /// property will be filled in, but it is a rare occurrence that both are
        /// specified.
        /// </remarks>
        public Guid FileStreamTicket
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the file is a binary file, ASCII text file, or
        /// an unknown format.
        /// </summary>
        public bool IsBinary
            => FileFormat == DetectedFileFormat.Binary ||
               FileFormat == DetectedFileFormat.Unknown;

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file on the disk.
        /// </summary>
        public string Pathname
        {
            get;
            set;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => $"File path: '{Pathname}', Format: '{FileFormat}'";
    }
}