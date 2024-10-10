using MFR.Renamers.Files.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Renamers.Files.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
    /// </summary>
    [Log(AttributeExclude = true)]
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