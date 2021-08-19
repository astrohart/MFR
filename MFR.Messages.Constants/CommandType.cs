using System;

namespace MFR.Messages.Constants
{
    /// <summary>
    /// Base class for pseudo-enumerations of command types.
    /// </summary>
    public class CommandType : MessageType
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Messages.Constants.CommandType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public CommandType(Guid messageId) : base(messageId) { }
    }
}