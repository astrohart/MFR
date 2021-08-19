using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Interfaces;

namespace MFR.Objects.Messages
{
    /// <summary>
    /// Defines the methods, properties, and other functionality that are common
    /// to all objects that are tagged with a
    /// <see
    ///     cref="T:MFR.Objects.MessageType" />
    /// enumeration value.
    /// </summary>
    public abstract class
        FixedMessageTypeSpecificObjectBase : IFixedMessageTypeSpecificObject
    {
        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.Objects.MessageType" />
        /// that is
        /// being used to identify which message this is.
        /// </summary>
        public abstract MessageType MessageType
        {
            get;
        }
    }
}