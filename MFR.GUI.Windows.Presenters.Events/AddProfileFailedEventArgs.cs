using PostSharp.Patterns.Threading;
using MFR.GUI.Windows.Presenters.Events.Properties;
using System;

namespace MFR.GUI.Windows.Presenters.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventHandler" />
    /// .
    /// </summary>
[ExplicitlySynchronized]
    public class AddProfileFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of
        /// <see cref="T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="message">
        /// (Required.) String containing the error message to display to the user, or
        /// write to the log file, that explains why the Add Profile operation has failed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="message" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public AddProfileFailedEventArgs(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(message)
                );
            Message = message;
        }

        /// <summary>
        /// Gets a string containing an error message that explains why the add profile
        /// operation failed.
        /// </summary>
        /// <remarks>This string can be displayed to the user or written to a log file.</remarks>
        public string Message
        {
            get;
        }
    }
}