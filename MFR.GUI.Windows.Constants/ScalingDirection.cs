namespace MFR.GUI.Windows.Constants
{
    /// <summary>
    /// Values to indicate which aspect of a <see cref="T:System.Windows.Forms.Form" />
    /// rectangle need to be scaled responsively for different monitor resolutions.
    /// </summary>
    public enum ScalingDirection
    {
        /// <summary>
        /// The height is being scaled.
        /// </summary>
        Height,

        /// <summary>
        /// The left edge of the form is being moved.
        /// </summary>
        Left,

        /// <summary>
        /// The top edge of the form is being moved.
        /// </summary>
        Top,

        /// <summary>
        /// The width of the form is being scaled.
        /// </summary>
        Width,

        /// <summary>
        /// Unknown scaling direction.
        /// </summary>
        Unknown = -1
    }
}