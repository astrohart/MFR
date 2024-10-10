using System;

namespace MFR.Settings.Profiles.Providers.Exceptions
{
    /// <summary>
    /// Exception that indicates that the developer forgot to call the
    /// <see
    ///     cref="M:MFR.Settings.ConfigurationComposedObjectBase.AndAttachConfiguration" />
    /// method when initializing an object.
    /// </summary>
    public class ProfileProviderNotAttachedException : Exception
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Providers.Exceptions.ProfileProviderNotAttachedException" />
        /// and returns a reference to it.
        /// </summary>
        public ProfileProviderNotAttachedException() : base(
            "You need to call the AndAttachProfileProvider method prior to calling this method."
        ) { }
    }
}