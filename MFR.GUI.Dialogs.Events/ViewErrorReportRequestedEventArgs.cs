using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Diagnostics;

namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Provides information for ViewErrorReportRequested event handlers.
    /// </summary>
    [ExplicitlySynchronized]
    public class ViewErrorReportRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" />
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
        static ViewErrorReportRequestedEventArgs()
        {
        }

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
        [Log(AttributeExclude = true)]
        public ViewErrorReportRequestedEventArgs(
            Exception exception,
            string errorReportContent
        )
        {
            Exception = exception;
            ErrorReportContent = errorReportContent;
        }

        /// <summary>
        /// Gets a string that contains the detailed error report that is to be sent.
        /// </summary>
        public string ErrorReportContent
        {
            [DebuggerStepThrough]
            get;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Exception" /> instance that
        /// describes the error that occurred.
        /// </summary>
        public Exception Exception
        {
            [DebuggerStepThrough]
            get;
        }
    }
}