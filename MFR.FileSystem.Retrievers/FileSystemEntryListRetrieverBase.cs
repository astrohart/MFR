/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

using MFR.Engines.Matching.Factories;
using MFR.Engines.Matching.Interfaces;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.FileSystem.Validators.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.TextValues.Retrievers.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Contains functionality that is shared by all file-system-entry-list
    /// retriever objects across all types of operations.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class FileSystemEntryListRetrieverBase :
        ConfigurationComposedObjectBase, IFileSystemEntryListRetriever
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase" />
        /// and returns a reference to it.
        /// </summary>
        protected FileSystemEntryListRetrieverBase()
        {
            Reset();
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfig CurrentConfig
        {
            get;
            set;
        } = ConfigProvider.CurrentConfig;

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
        protected IFileSystemEntryValidator FileSystemEntryValidatorSays
            => GetFileSystemEntryValidator.For(OperationType);

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
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract OperationType OperationType
        {
            get;
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
        protected virtual SearchOption SearchOption
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
        /// Fluent bridge property that accesses the appropriate text-expression
        /// matcher object, that implements the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface,
        /// for the current operation type and config.
        /// </summary>
        /// <remarks>
        /// The property is designed to be called as part of a fluent
        /// criteria-evaluation expression.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private ITextExpressionMatchingEngine TextExpressionMatchingEngineSays
            => GetTextExpressionMatchingEngine.For(OperationType)
                                              .AndAttachConfiguration(
                                                  CurrentConfig
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
            string replaceWith
        );

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
        /// Thrown if no config data is attached to this object.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose pathname is specified by the '
        /// <paramref
        ///     name="rootFolderPath" />
        /// ' parameter cannot be located on the file system.
        /// </exception>
        public IEnumerable<IFileSystemEntry> GetMatchingFileSystemPaths(
            string rootFolderPath,
            Predicate<string> pathFilter = null
        )
        {
            var result = Enumerable.Empty<IFileSystemEntry>();

            try
            {
                /*
                 * Validate the rootFolderPath by creating a file-system entry
                 * object for it and then validating the path of the entry thus
                 * created.  We do not utilize the factory object
                 * GetFileSystemEntryValidator here, but instead, we simply grab
                 * the singleton Instance of the DirectoryPathValidator class.
                 *
                 * This because the factory uses the OperationType to grab a
                 * file-validator or folder-validator object.  Here, we know for
                 * certain that we expect rootFolderPath to be a directory path;
                 * therefore, we cut right to the chase and grab a directory
                 * validator object instance.
                 */

                if (string.IsNullOrWhiteSpace(rootFolderPath)) return result;
                if (!Does.FileSystemEntryExist(rootFolderPath)) return result;

                var entry = MakeNewFileSystemEntry.ForPath(rootFolderPath);
                if (!FileSystemEntryValidatorSays.IsValid(entry)) return result;

                VerifyConfigurationAttached();

                /*
                 * This method is merely a template to ensure that the rootFolderPath
                 * is verified to be referencing a folder that actually exists on the
                 * disk, and we ensure the config object is attached.
                 *
                 * The "meat" is done in the DoGetMatchingFileSystemPaths template
                 * method.  This method is declared abstract, so it must be implemented
                 * by children of this class.
                 */

                result = DoGetMatchingFileSystemPaths(
                    rootFolderPath, pathFilter
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
            string searchPattern
        )
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
            SearchOption option
        )
        {
            if (!Enum.IsDefined(typeof(SearchOption), option))
                throw new InvalidEnumArgumentException(
                    nameof(option), (int)option, typeof(SearchOption)
                );

            SearchOption = option;

            return this;
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
        protected abstract IReadOnlyCollection<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(
                string rootFolderPath,
                Predicate<string> pathFilter = null
            );

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
        /// Thrown if no config data is attached to this object.
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
            IMatchExpression result = default;

            try
            {
                if (!FileSystemEntryValidatorSays.IsValid(entry))
                    return result;

                VerifyConfigurationAttached();

                var matchExpressionFactory =
                    GetMatchExpressionFactoryForOperation();
                if (matchExpressionFactory == null) return result;

                result = matchExpressionFactory.ForTextValue(
                                                   GetTextValueForOperation(
                                                       entry
                                                   )
                                               )
                                               .ToFindWhat(FindWhat)
                                               .AndReplaceItWith(ReplaceWith);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        protected IMatchExpressionFactory
            GetMatchExpressionFactoryForOperation()
        {
            IMatchExpressionFactory result;

            try
            {
                result = GetMatchExpressionFactory.For(OperationType)
                                                  .AndAttachConfiguration(
                                                      CurrentConfig
                                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        protected bool SatisfiesPathFilter(
            string value,
            Predicate<string> pathFilter
        )
        {
            var result = true;

            try
            {
                if (pathFilter == null) return result;

                result = pathFilter.Invoke(value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the path and/or user-state data in the specified
        /// file system <paramref name="entry" /> object matches search and
        /// config criteria specified by the user.
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
        protected bool SatisfiesSearchCritieria(IFileSystemEntry entry)
        {
            var result = false;

            try
            {
                if (entry == null) return result;
                if (!Does.FileSystemEntryExist(entry.Path)) return result;

                result = TextExpressionMatchingEngineSays.IsMatch(
                    ForFileSystemEntry(entry)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a certain path should be executed.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to be checked.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) A reference to an instance of
        /// <see cref="T:System.Predicate{System.String}" /> that contains additional rules
        /// stating whether to include files or directories.
        /// </param>
        /// <returns></returns>
        [Log(AttributeExclude = true)]
        protected bool ShouldDoPath(
            string path,
            Predicate<string> pathFilter = null
        )
        {
            bool result;

            try
            {
                result = pathFilter == null
                    ? FileSystemEntryValidatorSays.ShouldNotSkip(path)
                    : pathFilter(path) &&
                      FileSystemEntryValidatorSays.ShouldNotSkip(path);
            }
            catch
            {
                result = false;
            }

            return result;
        }

        private string GetTextValueForOperation(IFileSystemEntry entry)
        {
            var result = string.Empty;

            try
            {
                var retriever = GetTextValueRetriever.For(OperationType);
                if (retriever == null) return result;

                result = retriever.GetTextValue(entry);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}