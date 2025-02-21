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

using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Files;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// <c>File and Folder File System Entry List Retriever</c> objects that search for
    /// folders containing local Git repositories.
    /// </summary>
    public abstract class
        CommitToGitRetrieverBase :
        FileAndFolderNameFileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// A <see cref="T:System.IO.SearchOption" /> value to be utilized for
        /// file-system searches.
        /// </summary>
        protected override SearchOption SearchOption
        {
            get;
            set;
        } = SearchOption.TopDirectoryOnly;

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
        protected override IReadOnlyCollection<IFileSystemEntry>
            DoGetMatchingFileSystemPaths(
                string rootFolderPath,
                Predicate<string> pathFilter = null
            )
        {
            var result = new ConcurrentBag<IFileSystemEntry>();

            try
            {
                var folderSet = Enumerate.Directories(
                    rootFolderPath, SearchPattern, SearchOption
                    /* pathFilter is ignored. */
                );

                /*
                 * ASSUME that this FileAndFolderNameFileSystemEntryListRetriever is set to
                 * locate those folders whose names are '.git'.  We wish to return the
                 * containing folder of each '.git' folder.
                 */

                Parallel.ForEach(
                    folderSet, path =>
                    {
                        var parentOfPath = Parent.Of(path);
                        if (!Does.FolderExist(parentOfPath)) return;

                        var entry =
                            MakeNewFileSystemEntry.ForPath(parentOfPath);
                        if (entry == null) return;

                        result.Add(entry);
                    }
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new ConcurrentBag<IFileSystemEntry>();
            }

            return result;
        }
    }
}