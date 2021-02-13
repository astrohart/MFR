namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Represents a handler for an ConfigurationExported event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:MassFileRenamer.Objects.ConfigurationExportedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle
    /// the ConfigurationExported event.
    /// </remarks>
    public delegate void ConfigurationExportedEventHandler(object sender,
        ConfigurationExportedEventArgs e);
}