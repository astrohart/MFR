using EnvDTE;
using MFR.Processes.Factories;
using NUnit.Framework;
using System;
using System.Linq;

namespace MFR.RunningObjects.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetRunningObject" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetRunningObjectTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.RunningObjects.Factories.GetRunningObject.ByDisplayName" />
        /// method always returns a reference to an instance of an object that
        /// implements the <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        [Test]
        public void Test_ByDisplayName_Method_Works()
        {
            var pids = MakeNewProcessIdProvider.FromScratch()
                                               .GetAllProcessIDsOf("devenv.exe")
                                               .ToList();
            Assert.That(pids.All(x => x > 0));

            var runningObjects = pids.Select(
                                         pid => GetRunningObject.ByDisplayName(
                                             $"VisualStudio.DTE.16.0:{pid}"
                                         )
                                     )
                                     .ToList();

            Assert.That(runningObjects.Any(x => x != null));

            Assert.IsInstanceOf<DTE>(runningObjects.First(x => x != null));
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