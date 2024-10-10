using PostSharp.Patterns.Threading;
using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>RootDirectoryPathChanged</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class RootDirectoryPathChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="oldPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the previous
        /// fully-qualified pathname of a folder from which all operations start.
        /// </param>
        /// <param name="newPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the new
        /// fully-qualified pathname of a folder from which all operations start.
        /// </param>
        public RootDirectoryPathChangedEventArgs(string oldPath, string newPath)
        {
            OldPath = oldPath;
            NewPath = newPath;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the new root directory path.
        /// </summary>
        public string NewPath
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the old root directory path.
        /// </summary>
        public string OldPath
        {
            get;
        }
    }
}