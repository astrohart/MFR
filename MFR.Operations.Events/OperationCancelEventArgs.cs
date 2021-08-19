using MFR.Operations.Constants;
using System.ComponentModel;

namespace MFR.Operations.Events
{
    /// <summary>
    /// Contains data for an OperationCanceled event.
    /// </summary>
    public class OperationCancelEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.OperationEventArgs"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the <see
        /// cref="T:MFR.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public OperationCancelEventArgs(OperationType type)
        {
            OperationType = type;
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