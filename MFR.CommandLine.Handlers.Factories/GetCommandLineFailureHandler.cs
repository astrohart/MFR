using MFR.CommandLine.Handlers.Constants;
using MFR.CommandLine.Handlers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.CommandLine.Handlers.Factories
{
    /// <summary>
    /// Obtains references to instances of objects that implement the
    /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
    /// interface that change depending on the strategy desired.
    /// </summary>
    public static class GetCommandLineFailureHandler
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:MFR.CommandLine.Handlers.Factories.GetCommandLineFailureHandler" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetCommandLineFailureHandler() { }

        /// <summary>
        /// Obtains a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
        /// interface which corresponds to the specified meeting
        /// <paramref name="outcome" />.
        /// </summary>
        /// <param name="outcome">
        /// (Required.) One of the
        /// <see cref="T:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome" />
        /// enumeration values that describes the outcome of parsing the command line and
        /// any validation failure(s) encountered.
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
        /// interface which corresponds to the specific enumeration value that is specified
        /// for the argument of the <paramref name="outcome" /> parameter; otherwise, if
        /// the specified <paramref name="outcome" /> is not within the defined value set
        /// of the
        /// <see cref="T:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome" />
        /// enumeration, or it is not supported, then a <see langword="null" /> reference
        /// is returned.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the enumeration value passed for the argument of the
        /// <paramref name="outcome" /> parameter.
        /// </remarks>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static ICommandLineFailureHandler For(
            CommandLineHandingOutcome outcome
        )
        {
            ICommandLineFailureHandler result = default;

            try
            {
                switch (outcome)
                {
                    case CommandLineHandingOutcome.DoNothing:
                        result = GetDoNothingCommandLineFailureHandler
                            .SoleInstance();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(outcome), outcome,
                            $"The command-line handling outcome, '{outcome}', is not currently supported."
                        );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}