using MFR.CommandLine.Parsers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.CommandLine.Parsers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" /> interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetCommandLineParser
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" /> interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" /> interface.
        /// </returns>
        public static ICommandLineParser SoleInstance()
            => CommandLineParser.Instance;
    }
}