using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;

namespace MFR.GUI.Launchers.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that launches
    /// the error report dialog.
    /// </summary>
    public interface IErrorReportDialogLauncher
    {
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
        /// interface.
        /// </returns>
        IErrorReportDialogLaunchResults Launch(
            IErrorReportDialogLaunchParams parms);
    }
}