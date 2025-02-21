/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using MFR.GUI.Controls.Events;
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