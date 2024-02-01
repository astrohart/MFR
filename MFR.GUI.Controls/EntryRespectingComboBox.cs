using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.UI.Dark.Controls;

namespace MFR.GUI.Controls
{
    /// <summary>
    /// Dropdown combo box that respects typed-in text entries.
    /// </summary>
    /// <remarks>
    /// By "respects typed-in text entries," what we mean to say is, "does not
    /// make a typed in text entry go away, or get replaced by an auto-correct
    /// entry from the auto-suggest list, when the input focus leaves the
    /// control," which seems to be the default behavior. This is detrimental to
    /// the software meeting certain requirements.  Therefore, this object was
    /// engineered in the hopes of making that behavior go away.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class EntryRespectingComboBox : DarkComboBox,
        IEntryRespectingComboBox
    {
        /// <summary>
        /// Gets the text, verbatim, that was typed in the Combo Box's editing
        /// field, by the user.
        /// </summary>
        /// <remarks>
        /// This property only works for a
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBox" />
        /// whose style is set to
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBoxStyle.DropDown" />
        /// . Otherwise,
        /// it returns the value of the
        /// <see
        ///     cref="P:System.Windows.Forms.ComboBox.Text" />
        /// property.
        /// </remarks>
        public string EnteredText
        {
            get {
                var result = string.Empty;

                try
                {
                    if (InvokeRequired)
                        Invoke(new Func<string>(() => EnteredText));
                    else
                        result = base.Text;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }

            set {
                try
                {
                    if (InvokeRequired)
                        Invoke(new Action<string>(SetEnteredText), value);
                    else
                        SetEnteredText(value);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Sets the value of the
        /// <see cref="P:MFR.GUI.Controls.EntryRespectingComboBox.EnteredText" /> property
        /// to the specified <paramref name="text" />.
        /// </summary>
        /// <param name="text">
        /// (Required.) A <see cref="T:System.String" /> containing the new value to set
        /// for the property.
        /// </param>X
        private void SetEnteredText(string text)
            => base.Text = text;
    }
}