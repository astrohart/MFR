using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using System;

namespace MFR.Settings.Profiles.Actions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Messages.Actions.Interfaces.IAction" />
    /// interface, in order to perform actions on the list of profiles.
    /// </summary>
    /// <remarks>
    /// In our parlance, an Action is a process that has both an input and an output.
    /// </remarks>
    public static class GetProfileCollectionAction
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.IAction" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="actionType">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// value that
        /// indicates what action to execute.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.IAction" />
        /// interface
        /// that corresponds to the specified
        /// <see cref="T:MFR.Messages.Constants.MessageType" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if no action is available that corresponds to the
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// value provided
        /// in the <paramref name="actionType" /> parameter.
        /// </exception>
        public static IAction<TInput, TResult>
            For<TInput, TResult>(ProfileCollectionActionType actionType)
            where TInput : class where TResult : class
        {
            IAction<TInput, TResult> action;

            switch (actionType)
            {
                case var _ when actionType ==
                                ProfileCollectionActionType.LoadStringFromRegistry:
                    action =
                        (IAction<TInput, TResult>)
                        LoadProfileCollectionFilePathFromRegistryAction.Instance;
                    break;

                case var _ when actionType ==
                                ProfileCollectionActionType.CreateNewNamedProfile:
                    action =
                        (IAction<TInput, TResult>)CreateNewNamedProfileAction
                            .Instance;
                    break;

                case var _ when actionType ==
                                ProfileCollectionActionType.LoadProfileCollectionFromFile:
                    action =
                        (IAction<TInput, TResult>)LoadProfileCollectionFromFileAction
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(actionType), actionType,
                        $"There is no message available that corresponds to the '{actionType}' action type."
                    );
            }

            return action;
        }
    }
}
