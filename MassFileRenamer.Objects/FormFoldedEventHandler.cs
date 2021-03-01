namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides the method signature for the handler of a FormFolded event.
    /// </summary>
    /// <param name="sender">
    /// The sender of the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MassFileRenamer.Objects.FoldedEventArgs"/> that contains
    /// the event data.
    /// </param>
    public delegate void FormFoldedEventHandler(object sender, FormFoldedEventArgs e);
}