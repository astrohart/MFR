using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Dialog box that displays information about this application to the user.
    /// </summary>
    public partial class AboutDialog : Form
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.GUI.Dialogs.AboutDialog"/> and returns a reference
        /// to it.
        /// </summary>
        public AboutDialog()
        {
            InitializeComponent();
            Text = $"About {AssemblyTitle}";
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"Version {AssemblyVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        /// <summary>
        /// Gets the name of the company that produced this software.
        /// </summary>
        public string AssemblyCompany
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(
                        typeof(AssemblyCompanyAttribute), false
                    );
                if (attributes.Length == 0) return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        /// <summary>
        /// Gets the copyright string for this application.
        /// </summary>
        public string AssemblyCopyright
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(
                        typeof(AssemblyCopyrightAttribute), false
                    );
                if (attributes.Length == 0) return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /// <summary>
        /// Gets the description of this application.
        /// </summary>
        public string AssemblyDescription
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(
                        typeof(AssemblyDescriptionAttribute), false
                    );
                if (attributes.Length == 0) return "";
                return ((AssemblyDescriptionAttribute)attributes[0])
                    .Description;
            }
        }

        /// <summary>
        /// Gets the product name of the application.
        /// </summary>
        public string AssemblyProduct
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(
                        typeof(AssemblyProductAttribute), false
                    );
                return attributes.Length == 0
                    ? ""
                    : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        /// <summary>
        /// Gets the title string for this application.
        /// </summary>
        public string AssemblyTitle
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length <= 0)
                    return Path.GetFileNameWithoutExtension(
                        Assembly.GetExecutingAssembly().CodeBase
                    );
                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "") return titleAttribute.Title;

                return Path.GetFileNameWithoutExtension(
                    Assembly.GetExecutingAssembly().CodeBase
                );
            }
        }

        /// <summary>
        /// Gets the full version of the application.
        /// </summary>
        public string AssemblyVersion
            => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        /// Displays this dialog box and does not return until the user has
        /// dismissed it.
        /// </summary>
        /// <param name="owner">
        /// (Optional.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window"/> interface and
        /// which represents the parent window of this dialog box.
        /// </param>
        public static void Display(IWin32Window owner = null)
        {
            using (var dialog = new AboutDialog())
                if (owner == null) dialog.ShowDialog();
                else dialog.ShowDialog(owner);
        }
    }
}