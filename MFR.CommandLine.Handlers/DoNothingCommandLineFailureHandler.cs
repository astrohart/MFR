using MFR.CommandLine.Handlers.Constants;
using MFR.CommandLine.Handlers.Interfaces;
using MFR.Directories.Validators.Events;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.CommandLine.Handlers
{
    public class
        DoNothingCommandLineFailureHandler : CommandLineFailureHandlerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DoNothingCommandLineFailureHandler() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected DoNothingCommandLineFailureHandler() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.CommandLine.Handlers.Interfaces.ICommandLineFailureHandler" />
        /// interface for the
        /// <see
        ///     cref="F:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome.DoNothing" />
        /// outcome.
        /// </summary>
        public static ICommandLineFailureHandler Instance
        {
            [DebuggerStepThrough] get;
        } = new DoNothingCommandLineFailureHandler();

        /// <summary>
        /// Gets the
        /// <see cref="T:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome" />
        /// enumeration values that describe the outcome of the command-line operation that
        /// this particular object is designed to handle.
        /// </summary>
        public override CommandLineHandingOutcome Outcome
        {
            [DebuggerStepThrough] get;
        } = CommandLineHandingOutcome.DoNothing;

        /// <summary>
        /// Handles the command-line validation failure, information about which is
        /// provided in the specified <paramref name="eventArgs" />.
        /// </summary>
        /// <param name="eventArgs">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// that specifies how the validation of the command-line argument(s) failed.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the validation operation is to be cancelled
        /// (i.e., we should just fall through and allow the application configuration to
        /// take over), or <see langword="false" /> if the loading of the application is to
        /// be stopped.
        /// </returns>
        public override bool Handle(
                [NotLogged] RootDirectoryInvalidEventArgs eventArgs
            )

            // Do nothing; let the application configuration take over.
            => true;
    }
}