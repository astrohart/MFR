using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Form for putting controls on as a test bed.
    /// </summary>
    public partial class TestBedForm : Form
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TestBedForm() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TestBedForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MassFileRenamer.GUI.TestBedForm" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static TestBedForm Instance
        {
            get;
        } = new TestBedForm();

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = MainWindow.Instance.FullApplicationName;
        }
    }
}