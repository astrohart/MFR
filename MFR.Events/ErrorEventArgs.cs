using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Provides information for <c>Error</c> event handlers.
    /// </summary>
    /// <remarks>
    /// The <c>Error</c> event is typically raised when an error occurs that's not
    /// triggered by an actual <see cref="T:System.Exception" />.
    /// </remarks>
[ExplicitlySynchronized]
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Events.ErrorEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="message">
        /// (Required.) A <see cref="T:System.String" /> containing the message that
        /// describes the error.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="message" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public ErrorEventArgs(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(message)
                );
            Message = message;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the message that describes the
        /// error.
        /// </summary>
        public string Message
        {
            get;
        }
    }
}