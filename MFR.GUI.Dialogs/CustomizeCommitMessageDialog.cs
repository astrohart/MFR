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