using System;

namespace MFR.Renamers.Files.Watchers.Constants
{
    /// <summary>
    /// Contains the identifiers to be utilized in order to tag those messages
    /// sent by the Root Directory Watcher object.
    /// </summary>
    public static class RootDirectoryWatcherMessages
    {
        /// <summary>
        /// Unique identifier for a message that indicates that the folder in which all the
        /// operations that this application performs are to start, has itself been
        /// renamed,
        /// </summary>
        public static readonly Guid
            RDWM_ROOT_DIRECTORY_RENAMED = Guid.NewGuid();
    }
}