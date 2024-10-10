using PostSharp.Patterns.Threading;
using System;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MFR.Events.FileSystemEntrySkippedEventHandler"/>.
    /// </summary>
    [Log(AttributeExclude = true)]
[ExplicitlySynchronized]
    public class FileSystemEntrySkippedEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of <see
        /// cref="T:MFR.Events.FileSystemEntrySkippedEventArgs"/>
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname to the skipped file
        /// system entry (e.g., a file or a folder).
        /// </param>
        public FileSystemEntrySkippedEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets the pathname of the file system entry (e.g., a file or a
        /// folder) that is being skipped.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}