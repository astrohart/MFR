using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
    /// interface that searches a directory tree specified by the user in order to find
    /// a list of the folder(s) containing Visual Studio Solution (<c>*.sln</c>) files.
    /// <para />
    /// These are folders that must be renamed according to the text-replacement
    /// parameters specified by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetSolutionFoldersToRenameRetriever
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
        /// interface that searches a directory tree specified by the user in order to find
        /// a list of the folder(s) containing Visual Studio Solution (<c>*.sln</c>) files.
        /// <para />
        /// These are folders that must be renamed according to the text-replacement
        /// parameters specified by the user.
        /// </returns>
        public static IFileSystemEntryListRetriever SoleInstance()
            => SolutionFoldersToRenameRetriever.Instance;
    }
}