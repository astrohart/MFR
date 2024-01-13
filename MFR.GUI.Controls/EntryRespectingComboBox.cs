using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;
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
        /// String containing the text most recently typed into the editing
        /// field of the ComboBox by the user.
        /// </summary>
        private string _enteredText;

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
            get
                => string.IsNullOrWhiteSpace(_enteredText) ||
                   DropDownStyle != ComboBoxStyle.DropDown
                    ? Text
                    : _enteredText;
            set => Text = _enteredText = value;
        }
    }
}