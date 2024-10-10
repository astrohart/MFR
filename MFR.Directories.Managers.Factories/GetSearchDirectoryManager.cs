using MFR.Directories.Managers.Interfaces;

namespace MFR.Directories.Managers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
    /// interface.
    /// </summary>
    public static class GetSearchDirectoryManager
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </returns>
        public static ISearchDirectoryManager SoleInstance()
            => SearchDirectoryManager.Instance;
    }
}