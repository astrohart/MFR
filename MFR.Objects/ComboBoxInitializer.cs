using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects
{
    /// <summary>
    /// Declares methods that assist in initializing combo boxes.
    /// </summary>
    public static class ComboBoxInitializer
    {
        /// <summary>
        /// Initializes a <see cref="T:System.Windows.Forms.ComboBox"/> to have
        /// the specified <paramref name="itemList"/> as the items in its
        /// drop-down, and <paramref name="currentItem"/> as the
        /// currently-selected item.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to the <see
        /// cref="T:System.Windows.Forms.ComboBox"/> to be initialized.
        /// </param>
        /// <param name="currentItem">
        /// (Optional.) String containing the value to set as the
        /// currently-selected item in the combo box.
        /// </param>
        /// <param name="itemList">
        /// (Required.) Collection of one or more items that should be in the
        /// history list of items in the combo box's body.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameters, <paramref name="comboBox"/> and
        /// <paramref name="itemList"/>, are passed <see langword="null" /> reference for values.
        /// </exception>
        /// <remarks>
        /// This method is intended to be utilized in order to fill combo box
        /// controls with data from a data source.
        /// </remarks>
        public static void InitializeComboBox(ComboBox comboBox,
            IReadOnlyCollection<string> itemList, string currentItem = "")
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));
            if (itemList == null)
                throw new ArgumentNullException(nameof(itemList));

            comboBox.Text = currentItem;
            comboBox.Items.Clear();
            if (!string.IsNullOrWhiteSpace(currentItem))
                comboBox.Items.AddDistinct(currentItem);
            if (!itemList.Any()) return;

            foreach (var item in itemList.Distinct())
                comboBox.Items.AddDistinct(item);
        }
    }
}