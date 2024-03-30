using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.GUI.Launchers.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Launchers.Dialogs.Actions
{
    /// <summary>
    /// Launches the Profile Name dialog box and collects the results.
    /// </summary>
    public class LaunchProfileNameDialogAction : ActionBase<
        IProfileNameDialogLaunchParams, IProfileNameDialogLaunchResults>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LaunchProfileNameDialogAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LaunchProfileNameDialogAction() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Actions.LaunchProfileNameDialogAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LaunchProfileNameDialogAction Instance
        {
            get;
        } = new LaunchProfileNameDialogAction();

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.MessageType" />
        /// that is
        /// being used to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
        {
            get;
        } = DialogLauncherActionType.LaunchProfileNameDialog;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface.
        /// <para />
        /// This object's properties are initialized with the results of the user's choices
        /// in the dialog box.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IProfileNameDialogLaunchResults CommonExecute()
            => GetProfileNameDialogLauncher.SoleInstance()
                                           .Launch(Input);
    }
}
