using NUnit.Framework;
using System.IO;

namespace MFR.Objects.Tests
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
        /// method correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullyObtain_AppConfigFilePath()
        {
            var result = GetAction
                         .For<IRegQueryExpression<string>, IFileSystemEntry>(
                             MessageType.LoadStringFromRegistry
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