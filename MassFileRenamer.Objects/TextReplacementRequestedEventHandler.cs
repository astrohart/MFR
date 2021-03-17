namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the method signature for the handlers of a
    /// TextReplacementRequested event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MassFileRenamer.Objects.TextReplacementRequestedEventArgs" />
    /// that contains the event data.
    /// </param>
    public delegate void TextReplacementRequestedEventHandler(object sender,
        TextReplacementRequestedEventArgs e);
}