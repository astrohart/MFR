﻿using System;

namespace MFR.Settings.Configuration.Events
{
    /// <summary>
    /// Provides information for <c>StartingFolderChanged</c> event handlers.
    /// </summary>
    public class StartingFolderChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="oldPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the former value of
        /// the fully-qualified pathname of the folder in which this application's
        /// operations are started.
        /// </param>
        /// <param name="newPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the current value of
        /// the fully-qualified pathname  of the folder in which this application's
        /// operations are started.
        /// </param>
        public StartingFolderChangedEventArgs(string oldPath, string newPath)
        {
            OldPath = oldPath;
            NewPath = newPath;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the current value of the
        /// fully-qualified pathname of the folder in which this application's operations
        /// are started.
        /// </summary>
        public string NewPath
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> tha contains the former value of the
        /// fully-qualified pathname of the folder in which this application's operations
        /// are started.
        /// </summary>
        public string OldPath
        {
            get;
        }
    }
}