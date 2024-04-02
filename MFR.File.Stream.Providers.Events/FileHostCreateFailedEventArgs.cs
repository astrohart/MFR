using PostSharp.Patterns.Threading;
using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileHostCreateFailed</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class FileHostCreateFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file on which a file stream could not be allocated.
        /// </param>
        /// <param name="exception">
        /// (Required.) A <see cref="T:System.Exception" /> instance that describes the
        /// failure reason.
        /// </param>
        public FileHostCreateFailedEventArgs(
            string pathname,
            Exception exception
        )
        {
            Pathname = pathname;
            Exception = exception;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Exception" /> instance that describes the failure
        /// reason.
        /// </summary>
        public Exception Exception
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of a file for whom a file stream could not be opened.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}
