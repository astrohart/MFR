using MassFileRenamer.Objects;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Provides options to the user that allow the user to modify the
    /// application's behavior.
    /// </summary>
    public partial class OptionsDialog : Form
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.GUI.OptionsDialog" />
        /// and returns a reference
        /// to it.
        /// </summary>
        public OptionsDialog()
        {
            InitializeComponent();

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets or sets the text of the Configuration File Pathname text box.
        /// </summary>
        public string ConfigPathname
        {
            get => configPathnameTextBox.Text;
            set => configPathnameTextBox.Text = value;
        }

        /// <summary>
        /// Gets a value that indicates whether the data in this dialog box has
        /// been modified.
        /// </summary>
        public bool IsModified
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the value of the Reopen Visual Studio Solution checkbox
        /// </summary>
        public bool ShouldReOpenVisualStudioSolution
        {
            get => reOpenSolutionCheckBox.Checked;
            set => reOpenSolutionCheckBox.Checked = value;
        }

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        public event ModifiedEventHandler Modified;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.OptionsDialog.Modified" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.ModifiedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.ModifiedEventArgs.Handled" />
        /// property is set <c>true</c> by the event's handler, then the
        /// <see
        ///     cref="P:MassFileRenamer.GUI.OptionsDialog.IsModified" />
        /// will be set
        /// to <c>false</c>.
        /// </remarks>
        protected virtual void OnModified(ModifiedEventArgs e)
        {
            if (Modified == null) return;

            Modified.Invoke(this, e);
            SetModifiedFlag(!e.Handled);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            SetModifiedFlag(false); // start us off as having no modified values
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called in response to the user clicking the Apply
        /// button. We merely raise the
        /// <see
        ///     cref="E:MassFileRenamer.GUI.OptionsDialog.Modified" />
        /// event in order
        /// to prompt the client of this dialog box to update data.
        /// </remarks>
        private void OnClickApply(object sender, EventArgs e)
            => OnModified(new ModifiedEventArgs());

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
        /// for the Browse button on the Configuration File Pathname text box..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to a click of the '...' button that lies next
        /// to the text box that accepts the pathname of the application's
        /// configuration file.
        /// </remarks>
        private void OnClickConfigPathnameBrowseButton(object sender,
            EventArgs e)
        {
            configPathBrowseBox.InitialDirectory =
                string.IsNullOrWhiteSpace(ConfigPathname)
                    ? ConfigurationProvider.DefaultConfigDir
                    : Path.GetDirectoryName(ConfigPathname);
            configPathBrowseBox.FileName =
                string.IsNullOrWhiteSpace(ConfigPathname)
                    ? ConfigurationProvider.DefaultConfigFileName
                    : ConfigPathname;

            if (configPathBrowseBox.ShowDialog(this) != DialogResult.OK)
                return;

            ConfigPathname = configPathBrowseBox.FileName;
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to respond to the value of the text inside the
        /// Configuration File Pathname text box being changed. This method
        /// responds to such a happenstance by updating the value of the
        /// <see
        ///     cref="P:MassFileRenamer.GUI.OptionsDialog.IsModified" />
        /// property to
        /// be <c>true</c> by calling the
        /// <see
        ///     cref="M:MassFileRenamer.GUI.OptionsDialog.SetModifiedFlag" />
        /// method.
        /// </remarks>
        private void OnTextChangedConfiguraitonFilePathname(object sender,
            EventArgs e)
            => SetModifiedFlag();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Application.Idle" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to update the enabled or disabled state of controls.
        /// </remarks>
        [Log(AttributeExclude = true)] // do not log this method
        private void OnUpdateCmdUI(object sender, EventArgs e)
            => applyButton.Enabled = IsModified;

        /// <summary>
        /// Sets the dirty state of the data of this dialog box.
        /// </summary>
        /// <param name="dirty">
        /// Set to <c>true</c> to indicate data has changed; <c>false</c>
        /// otherwise. Default is <c>true</c>.
        /// </param>
        private void SetModifiedFlag(bool dirty = true)
            => IsModified = dirty;
    }
}