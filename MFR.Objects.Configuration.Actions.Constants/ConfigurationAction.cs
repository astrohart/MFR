using MFR.Objects.Messages.Constants;
using System;

namespace MFR.Objects.Configuration.Actions.Constants
{
    /// <summary>
    /// Available actions for use when working with configuration.
    /// </summary>
    public class ConfigurationAction : ActionType
    {
        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static readonly ConfigurationAction LoadConfigurationFromFile =
            new ConfigurationAction(Guid.NewGuid());

        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        public static readonly ConfigurationAction LoadStringFromRegistry =
            new ConfigurationAction(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Configuration.Actions.Constants.ConfigurationAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationAction(Guid messageId) : base(messageId) { }
    }
}