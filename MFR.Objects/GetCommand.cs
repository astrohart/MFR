using System;

namespace MFR.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.ICommand" />
    /// interface.
    /// </summary>
    /// <remarks>
    /// In our vernacular, a <c>command</c> object is an object that performs an
    /// operation that accepts input, but has no output.
    /// </remarks>
    public static class GetCommand
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.ICommand" />
        /// interface and returns a
        /// reference to it.
        /// </summary>
        public static ICommand<TInput> For<TInput>(MessageType type)
            where TInput : class
        {
            ICommand<TInput> command = null;

            switch (type)
            {
                case MessageType.SaveStringToRegistry:
                    command =
                        (ICommand<TInput>)SaveStringToRegistryCommand.Instance;
                    break;

                case MessageType.SaveConfigurationToFile:
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