using MFR.GUI.Processors.Constants;

namespace MFR.GUI.Processors.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// validates the type of a command-line processor.
    /// </summary>
    public interface ICommandLineProcessorTypeValidator
    {
        /// <summary>
        /// Determines whether the value of the <paramref name="type" /> parameter is
        /// within the defined value set of the
        /// <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" /> values
        /// that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="type" /> is
        /// within the defined value set of the
        /// <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(CommandLineProcessorType type);
    }
}