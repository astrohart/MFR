﻿using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    public class TextInFilesRetriever : FileSystemEntryListRetrieverBase
    {
        

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)] public override OperationType OperationType
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
        /// The value of the <paramref name="replaceWith" /> parameter may be
        /// allowed by some implementations to be blank.
        /// </remarks>
        public override IFileSystemEntryListRetriever AndReplaceItWith(
            string replaceWith)
        {
            ReplaceWith = replaceWith;

            return this;
        }

        /// <summary>
        /// Provides the implementation of the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths" />
        /// method.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of the folder in
        /// which to start the search.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <c>true</c> if the file should be
        /// included in the operation or <c>false</c> otherwise.
        /// <para />
        /// This parameter is <c>null</c> by default. This method should return
        /// <c>true</c> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <c>null</c>, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// Collection of instances of objects that implement the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
        /// interface that
        /// correspond to the file system entries that match the criteria specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <remarks>
        /// Implementers of this method have a guarantee that the
        /// <paramref
        ///     name="rootFolderPath" />
        /// parameter contains a fully-qualified
        /// pathname of a folder that exists on the disk, and that the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.ConfigurationComposedObjectBase.Configuration" />
        /// property is set to a valid object instance reference.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="rootFolderPath" />,
        /// is passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <exception cref="T:MassFileRenamer.Objects.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        protected override IEnumerable<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(string rootFolderPath,
                Predicate<string> pathFilter = null)
        {
            var result = Enumerable.Empty<IFileSystemEntry>();

            try
            {
                result = Directory.EnumerateFiles(
                                      rootFolderPath, SearchPattern,
                                      SearchOption
                                  )
                                  .Select(
                                      path => MakeNewFileSystemEntry
                                              .ForPath(path)
                                              .AndHavingUserState(
                                                  FileHelpers.GetContent(path)
                                              )
                                  )
                                  .Where(
                                      fse => !GetFileSystemEntryValidator
                                              .For(OperationType)
                                              .ShouldSkip(fse) &&
                                             GetTextExpressionMatcher
                                                 .For(OperationType)
                                                 .IsMatch(
                                                     GetMatchExpressionFor(fse)
                                                 ) && (pathFilter?.Invoke(
                                                     fse.Path
                                                 ) ??
                                                 true)
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