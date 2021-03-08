using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Provides helper methods to launch the error dialog.
    /// </summary>
    /// <remarks>
    /// The error dialog typically is utilized to provide the user with a
    /// helpful way to deal with, basically, otherwise-unhandled exceptions, and
    /// to send the resulting error information to xyLOGIX.
    /// </remarks>
    public static class ErrorDialogLauncher
    {
        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with
        /// recovering from an application-specific error i.e., an
        /// otherwise-unhandled exception.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// This object acts as the parent window of the dialog box.
        /// </param>
        /// <param name="exception">
        /// An <see cref="T:System.Exception" /> that contains the error information.
        /// </param>
        [Log(AttributeExclude = true)]
        public static void Display(IWin32Window owner, Exception exception)
        {
            using (var dialog = new ErrorReportDialog())
            {
                dialog.Exception = exception;

                dialog.ShowDialog(owner);   // right now, we do not care about the result
            }
        }
    }
}