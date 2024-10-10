using MFR.Errors.Reports.Commands.Constants;
using MFR.Errors.Reports.Commands.Factories;
using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.GUI.Launchers.Dialogs.Actions.Factories;
using MFR.GUI.Launchers.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Displayers
{
    /// <summary>
    /// Contains methods to display dialog boxes.
    /// </summary>
    public static class Display
    {
        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> that describes the
        /// error to be reported.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="exception" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        /// <remarks>
        /// This method invokes a user-friendly dialog box that prompts the user
        /// to type in what happened that led to the error encountered.
        /// <para />
        /// This method associates the
        /// <see cref="M:MFR.GUI.Displayers.Display.OnViewErrorReportRequested" /> method
        /// as a handler of the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </remarks>
        public static void ErrorReportDialog(Exception exception)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Display.ErrorReportDialog: Checking whether the variable 'exception' has a null reference for a value..."
                );

                // Check to see if the variable, exception, is null. If it is, send an error to the log file and quit, returning from the method.
                if (exception == null)
                {
                    // the variable exception is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Display.ErrorReportDialog: *** ERROR ***  The 'exception' variable has a null reference.  Stopping..."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, exception, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Display.ErrorReportDialog: *** SUCCESS *** The 'exception' variable has a valid object reference for its value.  Proceeding..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            if (exception == null)
                throw new ArgumentNullException(nameof(exception));

            GetDialogLauncherAction
                .For<IErrorReportDialogLaunchParams,
                    IErrorReportDialogLaunchResults>(
                    DialogLauncherActionType.LaunchErrorReportDialog
                )
                .WithInput(
                    (IErrorReportDialogLaunchParams)
                    MakeNewErrorReportDialogLaunchParams.FromScratch()
                        .ForException(exception)
                        .AndAttachViewErrorReportRequestedEventHandler(
                            OnViewErrorReportRequested
                        )
                        .AndAttachSendErrorReportRequestedEventHandler(
                            OnSendErrorReportRequested
                        )
                        .AndOwnerWindow(Application.OpenForms[0])
                )
                .Execute();
        }

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// The object that implements this interface represents the parent window of the
        /// dialog box.
        /// </param>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> that describes the
        /// error to be reported.
        /// </param>
        /// <remarks>
        /// This method also associates the
        /// <see cref="M:MFR.GUI.Displayers.Display.OnViewErrorReportRequested" /> method
        /// as the handler for the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </remarks>
        public static void ErrorReportDialog(
            IWin32Window owner,
            Exception exception
        )
            => GetDialogLauncherAction
               .For<IErrorReportDialogLaunchParams,
                   IErrorReportDialogLaunchResults>(
                   DialogLauncherActionType.LaunchErrorReportDialog
               )
               .WithInput(
                   (IErrorReportDialogLaunchParams)
                   MakeNewErrorReportDialogLaunchParams.FromScratch()
                       .ForException(exception)
                       .AndAttachViewErrorReportRequestedEventHandler(
                           OnViewErrorReportRequested
                       )
                       .AndOwnerWindow(owner)
               )
               .Execute();

        /// <summary>
        /// Shows a Help window that explains Profiles to the user.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// The object that implements this interface represents the parent window of the
        /// dialog box.
        /// </param>
        public static void HelpProfileExplainerDialog(IWin32Window owner)
            => GetHelpProfileExplainerDialogLauncher.SoleInstance()
                                                    .Launch(owner);

        /// <summary>
        /// Shows a Help window that explains Profiles to the user.
        /// </summary>
        public static void HelpProfileExplainerDialog()
            => GetHelpProfileExplainerDialogLauncher.SoleInstance()
                                                    .Launch(
                                                        Application.OpenForms[0]
                                                    );

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> that
        /// specifies whether the dialog should be launched to create a new profile, or
        /// save an existing profile with a new name.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface whose properties are set to the results of the user's selections in
        /// the dialog box.
        /// </returns>
        public static IProfileNameDialogLaunchResults ProfileNameDialogBox(
            ProfileCreateOperationType type
        )
            => GetDialogLauncherAction
               .For<IProfileNameDialogLaunchParams,
                   IProfileNameDialogLaunchResults>(
                   DialogLauncherActionType.LaunchProfileNameDialog
               )
               .WithInput(
                   (IProfileNameDialogLaunchParams)
                   MakeNewProfileNameDialogLaunchParams.FromScratch()
                       .ForProfileCreateOperationType(type)
                       .AndOwnerWindow(Application.OpenForms[0])
               )
               .Execute();

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> that
        /// specifies whether the dialog should be launched to create a new profile, or
        /// save an existing profile with a new name.
        /// </param>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface whose properties are set to the results of the user's selections in
        /// the dialog box.
        /// </returns>
        public static IProfileNameDialogLaunchResults ProfileNameDialogBox(
            ProfileCreateOperationType type,
            IWin32Window owner
        )
            => GetDialogLauncherAction
               .For<IProfileNameDialogLaunchParams,
                   IProfileNameDialogLaunchResults>(
                   DialogLauncherActionType.LaunchProfileNameDialog
               )
               .WithInput(
                   (IProfileNameDialogLaunchParams)
                   MakeNewProfileNameDialogLaunchParams.FromScratch()
                       .ForProfileCreateOperationType(type)
                       .AndOwnerWindow(owner)
               )
               .Execute();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewErrorReportRequested" />
        /// event raised by the Error Report dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by launching Notepad to view the detailed report.</remarks>
        private static void OnViewErrorReportRequested(
            object sender,
            ViewErrorReportRequestedEventArgs e
        )
            => GetErrorReportCommand.For<ViewErrorReportRequestedEventArgs>(
                                        ErrorReportCommandType
                                            .ViewErrorReportWithNotepad
                                    )
                                    .WithInput(e)
                                    .Execute();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.SendErrorReportRequested" />
        /// event raised by the Error Report dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by launching Notepad to view the detailed report.</remarks>
        private static void OnSendErrorReportRequested(
            object sender,
            SendErrorReportRequestedEventArgs e
        )
            => GetErrorReportCommand
               .For<SendErrorReportRequestedEventArgs>(
                   ErrorReportCommandType.SendErrorReport
               )
               .WithInput(e)
               .Execute();
    }
}