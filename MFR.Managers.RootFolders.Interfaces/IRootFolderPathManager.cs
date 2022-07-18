using MFR.Managers.RootFolders.Events;
using System.Collections.Generic;

namespace MFR.Managers.RootFolders.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages a
    /// collection of the paths to the root folders from which to start the
    /// operation(s) desired by the user.
    /// </summary>
    public interface IRootFolderPathManager
    {
        /// <summary>
        /// Occurs when a root folder pathname has been added to this object's collection.
        /// </summary>
        event RootFolderAddedEventHandler RootFolderAdded;

        /// <summary>
        /// Occurs when a root folder pathname has been removed from this object's
        /// collection.
        /// </summary>
        event RootFolderRemovedEventHandler RootFolderRemoved;

        /// <summary>
        /// Gets a count of the root folder pathnames stored in the collection.
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// Adds a root folder path to this object's collection if, and only if, the folder
        /// in question contains a file whose name ends with the <c>.sln</c> extension.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname to the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        int AddFolderIfItContainsASolution(string path);

        /// <summary>
        /// Adds a root folder path to this object's collection if, and only if, the folder
        /// in question contains a file whose name ends with the <c>.sln</c> extension,
        /// among the subfolders of the folder whose <paramref name="path" /> is specified.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname to the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        int AddSolutionSubFoldersOf(string path);

        /// <summary>
        /// Adds the subfolder(s) of the folder having the specified path (except folders
        /// such as <c>.vs</c>, <c>.git</c>, other dotfolder, and <c>packages</c> etc.) to
        /// the collection that this object manages.
        /// <para />
        /// This method just uses the folders in the topmost level of the directory tree.
        /// </summary>
        /// <param name="path">
        /// (Required). String containing the fully-qualified pathname
        /// of the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        int AddSubFoldersOf(string path);

        /// <summary>
        /// Clears all elements from the internal collection that this object manages.
        /// </summary>
        void Clear();

        /// <summary>
        /// Obtains a reference to an enumerable collection of all the root folders that
        /// this object manages.
        /// </summary>
        /// <returns>
        /// Enumerable collection of <see cref="T:System.String" />s, all of which
        /// are the pathname to a folder that exists and is where processing is to begin.
        /// </returns>
        IEnumerable<string> GetAll();

        /// <summary>
        /// Removes a root folder path from this object's collection if, and only if, the
        /// folder
        /// in question contains a file whose name ends with the <c>.sln</c> extension, and
        /// it's
        /// already a member of the internal collection.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname from the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        int RemoveSolutionSubFoldersOf(string path);

        /// <summary>
        /// Removes the subfolder(s) of the folder having the specified path (except
        /// folders
        /// such as <c>.vs</c>, <c>.git</c>, other dotfolder, and <c>packages</c> etc.)
        /// from
        /// the collection that this object manages.
        /// <para />
        /// This method just uses the folders in the topmost level of the directory tree.
        /// </summary>
        /// <param name="path">
        /// (Required). String containing the fully-qualified pathname
        /// of the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        int RemoveSubFoldersOf(string path);
    }
}
