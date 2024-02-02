using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Initializers
{
    /// <summary>
    /// Declares methods that assist in initializing combo boxes.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ComboBoxInitializer
    {
        /// <summary>
        /// Initializes a <see cref="T:System.Windows.Forms.ComboBox" /> to have
        /// the specified <paramref name="itemList" /> as the items in its
        /// drop-down, and <paramref name="currentItem" /> as the
        /// currently-selected item.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBox" />
        /// to be initialized.
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
        /// Thrown if the required parameters, <paramref name="comboBox" /> and
        /// <paramref name="itemList" />, are passed <see langword="null" />
        /// reference for values.
        /// </exception>
        /// <remarks>
        /// This method is intended to be utilized in order to fill combo box
        /// controls with data from a data source.
        /// </remarks>
        public static void InitializeComboBox(
            IEntryRespectingComboBox comboBox,
            IList<string> itemList,
            string currentItem = ""
        )
        {
            try
            {
                if (comboBox != null && !comboBox.IsDisposed)
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"ComboBoxInitializer.InitializeComboBox: Initializing the items and text of the '{comboBox.Name}' combo box..."
                    );

                if (comboBox == null) return;
                if (comboBox.IsDisposed) return;

                comboBox.Text = currentItem;
                comboBox.Items.Clear();

                if (itemList == null) return;
                if (itemList.Count == 0) return;

                /*
                 * Add the 'currentItem' to the drop-down portion of the
                 * ComboBox, but only if it is not identically equal to
                 * (modulus whitespace) the first element of the itemList.
                 */

                if (string.IsNullOrWhiteSpace(currentItem) && !currentItem
                        .Trim()
                        .Equals(
                            itemList[0]
                                .Trim()
                        ))
                    comboBox.Items.AddDistinct(currentItem);

                foreach (var item in itemList)
                    comboBox.Items.Add(item);

                comboBox.SelectedIndex = 0;

                // Dump the property comboBox.Text to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"ComboBoxInitializer.InitializeComboBox: comboBox.Text = '{comboBox.Text}'"
                );

                // Dump the property itemList.Count to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"ComboBoxInitializer.InitializeComboBox: itemList.Count = {itemList.Count}"
                );

                // Dump the property comboBox.Items.Count to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"ComboBoxInitializer.InitializeComboBox: comboBox.Items.Count = {comboBox.Items.Count}"
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}