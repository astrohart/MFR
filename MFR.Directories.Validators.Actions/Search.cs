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

using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Directories.Validators.Actions
{
    /// <summary>
    /// Exposes static methods to search for files and folders.
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// Searches the specified <paramref name="folder" />, and all its subfolders, for
        /// file(s) matching the specified <paramref name="extensionPattern" />.
        /// </summary>
        /// <param name="folder">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the folder in which to begin the search.
        /// </param>
        /// <param name="extensionPattern">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the glob pattern, e.g., <c>*.sln</c>, that designates the file(s)
        /// that are to be matched by the search.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the argument of either
        /// the <paramref name="folder" /> or the <paramref name="extensionPattern" />
        /// parameters is a <see langword="null" /> reference, the
        /// <see cref="F:System.String.Empty" /> value, or a <see cref="T:System.String" />
        /// that contains only whitespace.
        /// <para />
        /// If the argument of the <paramref name="folder" /> parameter refers to a folder
        /// that does not exist on the file system, then this method also returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if at least one file is found in the directory
        /// tree of the specified <paramref name="folder" /> whose filename matches the
        /// specified <paramref name="extensionPattern" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool ForFilesHavingExtension(
            string folder,
            string extensionPattern
        )
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension: Determining whether the folder '{folder}', or its subfolder(s), contains at least one file(s) whose extensions match the pattern '{extensionPattern}'..."
                );

                // Dump the parameter folder to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Search.ForFilesHavingExtension: folder = '{folder}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension *** INFO: Checking whether the folder with path '{folder}' exists on the file system..."
                );

                if (!Does.FolderExist(folder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"Search.ForFilesHavingExtension: *** ERROR *** The system could not locate the folder having the path '{folder}' on the file system.  This folder is required to exist in order for us to proceed."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Search.ForFilesHavingExtension: Result = {result}"
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Search.ForFilesHavingExtension: *** SUCCESS *** The folder with path '{folder}' was found on the file system.  Proceeding..."
                );

                // Dump the parameter extensionPattern to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Search.ForFilesHavingExtension: extensionPattern = '{extensionPattern}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the value of the 'extensionPattern' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(extensionPattern))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Search.ForFilesHavingExtension: Blank value passed for the 'extensionPattern' parameter. This parameter is required."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Search.ForFilesHavingExtension: Result = {result}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "Search.ForFilesHavingExtension: Done."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'extensionPattern' is not blank.  Continuing..."
                );

                result = Does.FolderHaveAtLeastOneFileMatching(
                    folder, extensionPattern, false
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Search.ForFilesHavingExtension: Result = {result}"
            );

            return result;
        }
    }
}