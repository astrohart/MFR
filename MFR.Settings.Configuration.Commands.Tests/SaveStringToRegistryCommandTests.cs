using PostSharp.Patterns.Threading;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Registry.Helpers;
using MFR.Registry.Loaders.Factories;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Commands.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.SaveStringToRegistryCommand" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class
        SaveStringToRegistryCommandTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.LoadStringFromRegistryAction.Execute" />
        /// method correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()
        {
            Assert.DoesNotThrow(
                () => GetConfigurationCommand
                      .For<IRegOperationMetadata<string>>(
                          ConfigurationCommandType
                              .SaveConfigurationFilePathToRegistry
                      )
                      .WithInput(
                          MakeNewRegOperationMetadata.FromScatch<string>()
                              .ForKeyPath(KEY_PATH)
                              .AndValueName(VALUE_NAME)
                              .WithValue(DEFAULT_CONFIG_FILE_PATH)
                      )
                      .Execute()
            );

            Assert.That(KEY_PATH.HasValueWithName(VALUE_NAME));
            Assert.That(
                DEFAULT_CONFIG_FILE_PATH,
                Is.EqualTo(
                    Load.String.FromRegistry(
                        KEY_PATH, VALUE_NAME, DEFAULT_CONFIG_FILE_PATH
                    )
                )
            );
        }
    }
}