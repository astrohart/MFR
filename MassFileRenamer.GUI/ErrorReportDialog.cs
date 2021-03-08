using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Displays information to the user about an exception or error.
    /// </summary>
    public partial class ErrorReportDialog : Form
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.GUI.ErrorReportDialog" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public ErrorReportDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Exception"/> that describes the error that occurred.
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This override forcibly terminates the application by calling
        /// <see
        ///     cref="M:System.Environment.Exit" />
        /// with an exit code of <c>-1</c>.
        /// </remarks>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            Environment.Exit(-1);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = Text.Replace("[AppTitle]", Application.ProductName);
            secondaryInstructionLabel.Text =
                secondaryInstructionLabel.Text.Replace(
                    "[AppTitle]", Application.ProductName
                );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:System.Windows.Forms.LinkLabel.LinkClicked" />
        /// event raised
        /// by the View Report hyperlink.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by dumping the current
        /// <see
        ///     cref="T:System.Exception" />
        /// 's message and stack trace to a text file
        /// in the user's temporary files folder, and then launches Notepad to
        /// view it.
        /// </remarks>
        private void OnLinkClickedViewErrorReportLinkLabel(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            var dumpFile = Path.GetTempFileName();
            File.WriteAllText(
                dumpFile,
                $"{Exception.GetType()}: {Exception.Message}\n\t{Exception.StackTrace}"
            );

            Process.Start("notepad", dumpFile);
        }
    }
}