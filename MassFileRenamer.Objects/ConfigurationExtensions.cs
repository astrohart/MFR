using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Extension methods for objects implementing the
    /// <see
    ///     cref="T:MassFileRenamer.GUI.IConfiguration" />
    /// interface.
    /// </summary>
    public static class ConfigurationExtensions
    {
        public static void SaveStartingFolderAndHistory(this IConfiguration config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));


        }
    }
}