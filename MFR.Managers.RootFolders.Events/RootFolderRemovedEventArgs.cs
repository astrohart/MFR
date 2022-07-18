namespace MFR.Managers.RootFolders.Events
{
    /// <summary>
    /// Provides information for RootFolderRemoved event handlers.
    /// </summary>
    public class RootFolderRemovedEventArgs : RootFolderEventArgsBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs" /> and
        /// returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname to the root folder
        /// that has just been removed.
        /// </param>
        public RootFolderRemovedEventArgs(string path) : base(path) { }
    }
}
