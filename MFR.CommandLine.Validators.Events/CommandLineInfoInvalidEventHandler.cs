namespace MFR.CommandLine.Validators.Events
{
    /// <summary>
    /// Represents a handler for a CommandLineInfoInvalid event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle
    /// the CommandLineInfoInvalid event.
    /// </remarks>
    public delegate void CommandLineInfoInvalidEventHandler(object sender,
        CommandLineInfoInvalidEventArgs e);
}