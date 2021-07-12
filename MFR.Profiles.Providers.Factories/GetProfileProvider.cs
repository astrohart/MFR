using MFR.Profiles.Providers.Interfaces;

namespace MFR.Profiles.Providers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
    /// interface.
    /// </summary>
    public static class GetProfileProvider
    {
        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IProfileProvider SoleInstance()
            => ProfileProvider.Instance;
    }
}