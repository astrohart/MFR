namespace MFR.GUI.Controls.Constants
{
    /// <summary>
    /// Values that indicate which side of a List Builder control that the user has
    /// acted upon.
    /// </summary>
    public enum ListBuilderSide
    {
        /// <summary>
        /// The user has acted on the list that is on the left-hand side of the control.
        /// </summary>
        /// <remarks>
        /// The left-hand side listbox of a list-builder control typically displays items
        /// that are available for selection in the list of desired items.
        /// </remarks>
        Left,

        /// <summary>
        /// The user has acted on the list that is on the right-hand side of the control.
        /// </summary>
        /// <remarks>
        /// The listbox on the right-hand side of a list-builder control typically displays
        /// items that are desired by the user to be in a certain collection.
        /// </remarks>
        Right,

        /// <summary>
        /// Unknown side of the list-builder control.
        /// </summary>
        Unknown = -1
    }
}