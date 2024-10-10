using System.Collections.Generic;

namespace MFR.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of all Validator objects.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Gets a collection of strings, each of which contains an error message.
        /// </summary>
        IList<string> Errors
        {
            get;
        }

        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid" />
        /// method was called.
        /// </summary>
        int ValidationFailures
        {
            get;
        }

        /// <summary>
        /// Gets a collection of strings, each of which contains a warning message.
        /// </summary>
        IList<string> VWarnings
        {
            get;
        }
    }
}