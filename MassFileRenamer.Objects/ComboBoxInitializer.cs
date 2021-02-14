using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Declares methods that assist in initializing combo boxes.
    /// </summary>
    public class ComboBoxInitializer
    {
        /// <summary>
        /// Initializes one of the combo boxes in this view.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBox" />
        /// to be initialized.
        /// </param>
        /// <param name="currentItem">
        /// (Required.) String containing the value to set as the
        /// currently-selected item in the combo box.
        /// </param>
        /// <param name="itemList">
        /// (Required.) Collection of one or more items that should be in the
        /// history list of items in the combo box's body.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameters, <paramref name="comboBox" /> and
        /// <paramref name="itemList" />, are passed <c>null</c> reference for values.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="currentItem" />, is
        /// passed a blank or <c>null</c> value.
        /// </exception>
        public static void InitializeComboBox(ComboBox comboBox,
            string currentItem, IReadOnlyCollection<string> itemList)
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));
            if (itemList == null)
                throw new ArgumentNullException(nameof(itemList));
            if (string.IsNullOrWhiteSpace(currentItem))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(currentItem)
                );

            comboBox.Text = currentItem;
            comboBox.Items.Clear();
            if (!string.IsNullOrWhiteSpace(currentItem))
                comboBox.Items.AddDistinct(currentItem);
            if (itemList.Any())
                foreach (var item in itemList.Distinct())
                    comboBox.Items.AddDistinct(item);
        }
    }
}