using MFR.GUI.Controls.Events;
using System.Drawing;
using System.Windows.Forms;

namespace MFR.GUI.Controls.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a button that
    /// folds and unfolds its parent form.
    /// </summary>
    public interface IFoldUnfoldButton : IButtonControl
    {
        /// <summary>
        /// Gets or sets the text that this button displays when the hosting
        /// form is in the Folded state.
        /// </summary>
        string FoldedText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
        /// form when the form is folded.
        /// </summary>
        Size FormFoldedSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Drawing.Size" /> of the parent
        /// form when the form is unfolded.
        /// </summary>
        Size FormUnfoldedSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the form is to be folded.
        /// </summary>
        bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text that this button displays when the hosting
        /// form is in the Folded state.
        /// </summary>
        string UnfoldedText
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the Folded state of the parent form is to be changed.
        /// </summary>
        event FormFoldedEventHandler FormFolded;

        /// <summary>
        /// Sets the <see cref="P:System.Windows.Forms.ButtonBase.Text" />
        /// property of this button to correspond to whether the hosting form is
        /// in the Folded state or not.
        /// </summary>
        void SetFoldedStateText();
    }
}