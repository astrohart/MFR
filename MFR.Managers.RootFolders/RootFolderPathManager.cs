using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Validators.Factories;
using MFR.Managers.RootFolders.Events;
using MFR.Managers.RootFolders.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Managers.RootFolders
{
    /// <summary>
    /// Class to manage a collection of root folder paths to iterate over, processing
    /// the find/replace operations for all folders listed in the collection.
    /// </summary>
    public class RootFolderPathManager : IRootFolderPathManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RootFolderPathManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RootFolderPathManager() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Managers.RootFolders.RootFolderPathManager" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RootFolderPathManager Instance
        {
            get;
        } = new RootFolderPathManager();

        /// <summary>
        /// Gets a reference to a collection of instances of objects that implement the
        /// <see cref="T:System.String" /> interface.
        /// <para />
        /// Each object plays the role of a folder from which the operation(s) that are
        /// selected by the user start processing from.
        /// </summary>
        /// <remarks>
        /// A <see cref="T:System.Collections.Generic.HashSet" /> is used as the
        /// implementation of this property.
        /// <para />
        /// The <see cref="T:System.Collections.Generic.HashSet" /> collection is designed
        /// to not allow/list out duplicate entries by default.
        /// </remarks>
        public ICollection<string> RootFolders
        {
            get;
        } = new HashSet<string>();

        /// <summary>
        /// Occurs when a root folder pathname has been added to this object's collection.
        /// </summary>
        public event RootFolderAddedEventHandler RootFolderAdded;

        /// <summary>
        /// Occurs when a root folder pathname has been removed from this object's
        /// collection.
        /// </summary>
        public event RootFolderRemovedEventHandler RootFolderRemoved;

        /// <summary>
        /// Gets a count of the root folder pathnames stored in the collection.
        /// </summary>
        public int Count
            => RootFolders.Count;

        /// <summary>
        /// Adds a root folder path to this object's collection if, and only if, the folder
        /// in question contains a file whose name ends with the <c>.sln</c> extension.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname to the folder whose subfolders should be added.
        /// </param>
        /// <returns>Number of entries added successfully.</returns>
        public int AddFolderIfItContainsASolution(string path)
        {
            // Default return value of this method
            var result = 0;

            if (string.IsNullOrWhiteSpace(path))
                return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = RootFolders.Count;

                if (Enumerate.Files(
                                 path, "*.sln", SearchOption.TopDirectoryOnly
                             )
                             .Any())
                    RootFolders.Add(path);

                result = RootFolders.Count - result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

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
        public int AddSolutionSubFoldersOf(string path)
        {
            // Default return value of this method
            var result = 0;

            if (string.IsNullOrWhiteSpace(path))
                return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = RootFolders.Count;

                AddAll(GetAllSubFoldersThatContainSolutionsIn(path));

                result = RootFolders.Count - result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

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
        public int AddSubFoldersOf(string path)
        {
            // Default return value of this method
            var result = 0;

            if (string.IsNullOrWhiteSpace(path))
                return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = RootFolders.Count;

                AddAll(GetSubFoldersOf(path));

                result = RootFolders.Count - result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Console.WriteLine(ex);
            }

            return result;
        }

        /// <summary>
        /// Clears all elements from the internal collection that this object manages.
        /// </summary>
        public void Clear()
            => RootFolders.Clear();

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
        public int RemoveSolutionSubFoldersOf(string path)
        {
            // Default return value of this method
            var result = 0;

            if (string.IsNullOrWhiteSpace(path))
                return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = RootFolders.Count;

                RemoveAll(GetAllSubFoldersThatContainSolutionsIn(path));

                /*
                 * We expect a drop in the RootFolders.Count from
                 * before, so we do the subtraction in the reverse from
                 * the way the AddSubFolderOf method does it.
                 */

                result -= RootFolders.Count;
            }
            catch (Exception ex)
            {
                // dump all the exception info from the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

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
        public int RemoveSubFoldersOf(string path)
        {
            // Default return value of this method
            var result = 0;

            if (string.IsNullOrWhiteSpace(path))
                return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                var folders = GetSubFoldersOf(path);

                result = RootFolders.Count;

                RemoveAll(folders);

                /*
                 * We expect a drop in the RootFolders.Count from
                 * before, so we do the subtraction in the reverse from
                 * the way the AddSubFolderOf method does it.
                 */

                result -= RootFolders.Count;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Console.WriteLine(ex);
            }

            return result;
        }

        /// <summary>
        /// Obtains a reference to an enumerable collection of all the root folders that
        /// this object manages.
        /// </summary>
        /// <returns>
        /// Enumerable collection of <see cref="T:System.String" />s, all of which
        /// are the pathname to a folder that exists and is where processing is to begin.
        /// </returns>
        public IEnumerable<string> GetAll()
            => RootFolders;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Managers.RootFolders.RootFolderPathManager.RootFolderAdded" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnRootFolderAdded(RootFolderAddedEventArgs e)
            => RootFolderAdded?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Managers.RootFolders.RootFolderPathManager.RootFolderRemoved" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        protected virtual void OnRootFolderRemoved(RootFolderRemovedEventArgs e)
            => RootFolderRemoved?.Invoke(this, e);

        /// <summary>
        /// Retrieves a list of the top-level folders of the folder having the specified
        /// <paramref name="path" />, the criteria for being in the set of returned strings
        /// being that the folder must contain a file whose name ends with the <c>.sln</c>
        /// extension.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname of the folder whose subfolers are to be enumerated.
        /// </param>
        /// <returns>
        /// Collection of strings containing the fully-qualified pathnames of all
        /// top-level subfolders of the folder having the specified
        /// <paramref name="path" /> that contain at least one file whose name has the
        /// extension <c>.sln</c>.
        /// </returns>
        private static IEnumerable<string>
            GetAllSubFoldersThatContainSolutionsIn(string path)
        {
            var result = Enumerable.Empty<string>();

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = GetSubFoldersOf(path)
                    .Where(
                        s => Enumerate.Files(
                                          s, "*.sln",
                                          SearchOption.TopDirectoryOnly
                                      )
                                      .Any()
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }

        /// <summary>
        /// Obtains a reference to a collection of strings that are the fully-qualified
        /// pathnames of the subfolders of the folder having the specified
        /// <paramref name="path" />, to the first level down only.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname of the folder to start searching in.
        /// </param>
        /// <returns>
        /// Collection of strings; this collection is the empty set if an error
        /// occurs or the <paramref name="path" /> parameter is blank, or whose value
        /// refers to a folder that does not exist on the disk; otherwise, a collection of
        /// strings containing the pathnames of all of the top-level subfolders of the
        /// folder having the specified <paramref name="path" /> is returned.
        /// <para />
        /// The empty collection is also returned if an I/O or other operating-system error
        /// occurs during the execution of the search.
        /// </returns>
        private static IEnumerable<string> GetSubFoldersOf(string path)
        {
            var result = Enumerable.Empty<string>();

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = Enumerate.Directories(
                                      path, "*", SearchOption.TopDirectoryOnly
                                  )
                                  .Where(
                                      s => GetFileSystemEntryValidator.For(
                                              OperationType
                                                  .ListTopLevelSubFolders
                                          )
                                          .ShouldNotSkip(s)
                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }

        /// <summary>
        /// Adds all the strings in the <paramref name="folders" /> collection to the
        /// internal collection that is managed by this class.
        /// </summary>
        /// <param name="folders">
        /// (Required.) Reference to an enumerable collection of
        /// strings, each of which is assumed to be a folder.
        /// </param>
        /// <remarks>
        /// If all of the strings in the collection passed are not the paths of folders
        /// that exist, then this method does nothing.
        /// </remarks>
        private void AddAll(IEnumerable<string> folders)
        {
            if (folders == null)
                return;

            if (!folders.Any() || folders.All(s => !Directory.Exists(s)))
                return;

            foreach (var folder in folders.Where(Directory.Exists))
            {
                if (RootFolders.Contains(folder))
                    continue;

                RootFolders.Add(folder);

                OnRootFolderAdded(new RootFolderAddedEventArgs(folder));
            }
        }

        /// <summary>
        /// Removes all the strings in the <paramref name="folders" /> collection from the
        /// internal collection that is managed by this class.
        /// </summary>
        /// <param name="folders">
        /// (Required.) Reference to an enumerable collection of
        /// strings, each of which is assumed to be a folder.
        /// </param>
        /// <remarks>
        /// If all of the strings in the collection passed are not the paths of folders
        /// that exist, then this method does nothing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="folders" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        private void RemoveAll(IEnumerable<string> folders)
        {
            if (folders == null)
                return;

            if (!folders.Any())
                return;

            foreach (var folder in folders)
            {
                if (!RootFolders.Contains(folder))
                    continue;

                RootFolders.Remove(folder);

                OnRootFolderRemoved(new RootFolderRemovedEventArgs(folder));
            }
        }
    }
}
