using System;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
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
        ///     cref="T:MassFileRenamer.Objects.EntryRespectingComboBox" />
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
            set => _enteredText = value;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Leave" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            _enteredText = Text; // save off the value of the Text property.
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (EnteredText != Text)
                Text = EnteredText;
        }
    }
}