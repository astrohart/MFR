using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Interfaces;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Factories;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
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
    public class ErrorReportDialogLauncher : IErrorReportDialogLauncher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ErrorReportDialogLauncher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ErrorReportDialogLauncher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher" />.
        /// </summary>
        public static IErrorReportDialogLauncher Instance
        {
            [DebuggerStepThrough] get;
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
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
        /// interface that describes the results of the user's choices in the dialog box.
        /// </returns>
        public IErrorReportDialogLaunchResults Launch(
            IErrorReportDialogLaunchParams parms)
        {
            IErrorReportDialogLaunchResults results;

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
                        dialog.AttachSendErrorReportRequestedEventHandler(
                            parms.SendHandler
                        );

                    var dialogResult = parms.Owner == null
                        ? dialog.ShowDialog()
                        : dialog.ShowDialog(parms.Owner);

                    results =
                        MakeNewErrorReportDialogLaunchResults
                            .WithPropertyValues(
                                dialogResult, dialog.Exception,
                                dialog.ErrorReportContents,
                                dialog.ReproductionSteps
                            );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                results = null;
            }

            return results;
        }
    }
}
