using MFR.Paths.Profiles.Provider.Interfaces;

namespace MFR.Paths.Profiles.Provider.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
    /// interface.
    /// </summary>
    public static class GetProfileListPathProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
        /// interface.
        /// </returns>
        public static IProfileListPathProvider SoleInstance()
            => ProfileListPathProvider.Instance;
    }
}