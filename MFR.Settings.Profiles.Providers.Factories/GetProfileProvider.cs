using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Settings.Profiles.Providers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetProfileProvider
    {
        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IProfileProvider SoleInstance()
            => ProfileProvider.Instance;
    }
}