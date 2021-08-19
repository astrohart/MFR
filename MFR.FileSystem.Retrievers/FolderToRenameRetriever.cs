using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves lists of file-system entries that should be processed by an
    /// operation that wants to rename the files in a folder and its subfolders.
    /// </summary>
    public class
        FolderToRenameRetriever :
            FileAndFolderNameFileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FolderToRenameRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FolderToRenameRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.FileSystem.Retrievers.FolderToRenameRetriever" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FolderToRenameRetriever Instance
        {
            get;
        } = new FolderToRenameRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameSubFolders;

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
        ///     cref="P:MFR.ConfigurationComposedObjectBase.Configuration" />
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:MFR.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null)
        {
            var result = Enumerable.Empty<IFileSystemEntry>();

            try
            {
                result = Directory.EnumerateDirectories(
                                      rootFolderPath, SearchPattern,
                                      SearchOption
                                  )
                                  .Where(ShouldNotSkipFileSystemEntry)
                                  .ToList() // narrow down list of elements to process
                                  .Select(MakeNewFileSystemEntry.ForPath)
                                  .Where(
                                      fse => SearchCriteriaMatch(fse) &&
                                             PassesPathFilter(pathFilter, fse)
                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<IFileSystemEntry>();
            }

            return result;
        }
    }
}