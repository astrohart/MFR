using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Errors.Reports.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with error reports.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ErrorReportCommand : CommandType
    {
        /// <summary>
        /// Views the error report requested using Notepad.
        /// </summary>
        public static readonly ErrorReportCommand ViewErrorReportWithNotepad =
            new ErrorReportCommand(Guid.NewGuid());

        /// <summary>
        /// Sends an error report.
        /// </summary>
        public static readonly ErrorReportCommand SendErrorReport =
            new ErrorReportCommand(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Errors.Reports.Commands.Constants.ErrorReportCommand" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ErrorReportCommand(Guid messageId) : base(messageId) { }
    }
}