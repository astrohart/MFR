using PostSharp.Patterns.Threading;
using System;

namespace MFR.GUI.Windows.Presenters.Events
{
    /// <summary>
    /// Provides information for CreateNewBlankProfileRequested event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class CreateNewBlankProfileRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="name">
        /// (Required.) String containing the name to be assigned to the new profile.
        /// </param>
        public CreateNewBlankProfileRequestedEventArgs(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets a string that contains the name that the user wants to use for the new
        /// Profile.
        /// </summary>
        public string Name
        {
            get;
        }
    }
}