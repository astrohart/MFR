using MFR.GUI.Controls.Constants;
using System;

namespace MFR.GUI.Controls.Events
{
    /// <summary>
    /// Arguments for a <c>ListBuilderEventHandler</c>-style event.
    /// </summary>
    public class ListBuilderEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Controls.Events.ListBuilderEventArgs" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="side">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Controls.Constants.ListBuilderSide" /> values that
        /// indicates on which side of the list-builder control did the user last act.
        /// </param>
        public ListBuilderEventArgs(ListBuilderSide side)
        {
            Side = side;
        }

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Controls.Constants.ListBuilderSide" /> enumeration
        /// value that indicates on which side of the list-builder control did the user
        /// act.
        /// </summary>
        public ListBuilderSide Side
        {
            get;
        }
    }
}