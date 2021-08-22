using MFR.GUI.Dialogs.Constants;
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

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = OperationType == ProfileCreateOperationType.New
                ? "Add New Profile"
                : "Save Profile As";
        }

        /// <summary>
        /// Gets or sets the value of the Profile Name text box.
        /// </summary>
        public string ProfileName
        {
            get => profileNameTextBox.Text;
            set => profileNameTextBox.Text = value;
        }
    }
}