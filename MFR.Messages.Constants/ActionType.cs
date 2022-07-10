using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Messages.Constants
{
    /// <summary>
    /// Base class for pseudo-enumerations of action types.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ActionType : MessageType
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.ActionType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ActionType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.ActionType" />
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
        public ActionType(Guid messageId, string description) : base(
            messageId, description
        ) { }
    }
}