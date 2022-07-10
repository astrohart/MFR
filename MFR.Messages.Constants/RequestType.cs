using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Messages.Constants
{
    /// <summary>
    /// Base class for pseudo-enumerations of request types.
    /// </summary>
    /// <remarks>
    /// A request is a sub-category of message where no data is passed to the message
    /// handler's code by the message's sender, but the message handler is expected to
    /// return data to the message's sender.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class RequestType : MessageType
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.RequestType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public RequestType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.RequestType" />
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
        public RequestType(Guid messageId, string description) : base(
            messageId, description
        ) { }
    }
}