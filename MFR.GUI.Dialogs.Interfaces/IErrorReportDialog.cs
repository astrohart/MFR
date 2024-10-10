using MFR.GUI.Dialogs.Events;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the Error Report dialog.
    /// </summary>
    /// <remarks>
    /// This dialog lets the user of the application know that an error has
    /// occurred and gives the user options as to what to do with the information.
    /// </remarks>
    public interface IErrorReportDialog : IForm
    {
        /// <summary>
        /// Occurs when the user clicks the Send Report button.
        /// </summary>
        event SendErrorReportRequestedEventHandler SendErrorReportRequested;

        /// <summary>
        /// Occurs when the user requests to view the error report.
        /// </summary>
        event ViewErrorReportRequestedEventHandler ViewErrorReportRequested;

        /// <summary>
        /// Gets a string that contains the contents of an error report, given the value of
        /// the <see cref="P:MFR.GUI.Dialogs.ErrorReportDialog.Exception" /> property.
        /// </summary>
        string ErrorReportContents
        {
            [DebuggerStepThrough]
            get;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Exception" /> that describes the error
        /// that occurred.
        /// </summary>
        Exception Exception
        {
            [DebuggerStepThrough]
            get;
            [DebuggerStepThrough]
            set;
        }

        /// <summary>
        /// Gets or sets the value of the Reproduction Steps text box.
        /// </summary>
        string ReproductionSteps
        {
            [DebuggerStepThrough]
            get;
            [DebuggerStepThrough]
            set;
        }

        /// <summary>
        /// Gets a reference to the View Report link-label control.
        /// </summary>
        LinkLabel ViewReportLinkLabel
        {
            [DebuggerStepThrough]
            get;
        }
    }
}