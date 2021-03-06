using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Retrieves the list of file system entries (i.e., files and/or folders)
    /// that are to be included in the <c>Replace Text in Files</c> operation.
    /// </summary>
    public class TextInFilesRetriever : FileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TextInFilesRetriever()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TextInFilesRetriever()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.FileSystem.Retrievers.TextInFilesRetriever"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static TextInFilesRetriever Instance
        {
            get;
        } = new TextInFilesRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType"/> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.ReplaceTextInFiles;

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
        public override IFileSystemEntryListRetriever AndReplaceItWith(
            string replaceWith)
        {
            ReplaceWith = replaceWith;

            return this;
        }

        /// <summary>
        /// Provides the implementation of the <see
        /// cref="M:MFR.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths"/> method.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of the folder in
        /// which to start the search.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// Collection of instances of objects that implement the <see
        /// cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry"/>
        /// interface that correspond to the file system entries that match the
        /// criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath"/>,
        /// is passed a blank or <see langword="null"/> string for a value.
        /// </exception>
        /// <remarks>
        /// Implementers of this method have a guarantee that the <paramref
        /// name="rootFolderPath"/> parameter contains a fully-qualified
        /// pathname of a folder that exists on the disk, and that the <see
        /// cref="P:MFR.Settings.ConfigurationComposedObjectBase.Configuration"/>
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath"/>,
        /// is passed a blank or <see langword="null"/> string for a value.
        /// </exception>
        /// <exception cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null)
        {
            var result = Enumerable.Empty<IFileSystemEntry>();

            try
            {
                /*
                 * NOTE: Avoid, at all costs, doing a ToList() call here,
                 * or anywhere else in the code, if it can be helped.  The
                 * reason is, that some projects in which we are to replace
                 * text in files have a truly massive number of files and
                 * if we call ToList(), there is a probability that the memory
                 * allocated to this process would overflow.  IEnumerable is
                 * very efficient at managing memory so long as you do not
                 * call ToList etc.
                 */

                result = Enumerate.Files(
                                      rootFolderPath, SearchPattern,
                                      SearchOption
                                  )
                                  .Where(GetFileSystemEntryValidator.For(OperationType).ShouldNotSkip)
                                  .Select(
                                      path => MakeNewFileSystemEntry
                                              .ForPath(path)
                                              .AndHavingUserState(
                                                  FileHelpers.GetTextContent(path)
                                              )
                                  )
                                  .Where(
                                      fse => SearchCriteriaMatch(fse) &&
                                             PassesPathFilter(fse, pathFilter)
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
