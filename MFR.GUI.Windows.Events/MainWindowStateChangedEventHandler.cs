namespace MFR.GUI.Windows.Events
{
    /// <summary>
    /// Represents a handler for a <c>MainWindowStateChanged</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>MainWindowStateChanged</c> event.
    /// </remarks>
    public delegate void MainWindowStateChangedEventHandler(
        object sender,
        MainWindowStateChangedEventArgs e
    );
}