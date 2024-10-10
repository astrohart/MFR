using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using System;

namespace MFR.GUI.Models.Events
{
    /// <summary>
    /// Provides information for <c>OperationTypeChanged</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class OperationTypeChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Models.Events.OperationTypeChangedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="oldValue">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that represents the former value.
        /// </param>
        /// <param name="newValue">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that represents the current value.
        /// </param>
        public OperationTypeChangedEventArgs(
            OperationType oldValue,
            OperationType newValue
        )
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that indicates the current operation type.
        /// </summary>
        public OperationType NewValue
        {
            get;
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that indicates the former value of the assigned
        /// <c>OperationType</c>.
        /// </summary>
        public OperationType OldValue
        {
            get;
        }
    }
}