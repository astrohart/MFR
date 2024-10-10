using PostSharp.Patterns.Threading;
using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>SolutionCloseFailed</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class SolutionCloseFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) A <see cref="T:System.Exception" /> that explains the reason for
        /// the failure.
        /// </param>
        public SolutionCloseFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Exception" /> instance that explains the reason for
        /// the failure.
        /// </summary>
        public Exception Exception
        {
            get;
        }
    }
}