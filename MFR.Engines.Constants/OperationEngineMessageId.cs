using System;

namespace MFR.Engines.Constants
{
    /// <summary>
    /// Encapsulates a unique identifier for a message, as well as its name.
    /// </summary>
    public class OperationEngineMessageId : MessageIdBase
    {
        /// <summary>
        /// s
        /// Allows us to pass instances of this class to methods that accept a
        /// <see cref="T:System.Guid" /> as an input parameter.
        /// </summary>
        /// <param name="id">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MFR.Engines.Constants.OperationEngineMessageId" /> to be
        /// converted.
        /// </param>
        public static implicit operator Guid(OperationEngineMessageId id)
            => id.MessageId;
    }
}