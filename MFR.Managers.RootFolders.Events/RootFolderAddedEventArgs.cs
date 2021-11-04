namespace MFR.Managers.RootFolders.Events
{
    /// <summary>
    /// Provides information for RootFolderAdded event handlers.
    /// </summary>
    public class RootFolderAddedEventArgs : RootFolderEventArgsBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname to the root folder
        /// that has just been added.
        /// </param>
        public RootFolderAddedEventArgs(string path) : base(path) { }
    }
}