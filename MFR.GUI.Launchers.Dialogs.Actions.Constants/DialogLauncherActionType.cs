using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Launchers.Dialogs.Actions.Constants
{
    /// <summary>
    /// Available commands for use when working with error reports.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class DialogLauncherActionType : ActionType
    {
        /// <summary>
        /// Launches the Profile Name dialog box.
        /// </summary>
        public static readonly DialogLauncherActionType
            LaunchErrorReportDialog =
                new DialogLauncherActionType(Guid.NewGuid(), nameof(LaunchErrorReportDialog));

        /// <summary>
        /// Launches the Help dialog that explains what Profiles are.
        /// </summary>
        public static readonly DialogLauncherActionType
            LaunchHelpExplainerDialog =
                new DialogLauncherActionType(Guid.NewGuid(), nameof(LaunchHelpExplainerDialog));

        /// <summary>
        /// Launches the Profile Name dialog box.
        /// </summary>
        public static readonly DialogLauncherActionType
            LaunchProfileNameDialog =
                new DialogLauncherActionType(Guid.NewGuid(), nameof(LaunchProfileNameDialog));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public DialogLauncherActionType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public DialogLauncherActionType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}