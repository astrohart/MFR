using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Providers.Events
{
    /// <summary>
    /// Provides information for <c>ConfigurationFilePathChanged</c> event handlers.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationFilePathChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the configuration file that was most recently loaded.
        /// </param>
        public ConfigurationFilePathChangedEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the configuration file that was most recently loaded.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}