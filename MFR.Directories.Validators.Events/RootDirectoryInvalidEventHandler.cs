namespace MFR.Directories.Validators.Events
{
    /// <summary>
    /// Represents a handler for a RootDirectoryInvalid event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle
    /// the RootDirectoryInvalid event.
    /// </remarks>
    public delegate void RootDirectoryInvalidEventHandler(object sender,
        RootDirectoryInvalidEventArgs e);
}