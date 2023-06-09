using MFR.Events.Common;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Providers.Events
{
    /// <summary>
    /// Provides information for <c>ConfigurationLoadFailed</c> event handlers.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationLoadFailedEventArgs : ExceptionRaisedEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Events.ConfigurationLoadFailedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) Reference to an instance of a <see cref="T:System.Exception" />
        /// that was recently caught upon the failure to load configuration settings for
        /// the application.
        /// </param>
        public ConfigurationLoadFailedEventArgs(Exception exception) : base(
            exception
        ) { }
    }
}