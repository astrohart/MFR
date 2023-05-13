namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Represents a handler for a <c>FileSteamOpenFailed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:MFR.File.Stream.Providers.Events.FileSteamOpenFailedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>FileSteamOpenFailed</c> event.
    /// </remarks>
    public delegate void FileSteamOpenFailedEventHandler(object sender,
        FileSteamOpenFailedEventArgs e);
}