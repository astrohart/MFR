using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Helpers;
using NUnit.Framework;
using System;

namespace MFR.Settings.Configuration.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfiguration" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ProjectFileRenamerConfigurationTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Produce_BlankConfiguration_HashCode()
            => Console.WriteLine(
                Create.BlankConfiguration()
                      .GetHashCode()
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Produce_NewlyConstructedConfigObject_HashCode()
            => Console.WriteLine(
                MakeNewProjectFileRenamerConfiguration.FromScratch()
                    .GetHashCode()
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_BlankAndNewlyConstructedConfigObjects_HashCodes_AreEqual()
        {
            var blankConfig = Create.BlankConfiguration();
            var newConfig = MakeNewProjectFileRenamerConfiguration.FromScratch();

            Assert.AreEqual(
                blankConfig,
                newConfig
            );
        }
    }
}