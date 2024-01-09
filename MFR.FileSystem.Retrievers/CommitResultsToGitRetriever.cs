using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves lists of file-system entries that should be processed by an
    /// operation that wants to commit the results of the processing of projects to the
    /// various GIt repository(ies) that may be contained within the directory tree of
    /// the starting folder..
    /// </summary>
    public class
        CommitResultsToGitRetriever :
            FileAndFolderNameFileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static CommitResultsToGitRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected CommitResultsToGitRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that represents an object that retrieves the pathname(s) of the
        /// various subfolders of the directory tree of the starting folder, that contain
        /// the various Git repository(ies) that may exist.
        /// </summary>
        public static IFileSystemEntryListRetriever Instance
        {
            get;
        } = new CommitResultsToGitRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.CommitResultsToGit;

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
        /// pathname of a folder that exists on the disk, and that the
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
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(
                string rootFolderPath,
                Predicate<string> pathFilter = null
            )
        {
            var result = new List<IFileSystemEntry>();

            try
            {
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var path in Enumerate.Directories(
                                                  rootFolderPath, SearchPattern,
                                                  SearchOption
                                              )
                                              .AsParallel())
                {
                    var entry =
                        MakeNewFileSystemEntry.ForPath(
                            Path.GetDirectoryName(path)
                        );
                    if (entry == null) continue;

                    result.Add(entry);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<IFileSystemEntry>();
            }

            return result;
        }
    }
}