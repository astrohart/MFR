using MFR.Objects.Configuration.Commands;
using MFR.Objects.Configuration.Commands.Constants;
using MFR.Objects.Messages.Commands;
using MFR.Objects.Messages.Commands.Interfaces;
using MFR.Objects.Messages.Constants;
using System;

namespace MFR.Profiles.Commands.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see
    /// cref="T:MFR.Objects.ICommand"/> interface, that define operations on the profile list file and its data.
    /// </summary>
    /// <remarks>
    /// In our vernacular, a <c>command</c> object is an object that performs an
    /// operation that accepts input, but has no output.
    /// </remarks>
    public static class GetProfileListCommand
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see
        /// cref="T:MFR.Objects.ICommand"/> interface and returns a reference to it.
        /// </summary>
        public static ICommand<TInput> For<TInput>(MessageType type)
            where TInput : class
        {
            ICommand<TInput> command;

            switch (type)
            {
                case var _ when type == ProfileListCommand.SaveProfileListPathToRegistry:
                    command =
                        (ICommand<TInput>)SaveStringToRegistryCommand.Instance;
                    break;

                case var _ when type == ProfileListCommand.SaveProfileListToFile:
                    command =
                        (ICommand<TInput>)SaveProfileListToFileCommand
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