using Alphaleonis.Win32.Filesystem;
using MFR.Configuration.Actions.Constants;
using MFR.Configuration.Actions.Factories;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Configuration.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.LoadStringFromRegistryAction" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        LoadConfigurationFilePathFromRegistryActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.LoadStringFromRegistryAction.Execute" />
        /// method
        /// correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullyObtain_AppConfigFilePath()
        {
            var result = GetConfigurationAction
                         .For<IRegQueryExpression<string>, IFileSystemEntry>(
                             ConfigurationAction.LoadStringFromRegistry
                         )
                         .WithInput(
                             MakeNewRegQueryExpression.FromScatch<string>()
                                 .ForKeyPath(KEY_PATH)
                                 .AndValueName(VALUE_NAME)
                                 .WithDefaultValue(
                                     Path.Combine(
                                         CONFIG_FILE_DIR, CONFIG_FILE_NAME
                                     )
                                 )
                         )
                         .Execute()
                         .Path;

            Assert.That(!string.IsNullOrWhiteSpace(result));
            Assert.That(result, Is.EqualTo(CONFIG_FILE_PATH.Replace("\"", "")));
        }
    }
}