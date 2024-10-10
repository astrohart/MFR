using MFR.Metadata.Registry.Validators.Interfaces;

namespace MFR.Metadata.Registry.Validators.Factories
{
    /// <summary>
    /// Accesses the sole instance of an object that implements the
    /// <see
    ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the type of the data that is to be retrieved from the system Registry.
    /// </typeparam>
    public static class GetRegOperationMetadataValidator<T> where T : class
    {
        /// <summary>
        /// Fluently retrieves the single instance of the object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}" />
        /// interface.
        /// </returns>
        public static IRegOperationMetadataValidator<T> SoleInstance()
            => RegOperationMetadataValidator<T>.Instance;
    }
}