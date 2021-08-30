using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Interfaces;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Launchers.Dialogs
{
    /// <summary>
    /// Provides helper methods to launch the error dialog.
    /// </summary>
    /// <remarks>
    /// The error dialog typically is utilized to provide the user with a
    /// helpful way to deal with, basically, otherwise-unhandled exceptions, and
    /// to send the resulting error information to xyLOGIX.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class ErrorReportDialogLauncher : IErrorReportDialogLauncher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ErrorReportDialogLauncher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ErrorReportDialogLauncher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher" />.
        /// </summary>
        public static IErrorReportDialogLauncher Instance
        {
            get;
        } = new ErrorReportDialogLauncher();

        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with
        /// recovering from an application-specific error i.e., an
        /// otherwise-unhandled exception.
        /// </summary>
        /// <param name="parms">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// <para />
        /// This object describes the values of the parameters this method needs to launch
        /// the dialog.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the means used by the user to dismiss the dialog.
        /// </returns>
        public DialogResult Launch(IErrorReportDialogLaunchParams parms)
        {
            var result = DialogResult.None;

            try
            {
                using (var dialog = MakeNewErrorReportDialog.FromScratch()
                    .ForException(parms.Exception))
                {
                    if (parms.ViewHandler != null)
                        dialog.AttachViewErrorReportRequestedEventHandler(
                            parms.ViewHandler
                        );
                    if (parms.SendHandler != null)
                        dialog.AttachSemdErrorReportRequestedEventHandler(
                            parms.SendHandler
                        );

                    result = parms.Owner == null
                        ? dialog.ShowDialog()
                        : dialog.ShowDialog(parms.Owner);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = DialogResult.None;
            }

            return result;
        }
    }
}