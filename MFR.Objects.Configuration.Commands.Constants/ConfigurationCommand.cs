using MFR.Objects.Messages.Constants;
using System;

namespace MFR.Objects.Configuration.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with configuration.
    /// </summary>
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
        public static readonly ConfigurationCommand SaveStringToRegistry =
            new ConfigurationCommand(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ConfigurationCommand Unknown =
            new ConfigurationCommand(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Configuration.Commands.Constants.ConfigurationCommand" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ConfigurationCommand(Guid messageId) : base(messageId) { }
    }
}