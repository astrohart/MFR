using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that obtains a list of all those folders in a directory tree whose
    /// names match a search pattern that is specified by the user for the renaming
    /// process.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetFolderToRenameRetriever
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that obtains a list of all those folders in a directory tree whose
        /// names match a search pattern that is specified by the user for the renaming
        /// process.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => FolderToRenameRetriever.Instance;
    }
}