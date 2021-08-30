using System;

namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Provides information for ViewErrorReportRequested event handlers.
    /// </summary>
    public class ViewErrorReportRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) A <see cref="T:System.Exception" /> that
        /// describes the error that occurred.
        /// </param>
        /// <param name="errorReportContent">
        /// (Required.) String containing the text of the report.
        /// </param>
        public ViewErrorReportRequestedEventArgs(Exception exception,
            string errorReportContent)
        {
            Exception = exception;
            ErrorReportContent = errorReportContent;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Exception" /> instance that
        /// describes the error that occurred.
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