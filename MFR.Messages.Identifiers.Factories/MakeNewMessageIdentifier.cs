using MFR.Messages.Identifiers.Interfaces;
using System;

namespace MFR.Messages.Identifiers.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
    /// interface, and returns references to them.
    /// </summary>
    public static class MakeNewMessageIdentifier
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.Name" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> that contains the name of the
        /// message that is identified by this object.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IMessageIdentifier AndName(
            this IMessageIdentifier self,
            string name
        )
        {
            if (self == null) return self;
            if (string.IsNullOrWhiteSpace(name)) return self;

            self.Name = name;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Messages.Identifiers.Interfaces.IMessageIdentifier" />
        /// interface.
        /// </returns>
        public static IMessageIdentifier ForNewMessageId()
            => new MessageIdentifier { MessageId = Guid.NewGuid() };
    }
}