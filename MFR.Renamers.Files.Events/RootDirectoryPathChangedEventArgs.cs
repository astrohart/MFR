using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>RootDirectoryPathChanged</c> event handlers.
    /// </summary>
    public class RootDirectoryPathChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="newPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the new
        /// fully-qualified pathname of a folder from which all operations start.
        /// </param>
        public RootDirectoryPathChangedEventArgs(string newPath)
        {
            NewPath = newPath;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the new root directory path.
        /// </summary>
        public string NewPath
        {
            get;
        }
    }
}