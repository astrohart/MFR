using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Win32.Interact;
using static System.String;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Expose static methods to show data and messages to the interactive user.
    /// </summary>
    /// <remarks>
    /// The methods of this class are designed to be used to ensure that
    /// information, data, and/or messages are displayed on the UI thread.
    /// </remarks>
    public static class Display
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Windows.Actions.Display" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Display() { }

        /// <summary>
        /// Displays a message box that asks the user a Yes/No question, and
        /// returns a <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// describes the choice selected.
        /// <para />
        /// The <b>No</b> button has the input focus upon display of the message box by
        /// default, but this can be changed by supplying one of the
        /// <see cref="T:System.Windows.Forms.MessageBoxDefaultButton" /> values for the
        /// <paramref name="defaultButton" /> parameter.
        /// </summary>
        /// <param name="parentForm">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface.
        /// <para />
        /// This object represents the parent (owner) window of the message box.
        /// <para />
        /// If <see langword="null" /> is passed to this method, then the overload of this
        /// method that does not accept this parameter is called, and the resulting message
        /// box is displayed without an owner window.
        /// </param>
        /// <param name="message">
        /// (Required.) String containing the message to be
        /// displayed.
        /// </param>
        /// <param name="defaultButton">
        /// (Required.) One of the
        /// <see cref="T:System.Windows.Forms.MessageBoxDefaultButton" /> values that
        /// specifies which button is to have the input focus by default.
        /// <para />
        /// This parameter is set to
        /// <see cref="T:System.Windows.Forms.MessageBoxDefaultButton.Button2" /> if not
        /// specified by the caller.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the button clicked by the user.
        /// <para />
        /// If the <b>Yes</b> button is clicked, then
        /// <see cref="T:System.Windows.Forms.DialogResult.Yes" /> is returned.
        /// <para />
        /// If the <b>No</b> button is clicked, then
        /// <see cref="T:System.Windows.Forms.DialogResult.No" /> is returned.
        /// </returns>
        public static DialogResult ConfirmWithYesNo(
            [NotLogged] IForm parentForm,
            [NotLogged] string message,
            MessageBoxDefaultButton defaultButton =
                MessageBoxDefaultButton.Button2
        )
        {
            var result = DialogResult.None;

            try
            {
                if (parentForm == null) return result;
                if (parentForm.IsDisposed) return result;
                if (IsNullOrWhiteSpace(message)) return result;

                parentForm.InvokeIfRequired(
                    () => result = Messages.ConfirmWithYesNo(
                        parentForm, message, defaultButton
                    )
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = DialogResult.None;
            }

            return result;
        }

        /// <summary>
        /// Shows a <c>Stop</c> message to the user, usually to indicate a fatal error that
        /// prevents further successful application execution.
        /// </summary>
        /// <param name="parentForm">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface representing the
        /// parent, or owner, form of the message box that will be displayed.
        /// </param>
        /// <param name="message">
        /// (Required.) A <see cref="T:System.String" /> containing a message that is to be
        /// displayed.
        /// </param>
        /// <remarks>
        /// This method ensures that the message is displayed on the UI thread.
        /// <para />
        /// If the argument of the <paramref name="parentForm" /> is a
        /// <see langword="null" /> reference, or if the <paramref name="message" /> is
        /// blank, then this method takes no action.
        /// </remarks>
        public static void StopError(
            [NotLogged] IForm parentForm,
            [NotLogged] string message
        )
        {
            try
            {
                if (parentForm == null) return;
                if (parentForm.IsDisposed) return;
                if (IsNullOrWhiteSpace(message)) return;

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