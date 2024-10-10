namespace MFR.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of the <see
    /// cref="E:MFR.FileSystemEntrySkippedEventHandler.FileSystemEntrySkipped"/> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see
    /// cref="T:MFR.FileSystemEntrySkippedEventArgs"/> that
    /// contains the event data.
    /// </param>
    public delegate void FileSystemEntrySkippedEventHandler(object sender, FileSystemEntrySkippedEventArgs e);
}