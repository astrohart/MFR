using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Controls.Helpers
{
    [Log(AttributeExclude = true)]
    public static class EntryRespectingComboBoxExtensions
    {
        /// <summary>
        /// Clears all the content from the combo box referenced by the
        /// <paramref name="box" /> parameter.
        /// </summary>
        /// <param name="box">
        /// Reference to the
        /// <see
        ///     cref="T:MFR.Objects.EntryRespectingComboBox" />
        /// that is
        /// to be cleared.
        /// </param>
        /// <remarks>
        /// This method removes all the items from the combo box and then blanks
        /// out the text.
        /// </remarks>
        public static void Clear(this EntryRespectingComboBox box)
        {
            if (box == null) throw new ArgumentNullException(nameof(box));

            if (box.IsClear()) return;  // nothing to do if combobox is already free of items

            box.Items.Clear();

            if (box.DropDownStyle != ComboBoxStyle.DropDown) return;

            box.EnteredText = box.Text = box.SelectedText = string.Empty;
        }

        /// <summary>
        /// Determines whether the specified
        /// <see
        ///     cref="T:MFR.GUI.EntryRespectingComboBox" />
        /// has any items.
        /// </summary>
        /// <param name="box">
        /// (Required.) Reference to the
        /// <see
        ///     cref="T:MFR.GUI.EntryRespectingComboBox" />
        /// instance to
        /// be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="box" /> is
        /// clear of all items and entered text; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="box" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        public static bool IsClear(this EntryRespectingComboBox box)
        {
            if (box == null) throw new ArgumentNullException(nameof(box));

            var result = false;

            if (box.DropDownStyle != ComboBoxStyle.DropDown) return result;

            try
            {
                result = string.IsNullOrWhiteSpace(box.EnteredText) &&
                         box.Items.Count == 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}