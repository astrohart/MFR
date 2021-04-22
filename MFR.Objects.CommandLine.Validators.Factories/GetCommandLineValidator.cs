using MFR.Objects.CommandLine.Validators.Interfaces;

namespace MFR.Objects.CommandLine.Validators.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator" />
    /// interface.
    /// </summary>
    public static class GetCommandLineValidator
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static ICommandLineValidator SoleInstance()
            => CommandLineValidator.Instance
                                   .AssociateWithRootDirectoryValidator(
                                       GetRootDirectoryValidator.SoleInstance()
                                   );
    }
}