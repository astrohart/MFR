using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Messages.Constants
{
    /// <summary>
    /// Base class for all message-type "enumeration" classes.
    /// </summary>
    /// <remarks>
    /// This object provides services that are common to all message-type objects.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public abstract class MessageType
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        protected MessageType(Guid messageId, string description)
        {
            MessageId = messageId;
            Description = description;
        }

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
            Description = string.Empty;
            MessageId = messageId;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a user-friendly description
        /// of this message type.
        /// </summary>
        protected string Description
        {
            get;
        }

        /// <summary>
        /// Reference to a <see cref="T:System.Guid" /> that is the unique ID of
        /// the command referenced by this type.
        /// </summary>
        protected Guid MessageId
        {
            get;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => string.IsNullOrWhiteSpace(Description)
                ? base.ToString()
                : Description;
    }
}