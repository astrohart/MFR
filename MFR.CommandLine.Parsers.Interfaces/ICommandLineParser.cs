using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Events;

namespace MFR.CommandLine.Parsers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that parses
    /// the command line of the application.
    /// </summary>
    public interface ICommandLineParser
    {
        /// <summary>
        /// Parses the application's command-line arguments and sets the properties of a
        /// new instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this
        /// application.
        /// </param>
        ICommandLineInfo Parse(string[] args);

        /// <summary>
        /// Occurs when Help text is to be displayed.
        /// </summary>
        event DisplayHelpEventHandler DisplayHelp;
    }
}