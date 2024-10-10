using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events.Common
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:MFR.Events.ExceptionRaisedEventHandler" />.
    /// </summary>
[ExplicitlySynchronized]
    public class ExceptionRaisedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:System.Exception" />,
        /// or a child of it, that provides error details.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="exception" />, is
        /// passed a <see langword="null" /> reference for a value.
        /// </exception>
        public ExceptionRaisedEventArgs(Exception exception)
        {
            Exception = exception ??
                        throw new ArgumentNullException(nameof(exception));
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Exception" /> instance
        /// that describes the error that occurred.
        /// </summary>
        public Exception Exception
        {
            get;
        }
    }
}