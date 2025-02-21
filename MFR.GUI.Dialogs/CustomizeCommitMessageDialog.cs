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

using MFR.GUI.Dialogs.Properties;
using MFR.Renamers.Files.Actions;
using MFR.Settings.Configuration.Mappers;
using MFR.Settings.Configuration.Mappers.Constants;
using MFR.Settings.Configuration.Mappers.Interfaces;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.UI.Dark.Forms;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Represents a dialog box that gathers input from the user.
    /// <para />
    /// This dialog box has a Dark theme.
    /// </summary>
    public partial class CustomizeCommitMessageDialog : DarkForm
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.CustomizeCommitMessageDialogBox" /> and returns a
        /// reference to
        /// it.
        /// </summary>
        public CustomizeCommitMessageDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the value of the <b>Commit Message</b> text box.
        /// </summary>
        public string CommitMessageFormat
        {
            [DebuggerStepThrough] get => commitMessageTextBox.Text;
            [DebuggerStepThrough] set => commitMessageTextBox.Text = value;
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface for commit messages.
        /// </summary>
        private static IConfigurationStringMapper CommitMessageMapper
        {
            get;
        } = GetConfigurationStringMapper.OfType(
            ConfigurationStringMapperType.CommitMessage
        );

        /// <summary>
        /// Gets or sets the value of the <b>Detailed Commit Message</b> text box.
        /// </summary>
        public string DetailedCommitMessageFormat
        {
            [DebuggerStepThrough] get => detailedCommitMessageTextBox.Text;
            [DebuggerStepThrough]
            set => detailedCommitMessageTextBox.Text = value;
        }

        /// <summary>
        /// Gets or sets the value of the <b>Preview</b> text box.
        /// </summary>
        private string Preview
        {
            [DebuggerStepThrough] set => previewTextBox.Text = value;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" />
        /// that contains the event data.
        /// </param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (DialogResult != DialogResult.OK) return;

            e.Cancel = CanClose() == false;
        }

        private bool CanClose()
        {
            if (!string.IsNullOrWhiteSpace(CommitMessageFormat)) return true;
            Messages.ShowStopError(Resources.Error_CommitMessageRequired);
            commitMessageTextBox.Focus();
            return false;
        }

        private void InsertTextAtCursor(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            detailedCommitMessageTextBox.Paste(text);
        }

        private void OnClickFindWhatButton(object sender, EventArgs e)
            => InsertTextAtCursor(CommitMessageReplacementParameter.FindWhat);

        private void OnClickReplaceWithButton(object sender, EventArgs e)
            => InsertTextAtCursor(
                CommitMessageReplacementParameter.ReplaceWith
            );

        private void OnClickRootDir(object sender, EventArgs e)
            => InsertTextAtCursor(CommitMessageReplacementParameter.RootDir);

        private void OnClickShortDateButton(object sender, EventArgs e)
            => InsertTextAtCursor(CommitMessageReplacementParameter.ShortDate);

        private void OnClickShortTimeButton(object sender, EventArgs e)
            => InsertTextAtCursor(CommitMessageReplacementParameter.ShortTime);

        private void OnClickTimezoneButton(object sender, EventArgs e)
            => InsertTextAtCursor(CommitMessageReplacementParameter.Timezone);

        private void OnTextChangedDetailedCommitMessage(
            object sender,
            EventArgs e
        )
            => Preview = Formulate.CommitMessage(
                CommitMessageMapper.Map(DetailedCommitMessageFormat),
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments
                ), "Foo", "Bar"
            ).Replace("\n", Environment.NewLine);
    }
}