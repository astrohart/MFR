using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories.Properties;
using System;
using xyLOGIX.Core.Debug;

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
            IAction<TInput, TResult> result;

            try
            {
                switch (actionType)
                {
                    case var _ when actionType ==
                                    ProfileCollectionActionType.LoadStringFromRegistry:
                        result =
                            (IAction<TInput, TResult>)
                            GetLoadProfileCollectionFilePathFromRegistryAction.SoleInstance();
                        break;

                    case var _ when actionType ==
                                    ProfileCollectionActionType.CreateNewNamedProfile:
                        result =
                            (IAction<TInput, TResult>)GetCreateNewNamedProfileAction
                                .SoleInstance();
                        break;

                    case var _ when actionType ==
                                    ProfileCollectionActionType.LoadProfileCollectionFromFile:
                        result =
                            (IAction<TInput, TResult>)GetLoadProfileCollectionFromFileAction
                                .SoleInstance();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(actionType), actionType,
                            string.Format(Resources.Error_NoActionAvailable, actionType)
                        );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}