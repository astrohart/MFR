﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Contains functionality that is shared by all file-system-entry-list
    /// retriever objects across all types of operations.
    /// </summary>
    public abstract class FileSystemEntryListRetrieverBase :
        ConfigurationComposedObjectBase, IFileSystemEntryListRetriever
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.FileSystemEntryListRetrieverBase"/>
        /// and returns a reference to it.
        /// </summary>
        protected FileSystemEntryListRetrieverBase()
        {
            Reset();
        }

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
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
        /// using the <see
        /// cref="M:MassFileRenamer.Objects.IFileSystemEntryListRetriever.ToFindWhat"/> method.
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
        /// using the <see
        /// cref="M:MassFileRenamer.Objects.IFileSystemEntryListRetriever.AndReplaceItWith"/> method.
        /// </remarks>
        protected string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// A <see cref="T:System.IO.SearchOption"/> value to be utilized for
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
        /// This property may have a blank or <c>null</c> value. The default
        /// value of this property is nominally an asterisk; however, classes
        /// that implement this interface may specify something different.
        /// </remarks>
        protected string SearchPattern
        {
            get;
            set;
        } = "*";

        /// <summary>
        /// Specifies a string that should be utilized in order to replace a
        /// textual pattern in the name of a file or folder or the contents thereof.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The value of the <paramref name="replaceWith"/> parameter may be
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
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <c>true</c> if the file should be
        /// included in the operation or <c>false</c> otherwise.
        /// <para/>
        /// This parameter is <c>null</c> by default. This method should return
        /// <c>true</c> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <c>null</c>, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// Collection of instances of objects that implement the <see
        /// cref="T:MassFileRenamer.Objects.IFileSystemEntry"/> interface that
        /// correspond to the file system entries that match the criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath"/>,
        /// is passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <exception cref="T:MassFileRenamer.Objects.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose pathname is specified by the ' <paramref
        /// name="path"/> ' parameter cannot be located on the disk.
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
            DirectoryValidator.Instance.Validate(
                MakeNewFileSystemEntry.ForPath(rootFolderPath)
            );

            VerifyConfigurationAttached();

            /*
             * This method is merely a template to ensure that the rootFolderPath
             * is verified to be referencing a folder that actually exists on the
             * disk, and we ensure the configuration object is attached.
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
        /// <para/>
        /// Whitespace may be passed for this parameter, but not the empty
        /// string or <c>null</c>.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat"/>, is
        /// passed either the empty string or <c>null</c> string for a value.
        /// <para/>
        /// Whitespace may be passed for <paramref name="findWhat"/>.
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
        /// <para/>
        /// NOTE: Calling this method is optional. If this method is not called,
        /// then the default value will be utilized.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="searchPattern"/>,
        /// is passed a blank or <c>null</c> string for a value.
        /// </exception>
        public IFileSystemEntryListRetriever UsingSearchPattern(
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
        /// Specifies the <see cref="T:System.IO.SearchOption"/> value to be
        /// utilized when performing searches for file system entries.
        /// <para/>
        /// The idea is that we can search either just the files in the topmost
        /// level of the root folder, or get all files recursively.
        /// </summary>
        /// <param name="option">
        /// (Required.) A <see cref="T:System.IO.SearchOption"/> value to pass
        /// to the file-system enumeration method that is called.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional. If this method is not called, the
        /// type that implements the <see
        /// cref="T:MassFileRenamer.Objects.IFileSystemEntryListRetriever"/>
        /// interface will decide what is the default value to be utilized.
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown in the event that an integer is passed for the <paramref
        /// name="option"/> parameter that is not defined by the <see
        /// cref="T:System.IO.SearchOption"/> enumeration.
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
        /// Provides the implementation of the <see
        /// cref="M:MassFileRenamer.Objects.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths"/> method.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of the folder in
        /// which to start the search.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <c>true</c> if the file should be
        /// included in the operation or <c>false</c> otherwise.
        /// <para/>
        /// This parameter is <c>null</c> by default. This method should return
        /// <c>true</c> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <c>null</c>, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// Collection of instances of objects that implement the <see
        /// cref="T:MassFileRenamer.Objects.IFileSystemEntry"/> interface that
        /// correspond to the file system entries that match the criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath"/>,
        /// is passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <remarks>
        /// Implementers of this method have a guarantee that the <paramref
        /// name="rootFolderPath"/> parameter contains a fully-qualified
        /// pathname of a folder that exists on the disk, and that the <see
        /// cref="P:MassFileRenamer.Objects.ConfigurationComposedObjectBase.Configuration"/>
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception cref="T:MassFileRenamer.Objects.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        protected abstract IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null);

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MassFileRenamer.Objects.IMatchExpression"/> interface.
        /// <para/>
        /// This object specifies textual search criteria.
        /// <para/>
        /// The resulting object instance is then to be composed with
        /// text-expression matching and or replacement-engine objects.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry"/> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MassFileRenamer.Objects.IMatchExpression"/> interface.
        /// <para/>
        /// The properties of the object provide text-search and replacement criteria.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry"/>, is
        /// passed a <c>null</c> value.
        /// </exception>
        /// <exception cref="T:MassFileRenamer.Objects.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown in the event that the <see
        /// cref="P:MassFileRenamer.Objects.IFileSystemEntry.Path"/> property of
        /// the object referenced by the <paramref name="entry"/> parameter is a
        /// blank or <c>null</c> string.
        /// </exception>
        protected IMatchExpression GetMatchExpressionFor(IFileSystemEntry entry)
        {
            GetFileSystemEntryValidator.For(OperationType)
                                       .Validate(entry);

            VerifyConfigurationAttached();

            return (MatchExpression)GetMatchExpressionFactory.For(OperationType)
                .AndAttachConfiguration(Configuration)
                .ForTextValue(
                    GetTextValueRetriever.For(OperationType)
                                         .GetTextValue(entry)
                )
                .ToFindWhat(FindWhat)
                .AndReplaceItWith(ReplaceWith);
        }
    }
}