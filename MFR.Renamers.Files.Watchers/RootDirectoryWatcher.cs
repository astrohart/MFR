using MFR.Events;
using MFR.Renamers.Files.Watchers.Constants;
using System.IO;
using xyLOGIX.Queues.Messages;

namespace MFR.Renamers.Files.Watchers
{
    /// <summary>
    /// Watches a root directory to see if it has gotten renamed by a file operation,
    /// such as Rename Solution Folders.
    /// </summary>
    /// <remarks>
    /// We wrote this class to use the
    /// <see cref="T:System.IO.FileSystemWatcher" /> functionality to watch a starting
    /// folder for all the operations, to see if it, itself, has been renamed etc.
    /// <para />
    /// We do this because we still refer to files within this folder after we've
    /// performed the requested functions for the user; and we need to ensure we know
    /// what happened to the folder if it did indeed get touched by the operations.
    /// </remarks>
    public class RootDirectoryWatcher
    {
        /// <summary>
        /// Reference to an instance of <see cref="T:System.IO.FileSystemWatcher" /> that
        /// enables this class to respond to the circumstance that a folder has been
        /// renamed.
        /// </summary>
        private FileSystemWatcher _fileSystemWatcher;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Watchers.RootDirectoryWatcher" /> and returns a
        /// reference to it.
        /// </summary>
        public RootDirectoryWatcher(string rootDirectoryPath)
        {
            RootDirectoryPath = rootDirectoryPath;

            InitializeFileSystemWatcher();
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the root (i.e., starting) directory that is to be watched.
        /// </summary>
        public string RootDirectoryPath
        {
            get;
        }

        /// <summary>
        /// Occurs if the folder having the path stored in the
        /// <see
        ///     cref="P:MFR.Renamers.Files.Watchers.RootDirectoryWatcher.RootDirectoryPath" />
        /// property has been renamed.
        /// </summary>
        public event FolderRenamedEventHandler RootDirectoryRenamed;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Watchers.RootDirectoryWatcher.RootDirectoryRenamed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.Events.FolderRenamedEventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method also sends a message to the entire application letting the
        /// application know that an event of interest has occurred.
        /// </remarks>
        protected virtual void OnRootDirectoryRenamed(FolderRenamedEventArgs e)
        {
            RootDirectoryRenamed?.Invoke(this, e);
            SendMessage<FolderRenamedEventArgs>.Having.Args(this, e)
                                               .ForMessageId(
                                                   RootDirectoryWatcherMessages
                                                       .RDWM_ROOT_DIRECTORY_RENAMED
                                               );
        }

        /// <summary>
        /// Sets up a <see cref="T:System.IO.FileSystemWatcher" /> instance to watch over
        /// the specified
        /// <see
        ///     cref="P:MFR.Renamers.Files.Watchers.RootDirectoryWatcher.RootDirectoryPath" />
        /// to see if its name has been updated.
        /// </summary>
        private void InitializeFileSystemWatcher() { }
    }
}