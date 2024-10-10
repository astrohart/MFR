namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Represents a handler for a <c>SolutionOpenFailed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>SolutionOpenFailed</c> event.
    /// <para />
    /// Such an event is typically raised in the event that the attempt to open a
    /// Visual Studio Solution (<c>*.sln</c>) file in a running instance of Visual
    /// Studio has failed.
    /// </remarks>
    public delegate void SolutionOpenFailedEventHandler(
        object sender,
        SolutionOpenFailedEventArgs e
    );
}