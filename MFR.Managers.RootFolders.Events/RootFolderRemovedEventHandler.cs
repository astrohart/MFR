namespace MFR.Managers.RootFolders.Events
{
    /// <summary>
    /// Represents a handler for a RootFolderRemoved event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// RootFolderRemoved event.
    /// </remarks>
    public delegate void RootFolderRemovedEventHandler(object sender,
        RootFolderRemovedEventArgs e);
}
