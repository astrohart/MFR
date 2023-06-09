using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Providers.Events
{
    /// <summary>
    /// Provides information for <c>ConfigurationLoaded</c> event handlers.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationLoadedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Events.ConfigurationLoadedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the configuration file that was most recently loaded.
        /// </param>
        public ConfigurationLoadedEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        public string Pathname
        {
            get;
        }
    }
}