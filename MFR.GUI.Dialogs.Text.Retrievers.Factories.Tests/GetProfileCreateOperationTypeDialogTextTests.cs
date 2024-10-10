using PostSharp.Patterns.Threading;
using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Text.Retrievers.Factories.Tests.Properties;
using NUnit.Framework;

namespace MFR.GUI.Dialogs.Text.Retrievers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetProfileCreateOperationTypeDialogTextTests
    {
        /// <summary>
        /// Asserts that the text returned by the
        /// <see
        ///     cref="M:MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.EnumerationValue" />
        /// method matches the value defined by the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Text.Retrievers.Factories.Tests.Properties.Resources.Text_AddNewProfile" />
        /// property when it is passed
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType.New" /> as a
        /// parameter.
        /// </summary>
        [Test]
        public void
            Test_GetProfileCreateOperationTypeDialogText_For_EnumerationValue_Of_New_Works()
            => Assert.That(
                GetProfileCreateOperationTypeDialogText.By.EnumerationValue(
                    ProfileCreateOperationType.New
                ), Is.EqualTo(Resources.Text_Dialogs_AddNewProifile)
            );

        /// <summary>
        /// Asserts that the text returned by the
        /// <see
        ///     cref="M:MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.EnumerationValue" />
        /// method matches the value defined by the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Text.Retrievers.Factories.Tests.Properties.Resources.Text_AddNewProfile" />
        /// property when it is passed
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType.SaveAs" /> as
        /// a parameter.
        /// </summary>
        [Test]
        public void
            Test_GetProfileCreateOperationTypeDialogText_For_EnumerationValue_Of_SaveAs_Works()
            => Assert.That(
                GetProfileCreateOperationTypeDialogText.By.EnumerationValue(
                    ProfileCreateOperationType.SaveAs
                ), Is.EqualTo(Resources.Text_Dialogs_SaveProfileAs)
            );
    }
}