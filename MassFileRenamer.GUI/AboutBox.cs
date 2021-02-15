using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    internal partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = $"About {AssemblyTitle}";
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"Version {AssemblyVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

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

        public string AssemblyProduct
        {
            get {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(
                        typeof(AssemblyProductAttribute), false
                    );
                if (attributes.Length == 0) return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

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

        public string AssemblyVersion
            => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        /// Displays this dialog box and does not return until the user has
        /// dismissed it.
        /// </summary>
        /// <param name="owner">
        /// (Optional.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface and
        /// which represents the parent window of this dialog box.
        /// </param>
        public static void Display(IWin32Window owner = null)
        {
            using (var dialog = new AboutBox())
                if (owner == null) dialog.ShowDialog();
                else dialog.ShowDialog(owner);
        }
    }
}