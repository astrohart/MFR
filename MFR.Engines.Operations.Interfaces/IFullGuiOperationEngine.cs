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
 */using System;
using System.Windows.Forms;

namespace MFR.Engines.Operations.Interfaces
{
    public interface IFullGuiOperationEngine : IOperationEngine
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the progress dialog.
        /// </summary>
        IWin32Window DialogOwner
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Engines.FullGuiOperationEngine.DialogOwner" /> property is
        /// updated.
        /// </summary>
        event EventHandler DialogOwnerChanged;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Sets the owner window of all dialog boxes displayed by this component.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the new owner window.
        /// </param>
        /// <remarks>
        /// Typically, this method would be called by passing a reference to the
        /// main window of the application.
        /// <para />
        /// </remarks>
        void SetDialogOwner(IWin32Window owner);

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        void ShowCalculatingProgressBar(string text, bool canCancel = true);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(bool canCancel);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        void ShowProgressDialog(IWin32Window owner);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(IWin32Window owner, bool canCancel);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();
    }
}