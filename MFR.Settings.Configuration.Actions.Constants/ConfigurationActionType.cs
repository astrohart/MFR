using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Actions.Constants
{
    /// <summary>
    /// Available actions for use when working with configuration.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationActionType : ActionType
    {
        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static readonly ConfigurationActionType
            LoadConfigurationFromFile = new ConfigurationActionType(
                Guid.NewGuid(), nameof(LoadConfigurationFromFile)
            );

        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        public static readonly ConfigurationActionType LoadStringFromRegistry =
            new ConfigurationActionType(
                Guid.NewGuid(), nameof(LoadStringFromRegistry)
            );

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Actions.Constants.ConfigurationAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationActionType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Actions.Constants.ConfigurationAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationActionType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}
