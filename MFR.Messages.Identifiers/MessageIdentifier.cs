using MFR.Messages.Identifiers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Messages.Identifiers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all message
    /// identifier objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class MessageIdentifier : IMessageIdentifier
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

        /// <summary>
        /// Expresses this object instance as a <see cref="T:System.Guid" /> that uniquely
        /// identifies the message.
        /// </summary>
        /// <returns></returns>
        public Guid ToGuid()
            => this; // use the implicit conversion operator

        public static implicit operator Guid(MessageIdentifier identifier)
        {
            var result = Guid.Empty;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Expressing message '{identifier.Name}' as a GUID..."
                );

                if (identifier == null) return result;
                if (identifier.MessageId.IsZero()) return result;

                result = identifier.MessageId;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Message {identifier.Name} = '{result}'."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Guid.Empty;
            }

            return result;
        }

        /// <summary>
        /// Expresses an instance of an object that implements the
        /// <see cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
        /// interface as a <see cref="T:System.Guid" /> value.
        /// </summary>
        /// <param name="id">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
        /// interface.
        /// </param>
        /// <returns></returns>
        public static Guid ToGuid(IMessageIdentifier id)
        {
            var result = Guid.Empty;

            try
            {
                if (id == null) return result;
                if (Guid.Empty.Equals(id.MessageId))
                    return result;

                result = id.MessageId;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Guid.Empty;
            }

            return result;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => $"{{ Name = '{Name}', MessageId = '{MessageId}' }}";
    }
}