using MFR.GUI.Dialogs.Events;
using System;

namespace MFR.GUI.Launchers.Dialogs.Params.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a parameter POCO for launching the Error Report dialog.
    /// </summary>
    public interface IErrorReportDialogLaunchParams : IDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets a reference to a <see cref="T:System.Exception" /> that describes
        /// the error being reported.
        /// </summary>
        Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets a reference to the
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewHandler" />
        /// -typed delegate that will be called when the user requests to view the detailed
        /// error report.
        /// </summary>
        ViewErrorReportRequestedEventHandler ViewHandler { get; set; }

        /// <summary>
        /// Gets or sets a reference to the
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler" />
        /// -typed delegate that will be called when the user requests to send the detailed
        /// error report.
        /// </summary>
        SendErrorReportRequestedEventHandler SendHandler { get; set; }
    }
}