using System;

namespace MFR.Operations.Exceptions
{
    /// <summary>
    /// Signals that a request has been made to abort an operation.
    /// </summary>
    public class OperationAbortedException : Exception
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Operations.Exceptions.OperationAbortedException"/> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        public OperationAbortedException(string message) : base(message) { }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Operations.Exceptions.OperationAbortedException"/> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference.
        /// </param>
        public OperationAbortedException(string message,
            Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Operations.Exceptions.OperationAbortedException"/> and
        /// returns a reference to it.
        /// </summary>
        protected OperationAbortedException()
        {
        }
    }
}