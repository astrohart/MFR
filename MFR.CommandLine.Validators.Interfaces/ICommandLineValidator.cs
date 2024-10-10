using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Validators.Events;
using MFR.Directories.Validators.Interfaces;
using MFR.Validators.Interfaces;

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
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface with this validator object.
        /// </summary>
        /// <param name="rootDirectoryPathValidator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="rootDirectoryPathValidator" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        ICommandLineValidator AssociateWithRootDirectoryPathValidator(
            IRootDirectoryPathValidator rootDirectoryPathValidator);

        /// <summary>
        /// Gets a value indicating whether the specified
        /// <paramref
        ///     name="cmdInfo" />
        /// refers to a valid set of command-line argument values.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that represents the object whose properties' values are to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="cmdInfo" /> object's
        /// properties contain valid values, according to the current validation rules.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="cmdInfo" /> parameter is passed a
        /// <see langword="null" /> reference, this method raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid" />
        /// event and then increments the value of the
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property, and then this method does no further processing.
        /// <para />
        /// Otherwise, the object whose reference is passed in the
        /// <paramref name="cmdInfo" /> parameter is validated.  The
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property is used to keep track of the number of validation failures that occur.
        /// <para />
        /// At the beginning of this method's execution, the
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property's value is set to zero.
        /// </remarks>
        bool Validate(ICommandLineInfo cmdInfo);
    }
}