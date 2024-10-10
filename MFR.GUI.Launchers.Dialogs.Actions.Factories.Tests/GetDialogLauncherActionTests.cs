using PostSharp.Patterns.Threading;
using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Launchers.Dialogs.Actions.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Actions.Factories.GetDialogLauncherAction" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    [Log(AttributeExclude = true)]
    public class GetDialogLauncherActionTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_GetLaunchErrorReportDialogAction_Works()
            => Assert.That(
                GetDialogLauncherAction
                    .For<IErrorReportDialogLaunchParams,
                        IErrorReportDialogLaunchResults>(
                        DialogLauncherActionType.LaunchErrorReportDialog
                    ), Is.TypeOf<LaunchErrorReportDialogAction>()
            );
    }
}
