using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Results.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>Error Report Dialog Launch Results</c> object.
    /// </summary>
    /// <remarks>
    /// Such an object describes the output of the choices made by the user when the
    /// <c>Error Report</c> dialog box is shown.
    /// </remarks>
    public interface IErrorReportDialogLaunchResults : IDialogBoxResults
    {
        /// <summary>
        /// Gets a reference to an instance of an <see cref="T:System.Exception" /> object
        /// that describes, in detail, the error which occurred.
        /// </summary>
        Exception Exception
        {
            get;
        }

        /// <summary>
        /// Gets a string tht contains the detailed error report.
        /// </summary>
        string ErrorReportContents
        {
            get;
        }

        /// <summary>
        /// Gets a string that contains the user's description of the events leading up to
        /// the error.
        /// </summary>
        string ReproductionSteps
        {
            get;
        }
    }
}