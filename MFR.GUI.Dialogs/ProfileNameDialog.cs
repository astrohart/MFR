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

using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Dialogs.Profiles.Help.Factories;
using MFR.GUI.Dialogs.Text.Retrievers.Factories;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Displayed to the user to allow the user to create a blank profile with a given
    /// name and/or save a profile.
    /// </summary>
    [Log(AttributeExclude = true)]
    public partial class ProfileNameDialog : Form, IProfileNameDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.ProfileNameDialog" /> and returns a reference
        /// to it.
        /// </summary>
        public ProfileNameDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private IProfileProvider ProfileProvider
        {
            get;
        } = GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets or sets the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that controls what type of profile-creation operation (e.g., New, Save As etc.)
        /// is being done.
        /// </summary>
        public ProfileCreateOperationType OperationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the Profile Name text box.
        /// </summary>
        public string ProfileName
        {
            get => profileNameTextBox.Text;
            set => profileNameTextBox.Text = value;
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

            e.Cancel = !CanClose();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            /*
             * Set the title bar text of the dialog box differently
             * depending on whether this dialog box was summoned by
             * means of the Add New Profile command or the Save Profile As
             * command.
             */

            Text = GetProfileCreateOperationTypeDialogText.By.EnumerationValue(
                OperationType
            );
            createButton.Text =
                GetProfileCreateOperationTypeButtonText.By.EnumerationValue(
                    OperationType
                );
        }

        /// <summary>
        /// Determines whether this dialog can be closed.
        /// <para />
        /// Whether or not this the case, depends on several factors; for instance,
        /// whether the input is valid.
        /// <para />
        /// If validation rules fail, then the user is presented with an error message box
        /// telling them what to do.
        /// <para />
        /// <b>NOTE:</b>If the dialog box's <c>Cancel</c> button is clicked, or the
        /// <c>ESC</c> key is pressed on the keyboard, then this method always returns
        /// <see langword="true" />.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the dialog is allowed to be closed;
        /// <see langword="false" /> otherwise.
        /// </returns>
        private bool CanClose()
        {
            if (DialogResult == DialogResult.Cancel)
                return true;

            /*
             * Run validation.
             */

            if (string.IsNullOrWhiteSpace(ProfileName))
            {
                Messages.ShowStopError(
                    this, "You must provide a non-blank Profile Name."
                );
                return false;
            }

            if (!ProfileProvider.Profiles.HasProfileNamed(ProfileName))
                return true;

            Messages.ShowStopError(
                this,
                $"A profile named '{ProfileName}' already exists.\n\nPlease use another name."
            );

            return false;

            /*
             * If we made it here, than all the input is valid.
             */
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event raised by
        /// the Read More About Profiles link label.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method is called when the user clicks the
        /// <b>Read More About Profiles</b> link.
        /// <para />
        /// The default action is to bring up a Help window that describes profiles and
        /// what can be done with them.
        /// </remarks>
        private void OnClickReadMoreAboutProfilesLinkLabel(object sender,
            EventArgs e)
            => MakeNewHelpProfileExplainerDialog.FromScratch()
                                                .ShowDialog(this);
    }
}