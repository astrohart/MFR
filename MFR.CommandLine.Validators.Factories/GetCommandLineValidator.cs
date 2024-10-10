using MFR.CommandLine.Validators.Interfaces;
using MFR.Directories.Validators.Factories;
using PostSharp.Patterns.Diagnostics;

namespace MFR.CommandLine.Validators.Factories
{
    /// <summary>
    /// Provides access to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
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
                                   .AssociateWithRootDirectoryPathValidator(
                                       GetRootDirectoryPathValidator.SoleInstance()
                                   );
    }
}