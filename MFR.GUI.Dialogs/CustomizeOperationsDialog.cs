using MFR.GUI.Dialogs.Interfaces;
using System.ComponentModel;
using System.Diagnostics;
using xyLOGIX.UI.Dark.Controls.Interfaces;
using xyLOGIX.UI.Dark.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Dialog box that is displayed when the user clicks the <b>Customize</b> button
    /// in the <b>Operations</b> tab of the main window.
    /// </summary>
    /// <remarks>
    /// This dialog box allows the user to customize the list of primary operations tha
    /// this application performs, to make some operations available and others not.
    /// </remarks>
    public partial class CustomizeOperationsDialog : DarkForm,
        ICustomizeOperationsDialog
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.CustomizeOperationsDialog" /> and returns a
        /// reference to it.
        /// </summary>
        public CustomizeOperationsDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.UI.Dark.Controls.Interfaces.IDarkListBuilderControl" />
        /// interface.
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Hidden
         )]
        public IDarkListBuilderControl OperationListBuilder
        {
            [DebuggerStepThrough] get => operationListBuilder;
        }
    }
}