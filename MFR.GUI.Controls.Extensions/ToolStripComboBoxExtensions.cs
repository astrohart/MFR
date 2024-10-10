using System.Windows.Forms;
using xyLOGIX.UI.Dark.Controls;

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
        /// Selects the first item in the <paramref name="control" /> specified.
        /// <para />
        /// Does nothing is the specified <paramref name="control" /> contains no items.
        /// </summary>
        /// <param name="control">
        /// (Required.) The <see cref="T:System.Windows.Forms.ToolStripControlHost" /> to
        /// operate on.
        /// </param>
        public static void SelectFirstItem(this ToolStripControlHost control)
        {
            if (!(control is DarkToolStripComboBox comboBox)) return;

            if (comboBox.Items == null || comboBox.Items.Count == 0) return;
            comboBox.SelectedIndex = 0;

            Application.DoEvents();
        }

        /// <summary>
        /// Finds the first item in the list having the specified <paramref name="name" />;
        /// if found, the item is selected.
        /// </summary>
        /// <param name="control">
        /// (Required.) The
        /// <see cref="T:System.Windows.Forms.ToolStripControlHost" /> to operate on.
        /// </param>
        /// <param name="name">(Required.) String containing the name to search for.</param>
        public static void SelectFirstItemNamed(
            this ToolStripControlHost control, string name)
        {
            if (!(control is DarkToolStripComboBox comboBox)) return;

            if (comboBox.Items == null || comboBox.Items.Count == 0) return;

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