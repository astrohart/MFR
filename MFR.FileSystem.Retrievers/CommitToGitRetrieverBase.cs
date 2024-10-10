using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Files;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// <c>File and Folder File System Entry List Retriever</c> objects that search for
    /// folders containing local Git repositories.
    /// </summary>
    public abstract class
        CommitToGitRetrieverBase :
        FileAndFolderNameFileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// A <see cref="T:System.IO.SearchOption" /> value to be utilized for
        /// file-system searches.
        /// </summary>
        protected override SearchOption SearchOption
        {
            get;
            set;
        } = SearchOption.TopDirectoryOnly;

        /// <summary>
        /// Gets or sets a string that contains a wildcard search pattern.
        /// </summary>
        /// <remarks>
        /// This property may have a blank or <see langword="null" /> value. The
        /// default value of this property is nominally an asterisk; however,
        /// classes that implement this interface may specify something different.
        /// </remarks>
        protected override string SearchPattern
        {
            get;
            set;
        } = ".git";

        /// <summary>
        /// Gets a list of the files that match the criteria specified by this
        /// object and that correspond to the type of operation being performed.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of the folder in
        /// which to start the search.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// Collection of instances of objects that implement the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that correspond to the file system entries that match the
        /// criteria specified.
        /// </returns>
        /// <remarks>
        /// Implementers of this method have a guarantee that the
        /// <paramref
        ///     name="rootFolderPath" />
        /// parameter contains a fully-qualified
        /// pathname of a folder that exists on the file system, and that the
        /// <see
        ///     cref="P:MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfig" />
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no config data is attached to this object.
        /// </exception>
        protected override IReadOnlyCollection<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(
                string rootFolderPath,
                Predicate<string> pathFilter = null
            )
        {
            var result = new ConcurrentBag<IFileSystemEntry>();

            try
            {
                var folderSet = Enumerate.Directories(
                    rootFolderPath, SearchPattern, SearchOption
                    /* pathFilter is ignored. */
                );

                /*
                 * ASSUME that this FileAndFolderNameFileSystemEntryListRetriever is set to
                 * locate those folders whose names are '.git'.  We wish to return the
                 * containing folder of each '.git' folder.
                 */

                Parallel.ForEach(
                    folderSet, path =>
                    {
                        var parentOfPath = Parent.Of(path);
                        if (!Does.FolderExist(parentOfPath)) return;

                        var entry =
                            MakeNewFileSystemEntry.ForPath(parentOfPath);
                        if (entry == null) return;

                        result.Add(entry);
                    }
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new ConcurrentBag<IFileSystemEntry>();
            }

            return result;
        }
    }
}