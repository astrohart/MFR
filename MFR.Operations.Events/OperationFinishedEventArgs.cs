using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;

namespace MFR.Operations.Events
{
    /// <summary>
    /// Contains the data for a OperationFinished event.
    /// </summary>
[ExplicitlySynchronized]
    public class OperationFinishedEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.OperationEventArgs"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="operationType">
        /// (Required.) One of the <see
        /// cref="T:MFR.Operations.Constants.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public OperationFinishedEventArgs(OperationType operationType) : base(operationType) { }
    }
}