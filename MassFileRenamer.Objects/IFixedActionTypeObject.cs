﻿namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// tagged with one of the <see
    /// cref="T:MassFileRenamer.Objects.MessageType"/> enumeration values.
    /// </summary>
    /// <remarks>
    /// Objects that implement this interface should treat the configuration
    /// message type as being immutable.
    /// </remarks>
    public interface IFixedMessageTypeObject
    {
        /// <summary>
        /// Gets the <see
        /// cref="T:MassFileRenamer.Objects.MessageType"/> that is
        /// being used to identify which message this is.
        /// </summary>
        MessageType MessageType
        {
            get;
        }
    }
}