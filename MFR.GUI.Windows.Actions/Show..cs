using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Expose static methods to show data and messages to the interactive user.
    /// </summary>
    public static class Display
    {
        /// <summary>
        /// Shows a <c>Stop</c> message to the user, usually to indicate a fatal error that prevents further successful application execution.
        /// </summary>
        /// <param name="parentForm">
        /// (Required.) Reference to an instance of an object that implements the <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface representing the parent, or owner, form of the message box that will be displayed.
        /// </param>
        /// <param name="message">
        /// (Required.) A <see cref="T:System.String" /> containing a message that is to be displayed.
        /// </param>
        /// <remarks>
        /// This method ensures that the message is displayed on the UI thread.
        /// <para/>
        /// If the argument of the <paramref name="parentForm"/> is a <see langword="null" /> reference, or if the <paramref name="message"/> is blank, then this method takes no action.
        /// </remarks>
        public static void StopError(IForm parentForm, string message)
        {
            try
            {
                if (parentForm == null) return;
                if (parentForm.IsDisposed) return;
                if (string.IsNullOrWhiteSpace(message)) return;

                parentForm.InvokeIfRequired(
                    () => Messages.ShowStopError(parentForm, message)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
