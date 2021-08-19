using MFR.CommandLine.Validators.Events;

namespace MFR.CommandLine.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>
    /// Command-Line Validator
    /// </c>
    /// object.
    /// </summary>
    public interface ICommandLineValidator : IValidator
    {
        /// <summary>
        /// Occurs once for each validation failure.
        /// </summary>
        event CommandLineInfoInvalidEventHandler CommandLineInfoInvalid;

        /// <summary>
        /// Associates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface with this validator object.
        /// </summary>
        /// <param name="rootDirectoryValidator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="rootDirectoryValidator" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        ICommandLineValidator AssociateWithRootDirectoryValidator(
            IRootDirectoryValidator rootDirectoryValidator);

        /// <summary>
        /// Gets a value indicating whether the specified
        /// <paramref
        ///     name="cmdInfo" />
        /// refers to a valid set of command-line argument values.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:MFR.CommandLine.CommandLineInfo" />
        /// that is the
        /// object to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="cmdInfo" /> object's
        /// properties contain valid values.
        /// </returns>
        bool IsValid(CommandLineInfo cmdInfo);
    }
}