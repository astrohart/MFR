namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Represents a handler for a <c>SolutionClosed</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.Renamers.Files.Events.SolutionClosedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>SolutionClosed</c> event.
    /// <para />
    /// The <c>SolutionClosed</c> event is used to indicate that a running
    /// instance of Visual Studio has just finished closing/unloading a Visual Studio
    /// Solution (<c>*.sln</c>) file.
    /// </remarks>
    public delegate void SolutionClosedEventHandler(
        object sender,
        SolutionClosedEventArgs e
    );
}