using MFR.GUI.Controls.Interfaces;
using xyLOGIX.UI.Dark.Controls;

namespace MFR.GUI.Controls
{
    /// <summary>
    /// A <see cref="T:System.Windows.Forms.UserControl" /> that is dark-themeable and
    /// allows users to create a list of choices by adding one item at a time, and
    /// optionally setting the list order.
    /// </summary>
    public partial class ListBuilderControl : DarkUserControl, IListBuilderControl
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Controls.ListBuilderControl" /> and returns a reference to
        /// it.
        /// </summary>
        public ListBuilderControl()
        {
            InitializeComponent();
        }
    }
}