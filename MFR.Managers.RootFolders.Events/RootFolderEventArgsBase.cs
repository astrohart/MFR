using System;

namespace MFR.Managers.RootFolders.Events
{
    /// <summary>
    /// Defines methods and properties that are common to all the event-argument
    /// objects that deal with root folder paths.
    /// </summary>
    public abstract class RootFolderEventArgsBase : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderAdded" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname to the root folder
        /// that has just been added.
        /// </param>
        protected RootFolderEventArgsBase(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Gets or sets the fully-qualified pathname of the root folder that has been
        /// added.
        /// </summary>
        public string Path
        {
            get;
        }
    }
}
