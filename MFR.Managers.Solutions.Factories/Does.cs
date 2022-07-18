using MFR.Managers.Solutions.Interfaces;
using System.IO;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Managers.Solutions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService" />
    /// interface.
    /// </summary>
    public static class Does
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.FolderToSearch" />
        /// property.
        /// </summary>
        /// <param name="folderToSearch">
        /// (Required.) String containing the fully-qualified pathname of the folder to be
        /// searched.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the <paramref name="folderToSearch" /> parameter is passed a value
        /// that is not the fully-qualified pathname of a folder that actually exists on
        /// the disk.
        /// </exception>
        public static IVisualStudioSolutionService Folder(string folderToSearch)
        {
            if (!Directory.Exists(folderToSearch))
                throw new DirectoryNotFoundException(
                    $"The folder '{folderToSearch}' cannot be located."
                );

            SoleInstance()
                .FolderToSearch = folderToSearch;
            return SoleInstance();
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        internal static IVisualStudioSolutionService SoleInstance()
            => VisualStudioSolutionService.Instance;
    }
}
