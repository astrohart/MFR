using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Text.Retrievers.Factories;
using MFR.Settings.Profiles.Providers.Factories;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Displayed to the user to allow the user to create a blank profile with a given
    /// name and/or save a profile.
    /// </summary>
    public partial class NewProfileNameDialog : Form
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.NewProfileNameDialog" /> and returns a reference
        /// to it.
        /// </summary>
        public NewProfileNameDialog()
        {
            InitializeComponent();
        }

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

        /// <summary>
        /// Determines whether this dialog can be closed.
        /// <para />
        /// Whether or not this is the case, depends on several factors; for instance,
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
                MessageBox.Show(
                    this, "You must provide a non-blank Profile Name.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                return false;
            }

            if (GetProfileProvider.SoleInstance()
                                  .ProfileCollection
                                  .HasProfileNamed(ProfileName))
            {
                MessageBox.Show(
                    this,
                    $"A profile named '{ProfileName}' already exists.\n\nPlease use another name.",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );
                return false;
            }

            /*
             * If we made it here, than all the input is valid.
             */
            return true;
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
    }
}