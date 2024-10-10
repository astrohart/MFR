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