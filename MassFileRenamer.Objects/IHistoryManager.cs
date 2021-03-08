namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a history manager
    /// object for the configuration.
    /// </summary>
    public interface IHistoryManager
    {
        /// <summary>
        /// Fluent-builder method to associate this History Manager object with
        /// a configuration object.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface. This object represents the settings chosen by the user to
        /// change the behavior of this app.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        IHistoryManager AttachConfig(IConfiguration configuration);

        /// <summary>
        /// Clears all the history objects in a configuration object.
        /// </summary>
        void ClearAll();
    }
}