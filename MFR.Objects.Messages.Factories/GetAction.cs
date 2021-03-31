using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Interfaces;
using System;

namespace MFR.Objects.Messages.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IAction" />
    /// interface.
    /// </summary
    public static class GetAction
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IAction" />
        /// interface
        /// and returns a reference to it.
        /// </summary>
        public static IAction<TInput, TResult>
            For<TInput, TResult>(MessageType type)
            where TInput : class where TResult : class
        {
            IAction<TInput, TResult> action = null;

            switch (type)
            {
                case MessageType.LoadStringFromRegistry:
                    action =
                        (IAction<TInput, TResult>)
                        LoadStringFromRegistryAction.Instance;
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