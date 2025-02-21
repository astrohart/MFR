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
 */using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewOperationDrivenProgressDialog
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Argument" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="argument">
        /// (Required.) An object that should be passed to the code that is to be executed
        /// by the dialog box, as an argument.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog AndArgument(
            this IOperationDrivenProgressDialog self, object argument)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Argument = argument;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Status" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="statusText">
        /// (Required.) String containing the text to be displayed in the dialog box while
        /// it is being displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog AndStatusText(
            this IOperationDrivenProgressDialog self, string statusText)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Status = statusText;

            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </returns>
        public static IOperationDrivenProgressDialog FromScratch()
            => new OperationDrivenProgressDialog();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="proc">
        /// (Required.) A <see cref="T:System.Func" /> delegate that specifies code that is
        /// to be executed when the dialog is to be displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog HavingProc(
            this IOperationDrivenProgressDialog self, Func<dynamic, dynamic> proc)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Proc = proc;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="proc">
        /// (Required.) A <see cref="T:System.Func" /> delegate that specifies code that is
        /// to be executed when the dialog is to be displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog HavingProc(
            this IOperationDrivenProgressDialog self, Delegate proc)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Proc = proc;
            return self;
        }
    }
}