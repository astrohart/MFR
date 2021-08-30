using System;

namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Provides information for SendErrorReportRequested event handlers.
    /// </summary>
    public class SendErrorReportRequestedEventArgs : EventArgs
    {
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
        public SendErrorReportRequestedEventArgs(Exception exception,
            string errorReportContent)
        {
            Exception = exception;
            ErrorReportContent = errorReportContent;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Exception" /> that
        /// describes the error being reported.
        /// </summary>
        public Exception Exception
        {
            get;
        }

        /// <summary>
        /// Gets a string that contains the detailed error report that is to be sent.
        /// </summary>
        public string ErrorReportContent
        {
            get;
        }
    }
}