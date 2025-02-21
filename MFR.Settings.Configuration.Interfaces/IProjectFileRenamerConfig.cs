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

using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Events;
using System.Collections.Generic;
using System.Diagnostics;

namespace MFR.Settings.Configuration.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a
    /// config object.
    /// </summary>
    public interface IProjectFileRenamerConfig
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically terminate once the user's requested operations
        /// are complete.
        /// </summary>
        bool AutoQuitOnCompletion
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the specified operation(s) should be
        /// automatically initiated when the application starts.  If this value is set to
        /// <see langword="true" /> then the application quits automatically after the
        /// specified operation(s) have been completed.
        /// </summary>
        /// <remarks>
        /// This flag is ignored if this config did not originate from the command
        /// line.
        /// </remarks>
        bool AutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the email address(es)
        /// of the author(s) of commits made to a local Git repository(ies) by this
        /// application.
        /// </summary>
        string CommitAuthorEmail
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the name of the
        /// author(s) of commits made to a local Git repository(ies) by this application.
        /// </summary>
        string CommitAuthorName
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a reference to an instance of a collection, each of whose elements are of
        /// type <see cref="T:System.String" />, representing the list of errant processes
        /// we should attempt to kill prior to the beginning of an operation.
        /// </summary>
        IList<string> ErrantProcessesList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the text to be found that was most-recently specified
        /// by the user.
        /// </summary>
        string FindWhat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a collection of strings consisting of the most-recently
        /// utilized values for Find What.
        /// </summary>
        IList<string> FindWhatHistory
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a reference to a collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances, that represents
        /// all the operations the user can perform with this application.
        /// </summary>
        IList<IOperationTypeInfo> InvokableOperations
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a value indicating whether the form is in the Folded state.
        /// </summary>
        /// <remarks>
        /// If this value is <see langword="true" /> when the form is loaded, then ensure
        /// that the form displays in the folded state.
        /// </remarks>
        bool IsFolded
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this config was specified by the
        /// user on the command line.
        /// </summary>
        bool IsFromCommandLine
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the case on
        /// found text.
        /// </summary>
        bool MatchCase
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the whole
        /// word on found text.
        /// </summary>
        bool MatchExactWord
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for pending changes that are committed prior to the start of the
        /// operations.
        /// </summary>
        string PendingChangesCommitMessageFormat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for pending changes that are committed prior to the
        /// start of the operations.
        /// </summary>
        string PendingChangesDetailedCommitMessageFormat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for the changed files once the operations have been completed.
        /// </summary>
        string PostOperationCommitMessageFormat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or set a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for the changed files once the operations have been
        /// completed.
        /// </summary>
        string PostOperationDetailedCommitMessageFormat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the application should prompt the user
        /// if it detects that one or more instances of Visual Studio are open, but none of
        /// them have the target Solution(s) loaded.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// <para />
        /// Set to <see langword="false" /> to suppress the display of the warning message
        /// box.  <b>NOTE:</b> If users suppress the message box, and one or more of the
        /// target Solution(s) are indeed loaded by a running instance of Visual Studio,
        /// then there may be file-sharing/permissions issues during the operation(s).
        /// </remarks>
        bool PromptUserToReloadOpenSolution
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically push the commits it creates to the remote
        /// repository when done with the requested operation(s).
        /// </summary>
        /// <remarks>This property is set to <see langword="true" /> by default.</remarks>
        bool PushChangesToRemoteWhenDone
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        bool RenameFilesInFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename folders that
        /// contain Visual Studio Solution (<c>*.sln</c>) files.
        /// </summary>
        bool RenameSolutionFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        bool RenameSubFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a flag that indicates whether to attempt to close and
        /// then re-open the Visual Studio solution, if open, that contains the
        /// project(s) being renamed.
        /// <para />
        /// </summary>
        /// <remarks>
        /// If this set to <see langword="true" />, and the containing solution is open,
        /// then the solution will be closed prior to the start of the selected
        /// operation(s) and then re-opened when the selected operation(s) are complete.
        /// </remarks>
        bool ReOpenSolution
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should replace text
        /// in files.
        /// </summary>
        bool ReplaceTextInFiles
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the text that found text should be replaced with.
        /// </summary>
        string ReplaceWith
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Replace With.
        /// </summary>
        IList<string> ReplaceWithHistory
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a number from 0...N, where N is the number of option
        /// tabs, of the one that is currently selected.
        /// </summary>
        int SelectedOptionTab
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        bool ShouldCommitPendingChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        bool ShouldCommitPostOperationChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        string StartingFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        IList<string> StartingFolderHistory
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to update the user's local Git
        /// repository even when running in <c>Auto Start</c> mode.
        /// </summary>
        /// <remarks>The default value of this property is <see langword="true" />.</remarks>
        bool UpdateGitOnAutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfig.ProjectFileRenamerConfig.StartingFolder" />
        /// property has been updated.
        /// </summary>
        event StartingFolderChangedEventHandler StartingFolderChanged;

        /// <summary>
        /// Determines whether the specified object is equal to the current
        /// object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current
        /// object; otherwise, <see langword="false" />.
        /// </returns>
        bool Equals(object obj);

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        int GetHashCode();

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        void Reset();
    }
}