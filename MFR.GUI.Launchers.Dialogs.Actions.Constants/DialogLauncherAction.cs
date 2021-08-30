using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Launchers.Dialogs.Actions.Constants
{
    /// <summary>
    /// Available commands for use when working with error reports.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class DialogLauncherAction : ActionType
    {
        /// <summary>
        /// Launches the error report dialog box.
        /// </summary>
        public static readonly DialogLauncherAction LaunchErrorReportDialog =
            new DialogLauncherAction(Guid.NewGuid());

        /// <summary>
        /// Launches the Help dialog tghat explains what Profiles are.
        /// </summary>
        public static readonly DialogLauncherAction LaunchHelpExplainerDialog =
            new DialogLauncherAction(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherAction" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public DialogLauncherAction(Guid messageId) : base(messageId) { }
    }
}