using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events.Common
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:MFR.Events.Common.StatusUpdateEventHandler" />.
    /// </summary>
    [ExplicitlySynchronized]
    public class StatusUpdateEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Events.Common.StatusUpdateEventArgs" />
        /// and returns
        /// a reference to it.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the status message text that is meant
        /// for display to the user.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that describes the operation that is currently being
        /// performed.
        /// </param>
        /// <param name="operationFinished">
        /// (Optional.) A <see cref="T:System.Boolean" /> value that indicates whether the
        /// operation is finished.
        /// <para />
        /// Default value is <see langword="false" />.
        /// </param>
        [Log(AttributeExclude = true)]
        public StatusUpdateEventArgs(
            string text,
            OperationType operationType,
            bool operationFinished = false
        )
        {
            Text = text;
            OperationFinished = operationFinished;
            OperationType = operationType;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Boolean" /> value that indicates whether the
        /// operation has completed.
        /// </summary>
        public bool OperationFinished
        {
            get;
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that indicates what operation is currently being performed.
        /// </summary>
        public OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets the textual status message that is meant for display to the user.
        /// </summary>
        public string Text
        {
            get;
        }
    }
}