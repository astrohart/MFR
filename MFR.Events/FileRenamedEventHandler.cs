namespace MFR.Events
{
    /// <summary>
    /// Represents a handler for a <c>FileRenamed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Events.FileRenamedEventArgs" /> that contains the event
    /// data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>FileRenamed</c> event.
    /// </remarks>
    public delegate void FileRenamedEventHandler(object sender,
        FileRenamedEventArgs e);
}