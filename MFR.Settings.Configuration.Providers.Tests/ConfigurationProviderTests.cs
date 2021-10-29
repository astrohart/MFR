using MFR.Settings.Configuration.Interfaces;
using NUnit.Framework;
using System;

namespace MFR.Settings.Configuration.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Configuration.Providers.ConfigurationProvider" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ConfigurationProviderTests
    {
        /// <summary>
        /// Path to a sample configuration file.
        /// </summary>
        private const string ConfigFilePath =
            @"C:\Users\Brian Hart\AppData\Local\xyLOGIX, LLC\Project File Renamer\Config\config.json";

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Load_Works()
        {
            Assert.DoesNotThrow(
                () => ConfigurationProvider.Instance.Load(ConfigFilePath)
            );

            Console.WriteLine(ConfigurationProvider.Instance.Configuration.FindWhat);
        }
    }
}