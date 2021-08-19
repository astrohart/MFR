using MFR.Operations.Constants;
using System;

namespace MFR.Operations.Events
{
    /// <summary>
    /// Provides methods and properties common to all event argument objects for
    /// a particular operation type.
    /// </summary>
    public class OperationEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.OperationEventArgs" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// specifies the operation being performed.
        /// </param>
        /// <exception cref="T:System.NotSupportedException">
        /// Thrown if
        /// <see
        ///     cref="T:MFR.OperationType.Unknown" />
        /// is passed
        /// for the <paramref name="operationType" /> parameter.
        /// </exception>
        public OperationEventArgs(OperationType operationType)
        {
            if (OperationType.Unknown == operationType)
                throw new NotSupportedException(
                    "The 'Unknown' OperationType value is not supported."
                );

            OperationType = operationType;
        }

        /// <summary>
        /// Gets the type of operation being performed.
        /// </summary>
        public OperationType OperationType
        {
            get;
        }
    }
}