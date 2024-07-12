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
    /// Retrieves a list of Visual Studio Solution (<c>*.sln</c>) files in a given
    /// directory tree.
    /// </summary>
    public class SolutionFilePathRetriever : FileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SolutionFilePathRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SolutionFilePathRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever" />
        /// interface that searches a particular directory tree of the file system for the
        /// pathnames of any Visual Studio Solution (<c>*.sln</c>) files that may be
        /// present within it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IFileSystemEntryListRetriever Instance
        {
            get;
        } = new SolutionFilePathRetriever();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
            => OperationType.ScanDirectoryTreeForSolutionFiles;

        /// <summary>
        /// Gets or sets a string that contains a wildcard search pattern.
        /// </summary>
        /// <remarks>
        /// This property may have a blank or <see langword="null" /> value. The
        /// default value of this property is nominally an asterisk; however,
        /// classes that implement this interface may specify something different.
        /// <para />
        /// This particular implementation overrides the
        /// <see
        ///     cref="P:MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern" />
        /// property in order to specify <c>*.sln</c> as the one and only search pattern to
        /// be utilized with this class.
        /// </remarks>
        protected override string SearchPattern
        {
            get;
            set;
        } = "*.sln";

        /// <summary>
        /// Specifies a string that should be utilized in order to replace a
        /// textual pattern in the name of a file or folder or the contents thereof.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The value of the <paramref name="replaceWith" /> parameter may be
        /// allowed by some implementations to be blank.
        /// <para />
        /// This specific implementation does not need such a "Replace With" value, so
        /// therefore the method
        /// always throws <see cref="T:System.NotSupportedException" />.
        /// </remarks>
        public override IFileSystemEntryListRetriever AndReplaceItWith(
            string replaceWith)
            => throw new NotSupportedException();

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        public override void Reset()
        {
            base.Reset();

            SearchPattern = "*.sln";
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
        /// This particular override hard-codes the
        /// <see
        ///     cref="P:MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern" />
        /// property to always have the value <c>*.sln</c>.
        /// <para />
        /// NOTE: Calling this method is optional. If this method is not called,
        /// then the default value will be utilized.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="searchPattern" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public override IFileSystemEntryListRetriever UsingSearchPattern(
            string searchPattern)
        {
            // Always ignore the input searchPattern parameter
            // and hard-code the SearchPattern property to be *.sln.
            SearchPattern = "*.sln";

            return this;
        }

        /// <summary>
        /// Verifies that config has been attached to this object.
        /// </summary>
        /// <remarks>
        /// If no config is attached to this object, then
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException" />
        /// is thrown.
        /// <para />
        /// <strong>NOTE:</strong> Child classes may override this method, e.g., to make
        /// attaching a config object optional.
        /// <para />
        /// This particular override of the method takes no action at all.
        /// </remarks>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no config data is attached to this object.
        /// </exception>
        public override void VerifyConfigurationAttached() { }

        /// <summary>
        /// Provides the implementation of the
        /// <see
        ///     cref="M:MFR.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths" />
        /// method.
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
        /// interface that
        /// correspond to the file system entries that match the criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
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
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no config data is attached to this object.
        /// </exception>
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null)
        {
            var result = Enumerable.Empty<IFileSystemEntry>();

            try
            {
                result = Enumerate.Files(
                                      rootFolderPath, SearchPattern,
                                      SearchOption, pathFilter
                                  )
                                  .Select(MakeNewFileSystemEntry.ForPath);
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