using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.Paths.Config.Provider.Factories;
using MFR.Paths.Config.Provider.Interfaces;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using NUnit.Framework;
using System;

namespace MFR.Settings.Configuration.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfig" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ProjectFileRenamerConfigTests
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider" />
        /// interface.
        /// </summary>
        private static IConfigPathProvider ConfigPathProvider
        {
            get;
        } = GetConfigPathProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfigProvider
            ProjectFileRenamerConfigProvider
        {
            get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

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
                MakeNewProjectFileRenamerConfig.FromScratch()
                    .GetHashCode()
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_BlankAndNewlyConstructedConfigObjects_HashCodes_AreEqual()
        {
            var blankConfig = GetBlankProjectFileRenamerConfig.SoleInstance();
            var newConfig =
                MakeNewProjectFileRenamerConfig.FromScratch();

            Assert.That(blankConfig, Is.EqualTo(newConfig));
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_BlankConfigReturned_ForMissingConfigFile()
        {
            Assert.That(!File.Exists(ConfigPathProvider.ConfigFilePath));

            IProjectFileRenamerConfig config = default;

            Assert.DoesNotThrow(() => config = ProjectFileRenamerConfigProvider.Load());
            Assert.That(ProjectFileRenamerConfig.IsBlankOrNull(config));
        }
    }
}