using MFR.Metadata.Registry.Interfaces;

namespace MFR.Metadata.Registry.Validators.Interfaces
{
    /// <summary>
    /// Validates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// (Required.) Name of the data type of the information that
    /// to be accessed.
    /// </typeparam>
    public interface IRegOperationMetadataValidator<T> where T : class
    {
        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.IRegOperationMetadata" />
        /// interface
        /// that is being validated.
        /// </summary>
        IRegOperationMetadata<T> Metadata
        {
            get;
        }

        /// <summary>
        /// Initializes the value of the
        /// <see
        ///     cref="P:MFR.IRegOperationMetadataValidator.Metadata" />
        /// property to refer to the data that is to be validated.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        IRegOperationMetadataValidator<T> ForRegOperationMetadata(
            IRegOperationMetadata<T> expression);

        /// <summary>
        /// Validates the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}.Metadata" />
        /// property is valid; <see langword="false" /> otherwise.
        /// </returns>
        bool Validate();
    }
}