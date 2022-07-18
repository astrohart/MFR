using System.Windows.Forms;

namespace MFR.GUI.Controls.Extensions
{
    /// <summary>
    /// Helper methods to allow us to use a
    /// <see cref="T:System.Windows.Forms.ToolStripComboBox" /> control in a fluent
    /// manner.
    /// </summary>
    public static class ToolStripComboBoxExtensions
    {
        /// <summary>
        /// Selects the first item in the <paramref name="comboBox" /> specified.
        /// <para />
        /// Does nothing is the specified <paramref name="comboBox" /> contains no items.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) The <see cref="T:System.Windows.Forms.ToolStripComboBox" /> to
        /// operate on.
        /// </param>
        public static void SelectFirstItem(this ToolStripComboBox comboBox)
        {
            if (comboBox == null || comboBox.Items == null ||
                comboBox.Items.Count == 0) return;

            comboBox.SelectedIndex = 0;

            Application.DoEvents();
        }

        /// <summary>
        /// Finds the first item in the list having the specified <paramref name="name" />;
        /// if found, the item is selected.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) The
        /// <see cref="T:System.Windows.Forms.ToolStripComboBox" /> to operate on.
        /// </param>
        /// <param name="name">(Required.) String containing the name to search for.</param>
        public static void SelectFirstItemNamed(this ToolStripComboBox comboBox,
            string name)
        {
            if (comboBox == null || comboBox.Items == null ||
                comboBox.Items.Count == 0) return;

            comboBox.SelectedIndex = 0;

            foreach (var item in comboBox.Items)
                if (item != null && name.Equals(item.ToString()))
                {
                    comboBox.SelectedItem = item;
                    break;
                }
        }
    }
}
