using MFR.GUI.Controls.Events;
using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xyLOGIX.UI.Dark.Controls;

namespace MFR.GUI.Controls
{
    /// <summary>
    /// Button that shows "More &gt;&gt;" or "Less &lt;&lt;" depending on
    /// whether a form is folded or unfolded.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class FoldUnfoldButton : DarkButton, IFoldUnfoldButton
    {
        /// <summary>
        /// Value indicating whether the containing form is to be in the folded state.
        /// </summary>
        private bool _isFolded;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Controls.FoldUnfoldButton" />
        /// and returns a reference
        /// to it.
        /// </summary>
        public FoldUnfoldButton()
        {
            FormFoldedSize = Size.Empty;
            FormUnfoldedSize = Size.Empty;
            IsFolded = true; // form starts out folded typically

            FoldedText = "&More >>";
            UnfoldedText = "&Less <<";
        }

        /// <summary>
        /// Occurs when the Folded state of the parent form is to be changed.
        /// </summary>
        public event FormFoldedEventHandler FormFolded;

        /// <summary>
        /// Gets or sets the text that this button displays when the hosting
        /// form is in the Folded state.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue("&More >>")]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Visible
        )]
        [Description(
            "Gets or sets the text that this button displays when the hosting form is in the Folded state."
        )]
        public string FoldedText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:Size" /> of the parent form when the
        /// form is folded.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Visible
        )]
        [Description(
            "Gets or sets the size of the parent form when the form is folded."
        )]
        public Size FormFoldedSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:Size" /> of the parent form when the
        /// form is unfolded.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Visible
        )]
        [Description(
            "Gets or sets the size of the parent form when the form is unfolded."
        )]
        public Size FormUnfoldedSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the form is to be folded.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden
        )]
        public bool IsFolded
        {
            get => _isFolded;
            set {
                var oldIsFoldedValue = _isFolded;
                _isFolded = value;

                if (value != oldIsFoldedValue)
                    OnFormFolded(
                        new FormFoldedEventArgs(
                            IsFolded,
                            IsFolded ? FormFoldedSize : FormUnfoldedSize
                        )
                    );
            }
        }

        /// <summary>
        /// Gets or sets the text that this button displays when the hosting
        /// form is in the Folded state.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue("&Less <<")]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Visible
        )]
        [Description(
            "Gets or sets the text that this button displays when the hosting form is in the Unfolded state."
        )]
        public string UnfoldedText
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the <see cref="P:System.Windows.Forms.ButtonBase.Text" />
        /// property of this button to correspond to whether the hosting form is
        /// in the Folded state or not.
        /// </summary>
        public void SetFoldedStateText()
            => Text = IsFolded ? FoldedText : UnfoldedText;

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            ToggleFolded();
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.FoldUnfoldButton.Folded" /> event.
        /// </summary>
        protected virtual void OnFormFolded(FormFoldedEventArgs e)
        {
            SetFoldedStateText();

            FormFolded?.Invoke(this, e);
        }

        /// <summary>
        /// Toggles the form between the folded and unfolded states.
        /// </summary>
        private void ToggleFolded()
            => IsFolded = !IsFolded;
    }
}