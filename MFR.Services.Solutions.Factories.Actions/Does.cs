using MFR.Services.Solutions.Interfaces;
using System.IO;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Services.Solutions.Factories.Actions
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
    /// interface.
    /// </summary>
    /// <remarks>This class is part of a fluent usage pattern and should be retained.</remarks>
    internal static class Does
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface.
        /// </summary>
        private static IVisualStudioSolutionService VisualStudioSolutionService
        {
            get;
        } = GetVisualStudioSolutionService.SoleInstance();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.FolderToSearch" />
        /// property.
        /// </summary>
        /// <param name="folderToSearch">
        /// (Required.) String containing the fully-qualified pathname of the folder to be
        /// searched.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
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

            VisualStudioSolutionService
                .FolderToSearch = folderToSearch;
            return VisualStudioSolutionService;
        }
    }
}