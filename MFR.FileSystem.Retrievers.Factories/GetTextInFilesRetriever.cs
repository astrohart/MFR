using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that represents an object that is capable of retrieving the list of
    /// all those files on the filesystem that contain a specific text pattern.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetTextInFilesRetriever
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
        /// interface that represents an object that is capable of retrieving the list of
        /// all those files on the filesystem that contain a specific text pattern.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => TextInFilesRetriever.Instance;
    }
}