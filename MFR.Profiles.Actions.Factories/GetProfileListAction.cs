using MFR.Objects.Configuration.Actions;
using MFR.Objects.Messages.Actions.Interfaces;
using MFR.Profiles.Actions.Constants;
using System;

namespace MFR.Profiles.Actions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IAction" />
    /// interface.
    /// </summary>
    public static class GetProfileListAction
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IAction" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="actionType">
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
        /// in the <paramref name="actionType" /> parameter.
        /// </exception>
        public static IAction<TInput, TResult>
            For<TInput, TResult>(ProfileListAction actionType) where TInput : class
            where TResult : class
        {
            IAction<TInput, TResult> action;

            switch (actionType)
            {
                case var _ when actionType == ProfileListAction.LoadStringFromRegistry:
                    action =
                        (IAction<TInput, TResult>)LoadProfileListFilePathFromRegistryAction
                            .Instance;
                    break;

                case var _ when actionType == ProfileListAction.LoadProfileListFromFile:
                    action =
                        (IAction<TInput, TResult>)
                            LoadConfigurationFromFileAction.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(actionType), actionType,
                        $"There is no message available that corresponds to the type '{actionType}'."
                    );
            }

            return action;
        }
    }
}