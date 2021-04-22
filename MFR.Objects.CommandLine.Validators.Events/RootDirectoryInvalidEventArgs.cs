using System;

namespace MFR.Objects.CommandLine.Validators.Events
{
    /// <summary>
    /// Provides information for RootDirectoryInvalid event handlers.
    /// </summary>
    public class RootDirectoryInvalidEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="rootDirectory">
        /// (Required.) String containing the value of the root directory
        /// specified by the user on the command line.
        /// </param>
        public RootDirectoryInvalidEventArgs(string rootDirectory)
        {
            RootDirectory = rootDirectory;
        }

        /// <summary>
        /// Gets the string containing the root directory that was specified by
        /// the user on the command line.
        /// </summary>
        public string RootDirectory
        {
            get;
        }
    }
}