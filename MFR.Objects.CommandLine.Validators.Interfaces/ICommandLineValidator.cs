using MFR.Objects.CommandLine.Validators.Events;

namespace MFR.Objects.CommandLine.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>
    /// Command-Line
    /// Validator
    /// </c>
    /// object.
    /// </summary>
    public interface ICommandLineValidator
    {
        /// <summary>
        /// Occurs when validation rules have determined that the value of the <see cref="P:MFR.Objects.CommandLine.CommandLineInfo.RootDirectory"/> property is invalid.
        /// </summary>
        event RootDirectoryInvalidEventHandler RootDirectoryInvalid;
    }
}