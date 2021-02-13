namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the method signature for the handlers of a ConfigurationImported event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MassFileRenamer.Objects.ConfigurationImportedEventArgs" />
    /// that contains the event data.
    /// </param>
    public delegate void ConfigurationImportedEventHandler(object sender,
        ConfigurationImportedEventArgs e);
}