using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Controls.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a combo box
    /// control that maintains the text that is manually typed in to the edit
    /// box portion of the drop down by the user, instead of throwing it away
    /// when the control loses the input focus..
    /// </summary>
    public interface IEntryRespectingComboBox : IComboBox
    {
        /// <summary>
        /// Gets the text, verbatim, that was typed in the Combo Box's editing
        /// field, by the user.
        /// </summary>
        /// <remarks>
        /// This property only works for a <see
        /// cref="T:System.Windows.Forms.ComboBox"/> whose style is set to <see
        /// cref="T:System.Windows.Forms.ComboBoxStyle.DropDown"/> . Otherwise,
        /// it returns the value of the <see
        /// cref="P:System.Windows.Forms.ComboBox.Text"/> property.
        /// </remarks>
        string EnteredText
        {
            get;
            set;
        }
    }
}