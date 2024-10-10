using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.GUI.Launchers.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.GUI.Launchers.Dialogs.Actions
{
    /// <summary>
    /// Launches the Error Report dialog box and collects the results.
    /// </summary>
    public class LaunchErrorReportDialogAction : ActionBase<
        IErrorReportDialogLaunchParams, IErrorReportDialogLaunchResults>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LaunchErrorReportDialogAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LaunchErrorReportDialogAction() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LaunchErrorReportDialogAction Instance
        {
            [DebuggerStepThrough] get;
        } = new LaunchErrorReportDialogAction();

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
            [DebuggerStepThrough] get;
        } = DialogLauncherActionType.LaunchErrorReportDialog;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
        /// interface.
        /// <para />
        /// This object's properties are initialized with the results of the user's choices
        /// in the dialog box.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IErrorReportDialogLaunchResults CommonExecute()
            => GetErrorReportDialogLauncher.SoleInstance()
                                           .Launch(Input);
    }
}
