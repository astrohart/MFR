using MFR.FileSystem.Filters.Interfaces;

namespace MFR.FileSystem.Filters.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.FileSystem.Filters.Interfaces.IFolderFilter" /> interface.
    /// </summary>
    /// <remarks>
    /// Such an object has the ability to determine whether certain facts are
    /// true about folders and files.
    /// </remarks>
    public static class Folder
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Filters.Interfaces.IFolderFilter" /> interface and
        /// returns a reference to it.
        /// <para />
        /// The folder filter object obtained is set to search in the specified
        /// <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder to be searched.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Filters.Interfaces.IFolderFilter" /> interface that
        /// can be used for searching.
        /// </returns>
        public static IFolderFilter HavingPath(string path)
            => new FolderFilter(path);
    }
}