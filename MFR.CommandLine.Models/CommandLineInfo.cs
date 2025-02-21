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
 */using MFR.CommandLine.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.CommandLine.Models
{
    /// <summary>
    /// Encapsulates this application's command line arguments.
    /// </summary>
    /// <remarks>
    /// This class depends on the <c>FluentCommandLineParser</c> NuGet package.
    /// </remarks>
    public class CommandLineInfo : ICommandLineInfo
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.CommandLine.Models.CommandLineInfo" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CommandLineInfo() { }

        /// <summary>
        /// Initializes a new instance of
        /// <see cref="T:MFR.CommandLine.Models.CommandLineInfo" /> and returns a reference
        /// to it.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This constructor is marked <see langword="protected" />
        /// due to the fact that this class is marked <see langword="abstract" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public CommandLineInfo() { }

        /// <summary>
        /// Gets or sets a value that indicates that the application should quit when the
        /// operations are finished.
        /// </summary>
        public bool? AutoQuitOnCompletion
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether processing starts when the application
        /// starts.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="false" />.
        /// </remarks>
        public bool AutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = false;

        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        public string FindWhat
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = "";

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? MatchCase
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? MatchExactWord
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool? RenameFilesInFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = true;

        /// <summary>
        /// Gets or sets a value indicating whether we are to rename folder(s) that contain
        /// Solution(s).
        /// </summary>
        public bool? RenameSolutionFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = false;

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool? RenameSubFolders
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value that indicates that the Solution is to be reloaded when
        /// the operations are finished.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ReOpenSolution
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is set to <see langword="true" />.
        /// </remarks>
        public bool? ReplaceTextInFiles
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        /// <remarks>
        /// This property's value is set to the
        /// <see cref="F:System.String.Empty" /> value if it is not specified on the
        /// command line.
        /// </remarks>
        public string ReplaceWith
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = string.Empty;

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ShouldCommitPendingChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        /// <remarks>
        /// If nothing was specified on the command line for this property, then
        /// its value is <see langword="null" />.
        /// </remarks>
        public bool? ShouldCommitPostOperationChanges
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;

        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        public string StartingFolder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether to update the user's local Git
        /// repository even when running in <c>Auto Start</c> mode.
        /// </summary>
        /// <remarks>
        /// If this property has a <see langword="null" /> value, then that means
        /// the user did not specify the corresponding flag on the command line at all.
        /// <para />
        /// The default value of this property is <see langword="null" />.
        /// </remarks>
        public bool? UpdateGitOnAutoStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = null;
    }
}