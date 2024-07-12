using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Services.Solutions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Solution Service</c> object.
    /// </summary>
    /// <remarks>
    /// <c>Solution Service</c> objects allow management of Visual Studio Solution
    /// (*.sln) files, such as scanning for them, detecting if they're loaded,
    /// and loading / unloading them in open instances of Visual Studio.
    /// </remarks>
    public interface IVisualStudioSolutionService
    {
        /// <summary>
        /// Gets or sets the fully-qualified pathname of the folder that is to be searched
        /// for <c>.sln</c> files.
        /// </summary>
        string FolderToSearch
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether the folder having path passed in the
        /// <paramref
        ///     name="folder" />
        /// parameter contains any <c>*.sln</c> files that represent
        /// solutions currently loaded by running instances of Visual Studio.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="folder" />
        /// contains <c>*.sln</c> files that are currently loaded by running instances
        /// of Visual Studio; <see langword="false" /> otherwise.
        /// </returns>
        bool ContainsLoadedSolutions(string folder);

        /// <summary>
        /// Scans the folder whose path is provided in the
        /// <paramref
        ///     name="folder" />
        /// parameter for <c>*.sln</c> files, and, for each file
        /// located, determines whether a running instance of Visual Studio has
        /// it loaded.
        /// <para />
        /// If this is so, then information about the loaded solution is
        /// returned as an element of a collection of any other such solutions.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// </param>
        /// <returns>
        /// Read-only list of references to instances of objects that implement
        /// the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface for each instance of Visual Studio that has that solution loaded.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="folder" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:DirectoryNotFoundException">
        /// Thrown if the directory whose fully-qualified path is passed in the
        /// <paramref name="folder" /> parameter cannot be found on the file system.
        /// </exception>
        IReadOnlyList<IVisualStudioSolution> GetLoadedSolutionsInFolder(
            string folder);

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection open at one
        /// time, to load them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represent the solution(s) to be loaded.
        /// </param>
        void LoadAll(IReadOnlyList<IVisualStudioSolution> solutions);

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection not loaded at
        /// one time, to unload them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface which represent the solution(s) to be unloaded.
        /// </param>
        void UnloadAll(IReadOnlyList<IVisualStudioSolution> solutions);

        /// <summary>
        /// Alias for the
        /// <see
        ///     cref="M:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method.
        /// <para />
        /// This serves to make this class more fluent.
        /// </summary>
        /// <returns>
        /// This method returns the same value as the
        /// <see
        ///     cref="M:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method does when a blank value is passed for its input.
        /// </returns>
        bool ContainLoadedSolutions();
    }
}
