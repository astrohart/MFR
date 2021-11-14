using MFR.CommandLine.Models.Interfaces;

namespace MFR.CommandLine.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface,
    /// and returns references to them.
    /// </summary>
    public static class MakeNewCommandLineInfo
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </returns>
        public static ICommandLineInfo FromScratch()
            => new CommandLineInfo();
    }
}