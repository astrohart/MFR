using System;

namespace MFR.Messages.Constants
{
    /// <summary>
    /// Base class for all message-type "enumeration" classes.
    /// </summary>
    /// <remarks>
    /// This object provides services that are common to all message-type objects.
    /// </remarks>
    public abstract class MessageType
    {
        /// <summary>
        /// Reference to a <see cref="T:System.Guid" /> that is the unique ID of
        /// the command referenced by this type.
        /// </summary>
        protected Guid _messageId;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        protected MessageType(Guid messageId)
        {
            _messageId = messageId;
        }
    }
}