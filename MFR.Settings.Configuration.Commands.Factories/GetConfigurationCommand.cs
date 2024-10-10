using MFR.Settings.Configuration.Commands.Constants;
using MFR.Messages.Commands;
using MFR.Messages.Commands.Interfaces;
using MFR.Messages.Constants;
using System;

namespace MFR.Settings.Configuration.Commands.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see
    /// cref="T:MFR.ICommand"/> interface, that define operations on the configuration file and its data.
    /// </summary>
    /// <remarks>
    /// In our vernacular, a <c>command</c> object is an object that performs an
    /// operation that accepts input, but has no output.
    /// </remarks>
    public static class GetConfigurationCommand
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see
        /// cref="T:MFR.ICommand"/> interface and returns a reference to it.
        /// </summary>
        public static ICommand<TInput> For<TInput>(MessageType type)
            where TInput : class
        {
            ICommand<TInput> command;

            switch (type)
            {
                case var _ when type == ConfigurationCommandType.SaveConfigurationFilePathToRegistry:
                    command =
                        (ICommand<TInput>)SaveStringToRegistryCommand.Instance;
                    break;

                case var _ when type == ConfigurationCommandType.SaveConfigurationToFile:
                    command =
                        (ICommand<TInput>)SaveConfigurationToFileCommand
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no command available that corresponds to the message type '{type}'."
                    );
            }

            return command;
        }
    }
}