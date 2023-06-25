namespace MFR.Renamers.Files.Constants
{
    /// <summary>
    /// Specialized data that is to be returned in the event that a file meets certain
    /// criteria, but we do not want to halt an operation.
    /// </summary>
    public static class SpecializedFileData
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains a specialized GUID that
        /// substitutes for file data of a binary file, so that we can skip these files
        /// without failing the overall operation..
        /// </summary>
        public const string BinaryFileData =
            "197cce64-a5d0-4129-a959-89803191c09f";
    }
}