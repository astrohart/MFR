using MFR.Objects.CommandLine.Validators.Interfaces;

namespace MFR.Objects.CommandLine.Validators.Factories
{
    /// <summary>
    /// Provides access to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
    /// interface.
    /// </summary>
    public static class GetRootDirectoryValidator
    {
        /// <summary>
        /// Provides access to the sole instance of the object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IRootDirectoryValidator SoleInstance()
            => RootDirectoryValidator.Instance;
    }
}