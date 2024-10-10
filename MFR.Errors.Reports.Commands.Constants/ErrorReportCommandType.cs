using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Errors.Reports.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with error reports.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ErrorReportCommandType : CommandType
    {
        /// <summary>
        /// Sends an error report.
        /// </summary>
        public static readonly ErrorReportCommandType SendErrorReport =
            new ErrorReportCommandType(Guid.NewGuid(), nameof(SendErrorReport));

        /// <summary>
        /// Views the error report requested using Notepad.
        /// </summary>
        public static readonly ErrorReportCommandType
            ViewErrorReportWithNotepad = new ErrorReportCommandType(
                Guid.NewGuid(), nameof(ViewErrorReportWithNotepad)
            );

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType" />
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
        static ErrorReportCommandType() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        [Log(AttributeExclude = true)]
        public ErrorReportCommandType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        [Log(AttributeExclude = true)]
        public ErrorReportCommandType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}