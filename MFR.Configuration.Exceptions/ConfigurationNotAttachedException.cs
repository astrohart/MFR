using System;

namespace MFR.Configuration.Exceptions
{
    /// <summary>
    /// Exception that indicates that the developer forgot to call the
    /// <see
    ///     cref="M:MFR.ConfigurationComposedObjectBase.AndAttachConfiguration" />
    /// method when initializing an object.
    /// </summary>
    public class ConfigurationNotAttachedException : Exception
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Configuration.Exceptions.ConfigurationNotAttachedException" />
        /// and returns a reference to it.
        /// </summary>
        public ConfigurationNotAttachedException() : base(
            "You need to call the AndAttachConfiguration method prior to calling this method."
        ) { }
    }
}