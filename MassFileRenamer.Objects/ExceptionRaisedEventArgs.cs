using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MassFileRenamer.Objects.ExceptionRaisedEventHandler"/>.
    /// </summary>
    public class ExceptionRaisedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.ExceptionRaisedEventArgs"/> and
        /// returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="exception"/>, is
        /// passed a <c>null</c> reference for a value.
        /// </exception>
        public ExceptionRaisedEventArgs(Exception exception)
        {
            Exception = exception ??
                        throw new ArgumentNullException(nameof(exception));
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Exception"/> instance
        /// that describes the error that occurred.
        /// </summary>
        public Exception Exception
        {
            get;
        }
    }
}