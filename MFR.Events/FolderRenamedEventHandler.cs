namespace MFR.Events
{
    /// <summary>
    /// Represents a handler for a <c>FolderRenamed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Events.FolderRenamedEventArgs" /> that contains the event
    /// data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>FolderRenamed</c> event.
    /// </remarks>
    public delegate void FolderRenamedEventHandler(object sender,
        FolderRenamedEventArgs e);
}