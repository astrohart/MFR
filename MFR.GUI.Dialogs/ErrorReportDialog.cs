using MFR.GUI.Dialogs.Events;
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