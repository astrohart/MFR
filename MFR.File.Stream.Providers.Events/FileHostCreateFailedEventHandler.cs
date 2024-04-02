namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Represents a handler for a <c>FileHostCreateFailed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>FileHostCreateFailed</c> event.
    /// </remarks>
    public delegate void FileHostCreateFailedEventHandler(object sender,
        FileHostCreateFailedEventArgs e);
}