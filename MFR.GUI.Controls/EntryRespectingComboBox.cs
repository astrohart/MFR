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
 */

using MFR.GUI.Controls.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.UI.Dark.Controls;

namespace MFR.GUI.Controls
{
    /// <summary>
    /// Dropdown combo box that respects typed-in text entries.
    /// </summary>
    /// <remarks>
    /// By "respects typed-in text entries," what we mean to say is, "does not
    /// make a typed in text entry go away, or get replaced by an auto-correct
    /// entry from the auto-suggest list, when the input focus leaves the
    /// control," which seems to be the default behavior. This detrimental to
    /// the software meeting certain requirements.  Therefore, this object was
    /// engineered in the hopes of making that behavior go away.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class EntryRespectingComboBox : DarkComboBox,
        IEntryRespectingComboBox
    {
        /// <summary>
        /// Gets the text, verbatim, that was typed in the Combo Box's editing
        /// field, by the user.
        /// </summary>
        /// <remarks>
        /// This property only works for a
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBox" />
        /// whose style is set to
        /// <see
        ///     cref="T:System.Windows.Forms.ComboBoxStyle.DropDown" />
        /// . Otherwise,
        /// it returns the value of the
        /// <see
        ///     cref="P:System.Windows.Forms.ComboBox.Text" />
        /// property.
        /// </remarks>
        public string EnteredText
        {
            get {
                if (InvokeRequired)
                    return (string)Invoke(new Func<string>(GetEnteredText));
                return GetEnteredText();
            }

            set {
                try
                {
                    if (InvokeRequired)
                        Invoke(new Action<string>(SetEnteredText), value);
                    else
                        SetEnteredText(value);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that corresponds to the text entered into
        /// this combo box by the user.
        /// </summary>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the text
        /// entered into the edit portion of the combo box by the user.
        /// </returns>
        private string GetEnteredText()
            => base.Text;

        /// <summary>
        /// Sets the value of the
        /// <see cref="P:MFR.GUI.Controls.EntryRespectingComboBox.EnteredText" /> property
        /// to the specified <paramref name="text" />.
        /// </summary>
        /// <param name="text">
        /// (Required.) A <see cref="T:System.String" /> containing the new value to set
        /// for the property.
        /// </param>
        /// X
        private void SetEnteredText(string text)
            => base.Text = text;
    }
}