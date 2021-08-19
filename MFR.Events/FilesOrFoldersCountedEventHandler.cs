namespace MFR.Objects.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of the <see
    /// cref="E:MFR.Objects.FilesOrFoldersCountedEventHandler.FilesOrFoldersCounted"/> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Objects.FilesOrFoldersCountedEventArgs"/>
    /// that contains the event data.
    /// </param>
    public delegate void FilesOrFoldersCountedEventHandler(object sender,
       FilesOrFoldersCountedEventArgs e);
}