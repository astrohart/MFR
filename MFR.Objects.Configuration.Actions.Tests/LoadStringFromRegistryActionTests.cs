using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Configuration.Actions.Constants;
using MFR.Objects.Configuration.Actions.Factories;
using MFR.Objects.Expressions.Registry.Factories;
using MFR.Objects.Expressions.Registry.Interfaces;
using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Tests.Common;
using NUnit.Framework;

namespace MFR.Objects.Configuration.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.LoadStringFromRegistryAction" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        LoadStringFromRegistryActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.LoadStringFromRegistryAction.Execute" />
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