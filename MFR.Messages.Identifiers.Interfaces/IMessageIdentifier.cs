using System;

namespace MFR.Messages.Identifiers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a message ID object.
    /// </summary>
    /// <remarks>These objects uniquely identify messages and also give them names.</remarks>
    public interface IMessageIdentifier
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Guid" /> value that uniquely identifies the
        /// message.
        /// </summary>
        Guid MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that names this message
        /// identifier.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether the value of the
        /// <see
        ///     cref="P:MFR.Engines.Constants.OperationEngineMessageId.OperationEngineMessageId" />
        /// property is set
        /// to the Zero GUID.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see
        ///     cref="P:MFR.Engines.Constants.OperationEngineMessageId.OperationEngineMessageId" />
        /// property is set
        /// to the Zero GUID; <see langword="false" /> otherwise.
        /// </returns>
        bool IsZero();

        /// <summary>
        /// Expresses this object instance as a <see cref="T:System.Guid" /> that uniquely
        /// identifies the message.
        /// </summary>
        /// <returns></returns>
        Guid ToGuid();
    }
}