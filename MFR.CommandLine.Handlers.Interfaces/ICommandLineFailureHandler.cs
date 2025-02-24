using MFR.CommandLine.Handlers.Constants;
using MFR.Directories.Validators.Events;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.CommandLine.Handlers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// handles a failure to validate the command line.
    /// </summary>
    public interface ICommandLineFailureHandler
    {
        /// <summary>
        /// Gets the
        /// <see cref="T:MFR.CommandLine.Handlers.Constants.CommandLineHandingOutcome" />
        /// enumeration values that describe the outcome of the command-line operation that
        /// this particular object is designed to handle.
        /// </summary>
        CommandLineHandingOutcome Outcome
        {
            [DebuggerStepThrough] get;
        }

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
        bool Handle([NotLogged] RootDirectoryInvalidEventArgs eventArgs);
    }
}