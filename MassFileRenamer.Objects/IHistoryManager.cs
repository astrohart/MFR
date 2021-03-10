namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a history manager
    /// object for the configuration.
    /// </summary>
    public interface IHistoryManager : IConfigurationComposedObject
    {
        /// <summary>
        /// Clears all the history objects in a configuration object.
        /// </summary>
        void ClearAll();
    }
}