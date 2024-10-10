using PostSharp.Patterns.Threading;
using System;

namespace MFR.Settings.Configuration.Events
{
    /// <summary>
    /// Provides information for ConfigurationExported event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class ConfigurationExportedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs"/>
        /// and returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname to the file where
        /// configuration data was exported to.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path"/>, is passed
        /// a blank or <see langword="null" /> value.
        /// </exception>
        public ConfigurationExportedEventArgs(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            Path = path;
        }

        /// <summary>
        /// Gets a string containing the pathname to the file where the
        /// configuration data was exported to.
        /// </summary>
        public string Path
        {
            get;
        }
    }
}