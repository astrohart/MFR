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
            ViewErrorReportWithNotepad =
                new ErrorReportCommandType(Guid.NewGuid(), nameof(ViewErrorReportWithNotepad));

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
        public ErrorReportCommandType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}