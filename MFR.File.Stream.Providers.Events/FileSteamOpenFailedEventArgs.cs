using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileSteamOpenFailed</c> event handlers.
    /// </summary>
    public class FileSteamOpenFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileSteamOpenFailedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which a file stream could not allocated.
        /// </param>
        public FileSteamOpenFailedEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of a file for whom a file stream could not be opened.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}