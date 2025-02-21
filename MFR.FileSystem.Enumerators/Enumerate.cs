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

using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using xyLOGIX.FileSystem.Enumerable.Factories;

namespace MFR.FileSystem.Enumerators
{
    /// <summary>
    /// Exposes static methods to search the file system.
    /// </summary>
    public static class Enumerate
    {
        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <param name="searchOption">
        /// (Required.) A
        /// <see cref="T:System.IO.SearchOption" /> value that specifies whether the search
        /// should list results from the current folder only, or subfolders as well.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of
        /// <see cref="T:System.Predicate{System.String}" /> that determines whether a
        /// given pathname must be included in the search results.
        /// <para />
        /// If this parameter is passed a <see langword="null" /> reference as an argument,
        /// then no path filter is applied.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// </returns>
        /// <remarks>
        /// This method searches either the top-level folder only, or all subfolders, as
        /// dictated by the argument of the <paramref name="searchOption" /> parameter.
        /// </remarks>
        [return: NotLogged]
        public static IEnumerable<string> Directories(
            string path,
            string searchPattern,
            SearchOption searchOption,
            Predicate<string> pathFilter = null
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(searchOption)
                                          .WithOptionalPathFilter(pathFilter)
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those folders in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Directories(string path)
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern("*")
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the subfolders of the folder whose fully-qualified pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the folders contained within the folder whose fully-qualified pathname is
        /// passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those folders in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Directories(
            string path,
            string searchPattern
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForDirectoriesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those files in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(string path)
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern("*")
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForFilesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method only returns those files in the top level of the folder whose
        /// fully-qualified pathname is specified for the <paramref name="path" />
        /// parameter's value.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(
            string path,
            string searchPattern
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(
                                              SearchOption.TopDirectoryOnly
                                          )
                                          .ForFilesOnly();

        /// <summary>
        /// Enumerates the files in the top level of the folder whose fully-qualified
        /// pathname is
        /// specified by the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the folder where the search is to start.
        /// </param>
        /// <param name="searchPattern">
        /// (Required.) String containing one or more wildcard
        /// expressions for the search.
        /// <para />
        /// Each wildcard expression must be separated by a semicolon.
        /// </param>
        /// <param name="searchOption">
        /// (Required.) A
        /// <see cref="T:System.IO.SearchOption" /> value that specifies whether the search
        /// should list results from the current folder only, or subfolders as well.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of
        /// <see cref="T:System.Predicate{System.String}" /> that determines whether a
        /// given pathname must be included in the search results.
        /// <para />
        /// If this parameter is passed a <see langword="null" /> reference as an argument,
        /// then no path filter is applied.
        /// </param>
        /// <returns>
        /// Collection of strings that contains the fully-qualified pathnames of
        /// the files contained within the top level of the folder whose fully-qualified
        /// pathname is passed in the <paramref name="path" />.
        /// <para />
        /// This method searches either the top-level folder only, or all subfolders, as
        /// dictated by the argument of the <paramref name="searchOption" /> parameter.
        /// </returns>
        [return: NotLogged]
        public static IEnumerable<string> Files(
            string path,
            string searchPattern,
            SearchOption searchOption,
            Predicate<string> pathFilter = null
        )
            => MakeNewFileSystemEnumerable.FromScratch()
                                          .StartingFromRootFolder(path)
                                          .UsingSearchPattern(searchPattern)
                                          .AndWithSearchOption(searchOption)
                                          .WithOptionalPathFilter(pathFilter)
                                          .ForFilesOnly();
    }
}