using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;

namespace MFR.Operations.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MFR.Operations.Events.OperationStartedEventHandler"/>.
    /// </summary>
[ExplicitlySynchronized]
    public class OperationStartedEventArgs : OperationEventArgs
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
        public OperationStartedEventArgs(OperationType operationType) : base(operationType) { }
    }
}