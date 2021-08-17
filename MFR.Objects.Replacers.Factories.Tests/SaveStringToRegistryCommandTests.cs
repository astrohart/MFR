using MFR.Objects.Configuration.Commands.Constants;
using MFR.Objects.Configuration.Commands.Factories;
using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Factories;
using MFR.Objects.Metadata.Registry.Factories;
using MFR.Objects.Metadata.Registry.Interfaces;
using MFR.Objects.Registry.Helpers;
using MFR.Objects.System;
using MFR.Objects.Tests.Common;
using NUnit.Framework;

namespace MFR.Objects.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.SaveStringToRegistryCommand" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        SaveStringToRegistryCommandTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.LoadStringFromRegistryAction.Execute" />
        /// method correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()
        {
            Assert.DoesNotThrow(
                () => GetConfigurationCommand
                      .For<IRegOperationMetadata<string>>(
                          ConfigurationCommand.SaveConfigurationFilePathToRegistry
                      )
                      .WithInput(
                          MakeNewRegOperationMetadata.FromScatch<string>()
                              .ForKeyPath(KEY_PATH)
                              .AndValueName(VALUE_NAME)
                              .WithValue(CONFIG_FILE_PATH)
                      )
                      .Execute()
            );

            Assert.That(KEY_PATH.HasValueWithName(VALUE_NAME));
            Assert.That(
                CONFIG_FILE_PATH,
                Is.EqualTo(
                    SystemPreparer.GetRegistryString(KEY_PATH, VALUE_NAME)
                )
            );
        }
    }
}