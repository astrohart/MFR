namespace MFR.Managers.RootFolders.Events
{
    /// <summary>
    /// Represents a handler for a RootFolderAdded event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// RootFolderAdded event.
    /// <para />
    /// The event should be raised by the
    /// <see cref="T:MFR.Managers.RootFolders.RootFolderPathManager" /> class when a
    /// folder is added to its collection of root folders.
    /// </remarks>
    public delegate void RootFolderAddedEventHandler(object sender,
        RootFolderAddedEventArgs e);
}