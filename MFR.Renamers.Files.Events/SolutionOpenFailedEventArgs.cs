using PostSharp.Patterns.Threading;
using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>SolutionOpenFailed</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class SolutionOpenFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) A <see cref="T:System.Exception" />
        /// instance that explains why the failure happened.
        /// </param>
        public SolutionOpenFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Exception" /> instance that explains why the failure
        /// happened.
        /// </summary>
        public Exception Exception
        {
            get;
        }
    }
}