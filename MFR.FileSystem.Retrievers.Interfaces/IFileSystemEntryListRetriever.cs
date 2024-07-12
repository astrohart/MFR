using MFR.Settings.Configuration.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace MFR.FileSystem.Retrievers.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// obtains a list of files from the file system that match certain criteria.
    /// <para />
    /// This allows us to specify differing criteria depending on the type of
    /// operation that is being performed.
    /// <para />
    /// The results of the searching and filtering is then returned.
    /// </summary>
    public interface
        IFileSystemEntryListRetriever : IFixedOperationTypeSpecificObject,
            IConfigurationComposedObject
    {
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
        IFileSystemEntryListRetriever AndReplaceItWith(string replaceWith);

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
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
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
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose pathname is specified by the '
        /// <paramref
        ///     name="rootFolderPath" />
        /// ' parameter cannot be located on the file system.
        /// </exception>
        IEnumerable<IFileSystemEntry> GetMatchingFileSystemPaths(
            string rootFolderPath, Predicate<string> pathFilter = null);

        /// <summary>
        /// Specifies a string that should be utilized in order to filter files
        /// and/or folders.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IFileSystemEntryListRetriever ToFindWhat(string findWhat);

        /// <summary>
        /// Specifies a string that is to be used as the search pattern for
        /// enumerating file-system entries.
        /// </summary>
        /// <param name="searchPattern">
        /// (Required.) String containing the search pattern to be utilized.  Default is "*".
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// This property may have a blank or <see langword="null" /> value. The default
        /// value is nominally an asterisk; however, classes that implement this
        /// interface may specify something different.
        /// <para />
        /// NOTE: Calling this method is optional. If this method is not called,
        /// then the default value will be utilized.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="searchPattern" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        IFileSystemEntryListRetriever UsingSearchPattern(string searchPattern);

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
        IFileSystemEntryListRetriever WithSearchOption(SearchOption option);
    }
}
