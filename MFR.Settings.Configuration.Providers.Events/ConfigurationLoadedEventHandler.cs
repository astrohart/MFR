namespace MFR.Settings.Configuration.Providers.Events
{
    /// <summary>
    /// Represents a handler for a <c>ConfigurationLoaded</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Providers.Events.ConfigurationLoadedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>ConfigurationLoaded</c> event.
    /// </remarks>
    public delegate void ConfigurationLoadedEventHandler(object sender,
        ConfigurationLoadedEventArgs e);
}