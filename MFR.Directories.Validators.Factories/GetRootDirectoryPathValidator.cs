using MFR.Directories.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Directories.Validators.Factories
{
    /// <summary>
    /// Provides access to the sole instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
    /// interface.
    /// </summary>
    public static class GetRootDirectoryPathValidator
    {
        /// <summary>
        /// Provides access to the sole instance of the object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IRootDirectoryPathValidator SoleInstance()
            => RootDirectoryPathValidator.Instance;
    }
}