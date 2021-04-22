using MFR.Objects.CommandLine.Validators.Interfaces;

namespace MFR.Objects.CommandLine.Validators.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
    /// interface.
    /// </summary>
    public static class GetRootDirectoryValidator
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface and returns a reference to it.
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