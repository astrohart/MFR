using MFR.Renamers.Files.Interfaces;

namespace MFR.Renamers.Files.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
    /// </summary>
    public static class GetFileRenamer
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface, and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </returns>
        public static IFileRenamer SoleInstance()
            => FileRenamer.Instance;
    }
}