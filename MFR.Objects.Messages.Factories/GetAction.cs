using MFR.Objects.Configuration.Actions;
using MFR.Objects.Messages.Actions;
using MFR.Objects.Messages.Actions.Interfaces;
using MFR.Objects.Messages.Constants;
using System;

namespace MFR.Objects.Messages.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IAction" />
    /// interface.
    /// </summary>
    public static class GetAction
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IAction" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Objects.Messages.Constants.MessageType" />
        /// value that
        /// indicates what action to execute.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Messages.Actions.Interfaces.IAction" />
        /// interface
        /// that corresponds to the specified
        /// <see cref="T:MFR.Objects.Messages.Constants.MessageType" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if no action is available that corresponds to the
        /// <see
        ///     cref="T:MFR.Objects.Messages.Constants.MessageType" />
        /// value provided
        /// in the <paramref name="type" /> parameter.
        /// </exception>
        public static IAction<TInput, TResult>
            For<TInput, TResult>(MessageType type) where TInput : class
            where TResult : class
        {
            IAction<TInput, TResult> action = null;

            switch (type)
            {
                case MessageType.LoadStringFromRegistry:
                    action =
                        (IAction<TInput, TResult>)LoadStringFromRegistryAction
                            .Instance;
                    break;

                case MessageType.LoadConfigurationFromFile:
                    action =
                        (IAction<TInput, TResult>)
                        LoadConfigurationFromFileAction.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no message available that corresponds to the type '{type}'."
                    );
            }

            return action;
        }
    }
}