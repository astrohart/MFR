using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides information for a FileNameMatchRequested event.
    /// </summary>
    public class FileNameMatchRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileNameMatchRequestedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the full pathname to the file to
        /// perform a match against.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the textual criteria for the
        /// match.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the either of the required parameters,
        /// <paramref
        ///     name="path" />
        /// or <<paramref name="findWhat" />, are passed
        /// blank or <c>null</c> strings for values.
        /// </exception>
        /// <exception
        ///     cref="T:System.IO.FileNotFoundException">
        /// Thrown if the system
        /// is unable to locate the file whose pathname is specified by the
        /// <paramref name="path" /> parameter on the disk.
        /// </exception>
        public FileNameMatchRequestedEventArgs(string path, string findWhat)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    "The system cannot find the file specified.", path
                );

            Path = path;
            FindWhat = findWhat;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the file name matches
        /// the criteria.
        /// </summary>
        public bool DoesMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a string containing the textual criteria for determining
        /// whether the name of the file is to be targeted by a rename operation.
        /// </summary>
        public string FindWhat
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the file to run a
        /// match operation again.
        /// </summary>
        public string Path
        {
            get;
        }
    }
}