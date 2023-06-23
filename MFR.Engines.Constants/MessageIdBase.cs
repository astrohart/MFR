using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Constants
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a message ID object.
    /// </summary>
    /// <remarks>These objects uniquely identify messages and also give them names.</remarks>
    public interface IMessageId
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
    }

    public class MessageIdBase : IMessageId
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Guid" /> value that uniquely identifies the
        /// message.
        /// </summary>
        public Guid MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that names this message
        /// identifier.
        /// </summary>
        public string Name
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
        public bool IsZero()
        {
            bool result;

            try
            {
                result = Guid.Empty.Equals(MessageId);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => $"{{ Name = '{Name}', MessageId = '{MessageId}' }}";
    }
}