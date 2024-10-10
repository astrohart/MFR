using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with configuration.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationCommandType : CommandType
    {
        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        public static readonly ConfigurationCommandType
            SaveConfigurationFilePathToRegistry =
                new ConfigurationCommandType(Guid.NewGuid(), nameof(SaveConfigurationFilePathToRegistry));

        /// <summary>
        /// Saves the configuration to a file.
        /// </summary>
        public static readonly ConfigurationCommandType
            SaveConfigurationToFile =
                new ConfigurationCommandType(Guid.NewGuid(), nameof(SaveConfigurationToFile));

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ConfigurationCommandType Unknown =
            new ConfigurationCommandType(Guid.Empty, nameof(Unknown));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationCommandType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType" />
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
        public ConfigurationCommandType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}