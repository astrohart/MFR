using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that searches a particular directory tree of the file system for the
    /// pathnames of any Visual Studio Solution (<c>*.sln</c>) files that may be
    /// present within it.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetSolutionFilePathRetriever
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
        /// interface that searches a particular directory tree of the file system for the
        /// pathnames of any Visual Studio Solution (<c>*.sln</c>) files that may be
        /// present within it.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => SolutionFilePathRetriever.Instance;
    }
}