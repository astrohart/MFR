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

using MFR.Directories.Managers.Interfaces;
using MFR.FileSystem.Enumerators;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Directories.Managers
{
    /// <summary>
    /// Manages the search folders for performing the operations requested by the user
    /// to rename projects, files, and folders.
    /// </summary>
    public class SearchDirectoryManager : ISearchDirectoryManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SearchDirectoryManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SearchDirectoryManager() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </summary>
        public static ISearchDirectoryManager Instance
        {
            get;
        } = new SearchDirectoryManager();

        /// <summary>
        /// Gets a collection of fully-qualified pathnames of folders found by this object,
        /// that
        /// should be searched for projects, files, and folders whose names should be
        /// changed.
        /// </summary>
        public IList<string> SearchDirectories
        {
            get;
        } = new AdvisableCollection<string>();

        /// <summary>
        /// Clears the list of search folders.
        /// </summary>
        public void Clear()
        {
            if (SearchDirectories == null) return;
            if (SearchDirectories.ToArray().Length == 0) return;

            SearchDirectories.Clear();
        }

        /// <summary>
        /// Scans the folder having the specified <paramref name="pathname" /> for Visual
        /// Studio Solution (<c>*.sln</c>) files and then builds the list in the
        /// <see cref="P:MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories" />
        /// property of all the folders under the folder having the specified
        /// <paramref name="pathname" /> that contain Visual Studio Solution (<c>*.sln</c>)
        /// files.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder to scan for Visual Studio Solution (<c>*.sln</c>) files.
        /// </param>
        /// <remarks>
        /// After this method executes, callers can access the
        /// <see cref="P:MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories" />
        /// property in order to access the list of folders that was retrieved.
        /// </remarks>
        public void Search(string pathname, Predicate<string> pathFilter = null)
        {
            try
            {
                if (!Does.FolderExist(pathname)) return;

                SearchDirectories.Clear();

                var solutionFileSet = Enumerate.Files(
                    pathname, "*.sln", SearchOption.AllDirectories, pathFilter
                ).Distinct();

                Parallel.ForEach(
                    solutionFileSet, path =>
                    {
                        var solutionFolder = Path.GetDirectoryName(path);
                        if (!Does.FolderExist(solutionFolder)) return;

                        SearchDirectories.Add(solutionFolder);
                    }
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}