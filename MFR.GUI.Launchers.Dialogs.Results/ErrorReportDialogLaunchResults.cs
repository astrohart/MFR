using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results
{
    /// <summary>
    /// POCO that contains the results of the operation of showing the Error Report
    /// dialog box to the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class
        ErrorReportDialogLaunchResults : DialogBoxResultsBase, IErrorReportDialogLaunchResults
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults" />
        /// and returns a reference to it.
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
        public ErrorReportDialogLaunchResults(DialogResult dialogResult,
            Exception exception, string errorReportContents,
            string reproductionSteps) : base(dialogResult)
        {
            Exception = exception;
            ErrorReportContents = errorReportContents;
            ReproductionSteps = reproductionSteps;
        }

        /// <summary>
        /// Gets a string tht contains the detailed error report.
        /// </summary>
        public string ErrorReportContents
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of an <see cref="T:System.Exception" /> object
        /// that describes, in detail, the error which occurred.
        /// </summary>
        public Exception Exception
        {
            get;
        }

        /// <summary>
        /// Gets a string that contains the user's description of the events leading up to
        /// the error.
        /// </summary>
        public string ReproductionSteps
        {
            get;
        }
    }
}