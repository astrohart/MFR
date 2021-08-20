using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with configuration.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ConfigurationCommand : CommandType
    {
        /// <summary>
        /// Saves the configuration to a file.
        /// </summary>
        public static readonly ConfigurationCommand SaveConfigurationToFile =
            new ConfigurationCommand(Guid.NewGuid());

        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        public static readonly ConfigurationCommand SaveConfigurationFilePathToRegistry =
            new ConfigurationCommand(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ConfigurationCommand Unknown =
            new ConfigurationCommand(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationCommand(Guid messageId) : base(messageId) { }
    }
}