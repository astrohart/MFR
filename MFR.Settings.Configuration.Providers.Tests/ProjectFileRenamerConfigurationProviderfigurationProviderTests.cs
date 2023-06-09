using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using NUnit.Framework;
using System;

namespace MFR.Settings.Configuration.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ProjectFileRenamerConfigurationProviderfigurationProviderTests
    {
        /// <summary>
        /// Path to a sample configuration file.
        /// </summary>
        private const string ConfigFilePath =
            @"C:\Users\Brian Hart\AppData\Local\xyLOGIX, LLC\Project File Renamer\Config\config.json";

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfigurationProvider
            ProjectFileRenamerConfigurationProvider
        {
            get;
        } = GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Load_Works()
        {
            Assert.DoesNotThrow(
                () => ProjectFileRenamerConfigurationProvider.Instance.Load(
                    ConfigFilePath
                )
            );

            Console.WriteLine(
                ProjectFileRenamerConfigurationProvider.Instance
                    .CurrentConfiguration.FindWhat
            );
        }
    }
}