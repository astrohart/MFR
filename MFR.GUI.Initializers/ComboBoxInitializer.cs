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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Initializers.ComboBoxInitializer" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ComboBoxInitializer() { }

        private static void AddCurrentItemToComboBox(
            [NotLogged] IEntryRespectingComboBox comboBox,
            [NotLogged] IList<string> itemList,
            [NotLogged] string currentItem
        )
        {
            try
            {
                if (comboBox == null) return;
                if (comboBox.IsDisposed) return;

                // Nothing to do if the 'currentItem' is null, empty, or all whitespace.
                if (string.IsNullOrWhiteSpace(currentItem)) return;

                if (itemList == null || itemList.Count <= 0)
                {
                    comboBox.Items.AddDistinct(currentItem);
                    return;
                }

                // If we are here, then the itemList has greater than zero element(s) in it.
                // Check to see if the 'currentItem' is already in the itemList.  If so, then stop.
                // Otherwise, add it to the combobox.

                if (itemList.Contains(currentItem)) return;

                comboBox.Items.AddDistinct(currentItem);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private static void AddItemsToComboBox(
            [NotLogged] IEntryRespectingComboBox comboBox,
            [NotLogged] IList<string> itemList
        )
        {
            try
            {
                if (comboBox == null) return;
                if (comboBox.IsDisposed) return;
                if (itemList == null) return;
                if (itemList.Count <= 0) return;

                foreach (var item in itemList)
                {
                    if (string.IsNullOrWhiteSpace(item)) continue;

                    comboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

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
                if (comboBox == null) return;
                if (comboBox.IsDisposed) return;

                comboBox.Items.Clear();

                AddCurrentItemToComboBox(comboBox, itemList, currentItem);

                AddItemsToComboBox(comboBox, itemList);

                if (string.IsNullOrWhiteSpace(currentItem))
                    comboBox.SelectedIndex = 0;
                else
                    comboBox.Text = currentItem;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}