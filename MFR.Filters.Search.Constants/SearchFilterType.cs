namespace MFR.Filters.Search.Constants
{
    /// <summary>
    /// Describes the kind of search filter we have.
    /// </summary>
    public enum SearchFilterType
    {
        /// <summary>
        /// This search filter is meant to include or exclude a folder.
        /// </summary>
        Folder,

        /// <summary>
        /// This search filter is meant to include or exclude a file.
        /// </summary>
        File,

        /// <summary>
        /// This search filter is meant to include or exclude all files
        /// corresponding to a certain glob pattern (e.g., wildcard).
        /// </summary>
        Glob
    }
}