namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Represents a handler for a <c>SolutionCloseFailed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>SolutionCloseFailed</c> event.
    /// <para />
    /// This event is typically raised in the event that an attempt to close a Visual
    /// Studio Solution (<c>*.sln</c>) file that has been loaded in a running instance
    /// of Visual Studio has failed.
    /// </remarks>
    public delegate void SolutionCloseFailedEventHandler(
        object sender,
        SolutionCloseFailedEventArgs e
    );
}