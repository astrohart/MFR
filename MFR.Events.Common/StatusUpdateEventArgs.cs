using MFR.Operations.Constants;
using System;

namespace MFR.Events.Common
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:MFR.Events.Common.StatusUpdateEventHandler" />.
    /// </summary>
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
        public StatusUpdateEventArgs(string text, OperationType operationType)
        {
            Text = text;
            OperationType = operationType;
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