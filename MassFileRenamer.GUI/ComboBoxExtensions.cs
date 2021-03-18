using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Clears all the content from the combo box referenced by the
        /// <paramref name="box" /> parameter.
        /// </summary>
        /// <param name="box">
        /// Reference to the <see cref="T:System.Windows.Forms.ComboBox" /> that
        /// is to be cleared.
        /// </param>
        /// <remarks>
        /// This method removes all the items from the combo box and then blanks
        /// out the text.
        /// </remarks>
        public static void Clear(this ComboBox box)
        {
            if (box == null) throw new ArgumentNullException(nameof(box));

            box.Items.Clear();

            if (box.DropDownStyle != ComboBoxStyle.DropDown) return;

            box.Text = box.SelectedText = string.Empty;
        }
    }
}