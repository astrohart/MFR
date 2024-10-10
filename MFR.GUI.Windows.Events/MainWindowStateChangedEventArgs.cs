using PostSharp.Patterns.Threading;
using MFR.GUI.Windows.Constants;
using System;

namespace MFR.GUI.Windows.Events
{
    /// <summary>
    /// Provides information for <c>MainWindowStateChanged</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class MainWindowStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="oldState">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" /> enumeration values
        /// that describes the former state.
        /// </param>
        /// <param name="newState">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" /> enumeration values
        /// that describes the current state.
        /// </param>
        public MainWindowStateChangedEventArgs(
            MainWindowState oldState,
            MainWindowState newState
        )
        {
            OldState = oldState;
            NewState = newState;
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" />
        /// enumeration values that describes the current state.
        /// </summary>
        public MainWindowState NewState
        {
            get;
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" />
        /// enumeration values that describes the former state.
        /// </summary>
        public MainWindowState OldState
        {
            get;
        }
    }
}