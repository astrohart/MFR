using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Provides information for <c>FolderRenamed</c> event handlers.
    /// </summary>
    /// <remarks>
    /// This class is utilized in order to supply data to handlers of the
    /// <c>FolderRenamed</c> event.
    /// <para />
    /// This class has two read-only <see cref="T:System.String" /> properties,
    /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> and
    /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" />.
    /// <para />
    /// The <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> property stores
    /// the fully-qualified pathname of the previous location of a folder that has been
    /// renamed.  The <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" />
    /// property stores the fully-qualified pathname of the current location of a
    /// folder that has been renamed.
    /// <para />
    /// Callers of this class must use the class' constructor to initialize these
    /// properties.
    /// </remarks>
[ExplicitlySynchronized]
    public class FolderRenamedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Events.FolderRenamedEventArgs" />
        /// and returns a reference to it.
        /// <para />
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the previous location of a folder that has been renamed.
        /// </param>
        /// <param name="destination">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the current location of a folder that has been renamed.
        /// </param>
        /// <remarks>
        /// This constructor is utilized in order to construct a new instance of an object
        /// that supplies data to handlers of the <c>FolderRenamed</c> event.
        /// <para />
        /// This constructor has two required parameters, <paramref name="source" /> and
        /// <paramref name="destination" />.  Both must be filled in, otherwise
        /// <see cref="T:System.ArgumentException" /> is thrown.  The
        /// <paramref name="source" /> parameter should refer to the name the folder used
        /// to have, and the <paramref name="destination" /> parameter should refer to the
        /// current pathname of the folder.
        /// <para />
        /// If valid values have been passed for both the <paramref name="source" /> and
        /// <paramref name="destination" /> parameters, then this constructor sets the
        /// values of the <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> and
        /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" /> properties to
        /// the corresponding parameter values.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required
        /// parameters, <paramref name="source" /> or <paramref name="destination" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public FolderRenamedEventArgs(string source, string destination)
        {
            /*
             * BOTH the source and destination parameters are mandatory.
             */

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
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the current location of a folder that has been renamed.
        /// </summary>
        public string Destination
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the previous location of a folder that has been renamed.
        /// </summary>
        public string Source
        {
            get;
        }
    }
}