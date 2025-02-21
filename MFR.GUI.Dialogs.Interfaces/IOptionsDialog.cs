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
 */using MFR.GUI.Dialogs.Events;
using MFR.GUI.Models.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a dialog box that
    /// allows the user to configure the application.
    /// </summary>
    public interface IOptionsDialog : IForm
    {
        /// <summary>
        /// Gets or sets the value of the
        /// <b>Exit the Application When Operations Are Complete</b> checkbox.
        /// </summary>
        bool AutoQuitOnCompletion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Email</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        string CommitAuthorEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Name</b> text box in the
        /// <b>Commit Author Information</b> group box on the <b>Git</b> tab.
        /// </summary>
        string CommitAuthorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text of the configuration File Pathname text box.
        /// </summary>
        string ConfigPathname
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Do not warn when Visual Studio is open but target Solution(s) aren't loaded</b>
        /// checkbox
        /// </summary>
        bool DontPromptUserToReloadOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface,
        /// representing the process(es), if running, that should be forcibly terminated
        /// prior to the execution of the <c>Rename Files in Folder</c> and
        /// <c>Rename Sub Folders</c> operations.
        /// </summary>
        IList<IErrantProcessInfo> ErrantProcesses
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a value that indicates whether the user has configured more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more than zero
        /// <c>Errant Process</c> entry(ies) in the <b>Errant Processes</b> list box;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool HasErrantProcesses
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether an entry is currently selected in the
        /// <b>Errant Processes</b> list box.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if an entry is currently selected in the
        /// <b>Errant Processes</b> list box; <see langword="false" /> otherwise.
        /// </returns>
        bool IsErrantProcessSelected
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a value that indicates whether the data in this dialog box has
        /// been modified.
        /// </summary>
        bool IsModified
        {
            get;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Push Changes To Remote When Done</b> checkbox.
        /// </summary>
        bool PushChangesToRemoteWhenDone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Reopen Visual Studio Solution</b> checkbox.
        /// </summary>
        bool ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface that
        /// represents the item that is currently selected, if any, in the
        /// <b>Errant Processes</b> list box on the <b>General</b> tab.
        /// </summary>
        /// <remarks>
        /// If there are no items currently in the list box, or none are currently
        /// selected, then this property returns a <see langword="null" /> reference.
        /// </remarks>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface;
        /// otherwise, a <see langword="null" /> reference is returned.
        /// </returns>
        IErrantProcessInfo SelectedErrantProcess
        {
            get;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Pending Changes</b> checkbox.
        /// </summary>
        bool ShouldCommitPendingChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Should Commit Post-Operation Changes</b>
        /// checkbox.
        /// </summary>
        bool ShouldCommitPostOperationChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the
        /// <b>Update Local Git Repos When Automatically Started</b> checkbox.
        /// </summary>
        bool UpdateGitOnAutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        event ModifiedEventHandler Modified;
    }
}