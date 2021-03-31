using System;
using System.Windows.Forms;

namespace MFR.GUI
{
    /// <summary>
    /// Dropdown combo box that respects typed-in text entries.
    /// </summary>
    public class EntryRespectingComboBox : ComboBox
    {
        /// <summary>
        /// String containing the text most recently typed into the editing
        /// field of the ComboBox by the user.
        /// </summary>
        private string _enteredText;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.EntryRespectingComboBox" />
        /// and
        /// returns a reference to it.
        /// </summary>
        public EntryRespectingComboBox()
        {
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
        ///     cref="P:MFR.GUI.EntryRespectingComboBox.EnteredText" />
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