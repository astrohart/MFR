using PostSharp.Patterns.Threading;
using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Factories;
using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.GUI.Dialogs.ProfileNameDialog" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ProfileNameDialogTests : DialogTestBase
    {
        /// <summary>
        /// Tests that the New Profile Name dialog works when the operation that the user
        /// wants to do is to add a new, blank profile.
        /// </summary>
        [Test]
        public void Test_AddNewProfile_Dialog_Works()
        {
            using (var dialog = MakeNewProfileNameDialog.FromScratch())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.OperationType = ProfileCreateOperationType.New;

                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;

                Console.WriteLine(
                    $"Profile name chosen by user is: {dialog.ProfileName}."
                );
            }
        }

        /// <summary>
        /// Tests that the New Profile Name dialog works when the operation that the user
        /// wants to do is to save a copy of the current Profile with a new name.
        /// </summary>
        [Test]
        public void Test_SaveProfileAs_Dialog_Works()
        {
            using (var dialog = MakeNewProfileNameDialog.FromScratch())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.OperationType = ProfileCreateOperationType.SaveAs;

                dialog.ShowDialog();

                Console.WriteLine(
                    $"Profile name chosen by user is: {dialog.ProfileName}."
                );
            }
        }
    }
}