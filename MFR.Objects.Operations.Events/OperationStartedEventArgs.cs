using MFR.Objects.Operations.Constants;

namespace MFR.Objects.Operations.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MFR.Objects.Operations.Events.OperationStartedEventHandler"/>.
    /// </summary>
    public class OperationStartedEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Objects.OperationEventArgs"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="operationType">
        /// (Required.) One of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public OperationStartedEventArgs(OperationType operationType) : base(operationType) { }
    }
}