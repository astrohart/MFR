using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.LoadStringFromRegistryAction" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        LoadConfigurationFilePathFromRegistryActionTests :
            RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Gets the one and only instance of the Registry query expression validator that
        /// read <see cref="T:System.String" /> values  from the system Registry.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessTheRegueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

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
            var configFilePathRegQueryExpression = MakeNewRegQueryExpression
                                                   .FromScatch<string>()
                                                   .ForKeyPath(KEY_PATH)
                                                   .AndValueName(VALUE_NAME)
                                                   .WithDefaultValue(
                                                       DEFAULT_CONFIG_FILE_PATH
                                                   );
            Assert.IsNotNull(configFilePathRegQueryExpression);
            Assert.IsTrue(
                AccessTheRegueryExpressionValidator
                    .ForRegQueryExpression(configFilePathRegQueryExpression)
                    .Validate()
            );

            var loadConfigFilePathFromRegistryAction = GetConfigAction
                .For<IRegQueryExpression<string>, IFileSystemEntry>(
                    ConfigActionType.LoadStringFromRegistry
                );
            Assert.IsNotNull(loadConfigFilePathFromRegistryAction);

            loadConfigFilePathFromRegistryAction =
                loadConfigFilePathFromRegistryAction.WithInput(
                    configFilePathRegQueryExpression
                );
            Assert.IsNotNull(loadConfigFilePathFromRegistryAction);

            IFileSystemEntry configFileSystemEntry = default;

            Assert.DoesNotThrow(
                () => configFileSystemEntry =
                    loadConfigFilePathFromRegistryAction.Execute()
            );
            Assert.IsNotNull(configFileSystemEntry);

            Assert.IsNotEmpty(configFileSystemEntry.Path);
            Assert.That(File.Exists(configFileSystemEntry.Path));

            Assert.That(!string.IsNullOrWhiteSpace(configFileSystemEntry.Path));
            Assert.That(
                ConfigFile.DefaultFilename.Equals(
                    Path.GetFileName(configFileSystemEntry.Path)
                )
            );
            Assert.That(
                configFileSystemEntry.Path,
                Is.EqualTo(DEFAULT_CONFIG_FILE_PATH)
            );
        }
    }
}