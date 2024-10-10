using PostSharp.Patterns.Threading;
using System;

namespace MFR.GUI.Dialogs.Events
{
    /// <summary>
    /// Provides information for a Modified event.
    /// </summary>
    [ExplicitlySynchronized]
    public class ModifiedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets a value indicating whether a Modified event has been
        /// handled. Can be set by handlers of the event.
        /// </summary>
        public bool Handled
        {
            get;
            set;
        }
    }
}