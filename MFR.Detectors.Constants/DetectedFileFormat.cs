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
        /// We were unable to determine the type of the file.
        /// </summary>
        Unknown = -1
    }
}