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
using PostSharp.Patterns.Threading;
using System;
using System.Diagnostics;

namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Provides information for SendErrorReportRequested event handlers.
    /// </summary>
    [ExplicitlySynchronized]
    public class SendErrorReportRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static SendErrorReportRequestedEventArgs() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) Reference to an instance of <see cref="T:System.Exception" /> that
        /// describes the error to be reported.
        /// </param>
        /// <param name="errorReportContent">
        /// (Required.) String containing the content of the detailed error report to be
        /// sent.
        /// </param>
        /// <param name="reproductionSteps">
        /// (Required.) String containing the user's report of what was happening that led
        /// up to the error.
        /// </param>
        /// <param name="nameOfUser">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the user.
        /// </param>
        /// <param name="emailAddressOfUser">
        /// (Required.) A <see cref="T:System.String" /> containing the email address of
        /// the user.
        /// </param>
        [Log(AttributeExclude = true)]
        public SendErrorReportRequestedEventArgs(
            Exception exception,
            string errorReportContent,
            string reproductionSteps,
            string nameOfUser = "",
            string emailAddressOfUser = ""
        )
        {
            Exception = exception;
            ErrorReportContent = errorReportContent;
            ReproductionSteps = reproductionSteps;
            NameOfUser = nameOfUser;
            EmailAddressOfUser = emailAddressOfUser;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the email address of the user.
        /// </summary>
        /// <remarks>
        /// If the user declines to provide their email address, then the value of
        /// this property is the <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        public string EmailAddressOfUser
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a string that contains the detailed error report that is to be sent.
        /// </summary>
        public string ErrorReportContent
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Exception" /> that
        /// describes the error being reported.
        /// </summary>
        public Exception Exception
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the name of the user if it has
        /// been provided.
        /// </summary>
        /// <remarks>
        /// If the user declines to share their name, then the value of this property is
        /// set to the <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        public string NameOfUser
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a string that contains the user's explanation of what led up to the error.
        /// </summary>
        public string ReproductionSteps
        {
            [DebuggerStepThrough] get;
        }
    }
}