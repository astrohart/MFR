using MFR.Engines.Matching.Factories;
using MFR.Engines.Matching.Interfaces;
using MFR.Expressions.Matches;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.FileSystem.Validators;
using MFR.FileSystem.Validators.Factories;
using MFR.FileSystem.Validators.Interfaces;
using MFR.Invokers.Factories;
using MFR.Operations.Constants;
using MFR.Settings.Configuration;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Contains functionality that is shared by all file-system-entry-list
    /// retriever objects across all types of operations.
    /// </summary>
    public abstract class FileSystemEntryListRetrieverBase :
        ConfigurationComposedObjectBase, IFileSystemEntryListRetriever
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase" />
        /// and returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FileSystemEntryListRetrieverBase()
        {
            Reset();
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets or sets a string containing the pattern to be found in the name
        /// and/or contents of a file or folder.
        /// </summary>
        /// <remarks>
        /// The value of this property can be set by clients of this object
        /// using the
        /// <see
        ///     cref="M:MFR.IFileSystemEntryListRetriever.ToFindWhat" />
        /// method.
        /// </remarks>
        protected string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the pattern to replace text found
        /// in the contents or name of a folder or file.
        /// </summary>
        /// <remarks>
        /// The value of this property can be set by clients of this object
        /// using the
        /// <see
        ///     cref="M:MFR.IFileSystemEntryListRetriever.AndReplaceItWith" />
        /// method.
        /// </remarks>
        protected string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// A <see cref="T:System.IO.SearchOption" /> value to be utilized for
        /// file-system searches.
        /// </summary>
        protected SearchOption SearchOption
        {
            get;
            set;
        } = SearchOption.AllDirectories;

        /// <summary>
        /// Gets or sets a string that contains a wildcard search pattern.
        /// </summary>
        /// <remarks>
        /// This property may have a blank or <see langword="null" /> value. The
        /// default value of this property is nominally an asterisk; however,
        /// classes that implement this interface may specify something different.
        /// </remarks>
        protected virtual string SearchPattern
        {
            get;
            set;
        } = "*";

        /// <summary>
        /// Fluent bridge property that accesses the appropriate file-system
        /// entry validator object, that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
        /// interface, for the current operation type.
        /// </summary>
        /// <remarks>
        /// The property is designed to be called as part of a fluent
        /// criteria-evaluation expression.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private IFileSystemEntryValidator FileSystemEntryValidatorSays
            => GetFileSystemEntryValidator.For(OperationType);

        /// <summary>
        /// Fluent bridge property that accesses the appropriate text-expression
        /// matcher object, that implements the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface,
        /// for the current operation type and projectFileRenamerConfiguration.
        /// </summary>
        /// <remarks>
        /// The property is designed to be called as part of a fluent
        /// criteria-evaluation expression.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private ITextExpressionMatchingEngine TextExpressionMatchingEngineSays
            => GetTextExpressionMatchingEngine.For(OperationType)
                                              .AndAttachConfiguration(
                                                  ProjectFileRenamerConfiguration
                                              );

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
        /// </remarks>
        public abstract IFileSystemEntryListRetriever AndReplaceItWith(
            string replaceWith);

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
        /// interface that
        /// correspond to the file system entries that match the criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no projectFileRenamerConfiguration data is attached to this object.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose pathname is specified by the '
        /// <paramref
        ///     name="rootFolderPath" />
        /// ' parameter cannot be located on the disk.
        /// </exception>
        public IEnumerable<IFileSystemEntry> GetMatchingFileSystemPaths(
            string rootFolderPath, Predicate<string> pathFilter = null)
        {
            /*
             * Validate the rootFolderPath by creating a file-system entry
             * object for it and then validating the path of the entry thus
             * created.  We do not utilize the factory object
             * GetFileSystemEntryValidator here, but instead, we simply grab
             * the singleton Instance of the DirectoryValidator class.
             *
             * This is because the factory uses the OperationType to grab a
             * file-validator or folder-validator object.  Here, we know for
             * certain that we expect rootFolderPath to be a directory path;
             * therefore, we cut right to the chase and grab a directory
             * validator object instance.
             */
            DirectoryValidator.Instance.IsValid(
                MakeNewFileSystemEntry.ForPath(rootFolderPath)
            );

            VerifyConfigurationAttached();

            /*
             * This method is merely a template to ensure that the rootFolderPath
             * is verified to be referencing a folder that actually exists on the
             * disk, and we ensure the projectFileRenamerConfiguration object is attached.
             *
             * The "meat" is done in the DoGetMatchingFileSystemPaths template
             * method.  This method is declared abstract, so it must be implemented
             * by children of this class.
             */

            return DoGetMatchingFileSystemPaths(rootFolderPath, pathFilter);
        }

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        public virtual void Reset()
        {
            SearchOption = SearchOption.AllDirectories;
            SearchPattern = "*";
        }

        /// <summary>
        /// Specifies a string that should be utilized in order to filter files
        /// and/or folders.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern that serves as search criteria.
        /// <para />
        /// Whitespace may be passed for this parameter, but not the empty
        /// string or <see langword="null" />.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed either the empty string or <see langword="null" /> string for
        /// a value.
        /// <para />
        /// Whitespace may be passed for <paramref name="findWhat" />.
        /// </exception>
        public IFileSystemEntryListRetriever ToFindWhat(string findWhat)
        {
            if (string.IsNullOrEmpty(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or the empty string.",
                    nameof(findWhat)
                );

            FindWhat = findWhat;

            return this;
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
        public virtual IFileSystemEntryListRetriever UsingSearchPattern(
            string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(searchPattern)
                );

            SearchPattern = searchPattern;

            return this;
        }

        /// <summary>
        /// Specifies the <see cref="T:System.IO.SearchOption" /> value to be
        /// utilized when performing searches for file system entries.
        /// <para />
        /// The idea is that we can search either just the files in the topmost
        /// level of the root folder, or get all files recursively.
        /// </summary>
        /// <param name="option">
        /// (Required.) A <see cref="T:System.IO.SearchOption" /> value to pass
        /// to the file-system enumeration method that is called.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional. If this method is not called, the
        /// type that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever" />
        /// interface will decide what is the default value to be utilized.
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown in the event that an integer is passed for the
        /// <paramref
        ///     name="option" />
        /// parameter that is not defined by the
        /// <see
        ///     cref="T:System.IO.SearchOption" />
        /// enumeration.
        /// </exception>
        public IFileSystemEntryListRetriever WithSearchOption(
            SearchOption option)
        {
            if (!Enum.IsDefined(typeof(SearchOption), option))
                throw new InvalidEnumArgumentException(
                    nameof(option), (int)option, typeof(SearchOption)
                );

            SearchOption = option;

            return this;
        }

        /// <summary>
        /// Determines whether the data in the file-system
        /// <paramref
        ///     name="entry" />
        /// provided passes the additional path-filtering
        /// criteria specified by the <paramref name="pathFilter" /> predicate.
        /// </summary>
        /// <param name="entry">
        /// (Optional.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that has the data to run decision-making upon. If this
        /// parameter is <see langword="null" />, then this method returns
        /// <see langword="false" />.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) A <see cref="T:System.Predicate" /> that points to the
        /// logic to be executed to determine a match to the file-system
        /// <paramref name="entry" /> passed. If this parameter is
        /// <see
        ///     langword="null" />
        /// , then this method returns <see langword="true" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file-system <paramref name="entry" />
        /// passed the path-filtering criteria in <paramref name="pathFilter" />,
        /// or if <paramref name="pathFilter" /> is <see langword="null" />;
        /// otherwise, <see langword="false" /> is returned.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if any of the required
        /// parameters, <paramref name="entry" />, or <paramref name="pathFilter" />, are
        /// passed a <see langword="null" /> value.
        /// </exception>
        protected static bool PassesPathFilter(IFileSystemEntry entry,
            Predicate<string> pathFilter)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            return pathFilter == null || MakeNewPathFilterInvoker.For(entry)
                                           .Passes(pathFilter);
        }

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
        /// pathname of a folder that exists on the disk, and that the
        /// <see
        ///     cref="P:MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration" />
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no projectFileRenamerConfiguration data is attached to this object.
        /// </exception>
        protected abstract IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null);

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.IMatchExpression" /> interface.
        /// <para />
        /// This object specifies textual search criteria.
        /// <para />
        /// The resulting object instance is then to be composed with
        /// text-expression matching and or replacement-engine objects.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpression" />
        /// interface.
        /// <para />
        /// The properties of the object provide text-search and replacement criteria.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no projectFileRenamerConfiguration data is attached to this object.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown in the event that the
        /// <see
        ///     cref="P:MFR.IFileSystemEntry.Path" />
        /// property of
        /// the object referenced by the <paramref name="entry" /> parameter is a
        /// blank or <see langword="null" /> string.
        /// </exception>
        protected IMatchExpression ForFileSystemEntry(IFileSystemEntry entry)
        {
            FileSystemEntryValidatorSays.IsValid(entry);

            VerifyConfigurationAttached();

            return (MatchExpression)GetMatchExpressionFactory.For(OperationType)
                .AndAttachConfiguration(ProjectFileRenamerConfiguration)
                .ForTextValue(
                    OperationType == OperationType.ReplaceTextInFiles
                        ? entry.UserState as string
                        : entry.Path
                )
                .ToFindWhat(FindWhat)
                .AndReplaceItWith(ReplaceWith);
        }

        /// <summary>
        /// Determines whether the path and/or user-state data in the specified
        /// file system <paramref name="entry" /> object matches search and
        /// projectFileRenamerConfiguration criteria specified by the user.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that has the data for the matching process.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="entry" /> data
        /// satisfies the text-expression match criteria for the current
        /// operation; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        protected bool SearchCriteriaMatch(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return TextExpressionMatchingEngineSays.IsMatch(
                ForFileSystemEntry(entry)
            );
        }
    }
}
