using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

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
    public class EntryRespectingComboBox : ComboBox, IEntryRespectingComboBox
    {
        /// <summary>
        /// String containing the text most recently typed into the editing
        /// field of the ComboBox by the user.
        /// </summary>
        private string _enteredText;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Controls.EntryRespectingComboBox" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public EntryRespectingComboBox()
        {
            _enteredText = Text;
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            _enteredText = Text;
        }

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

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Leave" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by saving off any text directly typed by the
        /// user into the
        /// <see
        ///     cref="P:MFR.GUI.Controls.EntryRespectingComboBox.EnteredText" />
        /// property and adding that text to the list.
        /// </remarks>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            EnteredText = Text; // save off the value of the Text property.

            if (DropDownStyle == ComboBoxStyle.DropDown &&
                !Items.Contains(EnteredText))
            {
                Items.Insert(
                    0, /* list goes by reverse chronological order of entry */
                    EnteredText
                ); // add the text typed by the user to the list of items
                SelectedIndex = 0; // select the newly-added item
            }

            ClearSelection(); // remove the highlight
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:System.Windows.Forms.ComboBox.SelectedIndexChanged" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by removing the highlight that persists in the
        /// edit portion of the control after the selection has been changed.
        /// </remarks>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            _enteredText = Text;

            ClearSelection();
        }

        /// <summary>
        /// Called to remove the selection highlight that persists on the text
        /// in the edit portion of the control even after the selection is
        /// changed or input focus leaves the control.
        /// </summary>
        private void ClearSelection()
        {
            SelectionStart = Text.Length;
            SelectionLength = 0;
        }
    }
}