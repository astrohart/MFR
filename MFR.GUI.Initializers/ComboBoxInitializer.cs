using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Initializers
{
    /// <summary>
    /// Declares methods that assist in initializing comboboxes.
    /// </summary>
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

        /// <summary>
        /// Adds the <paramref name="currentItem" /> to the drop-down portion of the
        /// specified <paramref name="comboBox" /> if it is not already present in the
        /// provided <paramref name="itemList" />.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that represents the combobox control to which the current item is to be added.
        /// </param>
        /// <param name="itemList">
        /// (Required.) Collection of <see cref="T:System.String" /> value(s), each of
        /// which representing an item that is already present in the combobox.
        /// </param>
        /// <param name="currentItem">
        /// (Required.) A <see cref="T:System.String" /> containing the value to set as the
        /// currently-selected item in the combobox (unless it is blank).
        /// </param>
        /// <remarks>
        /// This method checks if the value of the <paramref name="comboBox" /> parameter
        /// is a <see langword="null" /> reference or refers to an already-disposed
        /// control, and if the <paramref name="currentItem" /> is <see langword="null" />,
        /// the <see cref="F:System.String.Empty" /> value, or all whitespace.
        /// <para />
        /// If the specified <paramref name="itemList" /> is <see langword="null" /> or the
        /// empty collection, the specified <paramref name="currentItem" /> is added to the
        /// <paramref name="comboBox"/>.
        /// <para />
        /// If the specified <paramref name="currentItem" /> is not already in the item
        /// list, it is added to the drop-down portion of the combobox.
        /// </remarks>
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

        /// <summary>
        /// Adds items from the provided list to the specified combobox.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that represents the combobox control to which items are to be added.
        /// </param>
        /// <param name="itemList">
        /// (Required.) Collection of <see cref="T:System.String" /> value(s), each of
        /// which representing an item that is to be added to the drop-down portion of the
        /// combobox.
        /// </param>
        /// <remarks>
        /// This method iterates through the provided list of items and adds each non-null,
        /// non-empty, and non-whitespace item to the combobox.
        /// <para />
        /// If this method receives a <see langword="null" /> reference or an
        /// already-disposed combobox, then it simply returns without doing anything.
        /// <para />
        /// The same occurs if the paramref name="itemList" /> is <see langword="null" />
        /// or has no elements.
        /// </remarks>
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
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" /> interface
        /// that represents the combobox control that is to be initialized.
        /// </param>
        /// <param name="currentItem">
        /// (Optional.) String containing the value to set as the
        /// currently-selected item in the combobox.
        /// </param>
        /// <param name="itemList">
        /// (Required.) Collection of one or more items that should be in the
        /// history list of items in the combobox's body.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameters, <paramref name="comboBox" /> and
        /// <paramref name="itemList" />, are passed <see langword="null" />
        /// reference for values.
        /// </exception>
        /// <remarks>
        /// This method is intended to be utilized in order to fill combobox
        /// controls with data from a data source.
        /// </remarks>
        public static void InitializeComboBox(
            [NotLogged] IEntryRespectingComboBox comboBox,
            [NotLogged] IList<string> itemList,
            [NotLogged] string currentItem = ""
        )
        {
            try
            {
                if (comboBox == null) return;
                if (comboBox.IsDisposed) return;

                comboBox.Items.Clear();

                AddCurrentItemToComboBox(comboBox, itemList, currentItem);

                AddItemsToComboBox(comboBox, itemList);

                SelectAppropriateItem(comboBox, currentItem);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Selects the appropriate item in the combobox. If the
        /// <paramref name="currentItem" /> is not null, empty, or all whitespace, then set
        /// the value of the editable, text portion of the combobox to it. Otherwise,
        /// select the first item in the list, if there is one.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface.
        /// <para />
        /// This object is the combobox control that is to be initialized.
        /// </param>
        /// <param name="currentItem">
        /// (Required.) A <see cref="T:System.String" /> that
        /// represents the item that is either to be set as the text of the editable
        /// portion of the target <paramref name="comboBox" />, or, if it is already
        /// contained within the list of the item(s) in the combobox, selected.
        /// </param>
        private static void SelectAppropriateItem(
            [NotLogged] IEntryRespectingComboBox comboBox,
            [NotLogged] string currentItem
        )
        {
            try
            {
                // If the 'currentItem' is not null, empty, or all whitespace, then set the value of the editable, text portion of the combobox to it. Otherwise,// select the first item in the list, if there is one.
                if (!string.IsNullOrWhiteSpace(currentItem))
                {
                    comboBox.Text = currentItem;
                    return;
                }

                // If we are here, then the 'currentItem' is null, empty, or all whitespace. In this case,
                // we need to select the first item in the list, if there is one.
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                    return;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}