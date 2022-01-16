namespace MFR.CommandLine.Parsers.Events
{
    /// <summary>
    /// Represents a handler for a DisplayHelp event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// DisplayHelp event.
    /// </remarks>
    public delegate void DisplayHelpEventHandler(object sender,
        DisplayHelpEventArgs e);
}