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
using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.UI.Dark.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Displays information to the user about an exception or error.
    /// </summary>
    public partial class ErrorReportDialog : DarkForm, IErrorReportDialog
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Dialogs.ErrorReportDialog" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ErrorReportDialog() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.ErrorReportDialog" />
        /// and returns a
        /// reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public ErrorReportDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the value of the <b>Email</b> text box.
        /// </summary>
        public string EmailAddressOfUser
        {
            [DebuggerStepThrough] get => emailAddressOfUserTextBox.Text;
            [DebuggerStepThrough] set => emailAddressOfUserTextBox.Text = value;
        }

        /// <summary>
        /// Gets a string that contains the contents of an error report, given the value of
        /// the <see cref="P:MFR.GUI.Dialogs.ErrorReportDialog.Exception" /> property.
        /// </summary>
        public string ErrorReportContents
            => $"{Exception.GetType()}: {Exception.Message}\n\t{Exception.StackTrace}";

        /// <summary>
        /// Gets or sets the <see cref="T:System.Exception" /> that describes the error
        /// that occurred.
        /// </summary>
        public Exception Exception
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Name</b> text box.
        /// </summary>
        public string NameOfUser
        {
            [DebuggerStepThrough] get => nameOfUserTextBox.Text;
            [DebuggerStepThrough] set => nameOfUserTextBox.Text = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Reproduction Steps</b> text box.
        /// </summary>
        public string ReproductionSteps
        {
            [DebuggerStepThrough] get => reproductionStepsTextBox.Text;
            [DebuggerStepThrough] set => reproductionStepsTextBox.Text = value;
        }

        /// <summary>
        /// Gets a reference to the View Report link-label control.
        /// </summary>
        public LinkLabel ViewReportLinkLabel
        {
            [DebuggerStepThrough] get => viewReportLinkLabel;
        }

        /// <summary>
        /// Occurs when the user requests to view the error report.
        /// </summary>
        public event ViewErrorReportRequestedEventHandler
            ViewErrorReportRequested;

        /// <summary>
        /// Occurs when the user clicks the Send Report button.
        /// </summary>
        public event SendErrorReportRequestedEventHandler
            SendErrorReportRequested;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Exception" /> that contains the event
        /// data.
        /// </param>
        protected virtual void OnSendErrorReportRequested(
            SendErrorReportRequestedEventArgs e
        )
            => SendErrorReportRequested?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This override forcibly terminates the application by calling
        /// <see
        ///     cref="M:System.Environment.Exit" />
        /// with an exit code of <c>-1</c>.
        /// </remarks>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            Environment.Exit(-1);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = Text.Replace("[AppTitle]", Application.ProductName);
            secondaryInstructionLabel.Text =
                secondaryInstructionLabel.Text.Replace(
                    "[AppTitle]", Application.ProductName
                );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.LinkLabel.LinkClicked" />
        /// event raised
        /// by the View Report hyperlink.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by raising the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// <para />
        /// Doing this allows the caller of this dialog to attach their own custom
        /// event-handling logic.
        /// </remarks>
        private void OnLinkClickedViewErrorReportLinkLabel(
            object sender,
            LinkLabelLinkClickedEventArgs e
        )
            => OnViewErrorReportRequested(
                new ViewErrorReportRequestedEventArgs(
                    Exception, ErrorReportContents
                )
            );

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnViewErrorReportRequested(
            ViewErrorReportRequestedEventArgs e
        )
            => ViewErrorReportRequested?.Invoke(this, e);

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event raised by
        /// the Send Report button.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by raising the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested" />
        /// event.
        /// <para />
        /// Doing so allows the invoker of this dialog to decide how to carry out the
        /// action.
        /// </remarks>
        private void OnClickSendReportButton(object sender, EventArgs e)
            => OnSendErrorReportRequested(
                new SendErrorReportRequestedEventArgs(
                    Exception, ErrorReportContents, ReproductionSteps,
                    NameOfUser, EmailAddressOfUser
                )
            );
    }
}