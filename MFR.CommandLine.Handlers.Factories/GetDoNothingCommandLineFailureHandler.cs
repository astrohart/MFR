using MFR.CommandLine.Handlers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.CommandLine.Handlers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
    /// interface for the
    /// <see
    ///     cref="F:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome.DoNothing" />
    /// outcome.
    /// </summary>
    public static class GetDoNothingCommandLineFailureHandler
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:MFR.CommandLine.Handlers.Factories.GetDoNothingCommandLineFailureHandler" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetDoNothingCommandLineFailureHandler() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
        /// interface for the
        /// <see
        ///     cref="F:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome.DoNothing" />
        /// outcome.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static ICommandLineFailureHandler SoleInstance()
        {
            ICommandLineFailureHandler result;

            try
            {
                result = DoNothingCommandLineFailureHandler.Instance;
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