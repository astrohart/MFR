namespace MFR.File.Stream.Providers.Events
{
    /// <summary>
    /// Represents a handler for a <c>FileHostDisposed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.File.Stream.Providers.Events.FileHostDisposedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>FileHostDisposed</c> event.
    /// </remarks>
    public delegate void FileHostDisposedEventHandler(object sender,
        FileHostDisposedEventArgs e);
}