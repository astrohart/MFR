using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Dialogs.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Provides options to the user that allow the user to modify the
    /// application's behavior.
    /// </summary>
    public partial class OptionsDialog : Form, IOptionsDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.OptionsDialog" />
        /// and returns a reference to it.
        /// </summary>
        public OptionsDialog()
        {
            InitializeComponent();

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the actions
        /// associated with it.
        /// </remarks>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Occurs when data is modified in this property sheet and then the
        /// Apply button is clicked by the user.
        /// </summary>
        public event ModifiedEventHandler Modified;

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
        /// Raises the <see cref="E:MFR.GUI.OptionsDialog.Modified" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.ModifiedEventArgs" /> that contains the
        /// event data.
        /// </param>
        /// <remarks>
        /// If the <see cref="P:MFR.ModifiedEventArgs.Handled" />
        /// property is set <see langword="true" /> by the event's handler, then
        /// the <see cref="P:MFR.GUI.OptionsDialog.IsModified" /> will be set to
        /// <see langword="false" />.
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
        ///     cref="E:MFR.GUI.OptionsDialog.Modified" />
        /// event in order to prompt
        /// the client of this dialog box to update data.
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
                    ? GetConfigurationProvider.SoleInstance()
                                              .DefaultConfigFileName
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
        ///     cref="P:MFR.GUI.OptionsDialog.IsModified" />
        /// property to be
        /// <see
        ///     langword="true" />
        /// by calling the
        /// <see
        ///     cref="M:MFR.GUI.OptionsDialog.SetModifiedFlag" />
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
        /// Set to <see langword="true" /> to indicate data has changed;
        /// <see
        ///     langword="false" />
        /// otherwise. Default is <see langword="true" />.
        /// </param>
        private void SetModifiedFlag(bool dirty = true)
            => IsModified = dirty;
    }
}
