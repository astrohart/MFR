using MFR.Detectors.Constants;

namespace MFR.Detectors.Models
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// characterizes the detection of the format of a file..
    /// </summary>
    public interface IFileFormatDetectionResult
    {
        /// <summary>
        /// Gets or sets one of the
        /// <see cref="T:MFR.Detectors.Constants.DetectedFileFormat" /> enumeration values
        /// that indicates the detected format of the file.
        /// </summary>
        DetectedFileFormat FileFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the file is a binary file, ASCII text file, or
        /// an unknown format.
        /// </summary>
        bool IsBinary
        {
            get;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file on the disk.
        /// </summary>
        string Pathname
        {
            get;
            set;
        }
    }
}