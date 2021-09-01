using MFR.Errors.Reports.Commands.Constants;
using MFR.Errors.Reports.Commands.Factories;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Launchers.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Factories;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Displayers
{
    /// <summary>
    /// Contains methods to display dialog boxes.
    /// </summary>
    public static class Display
    {
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
        private static void OnViewErrorReportRequested(object sender,
            ViewErrorReportRequestedEventArgs e)
            => GetErrorReportCommand
               .For<ViewErrorReportRequestedEventArgs>(
                   ErrorReportCommand.ViewErrorReportWithNotepad
               )
               .WithInput(e)
               .Execute();

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> that describes the
        /// error to be reported.
        /// </param>
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
            => GetErrorReportDialogLauncher.SoleInstance()
                                           .Launch(
                                               MakeNewErrorReportDialogLaunchParams
                                                   .FromScratch()
                                                   .ForException(exception)
                                                   .AndOwnerWindow(
                                                       Application.OpenForms[0]
                                                   )
                                                   .AndAttachViewErrorReportRequestedEventHandler(
                                                       OnViewErrorReportRequested
                                                   )
                                           );

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
        public static void ErrorReportDialog(IWin32Window owner,
            Exception exception)
            => GetErrorReportDialogLauncher.SoleInstance()
                                           .Launch(
                                               MakeNewErrorReportDialogLaunchParams
                                                   .FromScratch()
                                                   .ForException(exception)
                                                   .AndOwnerWindow(owner)
                                                   .AndAttachViewErrorReportRequestedEventHandler(
                                                       OnViewErrorReportRequested
                                                   )
                                           );
    }
}