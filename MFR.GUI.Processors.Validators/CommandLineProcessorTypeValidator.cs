using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Processors.Validators
{
    /// <summary>
    /// Validates the type of a command-line processor.
    /// </summary>
    public class
        CommandLineProcessorTypeValidator : ICommandLineProcessorTypeValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineProcessorTypeValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineProcessorTypeValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Validators.Interfaces.ICommandLineProcessorTypeValidator" />
        /// interface.
        /// </summary>
        public static ICommandLineProcessorTypeValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new CommandLineProcessorTypeValidator();

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
        public bool IsValid(CommandLineProcessorType type)
        {
            var result = false;

            try
            {
                // Dump the argument of the parameter, 'type', to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"CommandLineProcessorTypeValidator.IsValid: type = '{type}'"
                );

                /*
                 * For cybersecurity reasons, and to defeat reverse-engineering,
                 * check the value of the 'type' parameter to ensure that it
                 * is not set to a value outside the set of valid values defined
                 * by the MFR.GUI.Processors.Constants.CommandLineProcessorType
                 * enumeration.
                 *
                 * In principle, since all C# enums devolve to integer values, a
                 * hacker could insert a different value into the CPU register that the
                 * 'type' parameter is read from and thereby make this application
                 * do something it's not intended to do.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CommandLineProcessorTypeValidator.IsValid: Checking whether the value of the 'type' parameter, i.e., '{type}', is within the defined value set of the MFR.GUI.Processors.Constants.CommandLineProcessorType enumeration..."
                );

                // Check whether the value of the 'type' parameter is within the defined value set of its 
                // enumerated data.  If this is not the case, then write an error message to the log
                // file, and then terminate the execution of this method while returning the default return
                // value.
                if (!Enum.IsDefined(typeof(CommandLineProcessorType), type))
                {
                    // The value of the 'type' parameter is NOT within the defined value set 
                    // of the MFR.GUI.Processors.Constants.CommandLineProcessorType enumeration.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The value of the 'type' parameter, i.e., '{type}', is NOT within the defined value set of the MFR.GUI.Processors.Constants.CommandLineProcessorType enumeration.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CommandLineProcessorTypeValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CommandLineProcessorTypeValidator.IsValid: *** SUCCESS *** The value of the 'type' parameter, i.e., '{type}', is within the defined value set of the MFR.GUI.Processors.Constants.CommandLineProcessorType enumeration.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineProcessorTypeValidator.IsValid: Checking whether the 'Unknown' value has NOT been specified for the 'type' parameter..."
                );

                // Check whether the 'Unknown' value has been specified for the 'type' parameter.  If this is the case, then
                // write an error message to the log file, and then terminate the execution 
                // of this method, returning the default return value in order to indicate
                // that this method failed.
                if (CommandLineProcessorType.Unknown.Equals(type))
                {
                    // The 'Unknown' value has been specified for the 'type' parameter.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The 'Unknown' value has been specified for the 'type' parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CommandLineProcessorTypeValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineProcessorTypeValidator.IsValid: *** SUCCESS *** The 'Unknown' value has NOT been specified for the 'type' parameter.  Proceeding..."
                );

                /*
                 * If we made it here with no Exception(s) getting caught, then
                 * assume that the value supplied to this method is valid.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"CommandLineProcessorTypeValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}