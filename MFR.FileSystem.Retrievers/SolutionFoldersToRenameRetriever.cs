using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves lists of folders, within the directory tree specified by the user,
    /// that contain Visual Studio Solution (<c>*.sln</c>) files.
    /// <para />
    /// The solution files themselves may have been renamed by the text-replacement
    /// pattern specified by the user; we also need to rename the folder(s) that
    /// contain them accordingly, if any.
    /// </summary>
    public class
        SolutionFoldersToRenameRetriever :
            FileAndFolderNameFileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SolutionFoldersToRenameRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SolutionFoldersToRenameRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that searches a directory tree specified by the user in order to find
        /// a list of the folder(s) containing Visual Studio Solution (<c>*.sln</c>) files.
        /// <para />
        /// These are folders that must be renamed according to the text-replacement
        /// parameters specified by the user.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IFileSystemEntryListRetriever Instance
        {
            get;
        } = new SolutionFoldersToRenameRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSolutionFolders;

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
        } = "*.sln";

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        public override void Reset()
        {
            base.Reset();

            SearchPattern = "*.sln"; // hard-code the SearchPattern to be *.sln
        }

        /// <summary>
        /// Specifies a string that is to be used as the search pattern for
        /// enumerating file-system entries.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The default value is nominally an asterisk; however, classes that
        /// implement this interface may specify something different.
        /// <para />
        /// Child classes can override this method, e.g., to hard-code the search pattern
        /// value.
        /// <para />
        /// NOTE: Calling this method is optional. If this method is not called,
        /// then the default value will be utilized.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="searchPattern" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public override IFileSystemEntryListRetriever UsingSearchPattern(
            string searchPattern
        )
        {
            SearchPattern = "*.sln"; // hard-code the SearchPattern to be *.sln
            return this;
        }

        /// <summary>
        /// Gets a list of the folder(s), if any, that contain Visual Studio Solution (
        /// <c>*.sln</c>) files that match the criteria specified by this object and that
        /// correspond to the type of operation being performed.
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
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(
                string rootFolderPath,
                Predicate<string> pathFilter = null
            )
        {
            var result = new List<IFileSystemEntry>();
            try
            {
                result.AddRange(
                    Enumerate.Files(
                                 rootFolderPath, SearchPattern, SearchOption,
                                 path => ShouldDoPath(path, pathFilter)
                             )
                             .AsParallel()
                             .Select(
                                 filePath
                                     => MakeNewFileSystemEntry.ForPath(
                                         Path.GetDirectoryName(filePath)
                                     )
                             )
                             .Where(
                                 entry => entry != null &&
                                          SatisfiesSearchCritieria(entry)
                             )
                );
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