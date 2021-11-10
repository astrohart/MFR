using MFR.GUI.Dialogs.Profiles.Help.Interfaces;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Profiles.Help
{
    /// <summary>
    /// Dialog box that launches when the user requests more information about
    /// Profiles.
    /// </summary>
    /// <remarks>
    /// This dialog is styled to have a look and feel that is consistent with
    /// the old Windows Help application.
    /// </remarks>
    public partial class HelpProfileExplainerDialog : Form,
        IHelpProfileExplainerDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.Profiles.Help.HelpProfileExplainerDialog" /> and returns a
        /// reference to it.
        /// </summary>
        public HelpProfileExplainerDialog()
        {
            InitializeComponent();
        }
    }
}