namespace MFR.Detectors.Constants
{
    /// <summary>
    /// Values that specify the format of a file that we have ascertained from looking
    /// at some of the bytes of the file.
    /// </summary>
    public enum DetectedFileFormat
    {
        /// <summary>
        /// The file seems to be ASCII format.
        /// </summary>
        ASCII,

        /// <summary>
        /// The file has been detected to be a binary format.
        /// </summary>
        Binary,

        /// <summary>
        /// We were unable to determine the format of the file.
        /// </summary>
        /// <remarks>
        /// When a file-format detection yields a value of
        /// <see cref="F:MFR.Detectors.Constants.DetectedFileFormat.Unknown" />, the file
        /// should be assumed by calling code to have a Binary file format.
        /// <para/>
        /// How this value is handled is application-specific.
        /// </remarks>
        Unknown = -1
    }
}