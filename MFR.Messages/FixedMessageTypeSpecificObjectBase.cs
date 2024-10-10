using MFR.Messages.Constants;
using MFR.Messages.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Messages
{
    /// <summary>
    /// Defines the methods, properties, and other functionality that are common
    /// to all objects that are tagged with a
    /// <see
    ///     cref="T:MFR.MessageType" />
    /// enumeration value.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class
        FixedMessageTypeSpecificObjectBase : IFixedMessageTypeSpecificObject
    {
        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.MessageType" />
        /// that is
        /// being used to identify which message this.
        /// </summary>
        public abstract MessageType MessageType
        {
            get;
        }
    }
}