using MFR.File.Stream.Providers.Interfaces;

namespace MFR.File.Stream.Providers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
    /// interface.
    /// </summary>
    public static class GetFileStreamProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </returns>
        public static IFileStreamProvider SoleInstance()
            => FileStreamProvider.Instance;
    }
}