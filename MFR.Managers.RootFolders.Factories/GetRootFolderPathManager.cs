using MFR.Managers.RootFolders.Interfaces;

namespace MFR.Managers.RootFolders.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager" />
    /// interface.
    /// </summary>
    public static class GetRootFolderPathManager
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager" />
        /// interface.
        /// </returns>
        public static IRootFolderPathManager SoleInstance()
            => RootFolderPathManager.Instance;
    }
}