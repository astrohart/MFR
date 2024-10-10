using MFR.GUI.Dialogs.Events;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using System;

namespace MFR.GUI.Launchers.Dialogs.Params
{
    /// <summary>
    /// Parameters for launching an Error Report dialog.
    /// </summary>
    public class ErrorReportDialogLaunchParams : DialogLaunchParamBase,
        IErrorReportDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets a reference to a <see cref="T:System.Exception" /> that describes
        /// the error being reported.
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to the
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewHandler" />
        /// -typed delegate that will be called when the user requests to view the detailed
        /// error report.
        /// </summary>
        public ViewErrorReportRequestedEventHandler ViewHandler
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to the
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler" />
        /// -typed delegate that will be called when the user requests to send the detailed
        /// error report.
        /// </summary>
        public SendErrorReportRequestedEventHandler SendHandler
        {
            get;
            set;
        }
    }
}