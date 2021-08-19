using MFR.CommandLine.Validators.Interfaces;

namespace MFR.CommandLine.Validators.Factories
{
    /// <summary>
    /// Provides access to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
    /// interface.
    /// </summary>
    public static class GetCommandLineValidator
    {
        /// <summary>
        /// Provides access to the sole instance of the object that implements
        /// the
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
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