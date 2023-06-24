using MFR.Detectors.Constants;

namespace MFR.Detectors.Models
{
    /// <summary>
    /// Encapsulates the result of running detection on the format of a particular file
    /// on the disk.
    /// </summary>
    public class FileFormatDetectionResult
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