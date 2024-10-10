using MFR.Settings.Configuration.Interfaces;

namespace MFR.Managers.History.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a history manager
    /// object for the config.
    /// </summary>
    public interface IHistoryManager : IConfigurationComposedObject
    {
        /// <summary>
        /// Clears all the history objects in a config object.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the Clear operation was carried out
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        bool ClearAll();
    }
}