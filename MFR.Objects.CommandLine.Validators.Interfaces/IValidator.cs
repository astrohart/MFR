namespace MFR.Objects.CommandLine.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of all Validator objects.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        ///     cref="M:MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid" />
        /// method was called.
        /// </summary>
        int ValidationFailures { get; }
    }
}