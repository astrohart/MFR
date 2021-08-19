using System;

namespace MFR.Profiles.Providers.Exceptions
{
    /// <summary>
    /// Exception that indicates that the developer forgot to call the
    /// <see
    ///     cref="M:MFR.ConfigurationComposedObjectBase.AndAttachConfiguration" />
    /// method when initializing an object.
    /// </summary>
    public class ProfileProviderNotAttachedException : Exception
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Exceptions.ProfileProviderNotAttachedException" />
        /// and returns a reference to it.
        /// </summary>
        public ProfileProviderNotAttachedException() : base(
            "You need to call the AndAttachProfileProvider method prior to calling this method."
        ) { }
    }
}