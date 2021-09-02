using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.Messages.Actions.Interfaces;
using System;

namespace MFR.GUI.Launchers.Dialogs.Actions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IAction" />
    /// interface and that summon and collect results from the various dialog boxes
    /// that are invoked by the commands in this application.
    /// </summary>
    public static class GetDialogLauncherAction
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IAction" />
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
        public static IAction<TInput, TResult> For<TInput, TResult>(
            DialogLauncherAction actionType) where TInput : class
            where TResult : class
        {
            IAction<TInput, TResult> action;

            switch (actionType)
            {
                case var _ when actionType ==
                                DialogLauncherAction.LaunchErrorReportDialog:
                    action =
                        (IAction<TInput, TResult>)
                        LaunchErrorReportDialogAction.Instance;
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