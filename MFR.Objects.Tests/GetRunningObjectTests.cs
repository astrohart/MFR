using EnvDTE;
using MFR.Objects.Processes.Factories;
using NUnit.Framework;
using System;
using System.Linq;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetRunningObject" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetRunningObjectTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ByDisplayName_Method_Works()
        {
            var pid =
                MakeNewProcessIdProvider.FromScratch()
                                        .GetProcessIDOf("devenv.exe");  
            Assert.IsFalse(-1 == pid);

            var runningObjectDisplayName = $"VisualStudio.DTE.16.0:{pid}";

            Assert.IsInstanceOf<DTE>(
                GetRunningObject.ByDisplayName(runningObjectDisplayName)
            );
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_DisplayNames_Method_Works()
        {
            var list = GetRunningObject.DisplayNames();
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Any());

            foreach (var entry in list) Console.WriteLine(entry);
        }
    }
}