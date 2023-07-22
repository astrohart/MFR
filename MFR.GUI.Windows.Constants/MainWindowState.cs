namespace MFR.GUI.Windows.Constants
{
    /// <summary>
    /// Values that describe the state of the main application window.
    /// </summary>
    public enum MainWindowState
    {
        /// <summary>
        /// The main application window is waiting for user input.
        /// </summary>
        Idle,

        /// <summary>
        /// The application is busy performing user-requested operations.
        /// </summary>
        PerformingOperations,

        /// <summary>
        /// The user-requested operations have finished.
        /// </summary>
        OperationsFinished,

        /// <summary>
        /// Unknown state.
        /// </summary>
        Unknown = -1
    }
}