using MFR.GUI.Dialogs.Factories;
using NUnit.Framework;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.GUI.Dialogs.HelpProfileExplainerDialog" /> class.
    /// </summary>
    [TestFixture]
    public class HelpProfileExplainerDialogTests : DialogTestBase
    {
        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.GUI.Dialogs.HelpProfileExplainerDialog.ShowDialog" /> method
        /// properly displays the dialog box.
        /// </summary>
        [Test]
        public void Test_HelpExplainerDialog_Works()
        {
            using (var dialog = MakeNewHelpProfileExplainerDialog.FromScratch())
            {
                dialog.Show();

                while (dialog.Visible)
                {
                    Application.DoEvents();
                    dialog.Refresh();
                    dialog.Update();
                    Thread.Sleep(50);
                }
            }
        }
    }
}