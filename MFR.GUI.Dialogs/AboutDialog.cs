/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using Alphaleonis.Win32.Filesystem;
using System.Reflection;
using System.Windows.Forms;
using xyLOGIX.UI.Dark.Forms;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Dialog box that displays information about this application to the user.
    /// </summary>
    public partial class AboutDialog : DarkForm
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.AboutDialog" />
        /// and returns a reference
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
                var attributes = Assembly.GetEntryAssembly()
                                         .GetCustomAttributes(
                                             typeof(AssemblyCompanyAttribute),
                                             false
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
                var attributes = Assembly.GetEntryAssembly()
                                         .GetCustomAttributes(
                                             typeof(AssemblyCopyrightAttribute),
                                             false
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
                var attributes = Assembly.GetEntryAssembly()
                                         .GetCustomAttributes(
                                             typeof(
                                                 AssemblyDescriptionAttribute),
                                             false
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
                var attributes = Assembly.GetEntryAssembly()
                                         .GetCustomAttributes(
                                             typeof(AssemblyProductAttribute),
                                             false
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
                var attributes = Assembly.GetEntryAssembly()
                                         .GetCustomAttributes(
                                             typeof(AssemblyTitleAttribute),
                                             false
                                         );
                if (attributes.Length <= 0)
                    return Path.GetFileNameWithoutExtension(
                        Assembly.GetEntryAssembly()
                                .CodeBase
                    );
                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "") return titleAttribute.Title;

                return Path.GetFileNameWithoutExtension(
                    Assembly.GetEntryAssembly()
                            .CodeBase
                );
            }
        }

        /// <summary>
        /// Gets the full version of the application.
        /// </summary>
        public string AssemblyVersion
            => Assembly.GetEntryAssembly()
                       .GetName()
                       .Version.ToString();

        /// <summary>
        /// Gets the required creation parameters when the control handle is
        /// created.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the
        /// required creation parameters when the handle to the control is created.
        /// </returns>
        protected override CreateParams CreateParams
        {
            get {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

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
            using (var dialog = new AboutDialog())
                if (owner == null) dialog.ShowDialog();
                else dialog.ShowDialog(owner);
        }
    }
}