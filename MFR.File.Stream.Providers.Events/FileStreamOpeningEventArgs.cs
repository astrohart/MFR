using System;

namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Provides information for <c>FileStreamOpening</c> event handlers.
    /// </summary>
    /// <remarks>
    /// A <c>FileStreamOpening</c> event is raised when a <c>FileStream</c> is about to
    /// be
    /// opened upon a specific file.
    /// <para />
    /// This object conveys information about the fully-qualified pathname of the
    /// particular file on which the <c>FileStream</c> is to be opened.
    /// </remarks>
    public class FileStreamOpeningEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that is about to have a <c>FileStream</c> opened upon it.
        /// </param>
        public FileStreamOpeningEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file on which a stream is about to be opened.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}