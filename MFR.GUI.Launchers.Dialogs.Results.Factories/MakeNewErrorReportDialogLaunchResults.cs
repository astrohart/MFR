using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewErrorReportDialogLaunchResults
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="dialogResult">
        /// (Required.) A <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// explains what action the user took to dismiss the dialog box.
        /// </param>
        /// <param name="exception">
        /// (Required.) Reference to an instance of a <see cref="T:System.Exception" />
        /// object that describes the error that occurred.
        /// </param>
        /// <param name="errorReportContents">
        /// (Required.) String containing the contents of the detailed error report.
        /// </param>
        /// <param name="reproductionSteps">
        /// (Required.) String containing the user's description of the steps that led up
        /// to the error.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
        /// interface, initialized with the values of the parameters referenced above.
        /// </returns>
        public static IErrorReportDialogLaunchResults WithPropertyValues(
            DialogResult dialogResult, Exception exception,
            string errorReportContents, string reproductionSteps)
            => new ErrorReportDialogLaunchResults(
                dialogResult, exception, errorReportContents, reproductionSteps
            );
    }
}