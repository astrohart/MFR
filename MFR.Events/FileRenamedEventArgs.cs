using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Provides information for FileRenamed event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class FileRenamedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Events.FileRenamedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file's former location (before the rename operation).
        /// </param>
        /// <param name="destination">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file's current location (after the rename operation).
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required
        /// parameters, <paramref name="source" /> or <paramref name="source" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public FileRenamedEventArgs(string source, string destination)
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(destination)
                );
            Source = source;
            Destination = destination;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file's current location.
        /// </summary>
        public string Destination
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file's former name.
        /// </summary>
        public string Source
        {
            get;
        }
    }
}