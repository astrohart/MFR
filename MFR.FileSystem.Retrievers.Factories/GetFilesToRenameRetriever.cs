using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that globs a directory tree for the set of all files that must be
    /// renamed because their filenames match a search pattern that is defined by the
    /// user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetFilesToRenameRetriever
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
        /// interface that globs a directory tree for the set of all files that must be
        /// renamed because their filenames match a search pattern that is defined by the
        /// user.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => FilesToRenameRetriever.Instance;
    }
}