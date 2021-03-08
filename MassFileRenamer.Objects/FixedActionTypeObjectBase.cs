namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the methods, properties, and other functionality that are common
    /// to all objects that are tagged with a
    /// <see
    ///     cref="T:MassFileRenamer.Objects.MessageType" />
    /// enumeration value.
    /// </summary>
    public abstract class
        FixedMessageTypeObjectBase : IFixedMessageTypeObject
    {
        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MessageType" />
        /// that is
        /// being used to identify which message this is.
        /// </summary>
        public abstract MessageType MessageType
        {
            get;
        }
    }
}